using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Enums;

public enum CreditCardProvider
{
        Visa,
        MasterCard,
        [Display(Name = "American Express")]        
        AmericanExpress,
        Discover,
        JCB,
        [Display(Name = "Diners Club")]    
        DinersClub,
        Maestro,
        Unknown
}
