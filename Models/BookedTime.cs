
namespace Sauna.Models
{
    public class BookedTime
    {
        public int Id { get; set;}
        public DateTime ChoosedTime{ get; set;}
        public int CustomerId { get; set;}
        public Customer Customer { get; set; }
    }
}