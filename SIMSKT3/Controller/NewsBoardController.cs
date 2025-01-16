using System;
using Classes.Model;
using Classes.Repository;
using Classes.Service;
using Classes.Controller;
using System.Collections.Generic;


namespace Classes.Controller
{
    public class NewsBoardController
    {
        NewsBoardService newsService = new NewsBoardService();

        public void CreateNews(News neww)
        {
            newsService.CreateNews(neww);
        }
        
        public void DeleteNews(int newsId)
        {
            newsService.DeleteNews(newsId);
        }

        public News ReadNews(int newsId)
        {
            return newsService.ReadNews(newsId);
        }

        public void UpdateNews(News news)
        {
            newsService.UpdateNews(news);
        }


        public List<News> ReadAllNews()
        {
            return newsService.ReadAllNews();
        }

        public void DeleteAllNews()
        {
            newsService.DeleteAllNews();
        }


    }
}
 
