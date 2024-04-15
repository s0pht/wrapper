using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace class_4._2
{
    public class StuffedCrust : Pizza
    {
        public StuffedCrust(){
            description = "Stuffed Crust";
        }
        public override double Cost()
        {
            double cost = 0.0;
            switch(size){
                case "Small":
                    cost+= 8.50;
                    break;
                case "Medium":
                    cost+=10.25;
                    break;
                case "Large":
                    cost+=12.0;
                    break;
            }
            return cost;
        }
    }
}