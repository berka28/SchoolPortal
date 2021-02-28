using SchoolPortal.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace SchoolPortal.Entities
{
    public partial class SchoolClass
    {
        public SchoolClass()
        {
            SchoolClassStudents = new HashSet<SchoolClassStudent>();
        }

        public Guid Id { get; set; }
        public string ClassName { get; set; }
        [DisplayName("Teacher")]
        public string TeacherId { get; set; }
        public DateTime Created { get; set; }

        public virtual ApplicationUser Teacher { get; set; }

        public virtual ICollection<SchoolClassStudent> SchoolClassStudents { get; set; }
    }
}
