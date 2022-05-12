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
    public class RelationController : DigitalController<Relation>
    {
        public RelationController(DigitalDbContext db) : base(db)
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
        public override IActionResult Create(Relation entity)
        {
            _repo.Insert(entity);
            _repo.Save();
            return Ok();
        }
        [HttpDelete]
        public override IActionResult Delete(Relation entity)
        {
            _repo.Delete(entity);
            _repo.Save();
            return Ok();
        }

       
        [HttpPut]
        public override IActionResult Update(int id, Relation entity)
        {
            var existing = _repo.GetById(id);
            existing.Update(entity);

            _repo.Update(existing);
            _repo.Save();

            return Ok(existing);
        }
    }
}
