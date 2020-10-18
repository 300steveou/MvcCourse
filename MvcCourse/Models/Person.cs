using System.ComponentModel.DataAnnotations;

namespace MvcCourse.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required(ErrorMessageResourceName = "PersonName_Valid", ErrorMessageResourceType = typeof(Common))]
        public string Name { get; set; }
         
        [Required(ErrorMessageResourceName = "Age_Valid", ErrorMessageResourceType = typeof(Common))]
        [Range(18, 99, ErrorMessage = "請輸入年紀至少18歲")]
        public int Age { get; set; }
    }
}