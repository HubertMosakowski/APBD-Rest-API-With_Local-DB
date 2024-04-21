using WebApplication1.Models;

namespace WebApplication1.Repositories;

public class VisitRepository : IVisitRepository
{
    private static List<Visit> _listOfVisits = new List<Visit>
    {
        new Visit
        {
            Animal = new Animal { IdAnimal = 1, Name = "A", Category = "dog", Weight = 3, Color = "white" },
            Date = DateTime.Today,
            Description = "bla bla bla",
            Price = 100
        },
        new Visit
        {
            Animal = new Animal { IdAnimal = 1, Name = "A", Category = "dog", Weight = 3, Color = "white" },
            Date = DateTime.Today,
            Description = "bla bla bla",
            Price = 100
        }
    };

    public IEnumerable<Visit> GetVisitsConnectedWithAnAnimal(int animalId)
    {
        List<Visit> res = new List<Visit>();
        foreach (Visit v in _listOfVisits)
        {
            if (v.Animal.IdAnimal == animalId)
            {
                res.Add(v);
            }
        }

        return res;
    }

    public bool AddVisit(Visit visit, int animalId)
    {
        AnimalRepository ar = new AnimalRepository();
        Animal a = ar.GetAnimal(animalId);
        if (a == null || visit.Animal.IdAnimal != animalId)
        {
            return false;
        }

        _listOfVisits.Add(visit);
        return true;
    }
}