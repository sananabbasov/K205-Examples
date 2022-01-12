using K205_Examples;



// 54as54-d51as4d-5a4sd-54a6-sdas54d-6as4-54d5a
// MD5 sifreleme C#-da

//static string Hash(string password)  // string 
//{
//    using (var sha256 = SHA256.Create())
//    {
//        var hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(password + "istifadeciEMaili"));
//        return BitConverter.ToString(hash).Replace("-","");
//    }
//}


//string sifre = "123";
//string sifre2 = "AAE8BFB9872FE65143FB5E619F5B96200D49BF7D015F107517005C7A9CE51BA9";

//Console.WriteLine(Hash(sifre));

//Console.WriteLine("Sifrenizi daxil edi");

//string parol = Console.ReadLine();

//if (sifre == Hash(parol))
//{
//    Console.WriteLine("Sifre duzdu");
//}
//else
//{
//    Console.WriteLine("Sifre sehfdi");
//}


//User user1 = new User();

//user1.Id = 1;
//user1.Name = "Vahid";
//user1.Surname = "Muradov";
//user1.Password = "1234";







//User user2 = new() { 
//    Id = 2,
//    Name = "Resad",
//    Surname = "Residli",
//    Password = "Resid123"

//};


//User user3 = new();




//Console.Write("Adinizi daxil edin: ");

//string name = Console.ReadLine();

//Console.Write("Sifrenizi daxil: ");

//string password = Console.ReadLine();

//user3.Name = name;
//user3.Password = password;

//Console.WriteLine(user3.Name + " " + user3.Password);

//// class


//User user1 = new User();

//user1.Id = 1;
//user1.Name = "Vahid";
//user1.Surname = "Muradov";
//user1.Password = "1234";


//Console.WriteLine(user1.Hash());



//var gun = DateTime.Now;



//switch (gun.DayOfWeek.ToString())
//{
//    case "Monday":
//        Console.WriteLine("Bazarertesi");
//        break;
//    case "Tuesday":
//        Console.WriteLine("Ceresenbe Axsami");
//        break;
//    case "Wednesday":
//        Console.WriteLine("Ceresenbe");
//        break;
//    case "Thursday":
//        Console.WriteLine("Cume Axsami");
//        break;
//    case "Friday":
//        Console.WriteLine("Cume");
//        break;
//    case "Saturday":
//        Console.WriteLine("Senbe");
//        break;
//    default:

//        Console.WriteLine("Bazar");

//        break;
//}


//Console.WriteLine("1. Yeni mehsul daxil edin.");
//Console.WriteLine("2. Mehsullar.");


//string key = Console.ReadLine();



//switch (Convert.ToUInt32(key))
//{
//    case 1:
//        Console.Write("Mehsul adini daxil edin: ");
//        string mehsulAdi = Console.ReadLine();
//        Console.WriteLine(mehsulAdi);

//        break;
//    case 2:
//        Console.WriteLine("IPhone, Xiomi");
//        break;
//    default:

//        break;
//}



//SEO link


//static void SEOLink(string text)
//{
//    var seo = text.ToLower().Replace(" ", "-")
//                  .Replace("ə", "e")
//                  .Replace("ğ", "g")
//                  .Replace("ç", "c");

//    Console.WriteLine(seo);
//}


//string metn = "GeÇtiĞimiz gün sosyal medya hesabından bir paylaşım yaparak";


//SEOLink(metn);






Product telefon = new();
telefon.Id = 1;
telefon.Name = "IPhoneX";
telefon.Description = "Cox bahali telefondu";
telefon.Price = 59.6M;


Product masin = new() { 
    Id = 2,
    Name = "Tesla",
    Description = "Cox yaxsi masindi",
    Price = 566.5465M

};

Product kompyuter = new() { 
    Id = 3,
    Name = "Asus TUF Gaming F17",
    Description="Agir notbukdu",
    Price = 2399.99M

};


Console.WriteLine(telefon.Name + " " + telefon.EDV() + " " + telefon.SEO());

