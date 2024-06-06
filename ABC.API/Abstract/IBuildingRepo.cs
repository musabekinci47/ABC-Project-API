using ABC.API.Model;

namespace ABC.API.Abstract
{
    public interface IBuildingRepo
    {
        List<Building> GetSearch(BuildingSearchVM buildingSearchVM);
    }
}
