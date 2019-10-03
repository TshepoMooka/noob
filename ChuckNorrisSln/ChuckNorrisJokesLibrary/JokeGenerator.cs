using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ChuckNorrisJokesLibrary
{
    public class JokeGenerator
    {

        public async Task<string> GetRandomJoke()
        {
            var client = new HttpClient();
            string jokeString = await client.GetStringAsync("https://api.chucknorris.io/jokes/random");

            var joke = JsonConvert.DeserializeObject<Joke>(jokeString);

            return joke.value; ;
        }

        public async Task<string[]> GetCatergories ()
        {
            var client = new HttpClient();
            string categoryString = await client.GetStringAsync("https://api.chucknorris.io/jokes/categories");

            var categories = JsonConvert.DeserializeObject<String[]>(categoryString);

            return categories;
        }
    }
}
