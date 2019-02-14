using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBookApp
{
    public class Employee
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public static Employee GetEmployee()
        {
            var employee = new Employee
            {
                Name = "Jhon Doe",
                Title="CEO"
            };
            return employee;
            
        }
        public static void WriteEmployee(Employee employee)
        {
            var employeeData = $"{employee.Name},{employee.Title}";
            FileHelper.WriteTextFileAsync("EmployeeTextFile", employeeData);
        }
    }
}
