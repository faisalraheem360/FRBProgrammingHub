using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameWorkWithSQLServerConnected.Models
{
    public class EmployeeContext : DbContext
    {
        private static object option;

        //Constructer
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
        
        
        
        
        }
        
           
                  
        public DbSet<Employee> Employees { get; set; }

    }
}
