using ABC.API.Abstract;
using ABC.API.Model;
using Microsoft.AspNetCore.Mvc;

namespace ABC.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BuildingController : ControllerBase
    {
   

        private readonly IBuildingRepo _buildingRepo;

        public BuildingController(IBuildingRepo buildingRepo)
        {
            _buildingRepo = buildingRepo;
        }

        [HttpPost]
        public List<Building> GetSearch(BuildingSearchVM buildingSearchVM)
        {
            return _buildingRepo.GetSearch(buildingSearchVM);
        }
    }
}