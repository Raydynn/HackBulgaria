using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public abstract class Person
    {
        public string Gender(string gender)
        {
            return gender;
        }
        public List<string> DailyStuffs(List<string> dailyes)
        {
            return dailyes;
        }
    }
    public class Adult : Person
    {
        private bool hasChild;
        public bool HasChild { get; set; }        
        public string GoToWork() 
        {
            return "I am an honest worker!";
        }
    }
    public class Child : Person 
    {
        public bool HasToys(bool hasToys)
        {
            return hasToys;
        }
    }
    public class Toy 
    {
        public string Color(string color)
        {
            return color;
        }
        public int Size(int threeInches) 
        {
            return threeInches;
        }
    }
}
