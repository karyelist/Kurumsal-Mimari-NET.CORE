using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMaster.Core.Entities;

namespace WebMaster.Entities.Concrete
{
    public class Company: IEntity
    {

		public int Id { get; set; }

		public string CompanyName { get; set; }

		public string CompanyDescription { get; set; }

        public string Adress { get; set; }

        public string Phone1 { get; set; }

        public string Phone2 { get; set; }

        public string MobilPhone { get; set; }

        public string TaxOfficeName { get; set; }


        public string TaxNumber { get; set; }

        public int ChangedUserId { get; set; }
        public string ChangedDate { get; set; }


     }
}
