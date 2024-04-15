using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace class_4._2
{
    public abstract class Pizza
    {
        public string size;
        public string description;
        public Pizza(){
            description = "Unkown pizza";
        }
        public virtual string GetDesciption(){
            return $"{size} {description}";
        }
        public virtual void SetSize(string size){
            this.size = size;
        }
        public virtual string GetSize(){
            return size;
        }
        
        public abstract double Cost();
    }
}