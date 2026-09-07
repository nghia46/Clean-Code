public class DelegateClient
{
    public delegate void WorkFlowStep();

    public void StartProcess()
    {
        Console.WriteLine("Staring process...");
    }
    public void ProcessData()
    {
        Console.WriteLine("Processing data...");
    }
    public void EndProcess()
    {
        Console.WriteLine("Ending proceess...");
    }
    public void RunWorkflow(WorkFlowStep[] steps)
    {
        foreach (WorkFlowStep step in steps)
        {
            step();
        }
    }
    public void Main()
    {
        WorkFlowStep[] workFlows = {StartProcess, ProcessData, EndProcess};
        RunWorkflow(workFlows);
    }
}