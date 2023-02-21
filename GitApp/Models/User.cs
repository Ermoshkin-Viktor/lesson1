using System.ComponentModel.DataAnnotations;

namespace GitApp.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Введите имя")]
        [RegularExpression(@"\D*", ErrorMessage = "Вводите только буквы")]
        public string Name { get; set; }//имя пользователя

        [Required(ErrorMessage = "Введите возраст")]
        public int Age { get; set; }//возраст пользователя
    }
}
