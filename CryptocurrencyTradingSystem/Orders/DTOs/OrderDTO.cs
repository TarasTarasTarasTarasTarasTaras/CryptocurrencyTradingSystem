namespace Orders.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public int UserId { get; set; }
    }
}
