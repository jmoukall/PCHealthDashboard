using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Routing.Constraints;

namespace PCHealthDashboard.Server.Models
{
    public class PcHealthStatus
    {
        public float CpuUsage { get; set; }
        public float CpuTemperature { get; set; }
        public float MemoryUsage { get; set; }
        public float DiskUsage { get; set; }
        public float DiskTemperature { get; set; }
        public float DiskSpaceAvailable { get; set; }
        public float NetworkUsage { get; set; }
        public float BatteryLevel { get; set; }
        public float GpuUsage { get; set; }
        public float GpuTemperature { get; set; }

    }
}
