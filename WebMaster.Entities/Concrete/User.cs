using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMaster.Core.Entities;

namespace WebMaster.Entities.Concrete
{
    public class User: IEntity
    {

		public int Id { get; set; }

		public int UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

		public DateTime BirthDate { get; set; }

		public string Address { get; set; }
		public string PostalCode { get; set; }
		public string Country { get; set; }

		public string Photo { get; set; }

		public string Notes { get; set; }

		public int ChangedUserId { get; set; }

		public DateTime ChangedDate { get; set; }

     }
}
