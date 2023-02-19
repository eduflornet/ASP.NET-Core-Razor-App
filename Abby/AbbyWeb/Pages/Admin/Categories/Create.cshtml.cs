using Abby.DAL.Repository.IRepository;
using Abby.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Admin.Categories
{
    public class CreateModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;

        public Category Category { get; set; }


        public CreateModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void OnGet()
        {
        }
    }
}
