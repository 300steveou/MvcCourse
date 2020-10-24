using System;
using System.ComponentModel.DataAnnotations;

namespace MvcCourse.Models.ViewModels
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DepartmentEdit
    {
        /// <summary>
        /// 
        /// </summary>
        public int DepartmentID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        public decimal Budget { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Nullable<int> InstructorID { get; set; }

    }
}