namespace AnonymousType
{
    internal class Program
    {
        public class Products 
        {
            public string? Color { get; set; }
            public int Price { get; set; }
        }
        static void Main(string[] args)
        {
            var v = new { Amoutn = 108, Message = "Hello" };
            Console.WriteLine($"{v.Amoutn} {v.Message}");

            //Products products = new Products() { Color = "Белый", Price = 15 };
            List<Products> products = new List<Products>();
            products.Add(new Products() { Color = "Белый", Price = 15 });
            products.Add(new Products() { Color = "Черный", Price = 16 });

            var productQuery =
                from prod in products
                select new { prod.Color, prod.Price };

            foreach (var item in productQuery)
            {
                Console.WriteLine("Color={0}, Price={1}", item.Color, item.Price);
            }

            var apple = new { Item = "apples", Price = 1.35 };
            var onSale = apple with { Price = 0.79 };
            Console.WriteLine(apple);
            Console.WriteLine(onSale);

        }
    }
}