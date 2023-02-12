using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebMaster.Core.Dal.EntityFramework;
using WebMaster.Dal.Abstract;
using WebMaster.Entities.Concrete;

 
namespace WebMaster.Dal.Concrete.EntityFramework
{
    public class EfProductDal:IEntityRepositoryBase<Product, WebMasterContext>,IProductDal
    {
    }
}
