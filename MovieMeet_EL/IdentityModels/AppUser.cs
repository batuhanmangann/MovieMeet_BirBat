using Microsoft.AspNetCore.Identity;
using MovieMeet_EL.Enums;
using MovieMeet_EL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieMeet_EL.IdentityModels
{
    public class AppUser : IdentityUser
    {
        [StringLength(50, MinimumLength = 2, ErrorMessage = "İsminiz 2-50 karakter aralığında olmalıdır.")]
        [Required(ErrorMessage = "İsim gereklidir.")]
        public string FullName { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public string Picture { get; set; }

        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }

        [Required(ErrorMessage = "Cinsiyet seçimi gereklidir.")]
        public Gender Gender { get; set; }

        public virtual List<User> User { get; set; }



    }
}
