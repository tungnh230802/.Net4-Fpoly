
using System.ComponentModel.DataAnnotations;

public class EmployeeModel
{
    [Display(Name = "Serial No")]
    public byte Id { get; set; }
    [Display(Name = "Name")]
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
}