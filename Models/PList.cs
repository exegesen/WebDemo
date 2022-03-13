using Microsoft.AspNetCore.Mvc;
using Nancy.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebDemo.Models;
using WebDemo.ViewModels;
namespace WebDemo.Models
{
    public class PersonList
    {
        [Required]
        public List<Person> PList { get; set; }
    }
    public static class JsonExtensions
    {
        public static string ToJson(this Object obj)
        {
            return new JavaScriptSerializer().Serialize(obj);
        }
    }
}