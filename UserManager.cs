using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagerSystem
{
    class UserManager
    {
        public UserManager(IBaseVerification verification)
        {
            verification.EMail();
        }
        public void Register(User user)
        {
            Console.WriteLine(user.FirstName + " : Kayıt işlemi başarıyla gerçekleştirildi");
        }
        public void Update(User user)
        {
            Console.WriteLine(user.FirstName + " Güncelleme işlemi başarıyla gerçekleştirildi");
        }
        public void Delete(User user)
        {
            Console.WriteLine(user.FirstName + " Silme işlemi başarıyla gerçekleştirildi");
        }

    }
}
