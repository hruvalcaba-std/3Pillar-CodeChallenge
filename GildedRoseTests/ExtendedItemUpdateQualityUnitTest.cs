using GildedRoseKata;
using NUnit.Framework;


namespace GildedRoseTests
{
    public class ExtendedItemUpdateQualityUnitTest
    {

        [Test]
        public void Aged30DaysStartQuality2End50()
        {
            // Arrange
            var item = new ExtendedItem
            {
                Name = "Aged Brie",
                Quality = 2,
                SellIn = 0,
            };

            // Act
            for (int i = 0; i < 30; i++)
            {
                item.UpdateQuality();
            }

            //Assert
            Assert.That(item.Quality, Is.EqualTo(50));
        }

        [Test]
        public void Aged30DaysStartSellIn0EndMinus30()
        {
            // Arrange
            var item = new ExtendedItem
            {
                Name = "Aged Brie",
                Quality = 2,
                SellIn = 0,
            };

            // Act
            for (int i = 0; i < 30; i++)
            {
                item.UpdateQuality();
            }

            //Assert
            Assert.That(item.SellIn, Is.EqualTo(-30));
        }

        [Test]
        public void Ticket15DaysStartSellIn15EndMinus0()
        {
            // Arrange
            var item = new ExtendedItem
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                Quality = 20,
                SellIn = 15,
            };

            // Act
            for (int i = 0; i < 15; i++)
            {
                item.UpdateQuality();
            }

            //Assert
            Assert.That(item.SellIn, Is.EqualTo(0));
        }

        [Test]
        public void Ticket15DaysStartQuality20End50()
        {
            // Arrange
            var item = new ExtendedItem
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                Quality = 20,
                SellIn = 15,
            };

            // Act
            for (int i = 0; i < 15; i++)
            {
                item.UpdateQuality();
            }

            //Assert
            Assert.That(item.Quality, Is.EqualTo(50));

        }

        [Test]
        public void Ticket16DaysStartSellIn15EndMinus1()
        {
            // Arrange
            var item = new ExtendedItem
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                Quality = 20,
                SellIn = 15,
            };

            // Act
            for (int i = 0; i < 16; i++)
            {
                item.UpdateQuality();
            }

            //Assert
            Assert.That(item.SellIn, Is.EqualTo(-1));
        }

        [Test]
        public void Ticket16DaysStartQuality20End50()
        {
            // Arrange
            var item = new ExtendedItem
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                Quality = 20,
                SellIn = 15,
            };

            // Act
            for (int i = 0; i < 16; i++)
            {
                item.UpdateQuality();
            }

            //Assert
            Assert.That(item.Quality, Is.EqualTo(50));
        }

        [Test]
        public void Ticket2DaysStartSellIn9Quality0EndQuality4()
        {
            // Arrange
            var item = new ExtendedItem
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                Quality = 0,
                SellIn = 9,
            };

            // Act
            for (int i = 0; i < 2; i++)
            {
                item.UpdateQuality();
            }

            //Assert
            Assert.That(item.Quality, Is.EqualTo(4));
        }

        [Test]
        public void Ticket9DaysStartSellIn9Quality0EndQuality23()
        {
            // Arrange
            var item = new ExtendedItem
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                Quality = 0,
                SellIn = 9,
            };

            // Act
            for (int i = 0; i < 9; i++)
            {
                item.UpdateQuality();
            }

            //Assert
            Assert.That(item.Quality, Is.EqualTo(23));
        }
    }
}
