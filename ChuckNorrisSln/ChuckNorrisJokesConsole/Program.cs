using ChuckNorrisJokesLibrary;
using System;
using System.Threading.Tasks;

namespace ChuckNorrisJokesConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            JokeGenerator jokeGenerator = new JokeGenerator();
            string randomJoke = await jokeGenerator.GetRandomJoke();
            Console.WriteLine(randomJoke);

            string[] categories = await jokeGenerator.GetCatergories();

            for (int index = 0; index < categories.Length; index++)
                Console.WriteLine(categories[index]);
        }

    }
}
