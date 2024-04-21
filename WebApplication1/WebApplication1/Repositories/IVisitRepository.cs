using WebApplication1.Models;

namespace WebApplication1.Repositories;

public interface IVisitRepository
{
    IEnumerable<Visit> GetVisitsConnectedWithAnAnimal(int animalId);
    bool AddVisit(Visit visit, int animalId);
}