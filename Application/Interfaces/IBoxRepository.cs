using Domain;

namespace Application.Interfaces;

public interface IBoxRepository
{
    List<BoxType> GetAllBoxTypes();
    BoxType CreateNewBoxType(BoxType map);
    BoxType UpdateBoxType(BoxType boxType);
    void CreateDatabase();
    List<Box> GetAllBoxes();
    Box CreateNewBox(Box mappedBox);
    bool DeleteBox(int boxId);
    void UpdateBox(Box box);
}