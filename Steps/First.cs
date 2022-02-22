using WorkflowCore.Interface;
using WorkflowCore.Models;

public class First : StepBody
{
    public int Output1 { get; set; }
    public int Output2 { get; set; }

    public override ExecutionResult Run(IStepExecutionContext context)
    {
        Output1 = 20;
        Output2 = 30;

        System.Console.WriteLine("Starting the workflow...");
        return ExecutionResult.Next();
    }
}