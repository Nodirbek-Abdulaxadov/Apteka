using Apteka.Data.Models;
using Apteka.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Apteka.Api.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class DrugController : ControllerBase
    {
        private readonly IDrugInterface _drugInterface;

        public DrugController(IDrugInterface drugInterface)
        {
                _drugInterface = drugInterface;
        }

        [HttpGet, Route("getall")]
        public async Task<IActionResult> GetAll()
        {
            List<Drug> listOfDrugs = await _drugInterface.GetAll();
            return Ok(listOfDrugs);
        }

        [HttpGet, Route("get/{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            Drug drug = await _drugInterface.GetById(id);
            return Ok(drug);
        }
    }
}
