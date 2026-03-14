using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Domain.Exceptions;

namespace SMIS.Application.Common.Behaviors
{
    public class DomainExceptionPipelineBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            try
            {
                return await next();
            }
            catch (DomainValidationException ex)
            {
                if (typeof(TResponse).IsGenericType && typeof(TResponse).GetGenericTypeDefinition() == typeof(Result<>))
                {
                    var resultType = typeof(TResponse).GetGenericArguments()[0];
                    var failureMethod = typeof(Result<>)
                        .MakeGenericType(resultType)
                        .GetMethod(nameof(Result<Unit>.FailureResult), new[] { typeof(string), typeof(string) });

                    if (failureMethod != null)
                    {
                        return (TResponse)failureMethod.Invoke(null, new object[] { "DomainValidation", ex.Message })!;
                    }
                }

                throw;
            }
        }
    }
}
