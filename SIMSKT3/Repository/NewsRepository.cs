using System;
using Classes.Model;
using Classes.Service;
using Classes.Controller;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Classes.Repository
{
    public class NewsRepository
    {
        public List<News> news = new List<News>();

        public NewsRepository()
        {
            if (!File.Exists("news.json"))
            {
                File.Create("news.json").Close();
            }

            using (StreamReader r = new StreamReader("news.json"))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    news = JsonConvert.DeserializeObject<List<News>>(json);
                }
            }
        }
        public void writeInJson()
        {
            string json = JsonConvert.SerializeObject(news, Formatting.Indented);
            File.WriteAllText("news.json", json);
        }



        public void saveNews(News neww)
        {
            news.Add(neww);
            writeInJson();
        }
        public void deleteNews(int newsId)
        {
            foreach (var nee in news.ToArray())
            {
                if (nee.newsId == newsId)
                {
                    news.Remove(nee);
                    writeInJson();
                }
            }
        }
        public News ReadNews(int newsId)
        {
            return news.Find(obj => obj.newsId == newsId);
        }
        public void updateNews(News neww)
        {
            int index = news.FindIndex(obj => obj.newsId == neww.newsId);
            news[index] = neww;
            writeInJson();
        }

        public List<News> getAllNews()
        {
            return news;
        }

        public void DeleteAllNews()
        {
            foreach (var all in news.ToArray())
            {
                news.Remove(all);
            }
            writeInJson();
        }


    }
}
