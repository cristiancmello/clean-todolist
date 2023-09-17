using System.Collections;

namespace TodoListApi
{
    public class Todo
    {
        public Todo()
        {
            CreationDate = null;
        }

        public Todo(string Title, string Description, User User)
        {
            this.Title = Title;
            this.Description = Description;
            CreationDate = DateTime.Now;
            Done = false;
            this.User = User;
        }

        public String Title { get; }

        public String Description { get; }

        public DateTime? CreationDate { get; }

        private Boolean Done { get; set;  }

        public DateTime? FinishedDate { get; }
        
        public DateTime? UpdatedDate { get; private set; }

        public List<Category> Categories { get; } = new List<Category>();

        public List<Comment> Comments { get; } = new List<Comment>();

        public User User { get; }

        public DateTime? Deadline { get; set; }

        public void Check()
        {
            Done = true;
            UpdatedDate = DateTime.Now;
        }

        public Boolean IsDone()
        {
            return this.Done;
        }

        public void Uncheck()
        {
            Done = false;
            UpdatedDate = DateTime.Now;
        }

        public bool IsDeadline()
        {
            var now = DateTime.Now;

            return now >= Deadline;
        }
    }
}