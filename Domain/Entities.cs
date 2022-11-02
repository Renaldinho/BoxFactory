namespace Domain;

public class Box
{
    public int Id { get; set; }
    public string Notes { get; set; }

    //public int BoxTypeId { get; set; }
    //public BoxType BoxType { get; set; }
    
    //TODO add setter methods
    
}

public class BoxType
{
    public int Id { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }
    public int Length { get; set; }
    public string Description { get; set; }
    public string Name { get; set; }

    
}