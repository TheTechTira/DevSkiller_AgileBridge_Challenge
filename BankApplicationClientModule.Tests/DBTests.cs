using BankApplicationClientModule.Model;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace BankApplicationClientModule.Tests
{
    public class DBTests
    {
        [SetUp]
        public void Initialization()
        {
            // Create the schema in the database
            using (var context = new ClientModuleDBContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                // test data
                context.Database.ExecuteSqlRaw($"insert into BankClient(FirstName, LastName) values('Paul', 'Junior')");
                context.Database.ExecuteSqlRaw($"insert into BankClient(FirstName, LastName) values('Anna', 'Morning')");
                context.Database.ExecuteSqlRaw($"insert into BankClient(FirstName, LastName) values('Tom', 'Second')");

                context.Database.ExecuteSqlRaw($"insert into BankAccount(AccountNumber, ClientId) select '1000000000000000000', Id from BankClient where FirstName = 'Paul'");
                context.Database.ExecuteSqlRaw($"insert into BankAccount(AccountNumber, ClientId) select '1000000000000000001', Id from BankClient where FirstName = 'Paul'");
                context.Database.ExecuteSqlRaw($"insert into BankAccount(AccountNumber, ClientId) select '1000000000000000002', Id from BankClient where FirstName = 'Paul'");
                context.Database.ExecuteSqlRaw($"insert into BankAccount(AccountNumber, ClientId) select '1000000000000000003', Id from BankClient where FirstName = 'Anna'");
                context.Database.ExecuteSqlRaw($"insert into BankAccount(AccountNumber, ClientId) select '1000000000000000004', Id from BankClient where FirstName = 'Anna'");
            }
        }

        private ClientModuleDataAccess CreateClientModuleDataAccess()
        {
            return new ClientModuleDataAccess();
        }

        [Test]
        public void CreateDB_Test()
        {
            using (var dao = CreateClientModuleDataAccess())
            {
                var list = dao.GetAllClients();
                Assert.IsNotNull(list);
            }
        }

        [Test]
        public void ClientModuleDBdao_NewClient_Test()
        {
            int cnt = 0;
            using (var dao = CreateClientModuleDataAccess())
            {
                cnt = dao.GetAllClients().Count();
                Assert.IsTrue(dao.SaveNewClient(new Model.BankClient() { Address = "Address", FirstName = "John", LastName = "Tester" }));
                Assert.AreEqual(cnt + 1, dao.GetAllClients().Count());
            }

            using (var dao = CreateClientModuleDataAccess())
            {
                Assert.AreEqual(cnt + 1, dao.GetAllClients().Count());
            }
        }

        [Test]
        public void ClientModuleDBdao_StartTracking_Test()
        {
            Model.BankClient client;
            using (var dao = CreateClientModuleDataAccess())
            {
                Assert.AreEqual(3, dao.GetAllClients().Count());
                client = dao.GetAllClients().FirstOrDefault(); // tracked client
                client.FirstName = "ABC";

                var detached = new Model.BankClient() { Id = client.Id };
                detached = dao.StartTracking(detached);

                Assert.AreNotEqual(client, detached);
                detached.FirstName = "XYZ";

                dao.DBContext.SaveChanges();
            }

            using (var dao = CreateClientModuleDataAccess())
            {
                var detached = dao.GetAllClients().Where(w => w.Id == client.Id).FirstOrDefault();
                Assert.AreEqual("XYZ", detached.FirstName); // XYZ overwrite data from DB
            }
        }


        [Test]
        public void ClientModuleDBdao_StartTrackingNew_Test()
        {
            Model.BankClient client;
            using (var dao = CreateClientModuleDataAccess())
            {
                Assert.AreEqual(3, dao.GetAllClients().Count());
                client = new BankClient()
                {
                    FirstName = "DEF"
                };

                client = dao.StartTracking(client);

                dao.DBContext.SaveChanges();
            }

            using (var dao = CreateClientModuleDataAccess())
            {
                var detached = dao.GetAllClients().Where(w => w.Id == client.Id).FirstOrDefault();
                Assert.AreEqual("DEF", detached.FirstName);
            }
        }


        [Test]
        public void ClientModuleDBdao_GetAllClientsThatHaveAtLeastOneAccount_Test()
        {
            using (var dao = CreateClientModuleDataAccess())
            {
                Assert.AreEqual(3, dao.GetAllClients().Count);
                Assert.AreEqual(5, dao.GetAllAccounts().Count);

                var clients = dao.GetAllClientsThatHaveAtLeastOneAccountDetached();
                Assert.AreEqual(2, clients.Count);
                Assert.AreEqual(3, clients.Where(w => w.FirstName == "Paul").Select(s => s.ClientAccounts.Count).FirstOrDefault());
                Assert.AreEqual(2, clients.Where(w => w.FirstName == "Anna").Select(s => s.ClientAccounts.Count).FirstOrDefault());
            }
        }

        [Test]
        public void ClientModuleDBdao_IsClientTrackedByEF_Test()
        {
            BankClient client = null;
            using (var dao = CreateClientModuleDataAccess())
            {
                client = dao.GetAllClients().FirstOrDefault();
                Assert.IsTrue(dao.IsClientTrackedByEF(client));
            }

            using (var dao = CreateClientModuleDataAccess())
            {
                Assert.IsFalse(dao.IsClientTrackedByEF(client));
            }
        }
    }
}
