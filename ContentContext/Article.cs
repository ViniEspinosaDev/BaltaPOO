namespace BaltaPOO.ContentContext
{
    public class Article : Content
    {
        public Article(string title, string url) : base(title, url)
        {
        }

        public override string ToString()
        {
            return $@"Id: {Id} - Title: {Title} - URL: {URL}";
        }
    }
}
