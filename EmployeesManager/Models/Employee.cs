using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManager.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int DepartmentId {  get; set; }
        public int PositionId { get; set; }
        public int ProjectId { get; set; }
        public virtual Department Department { get; set; }
        public virtual Position Position { get; set; }
        public virtual Project Project { get; set; }
    }
}
