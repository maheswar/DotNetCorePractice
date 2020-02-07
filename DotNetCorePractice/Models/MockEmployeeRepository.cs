using System.Collections.Generic;
using System.Linq;

namespace DotNetCorePractice.Models
{
    public class MockEmployeeRepository:IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){Id=1,Name = "Raju",Email = "Raju@devon.nl",Department = "HR"},
                new Employee(){Id=2,Name = "Mary",Email = "Mary@devon.nl",Department = "IT"},
                new Employee(){Id=3,Name = "John",Email = "John@devon.nl",Department = "IT"}
            };
        }
        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e=>e.Id==id);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }
    }
}
