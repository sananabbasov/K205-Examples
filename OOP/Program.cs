using OOP.Methods;
using OOP.Models;
// S - single responsibility
// O - open closed
// L
// I
// D

SeoLink seoLink = new SeoLink();




Category category = new() { 
   Id = 1,
   CategoryName = "Telefon",
   Created = DateTime.Now,
   SeoUrl = seoLink.Seo("Telefon")
};






Product product1 = new()
{
    Id = 1,
    Name = "IPhone 11",
    Description = "sadasd",
    Price = 544.00M,
    SeoUrl = seoLink.Seo("IPhone 11"),
    Created = DateTime.Now,
};

Product product2 = new()
{
    Id = 1,
    Name = "Samsung 11",
    Description = "sadasd",
    Price = 544.00M,
    SeoUrl = seoLink.Seo("IPhone 11"),
    Created = DateTime.Now,
};


Product product3 = new()
{
    Id = 1,
    Name = "Xiomi 11",
    Description = "sadasd",
    Price = 544.00M,
    SeoUrl = seoLink.Seo("IPhone 11"),
    Created = DateTime.Now,
};

Car car = new() { 

    Name = "Teslas",


};

Car car2 = new()
{

    Name = "BMW",


};
seoLink.Seo(car.Name);

//Console.WriteLine(product.SeoUrl);
//Console.WriteLine(category.SeoUrl);
//Console.WriteLine(seoLink.Seo(car.Name));


List<string> products = new();

//products.Add(product1.Name + " - " + product1.Price);
//products.Add(product2.Name + " - " + product2.Price);
//products.Add(product3.Name + " - " + product3.Price);


Evvele:
Console.WriteLine("Mehsul adini daxil edin: ");
var yeniMehsulAd = Console.ReadLine(); // telefon

Console.WriteLine("Mehsul qiymetini daxil edin: ");
var yeniMehsulQiymet = Console.ReadLine(); // 898


            // telefon                                // 898
products.Add(yeniMehsulAd + " - " + Convert.ToDecimal(yeniMehsulQiymet));

Console.WriteLine("Davam etmek isteyirsinizmi ?");
var tesdiq = Console.ReadLine();







switch (Convert.ToInt32(tesdiq))
{
    case 1:
        goto Evvele;
        break;
    case 2:
        foreach (var pro in products) // products List<>{ iphone, asus } || (1) pro =  iphone (2) pro = asus
        {
            Console.WriteLine(pro);
        }

        break;
    default:
        break;
}


