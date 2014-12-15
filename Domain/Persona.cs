using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Persona
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public byte[] Picture { get; set; }
        public Address[] Address { get; set; }
        public SocialAccounts[] SocialAccounts { get; set; }
        public string[] WebSite { get; set; }
        public string[] Email { get; set; }
        public string[] Phone { get; set; }
        public DateTime Created { get; set; }
        public DateTime Changed { get; set; }

        public BusinessCard[] BusinessCards { get; set; }
        public Contact[] Contacts { get; set; }
    }
}
