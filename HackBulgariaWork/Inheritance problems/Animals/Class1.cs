using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Animal
    {
        public string Move(string movement)
        {
            return movement;
        }
        public string Eating(string food)
        {
            return food;
        }
        public bool GiveBirth(bool birth)
        {
            return birth;
        }
        public virtual string Greet()
        {
            return "Greetings I am a generic animal.";
        }
    }
    public class Mammals : Animal
    {
        public override string Greet()
        {
            return "Greetings I am mammal.";
        }
    }
    public class Reptiles : Animal
    {
        public bool HasConstantTempreture(bool tempreture)
        {
            return false;
        }
        public override string Greet()
        {
            return "Greetings I am reptile.";
        }
    }
    public class Fish : Animal
    {
        public override string Greet()
        {
            return "Greetings I am fish.";
        }
    }
    public class Birds : Animal
    {
        public string Nesting(string makeNest)
        {
            return makeNest;
        }
        public override string Greet()
        {
            return "Greetings I am bird.";
        }
    }
    public class Cat : Mammals
    {
        public override string Greet()
        {
            return "Hello I am cat.";
        }
    }
    public class Dog : Mammals
    {
        public override string Greet()
        {
            return "Hello I am dog WOOF.";
        }
    }
    public class Crocodile : Reptiles
    {
        public override string Greet()
        {
            return "Hello my name is Crocodile.";
        }
    }
    public class Owl : Birds
    {
        public override string Greet()
        {
            return "Hello I am owl. Me am smart.";
        }
    }
    public class Shark : Fish
    {
        public override string Greet()
        {
            return "Hello I am fish O.O";
        }
    }
}





    //You should create a class hierarchy for Animals. All animals can move, eat, give birth. Animals can be mammals, reptiles, 
    //fish, birds. All land animals can greet (make sounds). Birds make nests, reptiles don't have constant temperature. Implement 
    //the following animals - cat, dog, crocodile, owl, shark.