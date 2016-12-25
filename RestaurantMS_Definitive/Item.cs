

namespace RestaurantMS_Definitive
{
    public class Item
    {
        public string itemID;
        public string itemName;
        public string itemPrice;
        public string itemCategory;

        public Item(string itemID, string itemName, string itemPrice, string itemCategory)
        {
            this.itemID = itemID;
            this.itemName = itemName;
            this.itemPrice = itemPrice;
            this.itemCategory = itemCategory;
        }
    }
}
