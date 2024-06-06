using ABC.API.Abstract;
using ABC.API.Model;
using Microsoft.AspNetCore.DataProtection.Repositories;

namespace ABC.API.Concrete
{
    public class BuildingRepo : IBuildingRepo
    {
        private List<Building> _buildingList;
        public BuildingRepo()
        {
            _buildingList = Data.buildings;
        }
        public List<Building> GetSearch(BuildingSearchVM buildingSearchVM)
        {
            IEnumerable<Building> result = _buildingList;
            if (buildingSearchVM.Location != null) result= result.Where(x => x.Location == buildingSearchVM.Location);
            if (buildingSearchVM.MinPrice != null) result= result.Where(x => x.Price >= buildingSearchVM.MinPrice);
            if (buildingSearchVM.MaxPrice != null) result=result.Where(x => x.Price <= buildingSearchVM.MaxPrice);
            if (buildingSearchVM.PropertyType != null) result=result.Where(x => x.PropertyType == buildingSearchVM.PropertyType);
            return result.ToList();
        }
    }
}
