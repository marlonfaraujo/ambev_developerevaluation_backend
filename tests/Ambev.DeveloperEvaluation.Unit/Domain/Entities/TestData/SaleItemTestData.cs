﻿using Ambev.DeveloperEvaluation.Domain.Entities;
using Bogus;

namespace Ambev.DeveloperEvaluation.Unit.Domain.Entities.TestData
{
    public static class SaleItemTestData
    {
        private static readonly Faker<SaleItem> SaleItemFaker = new Faker<SaleItem>()
            .RuleFor(u => u.ProductId, f => f.Random.Guid())
            .RuleFor(u => u.SaleItemStatus, f => f.Random.String());

        public static SaleItem GenerateValidSaleItem(Guid productId, int itemQuantity, decimal unitItemPrice)
        {
            SaleItemFaker.RuleFor(u => u.ProductId, f => productId);
            SaleItemFaker.RuleFor(u => u.ProductItemQuantity, f => itemQuantity);
            SaleItemFaker.RuleFor(u => u.UnitProductItemPrice, f => unitItemPrice);

            return SaleItemFaker.Generate();
        }

        public static Guid GenerateValidProductId()
        {
            return new Faker().Random.Guid();
        }

        public static int GenerateValidItemQuantity(int min = 1)
        {
            return new Faker().Random.Int(min, 20);
        }

        public static int GenerateValidItemQuantity(int min = 1, int max = 20)
        {
            return new Faker().Random.Int(min, max);
        }

        public static decimal GenerateValidUnitItemPrice()
        {
            return new Faker().Random.Decimal(50,100);
        }
    }
}
