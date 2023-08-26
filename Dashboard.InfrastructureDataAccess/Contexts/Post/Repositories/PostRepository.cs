using Dashboard.Application.AppServices.Contexts.Post.Repositories;
using Dashboard.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.InfrastructureDataAccess.Contexts.Post.Repositories
{
    public class PostRepository : IPostRepository
    {
        public Task<PostDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return Task.Run(() => new PostDto
            {
                Id = Guid.NewGuid(),
                Title = "Тест",
                Description = "Описание",
                CategoryName = "Категория",
                TagNames = new[] { "Что-то", "Еще" },
                Price = 100
            }, cancellationToken);
        }
    }
}
