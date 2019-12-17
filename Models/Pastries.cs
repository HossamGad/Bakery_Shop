namespace BackeryShop.Models
{
    public class Pie
    {
        public int PastriesId { get; set; }
        public int PastriesID { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public bool IsPieOfTheWeek { get; set; }

        public string LongDescription { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }        
        public bool IsbackeryOfTheWeek { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        

        
    }
}
