using InterfaceAbstractDemo3;

class Program
{
    static void Main(string[] args)
    {
        PrintProductWithDiscount(new Tshirts(1, "black tshirt", 1500, 1));
        PrintProductWithDiscount(new Tshirts(2, "white tshirt", 2000, 2));
        PrintProductWithDiscount(new Tshirts(3, "blue tshirt", 2500, 3));
        PrintProductWithDiscount(new Sweatshirts(4, "grey sweatshirt", 3000, 1));
        PrintProductWithDiscount(new Sweatshirts(5, "green sweatshirt", 3500, 2));

        Console.ReadLine();
    }

    static void PrintProductWithDiscount(DiscountManager product)
    {
        double originalPrice = product.ProductPrice;
        product.IndirimYap();
        double discountAmount = originalPrice - product.ProductPrice;

        Console.WriteLine($"Ürün Adı: {product.ProductName}, Orijinal Fiyat: {originalPrice}, İndirimli Fiyat: {product.ProductPrice}, İndirim Miktarı: {discountAmount}");
    }
}