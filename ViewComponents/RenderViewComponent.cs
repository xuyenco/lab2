using Microsoft.AspNetCore.Mvc;
using web__TH__1.Models;

namespace web__TH__1.ViewComponents
{
    
    public class RenderViewComponent : ViewComponent
    {
        private List<MenuItem> menuItems = new List<MenuItem>();
        public RenderViewComponent()
        {
            menuItems = new List<MenuItem>()
            {
                new MenuItem() { Id = 1, Name = "Branches", Link = "Branches/List" },
            new MenuItem() { Id = 2, Name = "Students", Link = "Students/List" },
            new MenuItem() { Id = 3, Name = "Subjects", Link = "Subjects/List" },
            new MenuItem() { Id = 4, Name = "Courses", Link = "Courses/List" },
            };

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("RenderLeftMenu", menuItems);
        }
    }
}
