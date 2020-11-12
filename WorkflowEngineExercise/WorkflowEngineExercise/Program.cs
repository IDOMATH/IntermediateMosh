using System;

namespace WorkflowEngineExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.Add(new UploadVideo());
            workflow.Add(new EncodeVideo());
            workflow.Add(new NotifyOwner());
            workflow.Add(new UpdateDb());

            var engine = new WorkflowEngine();
            engine.Execute(workflow);
        }
    }
}
