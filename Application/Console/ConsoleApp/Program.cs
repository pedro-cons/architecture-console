using Domain.Interfaces;
using Domain.Services;

IServiceLog serviceLog = new ServiceFileLog();

var runner = new BaseRunner(serviceLog);

// Execute runner
await runner.RunAsync();