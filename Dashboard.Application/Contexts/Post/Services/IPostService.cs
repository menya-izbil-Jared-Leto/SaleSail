using Dashboard.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Application.Contexts.Post.Services
{
    /// <summary>
    /// Сервис работы с объявлениями.
    /// </summary>
    public interface IPostService
    {
        /// <summary>
        /// Возвращает объявление по индетификатору.
        /// </summary>
        /// <param name="id">Идетификатор объявления.</param>
        /// <param name="cancellationToken">Отмена операции.</param>
        /// <returns>Модель объявления. <see cref="PostDto"/></returns>
        Task<PostDto> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}
