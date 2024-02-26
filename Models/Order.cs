namespace Sauna.Models
{
    public class Order
    {
        public int Id { get; set;}
        public int BookedTimeId { get; set;}
        public BookedTime BookedTime { get; set;}
        public int CustomerId { get; set;}
        public Customer Customer { get; set;}
        public decimal Price { get; set;}
    }
}