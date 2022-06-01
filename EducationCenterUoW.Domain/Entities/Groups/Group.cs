using EducationCenterUoW.Domain.Commons;
using EducationCenterUoW.Domain.Entities.Courses;
using EducationCenterUoW.Domain.Entities.Students;
using EducationCenterUoW.Domain.Entities.Teachers;
using EducationCenterUoW.Domain.Enums;
using EducationCenterUoW.Domain.Localization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationCenterUoW.Domain.Entities.Groups
{
    public class Group : IAuditable, ILocalizationName
    {
        public Guid Id { get; set; }

        /// <summary>
        /// Multilanguage names
        /// </summary>
        [JsonIgnore]
        public string NameUz { get; set; }

        [JsonIgnore]
        public string NameRu { get; set; }

        [JsonIgnore]
        public string NameEn { get; set; }

        [NotMapped]
        public string Name { get; set; }

        public Guid TeacherId { get; set; }

        [ForeignKey(nameof(TeacherId))]
        public Teacher Teacher { get; set; }

        public Guid CourseId { get; set; }

        [ForeignKey(nameof(CourseId))]
        public Course Course { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedBy { get; set; }
        public ItemState State { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
