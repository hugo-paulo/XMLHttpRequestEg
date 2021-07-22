using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using XMLHttpRequestEg.Models;

namespace XMLHttpRequestEg.Reader
{
    public static class TReader
    {
        /// <summary>
        /// We will pass the path variable from the FilePath class when calling the method from the Repository
        /// Note! we should place this class in the SD folder
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>

        //List<CharacterDetail> or String ? but don know what to return yet

        //? Try reading line by line instead of to end?
        public static string ReadText(string path)
        {
            string rawText = "";

            try
            {
                //Need to add Server.MapPath() method to use relative path
                using (StreamReader sr = new StreamReader(path))
                {
                    rawText = sr.ReadToEnd();
                }
                
                return rawText;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return "err";
            }
        }
    }


}
