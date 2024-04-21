using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Service;

public class VisitService : IVisitService
{
    private readonly IVisitRepository _visitRepository;

    public VisitService(IVisitRepository visitRepository)
    {
        _visitRepository = visitRepository;
    }

    public IEnumerable<Visit> GetVisitsConnectedWithAnAnimal(int animalId)
    {
        return _visitRepository.GetVisitsConnectedWithAnAnimal(animalId);
    }

    public bool AddVisit(Visit visit, int animalId)
    {
        return _visitRepository.AddVisit(visit, animalId);
    }
}