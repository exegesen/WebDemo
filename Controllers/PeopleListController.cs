using Microsoft.AspNetCore.Mvc;
using WebDemo.Models;
using WebDemo.ViewModels;
namespace WebDemo.Controllers
{
    public class PeopleListController : Controller
    {
        
        public ViewResult People()
        {
            //Create People
            Person p0 = new Person()
            {
                Name = "Dillip",
            };
            Person p1 = new Person()
            {
                Name = "Anton",
            };
            Person p2 = new Person()
            {
                Name = "Peter",
            };
            Person p3 = new Person()
            {
                Name = "Lisa",
            };


            //Creating the View model
            CreatePersonViewModel createPersonViewModel = new CreatePersonViewModel();
            createPersonViewModel.AddPerson(p0);
            createPersonViewModel.AddPerson(p1);
            createPersonViewModel.AddPerson(p2);
            createPersonViewModel.AddPerson(p3);
            createPersonViewModel.Col0 = "Name";
            createPersonViewModel.Col1 = "Remove";
            createPersonViewModel.Title = "Title";



            //Pass the viewModel to the view
            return View(createPersonViewModel);
        }
    }
}
