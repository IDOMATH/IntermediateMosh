using System.Collections.Generic;

namespace WorkflowEngineExercise
{
    public class Workflow : IWorkflow
    {
        private readonly IList<IActivity> _activities;
        public Workflow()
        {
            _activities = new List<IActivity>();
        }
        public void Add(IActivity activity)
        {
            _activities.Add(activity);
        }

        public IList<IActivity> GetActivities()
        {
            return _activities;
        }
    }
}
