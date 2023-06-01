using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppGarrels.Models
{
    public class responsive
    {
            //Creating Variables and their requirements
            [Required(ErrorMessage = "Name is required")]
            public string name { get; set; }

            [Required(ErrorMessage = "Please enter your Birth Year.")]
            [Range(1900, 2023, ErrorMessage ="Birth Year must be between 1900 and 2023")]
            public int BirthYear { get; set; }

            public const int EndYear = 2023;
            
            //Method to calculate age and return
            public String AgeThisYear()
            {
            int age = EndYear - BirthYear;

            string ageString = name + " will be " + age + " this Year!";

            return ageString;
            }
        }
}


