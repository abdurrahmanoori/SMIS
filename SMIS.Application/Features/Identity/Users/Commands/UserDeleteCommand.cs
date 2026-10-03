using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Services;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Application.Features.Identity.Users.Commands
{
    public record UserDeleteCommand(string UserId) : IRequest<Result>;

    public class UserDeleteCommandHandler : IRequestHandler<UserDeleteCommand, Result>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserAdministrationGuard _userAdministrationGuard;

        public UserDeleteCommandHandler(
            UserManager<ApplicationUser> userManager,
            IApplicationDbContext context,
            IUnitOfWork unitOfWork,
            IUserAdministrationGuard userAdministrationGuard
        )
        {
            _userManager = userManager;
            _context = context;
            _unitOfWork = unitOfWork;
            _userAdministrationGuard = userAdministrationGuard;
        }

        public async Task<Result> Handle(
            UserDeleteCommand request,
            CancellationToken cancellationToken
        )
        {
            var user = await _userManager.FindByIdAsync(request.UserId);
            if (user == null) return Result.NotFound(request.UserId);

            if (!await _userAdministrationGuard.CanManageUserAsync(user, cancellationToken))
            {
                return Result.Forbidden(
                    "user.administration_forbidden",
                    "You are not allowed to delete this user.");
            }

            if (await _userAdministrationGuard.WouldRemoveLastSuperAdminAsync(
                    user.Id,
                    cancellationToken))
            {
                return Result.BusinessRule(
                    "LastSuperAdmin",
                    "The last SuperAdmin account cannot be deleted.");
            }

            await _unitOfWork.StartTransactionAsync(cancellationToken);
            try
            {
                var userRoles = await _context.UserRoles
                    .Where(item => item.UserId == user.Id)
                    .ToListAsync(cancellationToken);
                var claims = await _context.UserClaims
                    .Where(item => item.UserId == user.Id)
                    .ToListAsync(cancellationToken);
                var logins = await _context.UserLogins
                    .Where(item => item.UserId == user.Id)
                    .ToListAsync(cancellationToken);
                var tokens = await _context.UserTokens
                    .Where(item => item.UserId == user.Id)
                    .ToListAsync(cancellationToken);

                _context.UserRoles.RemoveRange(userRoles);
                _context.UserClaims.RemoveRange(claims);
                _context.UserLogins.RemoveRange(logins);
                _context.UserTokens.RemoveRange(tokens);

                var result = await _userManager.DeleteAsync(user);
                if (!result.Succeeded)
                {
                    await _unitOfWork.RollbackTransactionAsync(cancellationToken);
                    return Result.Failure(result.Errors.Select(e => new Error
                    {
                        Code = e.Code,
                        Description = e.Description
                    }).ToList());
                }

                await _unitOfWork.CommitTransactionAsync(cancellationToken);
                return Result.Success();
            }
            catch (DbUpdateException)
            {
                if (_unitOfWork.HasActiveTransaction)
                    await _unitOfWork.RollbackTransactionAsync(cancellationToken);

                return Result.BusinessRule(
                    "UserInUse",
                    "The user cannot be deleted because existing business or audit records reference this account.");
            }
            catch
            {
                if (_unitOfWork.HasActiveTransaction)
                    await _unitOfWork.RollbackTransactionAsync(cancellationToken);
                throw;
            }
        }
    }
}
