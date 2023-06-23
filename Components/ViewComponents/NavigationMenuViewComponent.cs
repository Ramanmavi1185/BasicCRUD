using Microsoft.AspNetCore.Mvc;
using _200520823Midterm.Models;

namespace _200520823Midterm.Components.ViewComponents
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() {

            var menuItems = new List<MenuItem>
            {
                new MenuItem { Controller = "Home", Action = "Index", Label = "Home" }, 
                new MenuItem { Controller = "Companies", Action = "Index", Label = "Company" , DropdownItems =
                new List<MenuItem>
                { new MenuItem { Controller = "Companies", Action= "Index", Label = "List"},
                 new MenuItem { Controller = "Companies", Action= "", Label = "Create"},
            } },
                new MenuItem { Controller = "Employees", Action = "Index", Label = "Employee" , DropdownItems =
                new List<MenuItem>
                { new MenuItem { Controller = "Employees", Action= "Index", Label = "List"},
                 new MenuItem { Controller = "Employees", Action= "Create", Label = "Create"},
                } },
                new MenuItem { Controller = "Home", Action = "Privacy", Label = "Privacy" },
            };

            return View(menuItems);
        
        }
    }
}
