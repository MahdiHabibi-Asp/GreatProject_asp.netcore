using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.Entities
{
    public class Vm_student
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Family { get; set; }

        public string Address { get; set; }
    }
}
