using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("superadmin")]
    public class AdminController : Controller
    {
        [Route("")]
        [Route("save")]
        [Route("~/save")]
        public string Save()
        {
            return "Save";
        }
        [Route("update")]
        public string Update()
        {
            return "Update";
        }
        [Route("delete/{id?}")]
        public string Delete(int id=0)
        {
            return $"Delete {id}";
        }
    }
}
