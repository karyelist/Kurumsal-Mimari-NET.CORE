using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMaster.Core.Entities;
 
namespace WebMaster.Entities.Concrete
{
    public class Contact: IEntity
    {
		public int Id { get; set; }

		public string Adress { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public string MobilPhone1 { get; set; }
        public string MobilPhone2 { get; set; }

        public int ChangedUserId { get; set; }
        public DateTime ChangedDate { get; set; }


    }
}
