using WorkflowCore.Interface;
using WorkflowCore.Models;

public class HelloWorld : StepBody
{
    public int Input1 { get; set; }
    public int Input2 { get; set; }
    public int Output { get; set; }

    public override ExecutionResult Run(IStepExecutionContext context)
    {
        Output = Input1 + Input2;
        Console.WriteLine("Hello world", Output);
        return ExecutionResult.Next();
    }
}