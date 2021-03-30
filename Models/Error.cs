namespace error_track.Models
{
    public class Error
    {
        public int Id { get; set; }
        public string errorMessage { get; set; }
        public string solution { get; set; }  
        public string context { get; set; }
    }
}