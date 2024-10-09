namespace ShiftsLoggerAPI.Entities;

public class Employee
{
    public int Id { get; set; }
    public int Name { get; set; }
    public required List<Shift> Shifts { get; set; }
}