using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameWorkWithSQLServerConnected.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Designation { get; set; }
        public int Salery { get; set; }
    }
}
