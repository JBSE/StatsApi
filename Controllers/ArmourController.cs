namespace StatsApi.Controllers
{
    using System.Collections.Generic;
    using StatsApi.Data;
    using Microsoft.AspNetCore.Mvc;
    using StatsApi.Models;

    [Route("api/StatsApi")]
    [ApiController]
    public class ArmourController : ControllerBase
    {
        private readonly IRepo<ArmourStatsModel> _repo;

        public ArmourController(IRepo<ArmourStatsModel> repository)
        {
            _repo = repository;
        }

        [HttpGet("GetAllArmour")]
        public ActionResult<IEnumerable<ArmourStatsModel>> GetAll()
        {
            var allArmour = _repo.GetAll();

            return Ok(allArmour);
        }

        [HttpGet("GetArmourById/{id}")]
        public ActionResult<ArmourStatsModel> GetArmourById(int id)
        {
            var armourById = _repo.GetById(id);

            return Ok(armourById);
        }

        [HttpGet]
        [Route("GetArmourByType/{armourType}")]
        public ActionResult<ArmourStatsModel> GetArmourByType(string armourType)
        {
            var armourByType = _repo.GetByType(armourType);

            if (armourByType != null)
                return Ok(armourByType);
            else
                return BadRequest("Armour Type not found, please check spelling and try again");
        }

        [HttpGet]
        [Route("GetArmourByAttribute/{armourAttribute}")]
        public ActionResult<ArmourStatsModel> GetWeaponByAttribute(string armourAttribute)
        {
            var attribute = _repo.GetByAttribute(armourAttribute);

            if (attribute != null)
                return Ok(attribute);
            else
                return BadRequest("Attribute not found, please check spelling and try again");
        }
    }
}
