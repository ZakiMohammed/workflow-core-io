using WorkflowCore.Interface;
using WorkflowCore.Models;

public class CustomMessage : StepBody
{
    public string? Message { get; set; }

    public override ExecutionResult Run(IStepExecutionContext context)
    {
        Console.WriteLine(Message);
        return ExecutionResult.Next();
    }
}