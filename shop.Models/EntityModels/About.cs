using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace shop.Models.EntityModels
{
    public class About: BaseEntity
    {
        [Required]
        [StringLength(1000)]
        [DisplayName("Tiêu đề")]
        public string Title { get; set; }

        [Required]
        [AllowHtml]
        [DataType(DataType.MultilineText)]
        [DisplayName("Nội dung")]
        public string Text { get; set; }
    }
}
