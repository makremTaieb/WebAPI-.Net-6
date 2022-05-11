using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Digital.API2.Abstraction;
using WebAPI.Digital.API2.Data;
using WebAPI.Digital.API2.Domain;
using WebAPI.Digital.API2.Repositories;

namespace WebAPI.Digital.API2.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RelationsController : ControllerBase, IRelationController
    {
        
        private readonly IGenericRepository<Relations> _repo;
        public RelationsController(WebAPIDbContext db)
        {
     
            _repo = new GenericRepository<Relations>(db);
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_repo.GetAll()); 

            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        ///  return Relation By DigitalID from URL
        /// </summary>
        /// <param name="idD"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{idD}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Relations))]

        public IActionResult GetRelationByIDFromUrl(string idD)
        {
            try
            {
                 return Ok(_repo.GetByDigitalId(idD));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// return Relation By DigitalID from Params
        /// </summary>
        /// <param name="idD"></param>
        /// <returns> Relation </returns>
        [HttpGet]
        public IActionResult GetByIDFromParam(string idD)
        {
            try
            {
                return Ok(_repo.GetByDigitalId(idD));
            }
            catch (Exception ex)
            {

                throw;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="idD"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{idD}/{name}")]

        public IActionResult GetRelationFromUrlWithTwoAttributesInUrl(string idD, string name)
        {
            var item = _repo.GetAll().FirstOrDefault(x => x.DigitalId == idD && x.Name == name);
            return Ok(item);
        }

        [HttpGet]
        public IActionResult GetRelationFromUrlWithTwoParams(string idD, string name)
        {
            var item = _repo.GetAll().FirstOrDefault(x => x.DigitalId == idD && x.Name == name);
            return Ok(item);
        }


        [HttpPost]
        public IActionResult AddRelation(Relations relation)
        {
           return Ok(_repo.Create(relation));
        }

        [HttpPut]
        public IActionResult UpdateRelation(string idDigital, Relations updatedRelation)
        {

            if (updatedRelation.DigitalId != idDigital)
                throw new Exception();

            var ExistingRelation = _repo.GetByDigitalId(idDigital);
            if (ExistingRelation != null && !ExistingRelation.IsDeleted)
            {
                ExistingRelation.Name = updatedRelation.Name;
                ExistingRelation.UDate = DateTime.Now;
                ExistingRelation.UUserId = updatedRelation.UUserId;
                ExistingRelation.Segment = updatedRelation.Segment;
                _repo.Update(ExistingRelation);
            }
              return Ok();
         
        }

        [HttpDelete]
        public IActionResult DeleteRelation(string idDigital)
        {
       
            _repo.DeleteByDigitalId(idDigital);

            return Ok();
        }

    }
}
