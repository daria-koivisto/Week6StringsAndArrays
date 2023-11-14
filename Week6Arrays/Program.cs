string[] fruitBasket = { "apples", "bananas", "oranges" };
Console.WriteLine($"There are {fruitBasket.Length} fruits in your basket");
for (int i = 0; i < fruitBasket.Length; i++)
{
    Console.WriteLine(fruitBasket[i]);
}
fruitBasket[0] = "pineapples";
fruitBasket[2] = "peaches";

for (int i = 0;  i < fruitBasket.Length; i++)
{
    Console.WriteLine(fruitBasket[i]);
}