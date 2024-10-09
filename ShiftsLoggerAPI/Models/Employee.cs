using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ShiftsLoggerAPI.Models;

public class Employee
{
    public int Id { get; set; }
    
    [Required, MaxLength(50)]
    public required string Name { get; set; }
    
    public required List<Shift> Shifts { get; set; }
}