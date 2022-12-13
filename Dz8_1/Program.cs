class Item
{

}

interface IOrder
{
    public void CalculateTotalSum();
    public void GetItems();
    public void GetItemCount();
    public void AddItem(Item item);
    public void DeleteItem(Item item);
}

interface IRepository
{
    public void Load();
    public void Save();
    public void Update();
    public void Delete();
}

interface IPrint
{
    public void PrintOrder();
}

interface IShow
{

}
class Order : IOrder
{
    private List<Item> itemList;
    internal List<Item> ItemList
    {
        get
        {
            return itemList;
        }
        set
        {
            itemList = value;
        }
    }
    public void CalculateTotalSum() {/*...*/}
    public void GetItems() {/*...*/}
    public void GetItemCount() {/*...*/}
    public void AddItem(Item item) {/*...*/}
    public void DeleteItem(Item item) {/*...*/}
}

class Repository : IRepository
{
    public void Load() {/*...*/}
    public void Save() {/*...*/}
    public void Update() {/*...*/}
    public void Delete() {/*...*/}
}

class OrderPrint : IPrint
{
    public void PrintOrder() {/*...*/}
}

class OrderShow
{
    public void ShowOrder() {/*...*/}
}

//Порушено принцип Single Responsibility Principle 