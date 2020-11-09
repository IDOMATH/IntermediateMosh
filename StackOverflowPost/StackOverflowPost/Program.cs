using System;

namespace StackOverflowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            Post myPost = new Post("Help, I need something", "there is a problem, here it is. Help.");

            for (int i = 0; i < 10; i++) myPost.Upvote();
            myPost.Downvote();
            Console.WriteLine("Score: {0}", myPost.Score);
        }
    }
}
