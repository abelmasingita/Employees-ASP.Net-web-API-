 using EmployeesWebAPI.Data;
using EmployeesWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesWebAPI.Controlers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController
    {
        private readonly DataContext _dataContext;

        public EmployeeController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        //Get api/[employeeController]
        [HttpGet]
        public ICollection<Employee> Employees()
        {
            return _dataContext.Employees.ToList();
        }


        //Get api/[employeeController]/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return _dataContext.Employees.FirstOrDefault(e => e.EmployeeId == id);
        }

        //POST api/[employeeController]
        [HttpPost]
        public void Post([FromBody] Employee value)
        {
            _dataContext.Employees.Add(value);
            _dataContext.SaveChanges();
        }


        //PUT api/[employeeController]/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee value)
        {
            var employee = _dataContext.Employees.FirstOrDefault(e => e.EmployeeId == id);

            if (employee != null)
            {
                _dataContext.Entry<Employee>(employee).CurrentValues.SetValues(value);
                _dataContext.SaveChanges();
            }
        }

        //Delete api/[employeeController]/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var employee = _dataContext.Employees.FirstOrDefault(e => e.EmployeeId == id);

            if(employee != null)
            {
                _dataContext.Employees.Remove(employee);
                _dataContext.SaveChanges();
            }
        }

    }
}
