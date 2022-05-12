using Digital.BackOffice.Data;
using Digital.BackOffice.Model;
using Digital.Core;
using Digital.Core.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Digital.BackOffice.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TierController : DigitalController<Tier>
    {
        public TierController(DigitalDbContext db) : base(db)
        {
        }

        [HttpGet]
        public override IActionResult Get()
        {
            return Ok(_repo.GetAll());
        }

        [HttpGet]
        public override IActionResult GetById(int id)
        {
            return Ok(_repo.GetById(id));
        }

        [HttpPost]
        public override IActionResult Create(Tier entity)
        {
            _repo.Insert(entity);
            _repo.Save();
            return Ok();
        }
        [HttpDelete]
        public override IActionResult Delete(Tier entity)
        {
            _repo.Delete(entity);
            _repo.Save();
            return Ok();
        }

       
        [HttpPut]
        public override IActionResult Update(int id, Tier entity)
        {
            var existing = _repo.GetById(id);
            existing.Update(entity);

            _repo.Update(existing);
            _repo.Save();

            return Ok(existing);
        }
    }
}
