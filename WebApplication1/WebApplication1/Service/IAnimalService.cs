using WebApplication1.Models;

namespace WebApplication1.Service;

public interface IAnimalService
{
    IEnumerable<Animal> GetAnimals();
    Animal? GetAnimal(int id);
    bool AddAnimal(Animal animal);
    bool EditAnimal(Animal animal);
    bool DeleteAnimal(Animal animal);

}