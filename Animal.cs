using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Frame_Linq
{
    public class Animal
    {
        public Guid AnimalId { get; set; }
        public String Name { get; set; }
        public DateTime BirthDay { get; set; }
        public Species Species { get; set; }
    }
}
