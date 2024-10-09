using ShiftsLoggerAPI.Data;
using ShiftsLoggerAPI.Models;

namespace ShiftsLoggerAPI.Services;

public class EmployeeService : IEmployeeService
{
    private readonly ILogger<EmployeeService> _logger;
    private readonly DataContext _context;

    public EmployeeService(ILogger<EmployeeService> logger, DataContext context)
    {
        _logger = logger;
        _context = context;
    }
    
    public async Task<Employee?> GetEmployee(int id)
    {
        _logger.LogInformation("Locating employee #{id}...", id);
        
        var emp = await _context.Employees.FindAsync(id);
        if (emp is not null) _logger.LogInformation("Found {name}", emp.Name);

        return emp;
    }
}