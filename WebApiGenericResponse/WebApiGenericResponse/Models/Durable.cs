namespace WebApiGenericResponse.Models
{
    public class Durable : BaseAddon
    {
        public string ChildName { get; } = "durable-product";
        public int MinQuantity { get; } = 100;
    } 
}
