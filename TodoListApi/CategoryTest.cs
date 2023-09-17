namespace TodoListApi
{
    public class CategoryTest
    {
        [Fact]
        public void CanCreateCategory()
        {
            var category = new Category("CategoryName");
            Assert.Equal("CategoryName", category.Name);
            Assert.Equal(DateTime.Now.ToShortDateString(), category.CreatedDate?.ToShortDateString());
            Assert.Null(category.UpdatedDate);
        }

        [Fact]
        public void CanCreateEmptyCategory()
        {
            var category = new Category();
            Assert.Null(category.Name);
            Assert.Null(category.CreatedDate);
            Assert.Null(category.UpdatedDate);
        }
    }
}
