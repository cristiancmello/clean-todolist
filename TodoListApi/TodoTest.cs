namespace TodoListApi
{
    public class TodoTest
    {
        private Todo todo = new Todo();

        [Fact]
        public void CanCreateTodo()
        {
            var todo = new Todo("Title", "Description", new User());
            Assert.Equal("Title", todo.Title);
            Assert.Equal("Description", todo.Description);
            Assert.Equal(DateTime.Now.ToShortDateString(), todo.CreationDate?.ToShortDateString());
            Assert.False(todo.IsDone());
            Assert.Null(todo.FinishedDate);
            Assert.Null(todo.UpdatedDate);
            Assert.Empty(todo.Categories);
            Assert.Empty(todo.Comments);
            Assert.NotNull(todo.User);
            Assert.Null(todo.Deadline);
        }

        [Fact]
        public void CanCreateEmptyTodo()
        {
            Assert.Null(todo.Title);
            Assert.Null(todo.Description);
            Assert.Null(todo.CreationDate);
            Assert.Null(todo.UpdatedDate);
            Assert.False(todo.IsDone());
            Assert.Empty(todo.Categories);
            Assert.Empty(todo.Comments);
            Assert.Null(todo.User);
            Assert.Null(todo.Deadline);
        }

        [Fact]
        public void AfterCheck_willDone()
        {
            todo.Check();
            Assert.True(todo.IsDone());
            Assert.Equal(DateTime.Now.ToShortDateString(), todo.UpdatedDate?.ToShortDateString());
        }

        [Fact]
        public void AfterUncheck_IsNotDone()
        {
            todo.Uncheck();
            Assert.False(todo.IsDone());
            Assert.Equal(DateTime.Now.ToShortDateString(), todo.UpdatedDate?.ToShortDateString());
        }

        [Fact]
        public void AfterCheckAndUncheck_IsNotDone()
        {
            todo.Check();
            Assert.True(todo.IsDone());

            todo.Uncheck();
            Assert.False(todo.IsDone());
        }

        [Fact]
        public void AfterGetDateNow_willDeadlineWhenDateNowGreatherThanDeadline()
        {
            todo.Deadline = DateTime.Now.AddHours(-1);
            Assert.True(todo.IsDeadline());
        }

        [Fact]
        public void AfterGetDateNow_willDeadlineWhenDateNowLessThanDeadline()
        {
            todo.Deadline = DateTime.Now.AddHours(1);
            Assert.False(todo.IsDeadline());
        }
    }
}

/*
TODO:

- Campos do Todo: Titulo, Descricao, Data da Criacao, Conclusao, Data da Conclusao, Date de Update


- fazer paginação de todo
- comentário
- categoria

- cadastrar o todo
- permitir cadastrar usuário
- fazer o login

RECOMMENDATION
- Usar mysql, .Net, Clean Architecture
*/