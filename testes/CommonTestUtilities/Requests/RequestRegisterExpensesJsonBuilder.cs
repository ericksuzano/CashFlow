﻿using Bogus;
using CashFlow.Communication.Enums;
using CashFlow.Communication.Requests;

namespace CommonTestUtilities.Requests;
public class RequestRegisterExpensesJsonBuilder
{
    public static RequestExpenseJson Build()
    {
        /*var faker = new Faker();

        var request = new RequestRegisterExpensesJson
        {
            Title = faker.Commerce.Product(),
            Date = faker.Date.Past(),
        };*/

        //OU DESSA FORMA!

       return new Faker<RequestExpenseJson>()
            .RuleFor(r => r.Title, faker => faker.Commerce.ProductName())
            .RuleFor(r => r.Description, faker => faker.Commerce.ProductDescription())
            .RuleFor(r => r.Date, faker => faker.Date.Past())
            .RuleFor(r => r.PaymentType, faker => faker.PickRandom<PaymentType>())
            .RuleFor(r => r.Amount, faker => faker.Random.Decimal(min: 1, max: 1000));
    }
}
