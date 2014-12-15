
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Contact
    {
        public DateTime Created { get; set; }
        public DateTime ChangedDate { get; set; }
        public Group[] Groups { get; set; }
        public Persona Persona { get; set; }
    }
}
