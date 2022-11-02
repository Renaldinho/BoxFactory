using Application.DTOs;
using Application.Interfaces;
using Domain;

namespace Infrastructure;

public class BoxRepository: IBoxRepository
{

    private BoxDbContext _context;

    public BoxRepository(BoxDbContext context)
    {
        _context = context;
    }

    #region box type functions

    public List<BoxType> GetAllBoxTypes()
    {
        return _context.BoxTypes.ToList();
    }

    public BoxType CreateNewBoxType(BoxType boxType)
    {
        var createdBox = _context.BoxTypes.Add(boxType).Entity;
        _context.SaveChanges();
        return createdBox;

    }

    public BoxType UpdateBoxType(BoxType boxType)
    {
        throw new NotImplementedException();
    }

    

    public BoxType DeleteBoxType(BoxType boxType)
    {
        throw new NotImplementedException();
    }
    #endregion
    
    public void CreateDatabase()
    {
        _context.Database.EnsureDeleted();
        _context.Database.EnsureCreated();
    }


    #region box functions

    public List<Box> GetAllBoxes()
    {
        return _context.Boxes.ToList();
    }

    public Box CreateNewBox(Box mappedBox)
    {
        var createdBox = _context.Boxes.Add(mappedBox).Entity;
        _context.SaveChanges();
        return createdBox;
    }
    
    public bool DeleteBox(int boxId)
    {
        var existingBox = _context.Boxes.Find(boxId);
        if (existingBox == null)
            return false;
        _context.Boxes.Remove(existingBox);
        _context.SaveChanges();
        return true;
    }

    public void UpdateBox(Box box)
    {
        var existingBox = _context.Boxes.Where(b => b.Id == box.Id);
        if (existingBox == null)
            throw new KeyNotFoundException();
        _context.Update(box);
        _context.SaveChanges();
    }

    public List<Box> GetAllBoxesOfType(BoxType boxType)
    {
        return new List<Box>();
    }

    #endregion


}