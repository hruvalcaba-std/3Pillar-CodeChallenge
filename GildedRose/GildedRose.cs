using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    private readonly IList<ExtendedItem> _items;

    public GildedRose(IList<ExtendedItem> items)
    {
        _items = items;
    }

    public void UpdateQuality()
    {
        for (var i = 0; i < _items.Count; i++)
        {
            var item = _items[i];
            item.UpdateQuality();
        }
    }
}