using System;
using System.Collections.Generic;

namespace JeeyouHospital.Data;

public partial class Appointment
{
    public int Id { get; set; }

    public int? StaffId { get; set; }

    public int? PatientId { get; set; }

    public int? SpecializationId { get; set; }

    public DateTime? Date { get; set; }

    public virtual Patient? Patient { get; set; }

    public virtual ICollection<Result> Results { get; } = new List<Result>();

    public virtual Specialization? Specialization { get; set; }

    public virtual Staff? Staff { get; set; }
}
