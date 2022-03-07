using Microsoft.AspNetCore.Mvc;
using WebDemo.Models;
using WebDemo.ViewModels;
namespace WebDemo.Controllers
{
    public class PeopleList : Controller
    {
        CreatePersonViewModel createPersonViewModel = new CreatePersonViewModel();
        [HttpGet]
        public ViewResult People()
        {
            //Create People
            Person p0 = new Person()
            {
                Name = "Dillip",
                Id = 0,
                City = "Georgestown",
            };
            Person p1 = new Person()
            {
                Name = "Anton",
                Id = 1,
                City = "Malmö",
            };
            Person p2 = new Person()
            {
                Name = "Peter",
                Id = 2,
                City = "Foggy Bottom",
            };
            Person p3 = new Person()
            {
                Name = "Lisa",
                Id = 3,
                City = "Mexico City",
            };


            //Creating the View model
            createPersonViewModel.AddPerson(p0);
            createPersonViewModel.AddPerson(p1);
            createPersonViewModel.AddPerson(p2);
            createPersonViewModel.AddPerson(p3);
            createPersonViewModel.Col0 = "Name";
            createPersonViewModel.Col2 = "Remove";
            createPersonViewModel.Col1 = "City";
            createPersonViewModel.Title = "Title";



            //Pass the viewModel to the view
            return View(createPersonViewModel);
        }

        [HttpPost]
        public ViewResult People(CreatePersonViewModel createPersonViewModel)
        {
            createPersonViewModel.RemovePerson(id);
            return View(createPersonViewModel);
        }

    }
}
