using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsultationAvocat.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    namespace ConsultationAvocat.Models
    {
        public class Profile
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }

            public string? UserId { get; set; }
            public string UserName { get; set; }

            public string Email { get; set; }
            public string? Experience { get; set; }          
            public string? Telephone { get; set; }
            public string? Address { get; set; }
            public float Tariffs { get; set; }
            public UserType Type { get; set; }

        }

        public enum UserType
        {
            Notaire = 1,
            Avocat = 2,
            Huissier = 3
        }
    }



}
