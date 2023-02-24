using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj2302.Entities
{
    public class Client
    {

        internal string Name { get; set; }
        internal string Email { get; set; }
        internal string BirthDate { get; set; }

        public Client(string name, string email, string birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return Name
                + ", ("
                + BirthDate
                + ") - "
                + Email;
        }
    }
}
