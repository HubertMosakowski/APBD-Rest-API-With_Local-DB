using WebApplication1.Models;

namespace WebApplication1.Service;

using WebApplication1.Service;

public interface IVisitService
{
    IEnumerable<Visit> GetVisitsConnectedWithAnAnimal(int animalId);
    bool AddVisit(Visit visit,int animalId);
}