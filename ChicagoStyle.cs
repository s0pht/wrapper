using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace class_4._2
{
    public class ChicagoStyle : Pizza
    {
        public ChicagoStyle(){
            description = "Chicago Style";
        }
        public override double Cost()
        {
            double cost = 0.0;
            switch(size){
                case "Small":
                    cost+= 10.50;
                    break;
                case "Medium":
                    cost+=12.25;
                    break;
                case "Large":
                    cost+=14.0;
                    break;
            }
            return cost;
        }
    }
}