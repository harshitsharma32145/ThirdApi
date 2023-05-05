using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using thirdapi.repository3;

namespace thirdapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly Empoyee_Interface interface1;
        public ValuesController(Empoyee_Interface obj)
        {
            interface1 = obj;
        }


        [HttpGet]
        [Route("Getdata")]
        public IActionResult GetyourData()
        {
            var data = interface1.Get_Data();
            return Ok(data);
        }

        //-----------------------------------------GET------------------------
        [HttpGet]
        [Route("GETBYID")]
        public IActionResult Getbyid(int id)
        {
            var data = interface1.Getbyid(id);
            return Ok(data);
        }

        //----------------------------------------------POST--------------------
        [HttpPost]
        [Route("Postdata")]
        public IActionResult postdata(Harshit17 h)
        {
            interface1.PostData(h);
            return Ok(h);
        }
        //--------------------------UPDATE---------------------------------------

        [HttpPut]
        [Route("updatedat")]

        public IActionResult Updatedata(Harshit17 harshit)
        {
           var v= interface1.Updatevalue( harshit);
            return Ok(v);
        }

        //----------------------------------DELETE-------------------------------
        [HttpDelete]
        [Route("Deletedata")]
        public IActionResult deletedata(int id)
        {
           var data= interface1.Deletevalue( id);
            return Ok(data);
        }



    }
}
