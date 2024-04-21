namespace WebApplication1.Controller;

using WebApplication1.Models;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Service;


[ApiController]
[Route("api/Visit")]
public class VisitController : ControllerBase
{
    private IVisitService _visitService;

    public VisitController(IVisitService visitService)
    {
        _visitService = visitService;
    }

    [HttpPost]
    public IActionResult AddVisit(Visit visit, int animalId)
    {
        bool t = _visitService.AddVisit(visit, animalId);
        if (!t)
        {
            return NotFound($"Animal with id:{animalId} not found");
        }
        return StatusCode(StatusCodes.Status201Created);
    }


    [HttpGet("{id:int}")]
    public IActionResult GetVisitsConnectedWithAnAnimal(int id)
    {
        var visits = _visitService.GetVisitsConnectedWithAnAnimal(id);
        if (!visits.Any())
        {
            return NotFound("None of animals matches visits");
        }

        return Ok(visits);
    }
}