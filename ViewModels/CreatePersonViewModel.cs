using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebDemo.Models;
using WebDemo.ViewModels;

namespace WebDemo.ViewModels
{
    public class CreatePersonViewModel
    {
        public string Col0 { get; set; }
        public string Col1 { get; set; }
        public string Col2 { get; set; }
        public string Title { get; set; }

        public PersonList People { get; set; }
        
    }
}