using WorkflowCore.Interface;
using WorkflowCore.Models;

// public class HelloWorldWorkflow : IWorkflow<Dictionary<string, int>>

public class HelloWorldWorkflow : IWorkflow<CustomData>
{
    // public void Build(IWorkflowBuilder<Dictionary<string, int>> builder)
    public void Build(IWorkflowBuilder<CustomData> builder)
    {
        builder
            .UseDefaultErrorBehavior(WorkflowErrorHandling.Suspend)
            .StartWith<First>()
                .Output((step, data) =>
                    {
                        data.Value1 = step.Output1;
                        data.Value2 = step.Output2;
                    })
            .Then<HelloWorld>()
                .Input(step => step.Input1, data => data.Value1)
                .Input(step => step.Input2, data => data.Value2)
                .Output((step, data) => data.Value3 = step.Output)
            .Then<CustomMessage>()
                .Name("Some foo message")
                .Input(step => step.Message, data => $"The answer is: {data.Value3.ToString()}")
            .Then<GoodbyeWorld>();
    }

    public string Id => "HelloWorld";

    public int Version => 1;

}