namespace WebApiGenericResponse.Models
{
    public class BaseProduct<T> where T : BaseAddon, new()
    {
        public BaseProduct(T addon)
        {
            Name = "base-product";
            AddOn = addon;
        }

        public T AddOn { get; }

        public string Name { get; }
    }
}
