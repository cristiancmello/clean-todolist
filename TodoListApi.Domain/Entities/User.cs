using System.Collections;

namespace TodoListApi
{
    public class User
    {
        public User()
        {
        }

        public User(String Name, String Email, String Sms)
        {
            this.Name = Name;
            this.Email = Email;
            this.Sms = Sms;
            CreatedDate = DateTime.Now;
        }

        public String Name { get; }

        public String Email { get; }

        public String Sms { get; }

        public DateTime? CreatedDate { get; }

        public DateTime? UpdatedDate { get; }

        public List<Todo> Todos { get; } = new List<Todo>();

        public List<Comment> Comments { get; } = new List<Comment>();
    }
}