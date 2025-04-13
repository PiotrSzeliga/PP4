using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Application.Services;
using EShop.Domain.Exceptions.CreditCard;

namespace EShop.Application.Tests;

public class Tests
{
    [Theory]
    [InlineData("4024 ! 0071 ! 6540 ! 1778")]
    [InlineData("4024/0071/6540/1778")]
    [InlineData("4024 ~ 0071 ~ 6540 ~ 1778")]
    [InlineData("4024.0071.6540.1778")]
    [InlineData("4024 , 0071 , 6540 , 1778")]
    public void _InvalidCharacters_ThrowException(string cardNumber) 
    {
        var creditCardService = new CreditCardService();
        var exception = Assert.Throws<CardNumberInvalidException>(() => creditCardService.ValidateCardNumber(cardNumber));
        Assert.Equal("błąd 400", exception.Message);
    }

    [Fact]
    public void _TooLong_ThrowException()
    {
        string cardNumber = "55300164545384180000";
        var creditCardService = new CreditCardService();
        var exception = Assert.Throws<CardNumberTooLongException>(() => creditCardService.ValidateCardNumber(cardNumber));
        Assert.Equal("błąd 414", exception.Message);
    }
    
    [Fact]
    public void _TooShort_ThrowException() 
    {
        string cardNumber = "553001645453";
        var creditCardService = new CreditCardService();
        var exception = Assert.Throws<CardNumberTooShortException>(() => creditCardService.ValidateCardNumber(cardNumber));
        Assert.Equal("błąd 400", exception.Message);
    }

    [Theory]
    [InlineData("4532289052809182")] //4532289052809181
    [InlineData("5530015454538418")] //5530016454538418
    [InlineData("4551561343896215")] //5551561443896215
    [InlineData("6131208517986684")] //6131208517986681
    [InlineData("378590193817437")] //378523393817437
    public void _IncorrectLuhna_ThrowException(string cardNumber) 
    {
        var creditCardService = new CreditCardService();
        var exception = Assert.Throws<CardLuhnaInvalidException>(() => creditCardService.ValidateCardNumber(cardNumber));
        Assert.Equal("błąd 400", exception.Message);
    }

    [Theory]
    [InlineData("4532289052809181")]
    [InlineData("5530016454538418")]
    [InlineData("5551561443896215")]
    [InlineData("5131208517986691")]
    [InlineData("378523393817437")]
    public void _CorrectLuhna_ReturnTrue(string cardNumber)
    {
        var creditCardService = new CreditCardService();
        var result = creditCardService.ValidateCardNumber(cardNumber);
        Assert.True(result);
    }

    [Theory]
    [InlineData("3497 7965 8312 797")]
    [InlineData("345-470-784-783-010")]
    [InlineData("4024-0071-6540-1778")]
    [InlineData("4532 2080 2150 4434")]
    [InlineData("4556418049718210")]
    public void _CorrectNumber_ReturnTrue(string cardNumber)
    {
        var creditCardService = new CreditCardService();
        var result = creditCardService.ValidateCardNumber(cardNumber);
        Assert.True(result);
    }
}
