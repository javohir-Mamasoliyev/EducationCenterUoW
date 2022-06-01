using EducationCenterUoW.Domain.Commons;
using EducationCenterUoW.Domain.Entities.Courses;
using EducationCenterUoW.Domain.Enums;
using System;
using System.Collections.Generic;

namespace EducationCenterUoW.Domain.Entities.Teachers
{
    public class Teacher : IAuditable
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedBy { get; set; }
        public ItemState State { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
