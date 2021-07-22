using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XMLHttpRequestEg.Models;
using XMLHttpRequestEg.Reader;
using XMLHttpRequestEg.Repository.IRepository;

namespace XMLHttpRequestEg.Repository
{
    public class CharacterDetailRepoText : ICharacterDetailRepoText
    {
        /// <summary>
        /// Since we reading from a text file, save the whole file to a string
        /// Then need a method that will iterrate through the string length
        /// While iterating through the string we add the words to a defined list of Type Charater
        /// We do this by looking for white spaces or new lines
        /// </summary>
        /// <returns></returns>

        //public List<CharacterDetail> CharacterDetails()
        public List<string> GetAllCharacterDetails()
        {
            List<String> CharacterList = new List<string>(); //This should return List of type CharacterDetails

            string rawText = TReader.ReadText(SD.FilePath.TextFilePath); //? This must be assinged to a string and check for "err", it must be called by process text
            if (rawText != "err")
            {
                var list = FormatCharacterText(rawText);
            }

            //Now need to get this method to return something

            return CharacterList;
            //throw new NotImplementedException();
        }

        public bool CheckCharacter(string name) //? need to change this to private and the interface ?
        {
            throw new NotImplementedException(); //line 26 check place here
        }

        public string GetCharacterDetailByName(string name)
        {
            throw new NotImplementedException();
        }

        //?This will key value pair, thus must recieve a List<String> ?
        private Dictionary<int, string> FormatCharacterText(string rawText)
        {
            //Note! can not use this because we cannot have duplicate keys
            Dictionary<int, string> DetailsList = new Dictionary<int, string>();

            int key = 1;

            //foreach (var item in rawText)
            //{
            //    DetailsList.Add(key, item.);

            //    if (item.Equals('\n'))
            //    {
            //        key++;
            //    }
            //}
            
            foreach (var word in WordList(rawText))
            {
                DetailsList.Add(key, word.ToString());
                if (string.IsNullOrEmpty(word))
                {
                    key++;
                    continue;
                }
            }

            return DetailsList;
        }

        //?Note if we get a long string we need to split it into smaller strings ?
        private string[] WordList(string rawText)
        {
            List<string> wl = new List<string>();
            string[] words = rawText.Split('\n');
            return words;
        }

    }
}
