using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMaster.Core.Entities;

namespace WebMaster.Entities.Concrete
{
    public class Product: IEntity
    {

        public int Id { get; set; }
        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public int CategoryId { get; set; }

        public decimal UnitPrice { get; set; }

        public int UnitsinStock { get; set; }

         
    }
}
