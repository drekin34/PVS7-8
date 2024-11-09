namespace LAB7_8
{
    using FluentValidation;
    using LAB7_8.Models;

    public class UserModelValidator : AbstractValidator<UserModel>
    {
        public UserModelValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First Name is required");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last Name is required");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Please enter a valid email address");
            RuleFor(x => x.Age).GreaterThan(0).WithMessage("Age must be greater than 0");
            RuleFor(x => x.PhoneNumber).Matches(@"^\d{10}$").WithMessage("Phone Number must be 10 digits");
            RuleFor(x => x.Address).NotEmpty().WithMessage("Address is required");
            RuleFor(x => x.City).NotEmpty().WithMessage("City is required");
            RuleFor(x => x.Country).NotEmpty().WithMessage("Country is required");
            RuleFor(x => x.BirthDate)
             .Must(date => !date.HasValue || date <= DateTime.Today)
             .WithMessage("BirthDate cannot be in the future.");
            RuleFor(x => x.IsSubscribed).NotNull().WithMessage("Subscription status is required");
        }
    }

}
