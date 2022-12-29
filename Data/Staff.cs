using System;
using System.Collections.Generic;

namespace JeeyouHospital.Data;

public partial class Staff
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string StaffId { get; set; } = null!;

    public DateTime? DateOfBirth { get; set; }

    public int? YearsOfExperiences { get; set; }
}
