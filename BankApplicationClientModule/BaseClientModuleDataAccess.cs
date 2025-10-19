using BankApplicationClientModule.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplicationClientModule
{
    /// <summary>
    /// You cannot change this class, methods and properties in it!
    /// </summary>
    public class BaseClientModuleDataAccess : IDisposable
    {
        public ClientModuleDBContext DBContext { get; private set; }

        public BaseClientModuleDataAccess()
        {
            DBContext = new ClientModuleDBContext();
        }

        /// <summary>
        /// Gets all clients.
        /// </summary>
        /// <returns></returns>
        public IList<BankClient> GetAllClients()
        {
            return DBContext.BankClients.ToList();
        }

        /// <summary>
        /// Gets all accounts.
        /// </summary>
        /// <returns></returns>
        public IList<BankAccount> GetAllAccounts()
        {
            return DBContext.BankAccounts.ToList();
        }

        /// <summary>
        /// Disposes resources.
        /// </summary>
        public void Dispose()
        {
            DBContext.Dispose();
            DBContext = null;
        }
    }
}
