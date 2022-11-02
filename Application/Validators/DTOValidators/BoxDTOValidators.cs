using Application.DTOs;
using FluentValidation;

namespace Application.Validators.DTOValidators;

public class PostBoxTypeDTOValidator: AbstractValidator<PostBoxTypeDTO>
{
    public PostBoxTypeDTOValidator()
    {
        RuleFor(dto => dto.Height).GreaterThan(0);
        RuleFor(dto => dto.Width).GreaterThan(0);
        RuleFor(dto => dto.Length).GreaterThan(0);
        RuleFor(dto => dto.Name).NotEmpty();
        RuleFor(dto => dto.Description).NotEmpty();
    }
}

public class PostBoxDTOValidator : AbstractValidator<PostBoxDTO>
{
    public PostBoxDTOValidator()
    {
        //nothing really needs to be validated, as the comments could be left empty
    }
}