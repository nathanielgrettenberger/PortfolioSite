using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PortfolioSite.Models
{
    [MetadataType(typeof(ContactFormValidation))]
    public partial class ContactsForm
    { 
    
    }
    public class ContactFormValidation
    {
        // validtae the name
        [Required, Display(Name= "Your Name")]
        public int ContactID { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        [Required, EmailAddress(ErrorMessage= " Your email needs to be something@something.com ")]
        public string Email { get; set; }
        // validate the email
        [Required, DataType(DataType.MultilineText)]
        public string Comments { get; set; }
       
        
    }
}