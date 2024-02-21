using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using DeviceManagement.Model;

namespace DeviceManagement.Services
{
    public interface IAccountService
    {
        Task<IEnumerable<Account>> GetAccountsAsync(Account account);
        Task<Account?> GetAccountByUsernameAndPassword(string username, string password);
        Task AddAccountAsync(Account account);
        Task UpdateAccountAsync(Account account);
        Task DeleteAccountAsync(int id);
    }

    public class AccountService : IAccountService
    {
        private readonly ApplicationDbContext context;

        public AccountService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Account>> GetAccountsAsync(Account account)
        {
            if (account.tendangnhap == null || account.matkhau == null) return new List<Account>();
            var acc = await GetAccountByUsernameAndPassword(account.tendangnhap, account.matkhau);
            if (acc?.quyen != "admin") return new List<Account>();
            return await context.Accounts.ToListAsync();
        }

        public async Task<Account?> GetAccountByUsernameAndPassword(string username, string password) 
            => await context.Accounts.FirstOrDefaultAsync(acc => acc.tendangnhap == username && acc.matkhau == password);

        public async Task AddAccountAsync(Account account)
        {
            context.Accounts.Add(account);
            await context.SaveChangesAsync();
        }
        public async Task UpdateAccountAsync(Account account)
        {
            context.Accounts.Update(account);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAccountAsync(int id)
        {
            var account = await context.Accounts.FindAsync(id);
            {
                if (account != null)
                {
                    context.Accounts.Remove(account);
                    await context.SaveChangesAsync();
                }
            }
        }
    }
}
