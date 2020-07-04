using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using UCS.VariableSet.Configuration.Models;
using UCS.VariableSet.Service.MongoService;

namespace UCS.VariableSet.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class MongoController : ControllerBase
    {
        private IMongoService _mongoService;
        public MongoController(IMongoService mongoService)
        {
            _mongoService = mongoService;
        }

        [HttpGet]
        public ActionResult<List<VariableSetModel>> GetListByCollection()
        {
            return _mongoService.GetListByCollection<VariableSetModel>("UcsMain");
        }

        [HttpPost]
        public void Insert()
        {
            var body1 = new Body()
            {
                Id= 1,
                Name="bodyName1",
                Variable="bodyVariable1",
                Type= "bodyType1"
            };

            var body2 = new Body()
            {
                Id = 2,
                Name = "bodyName2",
                Variable = "bodyVariable2",
                Type = "bodyType2"
            };

            var listBody = new List<Body>();
            listBody.Add(body1);
            listBody.Add(body2);

            var variableSetModel = new VariableSetModel()
            {
                Id = "id",
                Name = "name",
                Message = "message",
                Body = listBody
            };

            _mongoService.Insert<VariableSetModel>("UcsMain", variableSetModel);

        }
    }
}
