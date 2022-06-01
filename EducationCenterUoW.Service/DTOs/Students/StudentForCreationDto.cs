using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EducationCenterUoW.Service.DTOs.Students
{
    public class StudentForCreationDto
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public Guid GroupId { get; set; }

        public IFormFile Image { get; set; }
    }
}
