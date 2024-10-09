using ShiftsLoggerAPI.Models;

namespace ShiftsLoggerAPI.Services;

public interface IEmployeeService
{
    Task<Employee?> GetEmployee(int id);
}