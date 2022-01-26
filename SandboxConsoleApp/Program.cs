using System;
using System.Collections;

namespace nanoFramework.Json
{
    class Program
    {
        static void Main(string[] args)
        {

            //        string correctValue = "{\"desired\":{\"Url\":\"https://ellerbachiotstorage.blob.core.windows.net/nano-containers\"," +
            //            "\"Authorization\":\"sp=r&st=2021-06-12T09:11:53Z&se=2021-06-14T17:11:53Z&spr=https&sv=2020-02-10&sr=c&sig=rn125LiO55RSCoEs4IEaCgg%2BuXKETdEZQPygxVjCHiY%3D\"," +
            //            "\"Files\":[\"Iot.Device.Bmxx80.pe\"]}}";

            //        Hashtable hash = (Hashtable)JsonConvert.DeserializeObject(correctValue, typeof(Hashtable));
            //        Hashtable desired = (Hashtable)hash["desired"];

            //        var auth = desired["Authorization"];

            //        if ("sp=r&st=2021-06-12T09:11:53Z&se=2021-06-14T17:11:53Z&spr=https&sv=2020-02-10&sr=c&sig=rn125LiO55RSCoEs4IEaCgg%2BuXKETdEZQPygxVjCHiY%3D" != (string)desired["Authorization"])
            //        {
            //            //"Authorization string doesn't match original value.");
            //        }

            //        ArrayList files = (ArrayList)desired["Files"];

            //        var file0 = files[0];
            //        if("Iot.Device.Bmxx80.pe" != (string)files[0])
            //        {

            //        }




            //        string correctValue1 = "{\"Url\":\"https://ellerbachiotstorage.blob.core.windows.net/nano-containers\"," +
            //"\"Authorization\":\"sp=r&st=2021-06-12T09:11:53Z&se=2021-06-14T17:11:53Z&spr=https&sv=2020-02-10&sr=c&sig=rn125LiO55RSCoEs4IEaCgg%2BuXKETdEZQPygxVjCHiY%3D\"," +
            //"\"Files\":[\"Iot.Device.Bmxx80.pe\"]}";

            //        Hashtable hash1 = (Hashtable)JsonConvert.DeserializeObject(correctValue1, typeof(Hashtable));

            //        var auth1 = hash1["Authorization"];

            //        if ("sp=r&st=2021-06-12T09:11:53Z&se=2021-06-14T17:11:53Z&spr=https&sv=2020-02-10&sr=c&sig=rn125LiO55RSCoEs4IEaCgg%2BuXKETdEZQPygxVjCHiY%3D" != (string)hash1["Authorization"])
            //        {
            //            //"Authorization string doesn't match original value.");
            //        }

            //        ArrayList files1 = (ArrayList)hash1["Files"];

            //        var file0_1 = files1[0];
            //        if( "Iot.Device.Bmxx80.pe" != (string)files1[0])
            //        {

            //        }

            //DateTime testTime = new DateTime(2015, 04, 22, 11, 56, 39, 456);


            //ICollection collection = new ArrayList() { testTime };

            //string jsonString = JsonConvert.SerializeObject(collection);

            //ArrayList convertTime = (ArrayList)JsonConvert.DeserializeObject(jsonString, typeof(ArrayList));

            //if (testTime.Ticks != ((DateTime)convertTime[0]).Ticks)
            //{
            //    //"Values did not match";
            //}

            //       JsonTestTown myTown = new JsonTestTown
            //       {
            //           TownID = 1,
            //           TownName = "myTown",
            //           CompaniesInThisTown = new JsonTestCompany[]
            //{
            //               new JsonTestCompany { CompanyID = 1, CompanyName = "AAA Amalgamated Industries" },
            //               new JsonTestCompany { CompanyID = 2, CompanyName = "BBB Amalgamated Industries" },
            //               new JsonTestCompany { CompanyID = 3, CompanyName = "CCC Amalgamated Industries" },
            //               new JsonTestCompany { CompanyID = 4, CompanyName = "DDD Amalgamated Industries" },
            //               new JsonTestCompany { CompanyID = 5, CompanyName = "EEE Amalgamated Industries" },
            //               new JsonTestCompany { CompanyID = 6, CompanyName = "FFF Amalgamated Industries" },
            //               new JsonTestCompany { CompanyID = 7, CompanyName = "GGG Amalgamated Industries" },
            //               new JsonTestCompany { CompanyID = 8, CompanyName = "HHH Amalgamated Industries" }
            //},
            //           EmployeesInThisTown = new JsonTestEmployee[]
            //{
            //               new JsonTestEmployee
            //               {
            //                   EmployeeID = 1,
            //                   EmployeeName = "John Smith",
            //                   CurrentEmployer = new JsonTestCompany { CompanyID = 3, CompanyName = "CCC Amalgamated Industries" },
            //                   FormerEmployers = new JsonTestCompany[]
            //                   {
            //                       new JsonTestCompany { CompanyID = 2, CompanyName = "BBB Amalgamated Industries" },
            //                       new JsonTestCompany { CompanyID = 5, CompanyName = "EEE Amalgamated Industries" },
            //                   }
            //               },
            //               new JsonTestEmployee
            //               {
            //                   EmployeeID = 1,
            //                   EmployeeName = "Jim Smith",
            //                   CurrentEmployer = new JsonTestCompany { CompanyID = 7, CompanyName = "GGG Amalgamated Industries" },
            //                   FormerEmployers = new JsonTestCompany[]
            //                   {
            //                       new JsonTestCompany { CompanyID = 4, CompanyName = "DDD Amalgamated Industries" },
            //                       new JsonTestCompany { CompanyID = 1, CompanyName = "AAA Amalgamated Industries" },
            //                       new JsonTestCompany { CompanyID = 6, CompanyName = "FFF Amalgamated Industries" },
            //                   }
            //               }
            //}
            //       };

            //       var result = JsonConvert.SerializeObject(myTown);
            //       //Debug.WriteLine($"Serialized Array: {result}");

            //       JsonTestTown dserResult = (JsonTestTown)JsonConvert.DeserializeObject(result, typeof(JsonTestTown));
            //       //Debug.WriteLine($"After deserialization - type: JsonTestTown");

            //       //Assert.Equal(myTown.TownID, dserResult.TownID, $"Validation: myTown.TownID: {myTown.TownID}");
            //       //Assert.Equal(myTown.TownName, dserResult.TownName, $"Validation: myTown.TownName: {myTown.TownName}");
            //       for (int i = 0; i < myTown.CompaniesInThisTown.Length; i++)
            //       {
            //           //Assert.Equal(myTown.CompaniesInThisTown[i].CompanyID, dserResult.CompaniesInThisTown[i].CompanyID, $"Validation: myTown.CompaniesInThisTown[{i}].CompanyID: {myTown.CompaniesInThisTown[i].CompanyID}");
            //           //Assert.Equal(myTown.CompaniesInThisTown[i].CompanyName, dserResult.CompaniesInThisTown[i].CompanyName, $"Validation: myTown.CompaniesInThisTown[{i}].CompanyName: {myTown.CompaniesInThisTown[i].CompanyName}");
            //       }
            //       for (int i = 0; i < myTown.EmployeesInThisTown.Length; i++)
            //       {
            //           //Assert.Equal(myTown.EmployeesInThisTown[i].EmployeeID, dserResult.EmployeesInThisTown[i].EmployeeID, $"Validation: myTown.EmployeesInThisTown[{i}].EmployeeID: {myTown.EmployeesInThisTown[i].EmployeeID} ");
            //           //Assert.Equal(myTown.EmployeesInThisTown[i].EmployeeName, dserResult.EmployeesInThisTown[i].EmployeeName, $"Validation: myTown.EmployeesInThisTown[{i}].EmployeeName: {myTown.EmployeesInThisTown[i].EmployeeName} ");
            //           //Assert.Equal(myTown.EmployeesInThisTown[i].CurrentEmployer.CompanyID, dserResult.EmployeesInThisTown[i].CurrentEmployer.CompanyID, $"Validation: myTown.EmployeesInThisTown[{i}].CurrentEmployer.CompanyID: {myTown.EmployeesInThisTown[i].CurrentEmployer.CompanyID} ");
            //           //Assert.Equal(myTown.EmployeesInThisTown[i].CurrentEmployer.CompanyName, dserResult.EmployeesInThisTown[i].CurrentEmployer.CompanyName, $"Validation: myTown.EmployeesInThisTown[{i}].CurrentEmployer.CompanyName: {myTown.EmployeesInThisTown[i].CurrentEmployer.CompanyName} ");
            //           for (int j = 0; j < myTown.EmployeesInThisTown[i].FormerEmployers.Length; j++)
            //           {
            //               //Assert.Equal(myTown.EmployeesInThisTown[i].FormerEmployers[j].CompanyID, dserResult.EmployeesInThisTown[i].FormerEmployers[j].CompanyID, $"Validation: myTown.EmployeesInThisTown[{i}].FormerEmployers[{j}].CompanyID: {myTown.EmployeesInThisTown[i].FormerEmployers[j].CompanyID} ");
            //               //Assert.Equal(myTown.EmployeesInThisTown[i].FormerEmployers[j].CompanyName, dserResult.EmployeesInThisTown[i].FormerEmployers[j].CompanyName, $"Validation: myTown.EmployeesInThisTown[{i}].FormerEmployers[{j}].CompanyName: {myTown.EmployeesInThisTown[i].FormerEmployers[j].CompanyName} ");
            //           }
            //       }



            //var timestampTests = new JsonTestClassTimestamp()
            //{
            //    Timestamp = DateTime.UtcNow,
            //    FixedTimestamp = new DateTime(2020, 05, 01, 09, 30, 00)
            //};


            //var result = JsonConvert.SerializeObject(timestampTests);

            //var dserResult = (JsonTestClassTimestamp)JsonConvert.DeserializeObject(result, typeof(JsonTestClassTimestamp));



            //var invocMessage = new InvocationSendMessage
            //{
            //    type = 1,
            //    invocationId = "0",
            //    arguments = new ArrayList() { 1, 2 },
            //    target = "Add"
            //};

            //Console.WriteLine(JsonConvert.SerializeObject(invocMessage));


            const string jsonComplex = @"{""type"":1,""target"":""ReceiveAdvancedMessage"",""arguments"":[{""age"":22,""name"":""Monica"",""gender"":1,""car"":{""age"":5,""model"":""Tesla""}},{""age"":88,""name"":""Grandpa"",""gender"":0,""car"":{""age"":35,""model"":""Buick""}},3]}";
            InvocationReceiveMessage invoc = (InvocationReceiveMessage)JsonConvert.DeserializeObject(jsonComplex, typeof(InvocationReceiveMessage));

            //const string jsonArgs = @"{""arguments"":[{""age"":22,""name"":""Monica"",""car"":{""age"":35,""model"":""Buick""}},3]}";
            //Hashtable args1 = (Hashtable)JsonConvert.DeserializeObject(jsonArgs, typeof(Hashtable));

            Person arg1 = (Person)JsonConvert.DeserializeObject(JsonConvert.SerializeObject(invoc.arguments[0]), typeof(Person));
            Person arg2  = (Person)JsonConvert.DeserializeObject(JsonConvert.SerializeObject(invoc.arguments[1]), typeof(Person));
            int argsCount = (int)JsonConvert.DeserializeObject(JsonConvert.SerializeObject(invoc.arguments[2]), typeof(int));



            ////Hashtable desired = (Hashtable)invoc.arguments;
            ArrayList desired1 = (ArrayList)invoc.arguments;
        }
    }

    internal class InvocationReceiveMessage
    {
        public int type { get; set; }
        public Hashtable headers { get; set; }
        public string invocationId { get; set; }
        public string target { get; set; }
        public ArrayList arguments { get; set; }
        public string[] streamIds { get; set; }
        public string error { get; set; }
        public bool allowReconnect { get; set; }
        public object result { get; set; }
    }

    public class Person
    {
        public int age { get; set; }
        public string name { get; set; }
        public Gender gender { get; set; }
        public Car car { get; set; }

    }

    public class Car
    {
        public int age { get; set; }
        public string model { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }

    // Classes to more thoroughly test array serialization/deserialization - added 2021-08-28
    public class JsonTestCompany
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
    }
    public class JsonTestEmployee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public JsonTestCompany CurrentEmployer { get; set; }
        public JsonTestCompany[] FormerEmployers { get; set; }
    }
    public class JsonTestTown
    {
        public int TownID { get; set; }
        public string TownName { get; set; }
        public JsonTestCompany[] CompaniesInThisTown { get; set; }
        public JsonTestEmployee[] EmployeesInThisTown { get; set; }
    }
    public class JsonTestClassTimestamp
    {
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public DateTime FixedTimestamp { get; set; }
    }
    public class InvocationSendMessage
    {
        public string invocationId { get; set; }
        public int type { get; set; }
        public string target { get; set; }
        public ArrayList arguments { get; set; }
    }

}
