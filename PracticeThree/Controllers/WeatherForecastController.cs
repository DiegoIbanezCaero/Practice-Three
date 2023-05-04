using Microsoft.AspNetCore.Mvc;
using PracticeThree.models;

namespace PracticeThree.Controllers;

[ApiController]
[Route("patients")]
public class PatientsController : ControllerBase
{
    public PatientsController()
    {
        
    }
    [HttpGet]
    public List<Patients> Get()
    {
        return new List<Patients>();
    }
    [HttpGet]
    [Route("{ci}")]
    public List<Patients> GetByci([FromRoute]int ci)
    {
        return new List<Patients>();
    }
    [HttpPut]
    public Patients Put()
    {
        return new Patients();
    }
    [HttpPost]
    public Patients Post()
    {
        return new Patients();
    }
    [HttpDelete]
    public Patients Detele()
    {
        return new Patients();
    }
}
