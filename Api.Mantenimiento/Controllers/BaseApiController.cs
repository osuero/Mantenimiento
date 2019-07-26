using Api.Mantenimiento.Models;
using AutoMapper;
using Mantenimiento.Common.Repository;
using Mantenimiento.Models.AudithVariables;
using Mantenimiento.Models.EntityModels;
using Mantenimiento.Services.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Api.Mantenimiento.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseApiController<T, TD> : ControllerBase 
        where T: GenericModel 
        where TD: class
    {
        private readonly GenericRepository<T> _repository;

        private readonly IMapper _mapper;

        // Assign the object in the constructor for dependency injection
        public BaseApiController(IMapper mapper, GenericRepository<T> repository)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET: api/Resident
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var result = _repository.GetAll();
            return new string[] { "value1", "value2" };
        }

        // GET: api/Resident/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            var objectEntity = _repository.Find(x => x.Id == id);

            return objectEntity.ToString();
        }

        // POST: api/Resident
        [HttpPost]
        public void Post([FromBody] TD headLine)
        {
            var resource = _mapper.Map<T>(headLine);

            _repository.Add(resource);
            _repository.Save();
        }

        // PUT: api/Resident/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            var objectEntity =_repository.Find(x => x.Id == id);

            var resource = _mapper.Map<T>(objectEntity);
            _repository.Edit(resource);
            _repository.Save();

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var objectEntity = _repository.Find(x => x.Id == id);
            var resource = _mapper.Map<T>(objectEntity);

            _repository.Delete(resource);
        }
    }
}
