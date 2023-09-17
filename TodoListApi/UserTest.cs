namespace TodoListApi
{
    public class UserTest
    {
        [Fact]
        public void CanCreateUser()
        {
            var user = new User("John Doe", "john.doe@email.com", "01+ 99 12345 6789");
            Assert.Equal("John Doe", user.Name);
            Assert.Equal("john.doe@email.com", user.Email);
            Assert.Equal("01+ 99 12345 6789", user.Sms);
            Assert.Equal(DateTime.Now.ToShortDateString(), user.CreatedDate?.ToShortDateString());
            Assert.Null(user.UpdatedDate);
            Assert.Empty(user.Todos);
            Assert.Empty(user.Comments);
        }

        [Fact]
        public void CanCreateEmptyUser()
        {
            var user = new User();
            Assert.Null(user.Name);
            Assert.Null(user.Email);
            Assert.Null(user.Sms);
            Assert.Null(user.CreatedDate);
            Assert.Null(user.UpdatedDate);
            Assert.Empty(user.Todos);
            Assert.Empty(user.Comments);
        }
    }
}
