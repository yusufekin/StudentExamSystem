using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımYapımıProje
{
    public class RegisterFactory
    {
        public IRegisterProcedure CreateRegistryObject(string userType, Dictionary<string, string> userınfo)
        {
            if (userType == "Öğrenci")
                return new RegisterStudent()
                {
                    userInfo = userınfo
                };

            else if (userType == "Sınav Sorumlusu")
                return new RegisterExamManager()
                {
                    userInfo = userınfo
                };

            else
                throw new InvalidOperationException();
        }
    }
}
