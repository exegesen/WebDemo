using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebDemo.Models;
using WebDemo.ViewModels;

namespace WebDemo.ViewModels
{
    public class CreatePersonViewModel
    {
        [Required]
        public string Col0 { get; set; }
        [Required]
        public string Col1 { get; set; }
        [Required]
        public string Col2 { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int PersonId { get; set; }
        public string Add { get; set; }
        public string Filter { get; set; }
        public string City { get; set; }
        [Required]
        public PersonList PersonList { get; set; }
        public Person Person { get; set; }

    }
}