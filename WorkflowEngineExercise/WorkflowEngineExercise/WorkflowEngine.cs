namespace WorkflowEngineExercise
{
    public class WorkflowEngine
    {
        public void Execute(IWorkflow workflow)
        {
            var activites = workflow.GetActivities();
            foreach (var activity in activites)
            {
                activity.Execute();
            }
        }
    }
}
