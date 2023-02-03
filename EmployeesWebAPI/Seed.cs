using EmployeesWebAPI.Data;
using EmployeesWebAPI.Models;

namespace EmployeesWebAPI
{
    public class Seed
    {
        public static void SeedData(DataContext dbContext)
        {
            if (!dbContext.Employees.Any())
            {
                dbContext.Employees.Add(new Employee
                {
                    EmployeeName = "Employee001",
                    Gender = "Male",
                    DateofBirth = "01-01-1990",
                    Nationality = "Indian",
                    City = "Bangalore",
                    CurrentAddress = "Current Address",
                    PaymentAddress = "Permanent Address",
                    PinCode = "560078"
                });
                dbContext.Employees.Add(new Employee
                {
                    EmployeeName = "Employee002",
                    Gender = "Female",
                    DateofBirth = "01-01-1994",
                    Nationality = "Indian",
                    City = "Bangalore",
                    CurrentAddress = "Current Address",
                    PaymentAddress = "Permanent Address",
                    PinCode = "560078"
                });
                dbContext.Employees.Add(new Employee
                {
                    EmployeeName = "Employee003",
                    Gender = "Female",
                    DateofBirth = "01-01-1995",
                    Nationality = "Indian",
                    City = "Bangalore",
                    CurrentAddress = "Current Address",
                    PaymentAddress = "Permanent Address",
                    PinCode = "560078"
                });

                dbContext.SaveChanges();
            }
        }
    }
}
