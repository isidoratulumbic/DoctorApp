using System;

namespace Classes.Model
{
   public class News
   {
      public int newsId { get; set; }
      public string title { get; set; }
      public string text { get; set; }
      public DateTime date { get; set; }

      public NewsBoard newsBoard;

   public News(int newsId, string title, string text, DateTime date)
   {
   this.newsId = newsId;
   this.title = title;
   this.text = text;
   this.date = date;
   }


   public News() { }


    }
}