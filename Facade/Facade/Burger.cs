using Facade.Ingridients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade;

public class Burger
{
    private Tomato tomato;
    private Bread bread;
    private Cheese cheese;
    private Meat meat;
    public Burger(Tomato tomato,Bread bread,Cheese cheese,Meat meat)
    {
        this.tomato = tomato;
        this.bread = bread;
        this.cheese = cheese;
        this.meat = meat;
    }

    public string makeBurger()
    {
        string result = "Cooking Burger: \n";
        result+=bread.cut();
        result += tomato.cut();
        result += cheese.melt();
        result += meat.cook();
        result += "Burger is Done!";
        return result;
    }

}
