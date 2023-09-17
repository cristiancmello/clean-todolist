namespace TodoListApi
{
    public class Category
    {
        public Category()
        {
        }

        public Category(String Name)
        {
            this.Name = Name;
            CreatedDate = DateTime.Now;
        }

        public String? Name { get; }

        public DateTime? CreatedDate { get; }

        public DateTime? UpdatedDate { get; }
    }
}