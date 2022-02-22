using WorkflowCore.Interface;
using WorkflowCore.Models;

public class GoodbyeWorld : StepBody
{
    public override ExecutionResult Run(IStepExecutionContext context)
    {
        Console.WriteLine("Goodbye world");
        return ExecutionResult.Next();
    }
}