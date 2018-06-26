using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewNew.Models
{
    public class FileUpload
    {
        [Required]
        [Display(Name = "Driver Email")]
        public string DriverEmail { get; set; }

        [Required]
        [Display(Name = "Public Schedule")]
        public IFormFile UploadPublicSchedule { get; set; }

        [Required]
        [Display(Name = "Private Schedule")]
        public IFormFile UploadPrivateSchedule { get; set; }
    }
}
