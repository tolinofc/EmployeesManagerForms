using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManager.Models
{
    public interface IEntityWithName
    {
        int Id { get; set; }
        string Name { get; set; }
    }
}
