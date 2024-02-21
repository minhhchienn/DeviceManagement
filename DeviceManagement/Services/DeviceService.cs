using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DeviceManagement.Model;

namespace DeviceManagement.Services
{
    public interface IDeviceService
    {
        Task<IEnumerable<Device>> GetDevicesAsync();
        Task<Device?> GetDeviceByIdAsync(int id);
        Task AddDeviceAsync(Device device);
        Task UpdateDeviceAsync(Device device);
        Task DeleteDeviceAsync(int id);
    }

    class DeviceService : IDeviceService
    {
        private readonly ApplicationDbContext context;

        public DeviceService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Device>> GetDevicesAsync() => await context.Devices.ToListAsync();
        public async Task<Device?> GetDeviceByIdAsync(int id) => await context.Devices.FindAsync(id);
        public async Task AddDeviceAsync(Device device)
        {
            context.Devices.Add(device);
            await context.SaveChangesAsync();
        }
        public async Task UpdateDeviceAsync(Device device)
        {
            context.Devices.Update(device);
            await context.SaveChangesAsync();
        }
        public async Task DeleteDeviceAsync(int id)
        {
            var device = await context.Devices.FindAsync(id);
            if (device != null)
            {
                context.Devices.Remove(device);
                await context.SaveChangesAsync();
            }
        }
    }
}
