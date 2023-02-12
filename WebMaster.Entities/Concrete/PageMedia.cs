using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMaster.Core.Entities;

namespace WebMaster.Entities.Concrete
{
    public class PageMedia: IEntity
    {
        public int Id { get; set; }

        public string MediaName { get; set; }
        public string MediaType { get; set; }
        public string MediaPath { get; set; }
        public int MediaSize { get; set; }
        public int ChangedUserId { get; set; }
        public string ChangedDate { get; set; }

    }
}
