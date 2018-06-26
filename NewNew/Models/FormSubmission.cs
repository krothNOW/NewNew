using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NewNew.Models
{
    public class FormSubmission
    {
        public int ID { get; set; }
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }
        [Display(Name = "Driver Email")]
        [DataType(DataType.EmailAddress)]
        [Required]
        public string DriverEmail { get; set; }
        [Display(Name = "Driver ID")]
        [Required]
        public int DriverID { get; set; }
        [Display(Name = "Driver Designation")]
        [Required]
        public string DriverDesignation { get; set; }
        [Display(Name = "Begin Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime BeginDate { get; set; }
        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime EndDate { get; set; }
        [Display(Name = "Additional Details")]
        public string AdditionalDetails { get; set; }
        [Display(Name = "BeginDuration")]
        public string BeginDuration { get; set; }
    }
}
