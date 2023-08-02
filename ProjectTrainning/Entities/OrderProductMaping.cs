namespace ProjectTrainning.Entities
{
    public class OrderProductMaping:Base
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
    }
}