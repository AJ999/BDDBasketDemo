
using NUnit.Framework;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace MyNamespace
{
    [Binding]
    public class StepDefinitions
    {
        Basket _basket;
        Object _item;

        [Given(@"I create a new basket")]
        [When(@"I create a new basket")]
        public void WhenICreateANewBasket()
        {
            _basket = new Basket();
        }

        [Then(@"The basket has no contents")]
        public void ThenTheBasketHasNoContents()
        {
            Assert.IsEmpty(_basket.Contents);
        }

        [Given(@"I add an item to the basket")]
        [When(@"I add an item to the basket")]
        public void WhenIAddAnItemToTheBasket()
        {
            _item = new object();

            _basket.Add(_item);
        }

        [Then(@"the basket contains the added item")]
        public void ThenTheBasketContainsTheAddedItem()
        {
            Assert.IsNotEmpty(_basket.Contents);
        }

        [When(@"I remove an item from the basket")]
        public void WhenIRemoveAnItemFromTheBasket()
        {
            

            _basket.Remove(_item);
        }

        [Then(@"the basket does not contain the item")]
        public void ThenTheBasketDoesNotContainTheItem()
        {
            Assert.IsEmpty(_basket.Contents);
        }
    }

    public class Basket
    {
        public Basket()
        {
            Contents = new List<object>();
        }
        public List<object> Contents { get; set; }

        internal void Add(object item)
        {
            Contents.Add(item);
        }

        internal void Remove(object item)
        {
            Contents.Remove(item);
        }
    }
}

