using CameraBazaar.Services.Contracts;
using CameraBazaar.Web.Models.Cameras;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CameraBazaar.Web.Controllers
{
    [Route("cameras")]
    public class CamerasController : Controller
    {
        private readonly ICameraService cameraService;

        public CamerasController(ICameraService cameraService)
        {
            this.cameraService = cameraService;
        }

        [Route("all")]
        public IActionResult All()
        {
            var cameras = this.cameraService.GetAllCameras();

            return View(cameras);
        }

        [Route("details/{id}")]
        public IActionResult Details(int id)
        {
            var camera = this.cameraService.GetCameraDetails(id);

            return View(camera);
        }

        [Authorize]
        [Route("add")]
        public IActionResult Add()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        [Route("add")]
        public IActionResult Add(AddCameraModel cameraModel)
        {
            if (!ModelState.IsValid)
            {
                return View(cameraModel);
            }

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            this.cameraService.Add(cameraModel.Model, cameraModel.Make, cameraModel.Price, cameraModel.Quantity, cameraModel.MinShutterSpeed, cameraModel.MaxShutterSpeed, cameraModel.MinIso, cameraModel.MaxIso, cameraModel.IsFullFrame, cameraModel.VideoResolution, cameraModel.LightMeterings, cameraModel.Description, cameraModel.ImageUrl, userId);

            return Redirect("/");
        }
    }
}
