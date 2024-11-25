/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accepted
{
    class Employee
    {
        public int ID { get; internal  set; }
        public string Name { get; internal  set; }
        public decimal Salary { get; internal  set; }

        public override bool Equals(object? obj)
        {
            Employee? temp = obj as Employee;
            if (temp == null) return false;
            if (this.GetType() != temp.GetType()) return false;
            if (ReferenceEquals(this, temp)) return true;
            return this.ID == temp.ID && this.Name == temp.Name && this.Salary == temp.Salary;
        }
        public override string ToString() => $"ID:{ID} , Name:{Name} , Salary{Salary}";
    }
}
*/