using System.ComponentModel.DataAnnotations;

namespace Graphene.SharedModels.ModelView
{
    public class RegisterModelView : LoginModelView
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}