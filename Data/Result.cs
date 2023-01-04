using System;
using System.Collections.Generic;

namespace JeeyouHospital.Data;

public partial class Result
{
    public int Id { get; set; }

    public int? PatientId { get; set; }

    public int? AppointmentId { get; set; }

    public string? Results { get; set; }

    public DateTime? Date { get; set; }

    public virtual Appointment? Appointment { get; set; }

    public virtual Patient? Patient { get; set; }
}
