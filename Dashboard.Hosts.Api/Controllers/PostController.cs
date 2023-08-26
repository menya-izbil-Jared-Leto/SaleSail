using Dashboard.Application.Contexts.Post.Services;
using Dashboard.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Dashboard.Hosts.Api.Controllers
{
    /// <summary>
    /// Контроллер для работы с оъявлениями.
    /// </summary>
    [ApiController]
    [Route("post")]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;

        /// <summary>
        /// Инициализирует экзепляр <see cref="PostController"/>
        /// </summary>
        /// <param name="postService">Сервис работы с объявлениями.</param>
        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        /// <summary>
        /// Возвращает объявление по индетификатору.
        /// </summary>
        /// <param name="id">Идетификатор объявления.</param>
        /// <param name="cancellationToken">Отмена операции.</param>
        /// <returns>Модель объявления. <see cref="PostDto"/></returns>
        [HttpGet("get-by-id")]
        [ProducesResponseType(typeof(PostDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var result = await _postService.GetByIdAsync(id, cancellationToken);
            return Ok(result);
        }

        /// <summary>
        /// Возвращает постраничные объявления.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <param name="pageSize">Размер страницы.</param>
        /// <param name="pageIndex">Номер страницы.</param>
        /// <returns>Коллекция объявлений.<see cref="PostDto"/></returns>
        [HttpGet("get-all-pages")]
        public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken, int pageSize = 10, int pageIndex = 0)
        {
            return Ok();
        }

        /// <summary>
        /// Создание объявления.
        /// </summary>
        /// <param name="dto"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateAsync(PostDto dto, CancellationToken cancellationToken)
        {
            return Created(string.Empty, null);
        }

        /// <summary>
        /// Редактирует объявление.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Отмена операции.</param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> UpdateAsync(PostDto dto, CancellationToken cancellationToken)
        {
            return Ok();
        }

        /// <summary>
        /// Удаление объявления по идетефикатору.
        /// </summary>
        /// <param name="id">Идетификатор объявления.</param>
        /// <param name="cancellationToken">Отмена операции.</param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            return Ok();
        }
    }
}
