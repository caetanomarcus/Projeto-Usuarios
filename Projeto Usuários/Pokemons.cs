namespace Projeto_Usuários
{
    public class Pokemons
    {
        public int Count { get; set; }
        public object Next { get; set; }
        public object Previous { get; set; }
        public IList<Result> Results { get; set; }

        public IEnumerable<Result> GetPokemonByName(string name) => Results.Where(x => x.Name == name);

        public IEnumerable<Result> GetPokemonByNameLike(string name) => Results.Where(x => x.Name.Contains(name));

    }

    public class Result
    {
        public string Name { get; set; }
        public string Url { get; set; }

 
    }

}
