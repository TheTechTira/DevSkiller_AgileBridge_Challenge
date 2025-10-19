
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

namespace BankApplicationClientModule.Tests
{
    /// <summary>
    /// !!! WARNING 
    /// !!! Project structure test.
    /// !!! DON'T CHANGE IT! 
    /// !!! Changes may cause the solution to be rejected.
    /// </summary>
    public class BankApplicationClientModuleStructureTest
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// !!! WARNING 
        /// !!! Project structure test.
        /// !!! DON'T CHANGE IT! 
        /// !!! Changes may cause the solution to be rejected.
        /// </summary>
        [Test]
        public void StructureTest()
        {
            
            Assembly assembly;
            Type type;
            Type methodReturnType;
            MethodInfo method;
            int methodsCount;
            ParameterInfo parameter;
            int parametersCount;
            int constructorsCount;
            List<string> constructorParameterNameTypeDictionary;
            ConstructorInfo constructor;
            int fieldsCount;
            FieldInfo field;
            Type fieldReturnType;
            PropertyInfo property;
            int propertiesCount;
            Type propertyReturnType;
            assembly = Assembly.Load(Decode("QmFua0FwcGxpY2F0aW9uQ2xpZW50TW9kdWxlLCBWZXJzaW9uPTEuMC4wLjAsIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49bnVsbA==") /*"BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"*/ );
            Assert.IsNotNull(assembly, "Missing  BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("QmFzZUNsaWVudE1vZHVsZURhdGFBY2Nlc3M=") /*"BaseClientModuleDataAccess"*/ );
                Assert.IsNotNull(type, "Missing assembly: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.BaseClientModuleDataAccess");
                    Assert.IsTrue(type.IsClass, "assembly: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.BaseClientModuleDataAccess is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.BaseClientModuleDataAccess is not public class");
                            method = type.GetMethods().Where(m => !m.IsSpecialName && m.GetParameters().Length == 0).FirstOrDefault(x=>x.Name == Decode("R2V0QWxsQ2xpZW50cw==") /*"GetAllClients"*/ );                            Assert.IsNotNull(method, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.BaseClientModuleDataAccess.GetAllClients() does not exists");
                            Assert.IsTrue(method.IsPublic, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.BaseClientModuleDataAccess.GetAllClients() is not public");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Collections.Generic.IList`1[[BankApplicationClientModule.Model.BankClient, BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]",methodReturnType.FullName, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.BaseClientModuleDataAccess.GetAllClients() return type has changed");
                            method = type.GetMethods().Where(m => !m.IsSpecialName && m.GetParameters().Length == 0).FirstOrDefault(x=>x.Name == Decode("R2V0QWxsQWNjb3VudHM=") /*"GetAllAccounts"*/ );                            Assert.IsNotNull(method, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.BaseClientModuleDataAccess.GetAllAccounts() does not exists");
                            Assert.IsTrue(method.IsPublic, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.BaseClientModuleDataAccess.GetAllAccounts() is not public");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Collections.Generic.IList`1[[BankApplicationClientModule.Model.BankAccount, BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]",methodReturnType.FullName, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.BaseClientModuleDataAccess.GetAllAccounts() return type has changed");
                            method = type.GetMethods().Where(m => !m.IsSpecialName && m.GetParameters().Length == 0).FirstOrDefault(x=>x.Name == Decode("RGlzcG9zZQ==") /*"Dispose"*/ );                            Assert.IsNotNull(method, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.BaseClientModuleDataAccess.Dispose() does not exists");
                            Assert.IsTrue(method.IsPublic, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.BaseClientModuleDataAccess.Dispose() is not public");
                            Assert.IsTrue(method.IsVirtual, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.BaseClientModuleDataAccess.Dispose() is not virtual");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Void",methodReturnType.FullName, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.BaseClientModuleDataAccess.Dispose() return type has changed");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.BaseClientModuleDataAccess() does not exists");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("REJDb250ZXh0") /*"DBContext"*/ );
                            Assert.IsNotNull(property, "property: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.BaseClientModuleDataAccess.ClientModuleDBContext DBContext does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0RCQ29udGV4dA==") /*"get_DBContext"*/ );                                Assert.IsNotNull(method, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.BaseClientModuleDataAccess.get_DBContext() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.BaseClientModuleDataAccess.get_DBContext() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("BankApplicationClientModule.ClientModuleDBContext",methodReturnType.FullName, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.BaseClientModuleDataAccess.get_DBContext() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0RCQ29udGV4dA==") /*"get_DBContext"*/ );                                Assert.IsNotNull(method, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.BaseClientModuleDataAccess.get_DBContext() does not exists");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("BankApplicationClientModule.ClientModuleDBContext",methodReturnType.FullName, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.BaseClientModuleDataAccess.get_DBContext() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("BankApplicationClientModule.ClientModuleDBContext",propertyReturnType.FullName, "property: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.BaseClientModuleDataAccess.ClientModuleDBContext DBContext  type has changed");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("Q2xpZW50TW9kdWxlRGF0YUFjY2Vzcw==") /*"ClientModuleDataAccess"*/ );
                Assert.IsNotNull(type, "Missing assembly: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDataAccess");
                    Assert.IsTrue(type.IsClass, "assembly: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDataAccess is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDataAccess is not public class");
                            method = type.GetMethods().Where(m => !m.IsSpecialName && m.GetParameters().Length == 0).FirstOrDefault(x=>x.Name == Decode("R2V0QWxsQ2xpZW50c1RoYXRIYXZlQXRMZWFzdE9uZUFjY291bnREZXRhY2hlZA==") /*"GetAllClientsThatHaveAtLeastOneAccountDetached"*/ );                            Assert.IsNotNull(method, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDataAccess.GetAllClientsThatHaveAtLeastOneAccountDetached() does not exists");
                            Assert.IsTrue(method.IsPublic, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDataAccess.GetAllClientsThatHaveAtLeastOneAccountDetached() is not public");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Collections.Generic.IList`1[[BankApplicationClientModule.Model.BankClient, BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]",methodReturnType.FullName, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDataAccess.GetAllClientsThatHaveAtLeastOneAccountDetached() return type has changed");
                            method = type.GetMethods().Where(m => !m.IsSpecialName && m.GetParameters().Length == 1).FirstOrDefault(x=>x.Name == Decode("U2F2ZU5ld0NsaWVudA==") /*"SaveNewClient"*/ );                            Assert.IsNotNull(method, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDataAccess.SaveNewClient(BankClient client) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDataAccess.SaveNewClient(BankClient client) is not public");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Boolean",methodReturnType.FullName, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDataAccess.SaveNewClient(BankClient client) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDataAccess.SaveNewClient(BankClient client) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("Y2xpZW50") /*"client"*/  && x.ParameterType.FullName == "BankApplicationClientModule.Model.BankClient");
                                Assert.IsNotNull(parameter, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDataAccess.SaveNewClient(BankClient client) parameter client does not exists or does not have type BankApplicationClientModule.Model.BankClient");
                            method = type.GetMethods().Where(m => !m.IsSpecialName && m.GetParameters().Length == 1).FirstOrDefault(x=>x.Name == Decode("U3RhcnRUcmFja2luZw==") /*"StartTracking"*/ );                            Assert.IsNotNull(method, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDataAccess.StartTracking(BankClient client) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDataAccess.StartTracking(BankClient client) is not public");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("BankApplicationClientModule.Model.BankClient",methodReturnType.FullName, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDataAccess.StartTracking(BankClient client) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDataAccess.StartTracking(BankClient client) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("Y2xpZW50") /*"client"*/  && x.ParameterType.FullName == "BankApplicationClientModule.Model.BankClient");
                                Assert.IsNotNull(parameter, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDataAccess.StartTracking(BankClient client) parameter client does not exists or does not have type BankApplicationClientModule.Model.BankClient");
                            method = type.GetMethods().Where(m => !m.IsSpecialName && m.GetParameters().Length == 1).FirstOrDefault(x=>x.Name == Decode("SXNDbGllbnRUcmFja2VkQnlFRg==") /*"IsClientTrackedByEF"*/ );                            Assert.IsNotNull(method, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDataAccess.IsClientTrackedByEF(BankClient client) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDataAccess.IsClientTrackedByEF(BankClient client) is not public");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Boolean",methodReturnType.FullName, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDataAccess.IsClientTrackedByEF(BankClient client) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDataAccess.IsClientTrackedByEF(BankClient client) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("Y2xpZW50") /*"client"*/  && x.ParameterType.FullName == "BankApplicationClientModule.Model.BankClient");
                                Assert.IsNotNull(parameter, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDataAccess.IsClientTrackedByEF(BankClient client) parameter client does not exists or does not have type BankApplicationClientModule.Model.BankClient");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDataAccess() does not exists");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("Q2xpZW50TW9kdWxlREJDb250ZXh0") /*"ClientModuleDBContext"*/ );
                Assert.IsNotNull(type, "Missing assembly: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDBContext");
                    Assert.IsTrue(type.IsClass, "assembly: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDBContext is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDBContext is not public class");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDBContext() does not exists");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("QmFua0FjY291bnRz") /*"BankAccounts"*/ );
                            Assert.IsNotNull(property, "property: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDBContext.DbSet`1 BankAccounts does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0JhbmtBY2NvdW50cw==") /*"get_BankAccounts"*/ );                                Assert.IsNotNull(method, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDBContext.get_BankAccounts() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDBContext.get_BankAccounts() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("Microsoft.EntityFrameworkCore.DbSet`1[[BankApplicationClientModule.Model.BankAccount, BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]",methodReturnType.FullName, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDBContext.get_BankAccounts() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0JhbmtBY2NvdW50cw==") /*"get_BankAccounts"*/ );                                Assert.IsNotNull(method, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDBContext.get_BankAccounts() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDBContext.get_BankAccounts() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("Microsoft.EntityFrameworkCore.DbSet`1[[BankApplicationClientModule.Model.BankAccount, BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]",methodReturnType.FullName, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDBContext.get_BankAccounts() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("Microsoft.EntityFrameworkCore.DbSet`1[[BankApplicationClientModule.Model.BankAccount, BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]",propertyReturnType.FullName, "property: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDBContext.DbSet`1 BankAccounts  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("QmFua0NsaWVudHM=") /*"BankClients"*/ );
                            Assert.IsNotNull(property, "property: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDBContext.DbSet`1 BankClients does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0JhbmtDbGllbnRz") /*"get_BankClients"*/ );                                Assert.IsNotNull(method, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDBContext.get_BankClients() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDBContext.get_BankClients() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("Microsoft.EntityFrameworkCore.DbSet`1[[BankApplicationClientModule.Model.BankClient, BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]",methodReturnType.FullName, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDBContext.get_BankClients() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0JhbmtDbGllbnRz") /*"get_BankClients"*/ );                                Assert.IsNotNull(method, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDBContext.get_BankClients() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDBContext.get_BankClients() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("Microsoft.EntityFrameworkCore.DbSet`1[[BankApplicationClientModule.Model.BankClient, BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]",methodReturnType.FullName, "method: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDBContext.get_BankClients() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("Microsoft.EntityFrameworkCore.DbSet`1[[BankApplicationClientModule.Model.BankClient, BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]",propertyReturnType.FullName, "property: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.ClientModuleDBContext.DbSet`1 BankClients  type has changed");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("RGF0YUV4aXN0c0V4Y2VwdGlvbg==") /*"DataExistsException"*/ );
                Assert.IsNotNull(type, "Missing assembly: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.DataExistsException");
                    Assert.IsTrue(type.IsClass, "assembly: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.DataExistsException is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.DataExistsException is not public class");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.DataExistsException() does not exists");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("V3JpdGluZ1RvREJFeGNlcHRpb24=") /*"WritingToDBException"*/ );
                Assert.IsNotNull(type, "Missing assembly: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.WritingToDBException");
                    Assert.IsTrue(type.IsClass, "assembly: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.WritingToDBException is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.WritingToDBException is not public class");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: BankApplicationClientModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.WritingToDBException() does not exists");


        }

        /// <summary>
        /// !!! WARNING 
        /// !!! Project structure test.
        /// !!! DON'T CHANGE IT! 
        /// !!! Changes may cause the solution to be rejected.
        /// </summary>
        private string Decode(string text)
        {
            return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(text));
        }
    }
}
