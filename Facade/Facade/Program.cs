


using Facade;
using Facade.Ingridients;

var burger = new Burger(new Tomato(), new Bread(), new Cheese(), new Meat());
Console.WriteLine(burger.makeBurger());






