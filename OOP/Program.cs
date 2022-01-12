using OOP.Models;
// S - single responsibility
// O
// L
// I
// D

Category category = new() { 
   Id = 1,
   CategoryName = "Telefon",
   Created = DateTime.Now,
   SeoUrl = "telefon"
};

Product product = new()
{
    Id = 1,
    Name = "IPhone 11",
    Description = "sadasd",
    Price = 544.00M,
    SeoUrl = "asd",
    Created = DateTime.Now,
};



Console.WriteLine(product.Id);