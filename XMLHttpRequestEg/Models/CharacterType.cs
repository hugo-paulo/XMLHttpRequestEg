using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XMLHttpRequestEg.Models
{
    public class CharacterType
    {
        //These properties must match the Json File
        public List<CharacterDetail> Witchers { get; set; }
        public List<CharacterDetail> Sorceress { get; set; }
    }
}
