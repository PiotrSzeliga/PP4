using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Exceptions.CreditCard;

public class CardNumberTooLongException : Exception
{
    public CardNumberTooLongException() : base("błąd 414") { }
    public CardNumberTooLongException(string number) { }
    public CardNumberTooLongException(string number, Exception innerException) : base(number, innerException) { }
}