using MediatR;

using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkout.Application.Common.Behaviours
{
    public class LoggingBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly ILogger _logger;
        private readonly Stopwatch _timer;

        public LoggingBehaviour(ILogger<TRequest> logger)
        {
            _logger = logger;
            _timer = new Stopwatch();
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            var requestName = typeof(TRequest).Name;
            _logger.LogInformation("{Name} is starting. {@Request}", requestName, request);
            _timer.Start();
            var response = await next();
            _timer.Stop();
            var executionTime = _timer.ElapsedMilliseconds;
            if (executionTime > 500)
            {
                _logger.LogWarning("[Long Running Request] {Name} has finished in {Time}ms. {@Request}", requestName, executionTime, request);
            }
            else
            {
                _logger.LogInformation("{Name} has finished in {Time}ms.", requestName, executionTime);
            }

            return response;
        }
    }
}
