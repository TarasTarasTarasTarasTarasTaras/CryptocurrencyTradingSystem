namespace CryptocurrencyTradingSystem.Core.EF.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public int UserId { get; set; }
        public virtual User? User { get; set; }
    }
}
