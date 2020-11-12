namespace WorkflowEngineExercise
{
    public class WorkflowEngine
    {
        public void Execute(Workflow workflow)
        {
            var activites = workflow.GetActivites();
            foreach (var activity in activites)
            {
                activity.Execute();
            }
        }
    }
}
