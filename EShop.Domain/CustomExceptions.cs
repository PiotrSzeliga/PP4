using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain;

public class CardNumberTooLongException : Exception
{
    public CardNumberTooLongException() : base("błąd 414") { }
    public CardNumberTooLongException(string number) { }
    public CardNumberTooLongException(string number, Exception innerException) : base(number, innerException) { }
}

public class CardNumberTooShortException : Exception
{
    public CardNumberTooShortException() : base("błąd 400") { }
    public CardNumberTooShortException(string number) { }
    public CardNumberTooShortException(string number, Exception innerException) : base(number, innerException) { }
}

public class CardNumberInvalidException : Exception
{
    public CardNumberInvalidException() : base("błąd 400") { }
    public CardNumberInvalidException(string number) { }
    public CardNumberInvalidException(string number, Exception innerException) : base(number, innerException) { }
}

public class CardLuhnaInvalidException : Exception
{
    public CardLuhnaInvalidException() : base("błąd 400") { }
    public CardLuhnaInvalidException(string number) { }
    public CardLuhnaInvalidException(string number, Exception innerException) : base(number, innerException) { }
}

public class CardProviderInvalidException : Exception
{
    public CardProviderInvalidException() : base("błąd 406") { }
    public CardProviderInvalidException(string number) { }
    public CardProviderInvalidException(string number, Exception innerException) : base(number, innerException) { }
}




