using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace class_4._2
{
    public class Cheese : PizzaDecorator
    {
        public Pizza pizza;
        public Cheese(Pizza pizza){
            this.pizza = pizza;
        }
        public override string GetDesciption()
        {
            return $"{pizza.GetDesciption()}, add Cheese";
        }
        public override string GetSize(){
            return $"{pizza.GetSize()}";

        }
        public override void SetSize(string size){
            pizza.SetSize(size);
        }
        public override double Cost()
        {
            double cost = pizza.Cost();
            switch(pizza.GetSize()){
                case "Small":
                    cost+= 0.5;
                    break;
                case "Medium":
                    cost+= 1.0;
                    break;
                case "Large":
                    cost+=1.5;
                    break;
            }
            return cost;
        }
    }
}