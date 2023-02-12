using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebMaster.Core.Dal.EntityFramework;
using WebMaster.Dal.Abstract;
using WebMaster.Dal.Concrete.EntityFramework;
using WebMaster.Dal.Abstract;
using WebMaster.Entities.Concrete;

namespace WebMaster.Bll
{
    public class ProductManager: IEntityRepositoryBase<Product, WebMasterContext>
    {

    }
}
