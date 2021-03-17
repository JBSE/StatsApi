using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StatsApi.Data;
using StatsApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace StatsApi.Controllers
{
    [Route("api/StatsApi")]
    [ApiController]
    public class WeaponsController : ControllerBase
    {
        private readonly IRepo<WeaponStatsModel> _repo;

        public WeaponsController (IRepo<WeaponStatsModel> repository)
        {
            _repo = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<WeaponStatsModel>> GetAll()
        {
            var allWeapons = _repo.GetAll();

            return Ok(allWeapons);
        }

        [HttpGet("{id}")]
        public ActionResult<WeaponStatsModel> GetWeaponById(int id)
        {
            var weaponById = _repo.GetById(id);

            return Ok(weaponById);
        }

        [HttpGet]
        public ActionResult<WeaponStatsModel> GetWeaponByType(string weaponType) 
        {
            var weaponByType = _repo.GetByType(weaponType);

            return Ok(weaponByType);
        }

        [HttpGet("{weaponAttribute}")]
        public ActionResult<WeaponStatsModel> GetWeaponByAttribute(string weaponAttribute)
        {
            var weaponByType = _repo.GetByType(weaponAttribute);

            return Ok(weaponByType);
        }
    }
}
