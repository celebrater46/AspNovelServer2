using System;

namespace AspNovelServer2.Models
{
    /*
    Columns (index_table)
    id (Title, Auto Increment)
    title
    chapter_num
    subtitle
    link
    last_update (For Title)
    */
    public class Novel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public int ChapterNum { get; set; }
        public string Subtitle { get; set; }
        public string Href { get; set; }
        public string LastUpdate { get; set; }
    }
}