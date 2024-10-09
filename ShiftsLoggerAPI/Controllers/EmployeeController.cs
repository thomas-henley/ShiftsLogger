using Microsoft.AspNetCore.Mvc;
using ShiftsLoggerAPI.Data;
using ShiftsLoggerAPI.Models;

namespace ShiftsLoggerAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{
    private readonly ILogger<EmployeeController> _logger;
    private readonly DataContext _context;

    public EmployeeController(ILogger<EmployeeController> logger, DataContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<List<Employee>>> GetEmployee(int id)
    {
        _logger.LogInformation("Locating employee #{id}...", id);
        var emp = await _context.Employees.FindAsync(id);
        if (emp is null) return NotFound();
        
        _logger.LogInformation("Found {name}", emp.Name);
        return Ok(emp);
    }
}