using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using WebDemo.Models;
using WebDemo.ViewModels;
namespace WebDemo.Models
{
    public class Person
    {
        public static int counter = 0;
        public static int Counter() {
            counter++;
            return counter;
        }
        public static void ResetCounter()
        {
            counter = 0;
        }
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string City { get; set; }
    }
}