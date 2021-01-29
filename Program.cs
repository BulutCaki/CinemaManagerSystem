using System;

namespace CinemaManagerSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            user1.Id = 1;
            user1.UserName = "Bulutt";
            user1.Password = "7854963";
            user1.Email = "bulutcaki023@gmail.com";
            user1.FirstName = "Bulut";
            user1.LastName = "Çakı";
            user1.Birthday = "12.02.2020";

            IBaseVerification verification = new Verification();
            UserManager userManager = new UserManager(verification);
            userManager.Register(user1);

            FilmList<string> filmList = new FilmList<string>();
            filmList.Add("İnception");
            filmList.Add("Intelstellar");
            filmList.Add("2012");

            Discount discount = new Discount();
            discount.Id = 1;
            discount.DiscountName = "Seçili Sinema Menülerindeki 7 TL indirim";
            discount.DiscountPrice = 7;

            Sales sales = new Sales();
            sales.Sale(user1, discount, filmList);
        }
    }
}

