using Application.DTOs;

namespace Domain.Interfaces;

public interface IBoxService
{
    List<BoxType> GetAllBoxTypes();
    BoxType CreateNewBoxType(PostBoxTypeDTO dto);
    BoxType UpdateBoxType(int id, BoxType boxType);
    void CreateDatabase();
    List<Box> GetAllBoxes();
    Box CreateNewBox(PostBoxDTO dto);
    bool DeleteBox(int boxId);
    void UpdateBox(int id,Box box);
}