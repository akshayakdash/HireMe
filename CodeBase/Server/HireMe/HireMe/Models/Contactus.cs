using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HireMe.Models
{
    public class Contactus
    {
        ///<summary>
        /// Gets or sets Name.
        ///</summary>
        [Required(ErrorMessage = "S'il vous plaît entrez votre nom")]
        public string Name { get; set; }

        ///<summary>
        /// Gets or sets Email.
        ///</summary>
        [Required]
        [EmailAddress(ErrorMessage = "Veuillez entrer votre adresse email dans un format valide")]
        public string Email { get; set; }

        ///<summary>
        /// Gets or sets Message.
        ///</summary>
        [Required(ErrorMessage = "S'il vous plaît entrez votre message")]
        public string Message { get; set; }

    }
}