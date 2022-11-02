using Domain;

namespace Application.DTOs;

public class PostBoxDTO
{
    public string Notes { get; set; }

    //public int BoxTypeId { get; set; }
    //public BoxType BoxType { get; set; }
}

public class PostBoxTypeDTO
{
    public int Height { get; set; }
    public int Width { get; set; }
    public int Length { get; set; }
    public string Description { get; set; }
    public string Name { get; set; }

    public PostBoxTypeDTO(int height, int width, int length, string description, string name)
    {
        Height = height;
        Width = width;
        Length = length;
        Description = description;
        Name = name;
    }
}