using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Models.EntityModels
{
    public class Category : BaseEntity
    {
        public int ParentId { get; set; }

        public int? SortOrder { get; set; }

        public string Name { get; set; }

    }
}
