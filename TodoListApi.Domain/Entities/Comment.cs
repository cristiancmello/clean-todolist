namespace TodoListApi
{
    public class Comment
    {
        public Comment()
        {
        }

        public Comment(String Body, User User, Todo Todo)
        {
            this.Body = Body;
            CreatedDate = DateTime.Now;
            this.User = User;
            this.Todo = Todo;
        }

        public String Body { get; }

        public DateTime? CreatedDate { get; }

        public DateTime? UpdatedDate { get; }

        public User User { get; }

        public Todo Todo { get; }
    }
}