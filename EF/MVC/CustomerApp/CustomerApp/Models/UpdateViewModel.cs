using System.ComponentModel.DataAnnotations;

namespace CustomerApp.Models
{
    public class UpdateViewModel
    {
        public string ID { get; set; }
        [Required(ErrorMessage = "Please Enter Your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Location")]
        public string Location { get; set; }

    }
}