using BlazorServer.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorServer.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await httpClient.GetFromJsonAsync<Employee>($"api/employees/{id}");
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await httpClient.GetFromJsonAsync<Employee[]>("api/employees");
        }

        public Task<Employee> UpdateEmployee(Employee updatedEmployee)
        {
            throw new NotImplementedException();
        }

        //public async Task<Employee> UpdateEmployee(Employee updatedEmployee)
        //{
        //    return await httpClient.PutJsonAsync<Employee>("api/employees", updatedEmployee);
        //}
    }
}