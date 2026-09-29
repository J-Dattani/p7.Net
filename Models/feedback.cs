using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Razor.Parser.SyntaxTree;

namespace p7.Models
{
    public class feedback
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public int Rating { get; set; }

        [Required]
        public string Message { get; set; }

    }
}