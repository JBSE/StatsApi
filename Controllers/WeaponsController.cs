using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DestinyAPI.Data;
using DestinyAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace DestinyApi.Controllers
{
    [Route("api/DestinyApi")]
    [ApiController]
    public class WeaponsController : ControllerBase
    {
        private readonly IWeaponRepo _repo;

        public WeaponsController (IWeaponRepo repository)
        {
            _repo = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<BaseWeaponStatsModel>> GetAllWeapons()
        {
            var allWeapons = _repo.GetAllWeapons();

            return Ok(allWeapons);
        } 

        [HttpGet("{id}")]
        public ActionResult<BaseWeaponStatsModel> GetWeaponById(int id)
        {
            var weaponById = _repo.GetWeaponById(id);

            return Ok(weaponById);
        }

        [HttpGet]
        public ActionResult<BaseWeaponStatsModel> GetWeaponByType(string weaponType) 
        {
            var weaponByType = _repo.GetWeaponsByWeaponType(weaponType);

            return Ok(weaponByType);
        }

        [HttpGet("{weaponAttribute}")]
        public ActionResult<BaseWeaponStatsModel> GetWeaponByAttribute(string weaponAttribute)
        {
            var weaponByType = _repo.GetWeaponsByWeaponType(weaponAttribute);

            return Ok(weaponByType);
        }
    }
}
