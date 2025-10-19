using BankApplicationClientModule.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankApplicationClientModule
{
    public class ClientModuleDataAccess : BaseClientModuleDataAccess
    {

        public ClientModuleDataAccess() : base()
        {
        }

        /// <summary>
        /// TODO:
        /// Returns ONLY clients that have at least one account, with their accounts populated,
        /// and returns them as NOT TRACKED by EF.
        /// </summary>
        /// <returns></returns>
        public IList<BankClient> GetAllClientsThatHaveAtLeastOneAccountDetached()
        {
            return DBContext.BankClients
                // Disable tracking to improve performance and return detached entities
                .AsNoTracking()
                // Include related accounts in the query result
                .Include(x => x.ClientAccounts)
                // Only return clients who have at least one account
                .Where(x => x.ClientAccounts.Any())
                // Execute the query and convert to list
                .ToList();
        }

        /// <summary>
        /// TODO:
        /// Persists a NEW client (Id <= 0) with its accounts.
        /// Throws DataExistsException if client is not new.
        /// Returns true on success, otherwise throws WritingToDBException.
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public bool SaveNewClient(BankClient client)
        {
            // Validate input
            if (client == null) throw new ArgumentNullException(nameof(client));

            // If client already has an Id, it exists in DB — not allowed for new clients
            if (client.Id > 0)
                throw new DataExistsException();

            // Ensure the accounts collection exists to avoid null references
            client.ClientAccounts ??= new List<BankAccount>();

            try
            {
                // Add client (and any linked accounts) to the DbContext for insertion
                DBContext.BankClients.Add(client);

                // Save all pending changes to the database
                var written = DBContext.SaveChanges();

                // If no rows were affected, throw exception (save failed)
                if (written <= 0)
                    throw new WritingToDBException();

                // Return true if operation succeeded
                return true;
            }
            catch (DbUpdateException ex)
            {
                // Wrap EF database errors into a custom exception
                throw new WritingToDBException();
            }
        }

        /// <summary>
        /// TODO:
        /// Ensures the passed client instance is tracked by EF. 
        /// If another instance with the same Id is tracked, it is detached.
        /// If this instance is not tracked, it is attached and marked:
        ///   - Modified if Id > 0
        ///   - Added   if Id <= 0
        /// Always returns a tracked BankClient (this instance).
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public BankClient StartTracking(BankClient client)
        {
            // Validate input
            if (client == null) throw new ArgumentNullException(nameof(client));

            // Step 1: If client already has an Id, check if another instance with same Id is tracked
            if (client.Id > 0)
            {
                // Find an existing tracked instance of BankClient with the same Id
                var other = DBContext.ChangeTracker
                    .Entries<BankClient>()
                    .FirstOrDefault(e => e.Entity.Id == client.Id && !ReferenceEquals(e.Entity, client));

                // If found, detach it to avoid EF "multiple tracked entities with same key" errors
                if (other != null && other.State != EntityState.Detached)
                {
                    other.State = EntityState.Detached;
                }
            }

            // Step 2: Get tracking entry for the passed instance
            var entry = DBContext.Entry(client);

            // Step 3: If not tracked, attach and mark state appropriately
            if (entry.State == EntityState.Detached)
            {
                // Attach current instance to start tracking
                DBContext.Attach(client);

                // Refresh the entry reference to ensure correct context state
                entry = DBContext.Entry(client);

                // Mark as Modified (existing client) or Added (new client)
                entry.State = client.Id > 0 ? EntityState.Modified : EntityState.Added;
            }

            // Step 4: Always return the tracked client instance
            return entry.Entity;
        }

        /// <summary>
        /// TODO:
        /// Returns true if THIS exact instance is tracked by EF (state != Detached).
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public bool IsClientTrackedByEF(BankClient client)
        {
            // Return false if null
            if (client == null) return false;

            // Entry.State == Detached means EF is NOT tracking this instance
            return DBContext.Entry(client).State != EntityState.Detached;
        }
    }
}
