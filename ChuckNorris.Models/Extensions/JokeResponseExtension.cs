namespace ChuckNorris.Models.Extensions
{
    public static class JokeResponseExtension
    {
        public static string ToJoke(this JokesResponse jokesResponse)
        {
            return jokesResponse.value.Replace("Chuck", "CH.");
        }
    }
}
