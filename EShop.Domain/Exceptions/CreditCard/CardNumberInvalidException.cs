﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Exceptions.CreditCard;

public class CardNumberInvalidException : Exception
{
    public CardNumberInvalidException() : base("błąd 400") { }
    public CardNumberInvalidException(string number) { }
    public CardNumberInvalidException(string number, Exception innerException) : base(number, innerException) { }
}