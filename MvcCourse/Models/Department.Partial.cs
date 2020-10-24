namespace MvcCourse.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(DepartmentMetaData))]
    public partial class Department
    {
    }
    
    public partial class DepartmentMetaData
    {
        [Required]
        public int DepartmentID { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        public string Name { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        public decimal Budget { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> StartDate { get; set; }

        public Nullable<int> InstructorID { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }
    
        public virtual ICollection<Course> Courses { get; set; }
        public virtual Person Person { get; set; }
    }
}
