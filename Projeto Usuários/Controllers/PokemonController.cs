using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Projeto_Usuários.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        public Pokemons Pokemons { get; set; }
        public RequestSender pokeApi = new RequestSender("https://pokeapi.co/api/v2/");

        [HttpGet]
        public Pokemons Get()
        {
            GetPokemons();
            return Pokemons;
        }


        [HttpGet("{name}")]
        public  IEnumerable<Result> Get(string name) => GetSugestionList(name);


        public void GetPokemons()
        {
            try
            {
                Task<string> data = pokeApi.Get("pokemon?limit=100000&offset=0");

                Pokemons = JsonConvert.DeserializeObject<Pokemons>(data.Result);
            }
            catch (Exception ex)
            {
                Pokemons ErrorMsg = new Pokemons();
                ErrorMsg.Results = new List<Result>()
                {

                    new Result()
                    {
                        Name = ex.Message,
                    }
                };

                Console.WriteLine(ex.Message);
                Pokemons = ErrorMsg;
            }
        }


        public IEnumerable<Result>? GetSugestionList (string name)
        {
          
            GetPokemons();
            return Pokemons.GetPokemonByNameLike(name);
        }
    }
}
