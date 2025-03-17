using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Application;

namespace EShop.Application.Tests;

public class ValidateCardTests
{
    [Theory]
    [InlineData("4024 ! 0071 ! 6540 ! 1778")]
    [InlineData("4024/0071/6540/1778")]
    [InlineData("4024 ~ 0071 ~ 6540 ~ 1778")]
    [InlineData("4024.0071.6540.1778")]
    [InlineData("4024 , 0071 , 6540 , 1778")]
    public void ValidateCard_InvalidCharacters_ReturnsFalse(string cardNumber) 
    { 
        var result = CardMethods.ValidateCard(cardNumber);
        Assert.False(result);
    }

    [Fact]
    public void ValidateCard_TooLong_ReturnsFalse()
    {
        string cardNumber = "55300164545384180000";
        var result = CardMethods.ValidateCard(cardNumber);
        Assert.False(result);
    }
    
    [Fact]
    public void ValidateCard_TooShort_ReturnsFalse() 
    {
        string cardNumber = "553001645453";
        var result = CardMethods.ValidateCard(cardNumber);
        Assert.False(result);
    }

    [Theory]
    [InlineData("4532289052809182")] //4532289052809181
    [InlineData("5530015454538418")] //5530016454538418
    [InlineData("4551561343896215")] //5551561443896215
    [InlineData("6131208517986684")] //6131208517986681
    [InlineData("378590193817437")] //378523393817437
    public void ValidateCard_IncorrectLuhna_ReturnFalse(string cardNumber) 
    {
        var result = CardMethods.ValidateCard(cardNumber);
        Assert.False(result);
    }

    [Theory]
    [InlineData("4532289052809181")]
    [InlineData("5530016454538418")]
    [InlineData("5551561443896215")]
    [InlineData("5131208517986691")]
    [InlineData("378523393817437")]
    public void ValidateCard_CorrectLuhna_ReturnTrue(string cardNumber)
    {
        var result = CardMethods.ValidateCard(cardNumber);
        Assert.True(result);
    }

    [Theory]
    [InlineData("3497 7965 8312 797")]
    [InlineData("345-470-784-783-010")]
    [InlineData("4024-0071-6540-1778")]
    [InlineData("4532 2080 2150 4434")]
    [InlineData("4556418049718210")]
    public void ValidateCard_CorrectNumber_ReturnTrue(string cardNumber)
    {
        var result = CardMethods.ValidateCard(cardNumber);
        Assert.True(result);
    }
}
