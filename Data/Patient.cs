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

    public virtual ICollection<Appointment> Appointments { get; } = new List<Appointment>();

    public virtual ICollection<Result> Results { get; } = new List<Result>();
}
