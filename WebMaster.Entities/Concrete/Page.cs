using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMaster.Core.Entities;

namespace WebMaster.Entities.Concrete
{
    public class Page: IEntity
    {

        public int Id { get; set; }

        public string PageTitle { get; set; }
        public string PageContent { get; set; }
        public string PageTags { get; set; }
        public string PageKeywords { get; set; }
        public int ChangedUserId { get; set; }
        public DateTime ChangedDate { get; set; }

    }
}
