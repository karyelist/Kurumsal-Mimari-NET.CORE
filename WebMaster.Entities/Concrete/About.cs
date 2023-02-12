using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMaster.Core.Entities;

namespace WebMaster.Entities.Concrete
{


    public class About:IEntity

    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }

        public int ChangedUserId { get; set; }
        public DateTime ChangedDate { get; set; }


     }
}
