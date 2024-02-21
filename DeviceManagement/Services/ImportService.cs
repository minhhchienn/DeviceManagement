using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeviceManagement.Model;

namespace DeviceManagement.Services
{
    public interface IImportService
    {
        Task<IEnumerable<Import>> GetImportsAsync();
        Task<Import?> GetImportByIdAsync(int id);
        Task AddImportAsync(Import import);
        Task UpdateImportAsync(Import import);
        Task DeleteImportAsync(int id);
    }

    public class ImportService : IImportService
    {
        private ApplicationDbContext context;
        public ImportService(ApplicationDbContext context) => this.context = context;
        public async Task<IEnumerable<Import>> GetImportsAsync() => await context.Imports.ToListAsync();
        public async Task<Import?> GetImportByIdAsync(int id) => await context.Imports.FindAsync(id);
        public async Task AddImportAsync(Import import)
        {
            context.Imports.Add(import);
            await context.SaveChangesAsync();
        }
        public async Task UpdateImportAsync(Import import)
        {
            context.Imports.Update(import);
            await context.SaveChangesAsync();
        }
        public async Task DeleteImportAsync(int id)
        {
            var import = context.Imports.Find(id);
            if (import != null)
            {
                context.Imports.Remove(import);
                await context.SaveChangesAsync();
            }
        }
    }
}
