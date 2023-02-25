using Abby.DAL.Repository.IRepository;
using Abby.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Admin.FoodTypes
{
    public class EditModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;

        public FoodType FoodType { get; set; }

        public EditModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void OnGet(int id)
        {
            FoodType = _unitOfWork.FoodType.GetFirstOrDefault(u => u.Id == id);
            
        }

        public async Task<IActionResult> OnPost(FoodType foodType)
        {
            
            if (ModelState.IsValid)
            {
                _unitOfWork.FoodType.Update(foodType);
                _unitOfWork.Save();
                TempData["success"] = "FoodType updated successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }


    }
}
