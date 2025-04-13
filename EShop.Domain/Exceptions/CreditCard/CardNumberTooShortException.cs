using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Exceptions.CreditCard;

public class CardNumberTooShortException : Exception
{
    public CardNumberTooShortException() : base("błąd 400") { }
    public CardNumberTooShortException(string number) { }
    public CardNumberTooShortException(string number, Exception innerException) : base(number, innerException) { }
}