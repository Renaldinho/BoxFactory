using Application.DTOs;
using Domain;
using FluentValidation;

namespace Application.Validators;

public class BoxTypeValidator : AbstractValidator<BoxType>
{
    public BoxTypeValidator()
    {
        RuleFor(bt => bt.Height).GreaterThan(0);
        RuleFor(bt => bt.Width).GreaterThan(0);
        RuleFor(bt => bt.Length).GreaterThan(0);
        RuleFor(bt => bt.Name).NotEmpty();
        RuleFor(bt => bt.Description).NotEmpty();
    }
}

public class BoxValidator : AbstractValidator<Box>
{
    public BoxValidator()
    {
        //Nothing really to validate
    }
}
