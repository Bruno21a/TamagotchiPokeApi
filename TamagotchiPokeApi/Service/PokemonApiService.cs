using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TamagotchiPokeApi.Model;

namespace TamagotchiPokeApi.Service
{
    public class PokemonApiService
    {
        public async Task<List<PokemonResult>> ObterEspeciesDisponiveisAsync()
        {
            try
            {

                var client = new RestClient("https://pokeapi.co/api/v2/pokemon-species/");
                var request = new RestRequest();
                var response = await client.ExecuteGetAsync(request);
                if (response.IsSuccessful)
                {
                    var pokemonEspeciesResposta = JsonConvert.DeserializeObject<PokemonSpeciesResult>(response.Content);

                    return pokemonEspeciesResposta.Results;
                }
                Console.WriteLine($"Erro ao obter detalhes do Pokémon: {response.Content}");
                return null;

            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Erro de solicitação: {e.Message}");
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro inesperado: {e.Message}");
                return null;
            }
        }

        public async Task<PokemonDetailsResult> ObterDetalhesDaEspecieAsync(PokemonResult especie)
        {
            try
            {
                var client = new RestClient($"https://pokeapi.co/api/v2/pokemon/{especie.Name}");
                var request = new RestRequest();
                var response = await client.ExecuteGetAsync(request);
                if (response.IsSuccessful)
                {
                    return JsonConvert.DeserializeObject<PokemonDetailsResult>(response.Content);
                }
                Console.WriteLine($"Erro ao obter detalhes do Pokémon: {response.Content}");
                return null;

            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Erro de solicitação: {e.Message}");
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro inesperado: {e.Message}");
                return null;
            }
        }
    }
}
