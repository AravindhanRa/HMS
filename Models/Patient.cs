using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HMS.Models
{
    public class Patient{
        [Key]
        public int Id { get; set; }
        [DisplayName("Patient Name")]
        [Required]
        public string PatientName { get; set; }

        [DisplayName("Patient Date Of Birth")]
        [Required]
        public DateTime PatientDob { get; set; }

        [DisplayName("Patient Gender")]
        [Required]
        public string PatientGender { get; set; }

        [DisplayName("Patient Age")]
        [Required]
        public int PatientAge { get; set; }

        [DisplayName("Blood Group")]
        [Required]
        public string PatientBloodGroup { get; set; }

        [DisplayName("Diagnosis")]
        [Required]
        public string Diagnosis { get; set; }

        [DisplayName("Attendant Name")]
        [Required]
        public string AttendantName { get; set; }

        [DisplayName("Mobile Number")]
        [Required]
        public string MobileNumber { get; set; }

        [DisplayName("Doctor")]
        [Required]
        public string ConsultingDoctor { get; set; }


    }    
}


