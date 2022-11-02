using Application.DTOs;
using Domain;
using Domain.Interfaces;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class BoxTypeController: ControllerBase
{
    private IBoxService _boxService;

    public BoxTypeController(IBoxService boxService)
    {
        _boxService = boxService;
    }

    [HttpGet]
    public List<BoxType> GetAllBoxTypes()
    {
        return _boxService.GetAllBoxTypes();
    }

    [HttpPost]
    public ActionResult<BoxType> CreateNewBoxType(PostBoxTypeDTO dto)
    {
        try
        {
            var result = _boxService.CreateNewBoxType(dto);
            return Created("boxtype/" + result.Id, result);
        }
        catch (ValidationException e)
        {
            return BadRequest(e.Message);
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }

    [HttpPut]
    [Route("{id}")]
    public ActionResult<BoxType> UpdateBoxType([FromRoute]int id, [FromBody]BoxType boxType)
    {
        try
        {
            return Ok(_boxService.UpdateBoxType(id, boxType));
        }
        catch (KeyNotFoundException e)
        {
            return NotFound("No box type found with ID " + id);
        }
        catch (Exception e)
        {
            return StatusCode(500, e.ToString());
        }
    }
}