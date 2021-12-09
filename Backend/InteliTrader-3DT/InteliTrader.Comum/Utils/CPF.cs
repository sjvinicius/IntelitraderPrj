using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteliTrader.Shared.Utils
{
  public static  class CPF
    {
        public static string Criptografar(string cpf)
        {
            return BCrypt.Net.BCrypt.HashPassword(cpf);
        }

        public static bool Validar(string cpf, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(cpf, hash);
        }
    }
}
