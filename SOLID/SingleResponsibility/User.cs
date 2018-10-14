using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SingleResponsibility
{
    public class User
    {
        public void ChangeUserName()
        {
            //Kullanıcı adını değiştirir
        }

        public void ChangeEmailAddress()
        {
            //Email adresini değiştirir
        }

        public void SendAnEmail()
        {
            //Email gönderir
        }
    }

    public class EmailHelper
    {
        public void SendAnEmail()
        {
            //Email gönderir
        }
    }
}
