using BlazorServer.Models;

public interface IEmployeeService
{
    Task<IEnumerable<Employee>> GetEmployees();
    Task<Employee> GetEmployee(int id);
    Task<Employee> UpdateEmployee(Employee updatedEmployee);
}