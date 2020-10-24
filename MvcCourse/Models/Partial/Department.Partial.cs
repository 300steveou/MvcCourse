using System;
using System.ComponentModel.DataAnnotations;

namespace MvcCourse.Models.Partial
{
    [MetadataType(typeof(DepartmentMetaData))]
    public partial class Department
    {
        public class DepartmentMetaData
        {
            /// <summary>
            /// 
            /// </summary>
            public int DepartmentID { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [Required]
            public string Name { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
            [Required]
            public decimal Budget { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
            [Required]
            public DateTime? StartDate { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public Nullable<int> InstructorID { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public byte[] RowVersion { get; set; }
        }
    }
}