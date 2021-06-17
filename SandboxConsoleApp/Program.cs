using System;
using System.Collections;

namespace nanoFramework.Json
{
    class Program
    {
        static void Main(string[] args)
        {

            string correctValue = "{\"desired\":{\"Url\":\"https://ellerbachiotstorage.blob.core.windows.net/nano-containers\"," +
                "\"Authorization\":\"sp=r&st=2021-06-12T09:11:53Z&se=2021-06-14T17:11:53Z&spr=https&sv=2020-02-10&sr=c&sig=rn125LiO55RSCoEs4IEaCgg%2BuXKETdEZQPygxVjCHiY%3D\"," +
                "\"Files\":[\"Iot.Device.Bmxx80.pe\"]}}";

            Hashtable hash = (Hashtable)JsonConvert.DeserializeObject(correctValue, typeof(Hashtable));
            Hashtable desired = (Hashtable)hash["desired"];

            var auth = desired["Authorization"];

            if ("sp=r&st=2021-06-12T09:11:53Z&se=2021-06-14T17:11:53Z&spr=https&sv=2020-02-10&sr=c&sig=rn125LiO55RSCoEs4IEaCgg%2BuXKETdEZQPygxVjCHiY%3D" != (string)desired["Authorization"])
            {
                //"Authorization string doesn't match original value.");
            }

            ArrayList files = (ArrayList)desired["Files"];

            var file0 = files[0];
            if("Iot.Device.Bmxx80.pe" != (string)files[0])
            {

            }




            string correctValue1 = "{\"Url\":\"https://ellerbachiotstorage.blob.core.windows.net/nano-containers\"," +
    "\"Authorization\":\"sp=r&st=2021-06-12T09:11:53Z&se=2021-06-14T17:11:53Z&spr=https&sv=2020-02-10&sr=c&sig=rn125LiO55RSCoEs4IEaCgg%2BuXKETdEZQPygxVjCHiY%3D\"," +
    "\"Files\":[\"Iot.Device.Bmxx80.pe\"]}";

            Hashtable hash1 = (Hashtable)JsonConvert.DeserializeObject(correctValue1, typeof(Hashtable));

            var auth1 = hash1["Authorization"];

            if ("sp=r&st=2021-06-12T09:11:53Z&se=2021-06-14T17:11:53Z&spr=https&sv=2020-02-10&sr=c&sig=rn125LiO55RSCoEs4IEaCgg%2BuXKETdEZQPygxVjCHiY%3D" != (string)hash1["Authorization"])
            {
                //"Authorization string doesn't match original value.");
            }

            ArrayList files1 = (ArrayList)hash1["Files"];

            var file0_1 = files1[0];
            if( "Iot.Device.Bmxx80.pe" != (string)files1[0])
            {

            }


        }
    }
}
