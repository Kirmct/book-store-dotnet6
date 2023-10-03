using FluentValidation;

namespace BookStoreApp.Application.DTOs.Validations
{
    public class BookRequestValidator : AbstractValidator<BookRequestDTO>
    {
        public BookRequestValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title cant be empty");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description cant be empty");
        }
    }
}
