using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain;
using Domain.Interfaces;
using FluentValidation;

namespace Application;

public class BoxService: IBoxService
{
    private IBoxRepository BoxRepository;
    private IMapper Mapper; 
    private IValidator<PostBoxTypeDTO> DTOValidator;
    private IValidator<BoxType> TypeValidator;
    private IValidator<PostBoxDTO> BoxDTOValidator;

    public BoxService(IBoxRepository boxRepository,IMapper mapper,
                        IValidator<PostBoxTypeDTO> dtoValidator,IValidator<BoxType> typeValidator
                        ,IValidator<PostBoxDTO> boxDtoValidator)
    {
        BoxRepository = boxRepository;
        Mapper = mapper;
        DTOValidator = dtoValidator;
        TypeValidator = typeValidator;
        BoxDTOValidator = boxDtoValidator;
    }

    public List<BoxType> GetAllBoxTypes()
    {
        return BoxRepository.GetAllBoxTypes();
    }

    public BoxType CreateNewBoxType(PostBoxTypeDTO dto)
    {
        var validation = DTOValidator.Validate(dto);
        if (!validation.IsValid)
            throw new ValidationException(validation.ToString());

        var mapping = Mapper.Map<BoxType>(dto);
        return BoxRepository.CreateNewBoxType(mapping);
    }

    public BoxType UpdateBoxType(int id, BoxType boxType)
    {
        if (id != boxType.Id)
            throw new ValidationException("ID inside the request body and route dont match");
        var validation = TypeValidator.Validate(boxType);
        if (!validation.IsValid)
            throw new ValidationException(validation.ToString());
        return BoxRepository.UpdateBoxType(boxType);
    }

    public void CreateDatabase()
    {
        BoxRepository.CreateDatabase();
    }

    public List<Box> GetAllBoxes()
    {
        return BoxRepository.GetAllBoxes();
    }

    public Box CreateNewBox(PostBoxDTO dto)
    {
        var validation = BoxDTOValidator.Validate(dto);
        if (!validation.IsValid)
            throw new ValidationException("Not a valid box, please check the values you've input");
        var mappedBox = Mapper.Map<Box>(dto);
        return BoxRepository.CreateNewBox(mappedBox);
    }

    public bool DeleteBox(int boxId)
    {
        return BoxRepository.DeleteBox(boxId);
    }

    public void UpdateBox(int id,Box box)
    {
        if (id != box.Id)
            throw new ValidationException("The id from the routes and body dont match");
        BoxRepository.UpdateBox(box);
    }
}