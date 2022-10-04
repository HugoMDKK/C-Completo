namespace Course.Entities
{
    internal class Comment
    {
        public String Text { get; set; }
        
        public Comment()
        {

        }
        public Comment(string text)
        {
            Text = text;
        }
    }
}
