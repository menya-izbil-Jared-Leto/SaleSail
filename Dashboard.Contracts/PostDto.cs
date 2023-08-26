using Dashboard.Contracts.Attachment;
using Dashboard.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Contracts
{
    /// <summary>
    /// Объявление.
    /// </summary>
    public class PostDto : BaseDto
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
        public string CategoryName { get; set; }

        /// <summary>
        /// Наименования тегов.
        /// </summary>
        public string[] TagNames { get; set; }

        /// <summary>
        /// Изображения.
        /// </summary>
        public IReadOnlyCollection<AttachmentDto> Attachments { get; set; }
    }
}
