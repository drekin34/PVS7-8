using Microsoft.AspNetCore.Mvc;
using FluentValidation;
using LAB7_8.Models;

namespace LAB7_8.Controllers
{
    public class UserController : Controller
    {
        private readonly IValidator<UserModel> _validator;

        public UserController(IValidator<UserModel> validator)
        {
            _validator = validator;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserModel model)
        {
            var validationResult = _validator.Validate(model);

            if (!validationResult.IsValid)
            {
                foreach (var failure in validationResult.Errors)
                {
                    ModelState.AddModelError(failure.PropertyName, failure.ErrorMessage);
                }
                return View(model);
            }

            // Якщо все пройшло успішно
            TempData["SuccessMessage"] = "Form submitted successfully!";
            return View(model);
        }
    }
}
