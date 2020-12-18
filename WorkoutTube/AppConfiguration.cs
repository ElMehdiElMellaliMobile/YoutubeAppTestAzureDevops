namespace WorkoutTube
{
    public class AppConfiguration : IAppConfiguration
    {
        public string GoogleApiBaseUrl => "https://www.googleapis.com";
        public string YoutubeApiKey => "AIzaSyBMY67OriE7Qgx1XzLOGX5LtkhF9Z42xMc"; //Add your own API key
        public string  VideosQuery => "FULL BODY WORKOUT";
    }
}
