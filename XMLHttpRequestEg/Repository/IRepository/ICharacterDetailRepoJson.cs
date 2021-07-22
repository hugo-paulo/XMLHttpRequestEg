using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XMLHttpRequestEg.Models;

namespace XMLHttpRequestEg.Repository.IRepository
{
    public interface ICharacterDetailRepoJson
    {
        //In the implementation call a bool function that checks if the character exists
        public string GetCharacterDetailByName(string name);
        //public List<CharacterDetail> CharacterDetails();
        public List<CharacterType> CharacterDetails();

        public bool CheckCharacter(string name);
    }
}
