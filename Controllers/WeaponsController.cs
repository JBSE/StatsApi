namespace StatsApi.Controllers
{
    using System.Collections.Generic;
    using StatsApi.Data;
    using Microsoft.AspNetCore.Mvc;
    using StatsApi.Models;

    [Route("api/StatsApi")]
    [ApiController]
    public class WeaponsController : ControllerBase
    {
        private readonly IRepo<WeaponStatsModel> _repo;

        public WeaponsController (IRepo<WeaponStatsModel> repository)
        {
            _repo = repository;
        }

        [HttpGet("GetAll")]
        public ActionResult<IEnumerable<WeaponStatsModel>> GetAll()
        {
            var allWeapons = _repo.GetAll();

            return Ok(allWeapons);
        }

        [HttpGet("GetWeaponById/{id}")]
        public ActionResult<WeaponStatsModel> GetWeaponById(int id)
        {
            var weaponById = _repo.GetById(id);

            return Ok(weaponById);
        }

        [HttpGet]
        [Route("GetWeaponByType/{weaponType}")]
        public ActionResult<WeaponStatsModel> GetWeaponByType(string weaponType)
        {
            var weaponByType = _repo.GetByType(weaponType);

            if (weaponByType != null)
                return Ok(weaponByType);
            else
                return BadRequest("Weapon Type not found, please check spelling and try again");
        }

        [HttpGet]
        [Route("GetWeaponByAttribute/{weaponAttribute}")]
        public ActionResult<WeaponStatsModel> GetWeaponByAttribute(string weaponAttribute)
        {
            var attribute = _repo.GetByAttribute(weaponAttribute);

            if (attribute != null)
                return Ok(attribute);
            else
                return BadRequest("Attribute not found, please check spelling and try again");
        }
    }
}
