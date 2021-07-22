using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XMLHttpRequestEg.Models;
using XMLHttpRequestEg.Repository.IRepository;

namespace XMLHttpRequestEg.Repository
{
    public class CharacterDetailRepoJson : ICharacterDetailRepoJson
    {
        //public List<CharacterDetail> CharacterDetails()
        public List<CharacterType> CharacterDetails()
        {
            var cd = Reader.JReader.ReadJson(SD.FilePath.JsonFilePath);

            List<CharacterType> characterList = new List<CharacterType>();
            characterList.Add(cd);

            return characterList;
        }

        public bool CheckCharacter(string name)
        {
            throw new NotImplementedException();
        }

        public string GetCharacterDetailByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
