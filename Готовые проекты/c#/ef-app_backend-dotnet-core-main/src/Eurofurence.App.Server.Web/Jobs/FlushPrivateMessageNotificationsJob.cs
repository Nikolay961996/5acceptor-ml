using System;
using System.Threading.Tasks;
using Eurofurence.App.Server.Services.Abstractions.Communication;
using Microsoft.Extensions.Logging;
using Quartz;

namespace Eurofurence.App.Server.Web.Jobs
{
    [DisallowConcurrentExecution]
    public class FlushPrivateMessageNotificationsJob : IJob
    {
        private readonly ILogger _logger;
        private readonly IPrivateMessageService _privateMessageService;

        public FlushPrivateMessageNotificationsJob(
            ILoggerFactory loggerFactory,
            IPrivateMessageService privateMessageService
        )
        {
            _logger = loggerFactory.CreateLogger(GetType());
            _privateMessageService = privateMessageService;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            //CA2254: Шаблон логирования должен быть статическим (структурное логгирование)
            _logger.LogDebug($"Starting job {context.JobDetail.Key.Name}");

            try
            {
                var count = await _privateMessageService.FlushPrivateMessageQueueNotifications();
                if (count > 0)
                {
                    //CA2254: Шаблон логирования должен быть статическим (структурное логгирование)
                    _logger.LogInformation($"Flushed {count} messages");
                }
            }
            catch (Exception e)
            {
                //CA2254: Шаблон логирования должен быть статическим (структурное логгирование)
                _logger.LogError($"Job {context.JobDetail.Key.Name} failed with exception: {e.Message} {e.StackTrace}");
            }
        }
    }
}
