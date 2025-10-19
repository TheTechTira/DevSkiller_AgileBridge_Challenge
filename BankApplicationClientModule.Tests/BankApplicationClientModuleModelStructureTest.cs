
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
    public class BankApplicationClientModuleModelStructureTest
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
            assembly = Assembly.Load(Decode("QmFua0FwcGxpY2F0aW9uQ2xpZW50TW9kdWxlLk1vZGVsLCBWZXJzaW9uPTEuMC4wLjAsIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49bnVsbA==") /*"BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"*/ );
            Assert.IsNotNull(assembly, "Missing  BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("QmFua0FjY291bnQ=") /*"BankAccount"*/ );
                Assert.IsNotNull(type, "Missing assembly: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankAccount");
                    Assert.IsTrue(type.IsClass, "assembly: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankAccount is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankAccount is not public class");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankAccount() does not exists");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("SWQ=") /*"Id"*/ );
                            Assert.IsNotNull(property, "property: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankAccount.Int32 Id does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0lk") /*"get_Id"*/ );                                Assert.IsNotNull(method, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankAccount.get_Id() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankAccount.get_Id() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Int32",methodReturnType.FullName, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankAccount.get_Id() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0lk") /*"get_Id"*/ );                                Assert.IsNotNull(method, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankAccount.get_Id() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankAccount.get_Id() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Int32",methodReturnType.FullName, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankAccount.get_Id() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.Int32",propertyReturnType.FullName, "property: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankAccount.Int32 Id  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("QWNjb3VudE51bWJlcg==") /*"AccountNumber"*/ );
                            Assert.IsNotNull(property, "property: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankAccount.String AccountNumber does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0FjY291bnROdW1iZXI=") /*"get_AccountNumber"*/ );                                Assert.IsNotNull(method, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankAccount.get_AccountNumber() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankAccount.get_AccountNumber() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankAccount.get_AccountNumber() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0FjY291bnROdW1iZXI=") /*"get_AccountNumber"*/ );                                Assert.IsNotNull(method, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankAccount.get_AccountNumber() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankAccount.get_AccountNumber() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankAccount.get_AccountNumber() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String",propertyReturnType.FullName, "property: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankAccount.String AccountNumber  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("Q2xpZW50SWQ=") /*"ClientId"*/ );
                            Assert.IsNotNull(property, "property: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankAccount.Int32 ClientId does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0NsaWVudElk") /*"get_ClientId"*/ );                                Assert.IsNotNull(method, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankAccount.get_ClientId() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankAccount.get_ClientId() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Int32",methodReturnType.FullName, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankAccount.get_ClientId() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0NsaWVudElk") /*"get_ClientId"*/ );                                Assert.IsNotNull(method, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankAccount.get_ClientId() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankAccount.get_ClientId() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Int32",methodReturnType.FullName, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankAccount.get_ClientId() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.Int32",propertyReturnType.FullName, "property: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankAccount.Int32 ClientId  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("Q2xpZW50") /*"Client"*/ );
                            Assert.IsNotNull(property, "property: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankAccount.BankClient Client does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0NsaWVudA==") /*"get_Client"*/ );                                Assert.IsNotNull(method, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankAccount.get_Client() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankAccount.get_Client() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("BankApplicationClientModule.Model.BankClient",methodReturnType.FullName, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankAccount.get_Client() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0NsaWVudA==") /*"get_Client"*/ );                                Assert.IsNotNull(method, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankAccount.get_Client() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankAccount.get_Client() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("BankApplicationClientModule.Model.BankClient",methodReturnType.FullName, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankAccount.get_Client() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("BankApplicationClientModule.Model.BankClient",propertyReturnType.FullName, "property: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankAccount.BankClient Client  type has changed");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("QmFua0NsaWVudA==") /*"BankClient"*/ );
                Assert.IsNotNull(type, "Missing assembly: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient");
                    Assert.IsTrue(type.IsClass, "assembly: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient is not public class");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient() does not exists");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("SWQ=") /*"Id"*/ );
                            Assert.IsNotNull(property, "property: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.Int32 Id does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0lk") /*"get_Id"*/ );                                Assert.IsNotNull(method, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.get_Id() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.get_Id() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Int32",methodReturnType.FullName, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.get_Id() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0lk") /*"get_Id"*/ );                                Assert.IsNotNull(method, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.get_Id() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.get_Id() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Int32",methodReturnType.FullName, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.get_Id() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.Int32",propertyReturnType.FullName, "property: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.Int32 Id  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("Rmlyc3ROYW1l") /*"FirstName"*/ );
                            Assert.IsNotNull(property, "property: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.String FirstName does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0ZpcnN0TmFtZQ==") /*"get_FirstName"*/ );                                Assert.IsNotNull(method, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.get_FirstName() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.get_FirstName() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.get_FirstName() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0ZpcnN0TmFtZQ==") /*"get_FirstName"*/ );                                Assert.IsNotNull(method, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.get_FirstName() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.get_FirstName() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.get_FirstName() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String",propertyReturnType.FullName, "property: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.String FirstName  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("TGFzdE5hbWU=") /*"LastName"*/ );
                            Assert.IsNotNull(property, "property: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.String LastName does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0xhc3ROYW1l") /*"get_LastName"*/ );                                Assert.IsNotNull(method, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.get_LastName() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.get_LastName() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.get_LastName() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0xhc3ROYW1l") /*"get_LastName"*/ );                                Assert.IsNotNull(method, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.get_LastName() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.get_LastName() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.get_LastName() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String",propertyReturnType.FullName, "property: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.String LastName  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("QWRkcmVzcw==") /*"Address"*/ );
                            Assert.IsNotNull(property, "property: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.String Address does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0FkZHJlc3M=") /*"get_Address"*/ );                                Assert.IsNotNull(method, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.get_Address() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.get_Address() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.get_Address() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0FkZHJlc3M=") /*"get_Address"*/ );                                Assert.IsNotNull(method, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.get_Address() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.get_Address() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.get_Address() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String",propertyReturnType.FullName, "property: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.String Address  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("Q2xpZW50QWNjb3VudHM=") /*"ClientAccounts"*/ );
                            Assert.IsNotNull(property, "property: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.ICollection`1 ClientAccounts does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0NsaWVudEFjY291bnRz") /*"get_ClientAccounts"*/ );                                Assert.IsNotNull(method, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.get_ClientAccounts() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.get_ClientAccounts() is not public");
                                Assert.IsTrue(method.IsVirtual, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.get_ClientAccounts() is not virtual");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Collections.Generic.ICollection`1[[BankApplicationClientModule.Model.BankAccount, BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]",methodReturnType.FullName, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.get_ClientAccounts() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0NsaWVudEFjY291bnRz") /*"get_ClientAccounts"*/ );                                Assert.IsNotNull(method, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.get_ClientAccounts() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.get_ClientAccounts() is not public");
                                Assert.IsTrue(method.IsVirtual, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.get_ClientAccounts() is not virtual");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Collections.Generic.ICollection`1[[BankApplicationClientModule.Model.BankAccount, BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]",methodReturnType.FullName, "method: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.get_ClientAccounts() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.Collections.Generic.ICollection`1[[BankApplicationClientModule.Model.BankAccount, BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]",propertyReturnType.FullName, "property: BankApplicationClientModule.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BankApplicationClientModule.Model.BankClient.ICollection`1 ClientAccounts  type has changed");


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
