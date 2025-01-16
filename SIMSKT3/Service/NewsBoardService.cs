using System;
using Classes.Model;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;

namespace Classes.Service
{
   public class NewsBoardService
   {
        NewsRepository newsRepository = new NewsRepository();

        public void CreateNews(News neww)
        {
             newsRepository.saveNews(neww);
        }

        public void DeleteNews(int newsId)
        {
            newsRepository.deleteNews(newsId);
        }

        public News ReadNews(int newsId)
        {
            return newsRepository.ReadNews(newsId);
        }

        public void UpdateNews(News news)
        {
            newsRepository.updateNews(news);
        }


        public List<News> ReadAllNews()
        {
            return newsRepository.getAllNews();
        }

        public void DeleteAllNews()
        {
            newsRepository.DeleteAllNews();
        }


    }
}