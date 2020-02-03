﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Graphene.SharedModels.ModelView
{
    public class LoginModelView
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool IsPersistent { get; set; }
    }
}