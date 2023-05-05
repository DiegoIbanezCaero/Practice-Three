using Microsoft.AspNetCore.Mvc;
using PracticeThree.models;
using PracticeThree.Manager;

namespace PracticeThree.Controllers;

[ApiController]
[Route("patients")]
public class PatientsController : ControllerBase
{
    private readonly patientsManager _PatientsManagers;
    public PatientsController(patientsManager patientsManager)
    {
        _PatientsManagers = patientsManager;
    }

    [HttpGet]
    public List<Patients> Get()
    {
        return _PatientsManagers.GetAll();
    }
    [HttpGet]
    [Route("{ci}")]
    public Patients GetByci([FromRoute]int ci)
    {
        return _PatientsManagers.GetByci(ci);
    }
    [HttpPut]
    [Route("{ci}")]
    public Patients Put([FromRoute]int ci,string name, string lastName,[FromBody]Patients patientsToUpdate)
    {
        return _PatientsManagers.Update(ci,name,lastName);
    }
    [HttpPost]
    public Patients Post([FromBody]Patients createdPatient)
    {
        return _PatientsManagers.Create(createdPatient.name,createdPatient.lastName,createdPatient.ci);
    }
    [HttpDelete]
    [Route("{ci}")]
    public Patients Detele([FromRoute]int ci)
    {
        return _PatientsManagers.Detele(ci);
    }
}
