using WebApplication1.Models;
using WebApplication1.Repositories;
using WebApplication1.Service;

namespace Zadanie5.Service;

public class AnimalService : IAnimalService
{
    private readonly IAnimalRepository _animalRepository;

    public AnimalService(IAnimalRepository animalRepository)
    {
        _animalRepository = animalRepository;
    }

    public IEnumerable<Animal> GetAnimals()
    {
        return _animalRepository.GetAnimals();
    }

    public Animal? GetAnimal(int id)
    {
        return _animalRepository.GetAnimal(id);
    }

    public bool AddAnimal(Animal animal)
    {
        return _animalRepository.AddAnimal(animal);
    }

    public bool EditAnimal(Animal animal)
    {
        return _animalRepository.EditAnimal(animal);
    }

    public bool DeleteAnimal(Animal animal)
    {
        return _animalRepository.DeleteAnimal(animal);
    }
}