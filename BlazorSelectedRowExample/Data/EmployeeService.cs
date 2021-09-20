using System;
using System.Threading.Tasks;

namespace BlazorSelectedRowExample.Data
{
    public class EmployeeService
    {
        public Task<Employee[]> GetEmployeesAsync()
        {
            var employeeCount = 10;

            var employees = new Employee[employeeCount];
            for(var x = 0; x < employeeCount; x++)
            {
                var employee = new Employee();

                employee.Id = Guid.NewGuid();
                employee.FirstName = Faker.Name.First();
                employee.LastName = Faker.Name.Last();
                employee.Age = Faker.RandomNumber.Next(18, 100);
                employee.Address = Faker.Address.StreetAddress();
                employee.City = Faker.Address.City();
                employee.State = Faker.Address.UsState();
                employee.ZipCode = Faker.Address.ZipCode();

                employees[x] = employee;
            }

            return Task.FromResult(employees);
        }
    }
}
