using WebApplication1.Models;

namespace WebApplication1.Repositories;

public class AnimalRepository : IAnimalRepository
{
    private static List<Animal> _listOfAnimals = new List<Animal>
    {
        new Animal { IdAnimal = 1, Name = "A", Category = "dog", Weight = 3, Color = "white" },
        new Animal { IdAnimal = 2, Name = "B", Category = "cat", Weight = 5, Color = "brown" },
        new Animal { IdAnimal = 3, Name = "C", Category = "rabbit", Weight = 2, Color = "black" }
    };

    public IEnumerable<Animal> GetAnimals()
    {
        return _listOfAnimals;
    }

    public Animal GetAnimal(int id)
    {
        Animal res = null;
        _listOfAnimals.ForEach(animal =>
        {
            if (animal.IdAnimal == id)
            {
                res = animal;
            }
        });
        return res;
    }

    public bool AddAnimal(Animal animal)
    {
        var test = GetAnimal(animal.IdAnimal);
        if (test != null)
        {
            return false;
        }

        _listOfAnimals.Add(animal);
        return true;
    }

    public bool EditAnimal(Animal animal)
    {
        var edit = GetAnimal(animal.IdAnimal);
        if (edit == null)
        {
            return false;
        }

        edit.IdAnimal = animal.IdAnimal;
        edit.Name = animal.Name;
        edit.Category = animal.Category;
        edit.Weight = animal.Weight;
        edit.Color = animal.Color;
        return true;
    }

    public bool DeleteAnimal(Animal animal)
    {
        var toRemove = GetAnimal(animal.IdAnimal);
        if (toRemove == null)
        {
            return false;
        }

        _listOfAnimals.Remove(animal);
        return false;
    }
    
}