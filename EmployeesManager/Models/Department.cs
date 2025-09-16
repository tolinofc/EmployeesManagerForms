using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManager.Models
{
    public class Department : DbContext
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
