using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcCourse.Models.ViewModels
{
    public class CourseCreateOrEdit
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public int CourseID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public int Credits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public int DepartmentID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Memo { get; set; }
    }
}