using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace JeeyouHospital.Data;


public class PatientMetadata
{
    [Display(Name="First Name")]
    public string FirstName { get; set; } = null!;

   [Display(Name="Last Name")]
    public string LastName { get; set; } = null!;

    [Display(Name="Patient Id")]
    public string PatientId { get; set; } = null!;

    [Display(Name="Date Of Birth")]
    public 
    DateTime? DateOfBirth { get; set; }
}

[ModelMetadataType(typeof(PatientMetadata))]
public partial class Patient{

}