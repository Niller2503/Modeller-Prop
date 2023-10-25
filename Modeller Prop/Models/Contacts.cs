using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modeller_Prop.Models
{
    public class Contacts
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public int Pnumber { get; set; }
        public string By { get; set; }
        public int Tlf { get; set; }
        public string Email { get; set; }
        public Contacts() { }
    }
}
