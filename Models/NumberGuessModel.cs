using Microsoft.AspNetCore.Mvc;
using System;
namespace WebDemo.Models
{
    public class GuessGameFormData
    {
        public int numberInput { get; set; }
        public string wrongRightGuess { get; set; }
        public static int generateNumber() {
            Random rnd = new Random();
            int rand = rnd.Next(1,100);
            return rand;
        }
    }
}
