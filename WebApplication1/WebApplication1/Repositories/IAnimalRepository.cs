namespace WebApplication1.Repositories;

using WebApplication1.Models;

public interface IAnimalRepository
{
    IEnumerable<Animal> GetAnimals();
    Animal GetAnimal(int id);
    bool AddAnimal(Animal animal);
    bool EditAnimal(Animal animal);
    bool DeleteAnimal(Animal animal);
}