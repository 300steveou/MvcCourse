using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcCourse.Models
{
    public class Person
    {
        public int Id { get; set; }

        [DisplayName("姓名")]
        [Required(ErrorMessageResourceName = "PersonName_Valid", ErrorMessageResourceType = typeof(Common))]
        public string Name { get; set; }
         
        [DisplayName("年齡")]
        [Required(ErrorMessageResourceName = "Age_Valid", ErrorMessageResourceType = typeof(Common))]
        [Range(18, 99, ErrorMessage = "請輸入年紀介於{1}~{2}處之間")]
        public int Age { get; set; }
    }
}