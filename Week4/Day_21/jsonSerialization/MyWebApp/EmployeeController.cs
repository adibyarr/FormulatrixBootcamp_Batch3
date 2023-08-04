using Microsoft.AspNetCore.Mvc;
namespace JsonSerialization;
[ApiController]
[Route("api/[controller]")]
public class EmployeesController : ControllerBase
{
    [HttpPost]
    public IActionResult Create([FromBody] Employee employee)
    {
        // Lakukan logika untuk menyimpan data karyawan di sini
        // Misalnya, menyimpan data karyawan ke database atau melakukan operasi lainnya

        return Ok("Employee data has been received and processed.");
    }
}
