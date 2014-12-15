using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class BusinessCard
    {
        public DateTime Created { get; set; }
        public DateTime ChangedDate { get; set; }
        public string CompanyName { get; set; }
        public string[] Email { get; set; }
        public string[] Phone { get; set; }
        public string Position { get; set; }
        public byte[] CompanyLogo { get; set;}
        public Address[] Address { get; set;}
        public string[] KeyWords { get;set;}
        public string[] WebSite { get; set; }
        public byte[] BusinessDemo { get; set; }
        public Persona Persona { get; set; }
    }
}

