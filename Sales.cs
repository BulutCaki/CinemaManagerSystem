using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagerSystem
{
    class Sales
    {
        public void Sale(User user,Discount discount,FilmList<String> filmList)
        {
            Console.WriteLine(
                user.UserName +" kullanıcısı " + discount.DiscountName + "Kampanyasından " + discount.DiscountPrice + "tutarında indirimden yararlanarak " + filmList.Length + "adet film satın aldı"
                );
            Console.WriteLine("----------------------------");
            for (int i = 0; i < filmList.Length; i++)
            {
                Console.WriteLine(filmList.Film[i]);
            }
        }
    }
}
