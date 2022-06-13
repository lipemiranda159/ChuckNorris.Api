namespace ChuckNorris.Api
{
    public static class JokeHelper
    {
        public static dynamic GetJoke(dynamic joke)
        {
            joke.value.Replace("Chuck", "CH.");

            return joke.value;
        }

    }
}
