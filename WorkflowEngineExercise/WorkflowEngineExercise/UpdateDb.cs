using System;

namespace WorkflowEngineExercise
{
    public class UpdateDb : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Updating db");
        }
    }
}
