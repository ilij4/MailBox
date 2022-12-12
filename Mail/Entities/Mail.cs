using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mail.Entities
{
    public class Mail
    {
        public int? MailID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public DateTime MailDate { get; set; }

    }
}
