using PracticeThree.models;

namespace PracticeThree.Manager;


public class patientsManager
{
    private List<Patients> _patients;
    public patientsManager()
    {
        _patients = new List<Patients>();
    }
    public List<Patients> GetAll()
    {
        return _patients;
    }

     public Patients GetByci(int ci)
    {
        Patients patientFound =_patients.Find(Patients => Patients.ci == ci);
        if(patientFound==null)
        {
            throw new Exception("“Patient not found");
        }
        return patientFound;
    }
    public Patients Update(int ci,string name,string lastname)
    {
        if(ci<0)
        {
            throw new Exception("CI invalido");
        }
        Patients patientFound =_patients.Find(Patients => Patients.ci == ci);
        if(patientFound==null)
        {
            throw new Exception("Patient not found");
        }
        patientFound.name=name;
        patientFound.lastName=lastname;   
        return patientFound;
    }
    public Patients Create(string name,string lastName,int ci)
    {
         string[] bloodTypes = { "O+", "O-", "A+", "A-", "B+", "B-", "AB+", "AB-" };
        Random random = new Random();
        int index = random.Next(bloodTypes.Length);
        string bloodType = bloodTypes[index];
        Patients createdPatient =new Patients(){name=name,lastName=lastName,ci=ci,blood=bloodType};
        _patients.Add(createdPatient);
        return createdPatient;
    }
    public Patients Detele(int ci)
    {
        int patientToDeleteIndex =_patients.FindIndex(Patients => Patients.ci == ci);
        Patients patientToDelete =_patients[patientToDeleteIndex];
        _patients.RemoveAt(patientToDeleteIndex);
        if(patientToDeleteIndex==null)
        {
            throw new Exception("“Patient not found");
        }
        return patientToDelete;
    }
}