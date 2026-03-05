using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

InventoryItem[] items = new InventoryItem[]
{
    new InventoryItem("검", 3.5, 1500),
    new InventoryItem("방패", 5.0, 1200),
    new InventoryItem("포션", 0.3, 50),
    new InventoryItem("활", 1.8, 1300),
    new InventoryItem("투구", 2.0, 800)
};
Console.WriteLine("=== 인벤토리 목록 === ");
foreach (InventoryItem item in items)
{
    Console.WriteLine($"{item.Name} - 무게: {item.Weight}kg, 가격: {item.Price}골드");
}
Console.WriteLine();
double totalWeight = 0;  // 통계를 위한 변수 초기화
int totalPrice = 0;
InventoryItem mostExpensive = items[0];
InventoryItem lightest = items[0];

foreach (InventoryItem item in items)  // 반복 순환으로 통계
{
    totalWeight += item.Weight; 
    totalPrice += item.Price;

    if(item.Price > mostExpensive.Price)
    {
        mostExpensive = item;
    }
    if (item.Weight < lightest.Weight)
    {
        lightest = item;
    }
}
Console.WriteLine("=== 인벤토리 통계 ==="); // 통계 출력문
Console.WriteLine($"전체 무게: {totalWeight:F1}kg");
Console.WriteLine($"전체 가격: {totalPrice}골드");
Console.WriteLine($"평균 가격: {totalPrice / items.Length}골드");
Console.WriteLine($"가장 비싼 아이템: {mostExpensive.Name}");
Console.WriteLine($"가장 가벼운 아이템: {lightest.Name}");
struct InventoryItem
{
    public string Name;
    public double Weight;
    public int Price;

    public InventoryItem(string name, double weight, int price)
        {
        Name = name;
        Weight = weight;
        Price = price;
    }
}

