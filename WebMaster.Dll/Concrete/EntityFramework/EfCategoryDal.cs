using Microsoft.EntityFrameworkCore;
using WebMaster.Core.Dal.EntityFramework;
using WebMaster.Dal.Abstract;
using WebMaster.Entities.Concrete;

namespace WebMaster.Dal.Concrete.EntityFramework;

public class EfCategoryDal : IEntityRepositoryBase<Categories, WebMasterContext>, ICategoryDal
{

}