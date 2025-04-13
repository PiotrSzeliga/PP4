using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Application.Services;

namespace EShop.Application.Tests;

public class GetCardTypeTests
{
    [Theory]
    [InlineData("3497 7965 8312 797", "American Express")]
    [InlineData("345-470-784-783-010", "American Express")]
    [InlineData("378523393817437", "American Express")]
    [InlineData("4024-0071-6540-1778", "Visa")]
    [InlineData("4532 2080 2150 4434", "Visa")]
    [InlineData("4532289052809181", "Visa")]
    [InlineData("5530016454538418", "MasterCard")]
    [InlineData("5551561443896215", "MasterCard")]
    [InlineData("5131208517986691", "MasterCard")]
    public void GetCardType_ShouldReturnType(string cardNumber, string expectedResult) 
    {
        var creditCardService = new CreditCardService();
        var result = creditCardService.GetCardType(cardNumber);
        Assert.Equal(expectedResult, result);
    }
}
