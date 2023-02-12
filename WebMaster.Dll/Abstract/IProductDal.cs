using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMaster.Core.Dal;
using WebMaster.Entities.Concrete;

namespace WebMaster.Dal.Abstract
{
    public interface IProductDal: IEntityRepository<Product>
    {

    }
}
