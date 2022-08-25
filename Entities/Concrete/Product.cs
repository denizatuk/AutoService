using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string ProductSku { get; set; }
        public string ProductImageUrl { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        public short ProductStock { get; set; }
        public bool ProductStatus { get; set; }

    }
}
