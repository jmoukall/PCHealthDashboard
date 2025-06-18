using Microsoft.AspNetCore.Mvc;
using PCHealthDashboard.Server.Models;
using PCHealthDashboard.Server.Data;

namespace PCHealthDashboard.Server.Controllers
{

    [ApiController]
    [Route("api")]
    public class PcHealthController : ControllerBase
    {


        [HttpGet]
        public ActionResult<PcHealthStatus> GetStatus()
        {
            var status = new PcHealthStatus
            {
                CpuUsage = PcHealthData.GetCpuUsage(),
                CpuTemperature = PcHealthData.GetCpuTemp(),
                GpuUsage = PcHealthData.GetGpuUsage(),
                GpuTemperature = PcHealthData.GetGpuTemp(),
                BatteryLevel = PcHealthData.GetBatteryLevel(),
                NetworkUsage = PcHealthData.GetNetworkUsage(),
                MemoryUsage = PcHealthData.GetMemoryUsage(),
                DiskSpaceAvailable = PcHealthData.GetDiskSpaceAvailable(),
                DiskUsage = PcHealthData.GetDiskUsage(),
                DiskTemperature = PcHealthData.GetDiskTemp()
            };

            return Ok(status);
        }

    }
}
