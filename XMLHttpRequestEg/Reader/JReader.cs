using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using XMLHttpRequestEg.Models;

namespace XMLHttpRequestEg.Reader
{
    /// <summary>
    /// Information on how to serialize and deserialize JSON in .NET
    /// https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-how-to?pivots=dotnet-core-3-1#how-to-read-json-into-net-objects-deserialize
    /// https://www.youtube.com/watch?v=CjoAYslTKX0
    /// </summary>

    static public class JReader
    {
        static public CharacterType ReadJson(string path)
        {
            string jsonAsString = File.ReadAllText(path);            
            
            CharacterType ct = JsonSerializer.Deserialize<CharacterType>(jsonAsString);
            
            //When an iterator is needed, ie many entries in our json, can only be used with dictionary<string,string>
            //List<CharacterType> ctList = new List<CharacterType>();
            //ctList = JsonSerializer.Deserialize<List<CharacterType>>(jsonAsString);

            return ct;
        }
    }
}
