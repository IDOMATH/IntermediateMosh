namespace StackOverflowPost
{
    public class Post
    {
        private readonly string Title;
        public int Score { get; private set; }
        public string Description { get; set; }

        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
        }

        public void Upvote()
        {
            Score++;
        }
        public void Downvote()
        {
            Score--;
        }
        public void DisplayPost()
        {
            System.Console.WriteLine("Title: {0}\n{1}", Title, Description);
        }
    }
}
