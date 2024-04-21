namespace WebApplication1.Controller;

using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Service;

[ApiController]
[Route("api/Animal")]
public class AnimalController : ControllerBase
{
    private IAnimalService _animalService;

    public AnimalController(IAnimalService animalService)
    {
        _animalService = animalService;
    }

    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = _animalService.GetAnimals();
        return Ok(animals);
    }

    [HttpGet("{id:int}")]
    public IActionResult GetAnimal(int id)
    {
        var animal = _animalService.GetAnimal(id);
        if (animal == null)
        {
            return NotFound("Animal not found");
        }

        return Ok(animal);
    }

    [HttpPost]
    public IActionResult AddAnimal(Animal animal)
    {
        var add = _animalService.AddAnimal(animal);
        if (!add)
        {
            return BadRequest($"Id:{animal.IdAnimal} is already taken ");
        }

        return StatusCode(StatusCodes.Status201Created);
    }

    [HttpPut("{id:int}")]
    public IActionResult EditAnimal(int id, Animal animal)
    {
        if (animal == null || id != animal.IdAnimal)
        {
            return BadRequest("Invalid Id");
        }

        var update = _animalService.EditAnimal(animal);
        if (!update)
        {
            return NotFound($"Animal wih id:{id} not found");
        }

        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        var animal = _animalService.GetAnimal(id);
        if (animal != null)
        {
            _animalService.DeleteAnimal(animal);
            return NoContent();
        }
        else
        {
            return NotFound($"Animal with id:{id} not found");
        }
    }
}