using Application.DTOs;
using Domain;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class BoxController
{
    private IBoxService _boxService;

    public BoxController(IBoxService boxService)
    {
        _boxService = boxService;
    }

    [HttpGet]
    public List<Box> GetAllBoxes()
    {
        return _boxService.GetAllBoxes();
    }

    [HttpPost]
    public Box CreateNewBox(PostBoxDTO dto)
    {
        return _boxService.CreateNewBox(dto);
    }

    [HttpDelete]
    [Route("{boxId}")]
    public bool DeleteBox([FromRoute]int boxId)
    {
        return _boxService.DeleteBox(boxId);
    }

    [HttpPatch]
    [Route("{id}")]
    public void UpdateBox([FromRoute]int id, [FromBody]Box box)
    {
        _boxService.UpdateBox(id,box);
    }



}