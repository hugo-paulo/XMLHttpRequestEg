using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XMLHttpRequestEg.Repository.IRepository;

using XMLHttpRequestEg.Reader; //to delete

namespace XMLHttpRequestEg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterDetailsController : ControllerBase
    {
        private readonly ICharacterDetailRepoText _characterDetailRepoText;
        private readonly ICharacterDetailRepoJson _characterDetailRepoJson;

        //The ctor doesn't have to have both variable, just lazt to write another controller for json
        public CharacterDetailsController(ICharacterDetailRepoText characterDetailRepo,
            ICharacterDetailRepoJson characterDetailRepoJson)
        {
            this._characterDetailRepoText = characterDetailRepo;
            this._characterDetailRepoJson = characterDetailRepoJson;
        }

        public IActionResult Index()
        {
            
            var charaterDetails = _characterDetailRepoJson.CharacterDetails();

            return Ok(charaterDetails);
        }
    }
}
