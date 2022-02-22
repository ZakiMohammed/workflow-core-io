using Microsoft.Extensions.DependencyInjection;
using WorkflowCore.Interface;
using WorkflowCore.Services.DefinitionStorage;

IServiceProvider serviceProvider = ConfigureServices();

var file = File.ReadAllText("Sample.json");
// var file = File.ReadAllText("Sample.yml");

var loader = serviceProvider.GetService<IDefinitionLoader>();
if (loader == null)
    throw new Exception("Loader not initialized");

loader.LoadDefinition(file, Deserializers.Json);
// loader.LoadDefinition(file, Deserializers.Yaml);

// start the workflow host
var host = serviceProvider.GetService<IWorkflowHost>();
if (host == null)
    throw new Exception("Host not initialized");

// host.RegisterWorkflow<HelloWorldWorkflow, Dictionary<string, int>>();
// host.RegisterWorkflow<HelloWorldWorkflow, CustomData>();
host.Start();

host.StartWorkflow("HelloWorld");

Console.ReadLine();
host.Stop();

IServiceProvider ConfigureServices()
{
    //setup dependency injection
    IServiceCollection services = new ServiceCollection();
    services.AddLogging();
    services.AddWorkflow();
    services.AddWorkflowDSL();

    var serviceProvider = services.BuildServiceProvider();

    return serviceProvider;
}