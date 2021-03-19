﻿namespace StatsApi.Controllers
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
