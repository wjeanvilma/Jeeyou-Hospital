using System;
using System.Collections.Generic;

namespace JeeyouHospital.Data;

public partial class Patient
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string PatientId { get; set; } = null!;

    public DateTime? DateOfBirth { get; set; }
}
