using mvcmultilangexample.Resources;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;



namespace mvcmultilangexample.Models
{
    public class UserViewModel
    {
        [Display(Name = "LabelEmail", ResourceType = typeof(Labels))]
        public string Email { get; set; }
    }
}
