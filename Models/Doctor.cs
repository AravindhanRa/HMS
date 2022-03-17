using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HMS.Models
{

public class Doctor{
    [Key]
    public int DoctorId { get; set; }
    
    [DisplayName("Doctor Name")]
    [Required]

    public string DoctorName { get; set; }

    [DisplayName("Doctor's Age")]
    [Required]

    public int DoctorAge { get; set; }
    
    [DisplayName("Doctor's Blood Group ")]
    [Required]

    public string DoctorBloodGroup { get; set; }

    [DisplayName("Qualification")]
    [Required]
    public string Qualification { get; set; }

    [DisplayName("Area Of Expertise")]
    [Required]
    public string AreaOfExpertise { get; set; }

    [DisplayName("Mobile Number")]
    [Required]
     public string MobileNumber { get; set; }

    [DisplayName("Patients Under Consultation")]
    [Required]
     public string PatientsUnderConsultation { get; set; }

}
}