using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using MenuPlanner.Core.Models;
using Newtonsoft.Json.Linq;

namespace MENU
{
    public class YouTubeService
    {
        private readonly string _apiKey;

        public YouTubeService(string apiKey)
        {
            _apiKey = apiKey;
        }

        public string ExtractVideoId(string url)
        {
            if (url.Contains("v="))
                return url.Split(new[] { "v=" }, StringSplitOptions.None)[1].Split('&')[0];


            if (url.Contains("youtu.be/"))
                return url.Split(new[] { "youtu.be/" }, StringSplitOptions.None)[1].Split('?')[0];

            return null;
        }

        public async Task<YouTubeVideoInfo> LoadVideoInfo(string url)
        {
            string videoId = ExtractVideoId(url);
            if (videoId == null)
                return null;

            string apiUrl =
                $"https://www.googleapis.com/youtube/v3/videos?id={videoId}&key={_apiKey}&part=snippet";

            using (HttpClient client = new HttpClient())
            {
                string json = await client.GetStringAsync(apiUrl);
                var data = JObject.Parse(json);

                var snippet = data["items"]?[0]?["snippet"];
                if (snippet == null)
                    return null;

                string title = snippet["title"]?.ToString();
                string description = snippet["description"]?.ToString();

                string thumbnailPath = await DownloadThumbnail(videoId);

                return new YouTubeVideoInfo
                {
                    Title = title,
                    Description = description,
                    ThumbnailPath = thumbnailPath
                };
            }
        }

        private async Task<string> DownloadThumbnail(string videoId)
        {
            string[] urls =
            {
                $"https://img.youtube.com/vi/{videoId}/maxresdefault.jpg",
                $"https://img.youtube.com/vi/{videoId}/hqdefault.jpg"
            };

            using (HttpClient client = new HttpClient())
            {
                foreach (var url in urls)
                {
                    try
                    {
                        var bytes = await client.GetByteArrayAsync(url);

                        string folder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
                        Directory.CreateDirectory(folder);

                        string filePath = Path.Combine(folder, $"youtube_{videoId}.jpg");

                        File.WriteAllBytes(filePath, bytes);

                        return filePath;
                    }
                    catch
                    {
                    }
                }
            }

            return null;
        }
    }
}
