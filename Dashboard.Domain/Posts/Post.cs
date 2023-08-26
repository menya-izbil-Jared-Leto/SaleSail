using Dashboard.Domain.Attachment;
using Dashboard.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Domain.Posts
{
    /// <summary>
    /// Сущность объявлений.
    /// </summary>
    public class Post : BaseEntity
    {
        /// <summary>
        /// Название.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Описание.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Характеристики товара.
        /// </summary>
        public string Overview { get; set; }

        /// <summary>
        /// Цена.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Наименование категории.
        /// </summary>
        public Guid CategoryId { get; set; }

        /// <summary>
        /// Наименования тегов.
        /// </summary>
        public string[] TagNames { get; set; }

        /// <summary>
        /// Изображения.
        /// </summary>
        public required IReadOnlyCollection<Attachment.Attachment> Attachments { get; set; }
    }
}
