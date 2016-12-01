using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyOnline.Models.Entities
{
    /// <summary>
    /// Model of user entity.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets the unique entity key to be selected by.
        /// </summary>
        [Key]
        [Required]
        [Column(Order = 1)]
        public int UserId { get; set; }
        /// <summary>
        /// Gets or sets user email.
        /// </summary>
        [Required]
        [Column(Order = 2, TypeName = "varchar")]
        [MaxLength(255)]
        public string Email { get; set; }
        /// <summary>
        /// Gets or sets user password.
        /// </summary>
        [Required]
        [Column(Order = 3, TypeName = "varchar")]
        [MaxLength(31), MinLength(7)]
        public string Password { get; set; }
        /// <summary>
        /// Gets or sets user name.
        /// </summary>
        [Required]
        [Column(Order = 4, TypeName = "varchar")]
        [MaxLength(31), MinLength(4)]
        public string UserName { get; set; }
    }
}
