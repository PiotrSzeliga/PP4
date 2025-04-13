using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Exceptions.CreditCard;

public class CardProviderInvalidException : Exception
{
    public CardProviderInvalidException() : base("błąd 406") { }
    public CardProviderInvalidException(string number) { }
    public CardProviderInvalidException(string number, Exception innerException) : base(number, innerException) { }
}
