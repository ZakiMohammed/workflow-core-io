# Pipeline Starter App with IO

The WorkflowCore package required `.NET Core 2.0` framework

#### Initial Setup
```
dotnet new console -o PipelineIOApp
dotnet run
```

#### Nuget Packages
```
dotnet add package WorkflowCore
dotnet add package Microsoft.Extensions.DependencyInjection --version 6.0.0
dotnet add package Microsoft.Extensions.DependencyInjection.Abstractions --version 6.0.0
dotnet add package Microsoft.Extensions.Logging --version 6.0.0

dotnet add package WorkflowCore.DSL --version 3.6.2
```