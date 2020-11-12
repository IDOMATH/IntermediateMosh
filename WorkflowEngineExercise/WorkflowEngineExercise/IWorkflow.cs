using System.Collections.Generic;

namespace WorkflowEngineExercise
{
    public interface IWorkflow
    {
        void Add(IActivity activity);
        IEnumerable<IActivity> GetActivities();
    }
}
