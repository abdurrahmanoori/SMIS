using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Customers;

namespace SMIS.Application.Features.Customers.Commands
{
    public record CustomerDeleteCommand(string Id) : IRequest<Result>;

    internal sealed class CustomerDeleteCommandHandler : IRequestHandler<CustomerDeleteCommand, Result>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CustomerDeleteCommandHandler(
            IUnitOfWork unitOfWork,
            ICustomerRepository customerRepository
        )
        {
            _unitOfWork = unitOfWork;
            _customerRepository = customerRepository;
        }

        public async Task<Result> Handle(
            CustomerDeleteCommand request,
            CancellationToken cancellationToken
        )
        {
            var entity = await _customerRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                return Result.NotFound(request?.Id);
            }

            await _customerRepository.RemoveAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);
            return Result.Success();
        }
    }
}