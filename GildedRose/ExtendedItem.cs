namespace GildedRoseKata;

public class ExtendedItem : Item
{
    public Type Type { 
        get {

            if (string.IsNullOrEmpty(Name))
                return Type.Regular;

            var normalizedName = Name.ToLowerInvariant();
            
            if(normalizedName.Contains("aged"))
                return Type.Aged;

            if (normalizedName.Contains("sulfura"))
                return Type.Sulfura;

            if (normalizedName.Contains("passes"))
                return Type.Ticket;

            return Type.Regular;
        }
    }

    public void UpdateQuality()
    {
        
        switch (Type) 
        {
            case Type.Sulfura:
                SellIn++;
                Quality = 80;
                break;
            case Type.Aged:
                Quality = SellIn > 0 ? Quality + 1 : Quality + 2;
                if (Quality > 50) 
                    Quality = 50;
                break;
            case Type.Ticket:
                // this case is not mention on the requeriments but I just set up to manage this case as a "normal" item;
                if (SellIn > 10)
                    Quality++;
                // Quality increases by 2 when there are 10 days or less 
                if (SellIn <= 10 && SellIn >= 6)
                    Quality += 2;
                // by 3 when there are 5 days or less
                if (SellIn <= 5 && SellIn >= 0)
                    Quality += 3;
                // Quality drops to 0 after the concert
                if (SellIn < 0)
                    Quality = 0;
                if (Quality > 50)
                    Quality = 50;
                break;
            case Type.Regular:
            default:
                Quality = SellIn > 0 ? Quality - 1 : Quality - 2;
                break;
        }

        if (Quality < 0)
            Quality = 0;

        SellIn--;
    }
}

public enum Type
{
    Regular = 0,
    Aged = 1,
    Sulfura = 2,
    Ticket = 3,
}
