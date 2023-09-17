namespace TodoListApi
{
    public class CommentTest
    {
        [Fact]
        public void CanCreateComment()
        {
            var comment = new Comment("One comment", new User(), new Todo());
            Assert.Equal("One comment", comment.Body);
            Assert.Equal(DateTime.Now.ToShortDateString(), comment.CreatedDate?.ToShortDateString());
            Assert.Null(comment.UpdatedDate);
            Assert.NotNull(comment.User);
            Assert.NotNull(comment.Todo);
        }

        [Fact]
        public void CanCreateEmptyComment()
        {
            var comment = new Comment();
            Assert.Null(comment.Body);
            Assert.Null(comment.CreatedDate);
            Assert.Null(comment.UpdatedDate);
            Assert.Null(comment.User);
            Assert.Null(comment.Todo);
        }
    }
}
