using Microsoft.AspNetCore.Mvc;
using ShiftsLoggerAPI.Models;
using ShiftsLoggerAPI.Services;

namespace ShiftsLoggerAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{
    private readonly ILogger<EmployeeController> _logger;
    private readonly IEmployeeService _employeeService;

    public EmployeeController(ILogger<EmployeeController> logger, IEmployeeService employeeService)
    {
        _logger = logger;
        _employeeService = employeeService;
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<List<Employee>>> GetEmployee(int id)
    {
        var emp = await _employeeService.GetEmployee(id);
        if (emp is null) return NotFound("No employee with that ID.");
        return Ok(emp);
    }
}