using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Patients;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.Patients.Commands
{
    public record DeletePatientCommand(int Id) : IRequest<Result<Unit>> { }

    internal sealed class DeletePatientCommandHandler : IRequestHandler<DeletePatientCommand, Result<Unit>>
    {
        private readonly IPatientRepository _patientRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeletePatientCommandHandler(IUnitOfWork unitOfWork, IPatientRepository patientRepository)
        {
            _unitOfWork = unitOfWork;
            _patientRepository = patientRepository;
        }

        public async Task<Result<Unit>> Handle(DeletePatientCommand request, CancellationToken cancellationToken)
        {
            // Attempt to locate the patient
            var patient = await _patientRepository.GetByIdAsync(request.Id);
            //var patient = await _patientRepository.GetFirstOrDefaultAsync(x => x.Id == request.Id);
            if (patient is null)
            {
                return Result<Unit>.NotFoundResult(request.Id);
            }

            await _patientRepository.RemoveAsync(patient);
            await _unitOfWork.SaveChanges(cancellationToken);

            return Result<Unit>.SuccessResult(Unit.Value);
        }
    }
}
