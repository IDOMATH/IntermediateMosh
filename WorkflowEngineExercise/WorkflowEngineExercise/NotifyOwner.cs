using System;

namespace WorkflowEngineExercise
{
    public class NotifyOwner : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Video has processed");
        }
    }
}
