using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Exceptions.CreditCard;

public class CardLuhnaInvalidException : Exception
{
    public CardLuhnaInvalidException() : base("błąd 400") { }
    public CardLuhnaInvalidException(string number) { }
    public CardLuhnaInvalidException(string number, Exception innerException) : base(number, innerException) { }
}

