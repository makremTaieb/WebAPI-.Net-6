using Digital.Core.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital.Core.Web
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public abstract class DigitalController<T> : ControllerBase where T : BaseEntity<int>
    {
        protected readonly Repository<T> _repo;

        public DigitalController(DigitalDbContextBase db)
        {
            _repo = new Repository<T>(db);

        }

        public abstract IActionResult Get();

        public abstract IActionResult GetById(int id);
        [HttpPost]
        public abstract IActionResult Create(T entity);

        public abstract IActionResult Update(int id, T entity);

        public abstract IActionResult Delete(T entity);

       
    }
}
