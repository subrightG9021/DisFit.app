using System;
using System.Collections.Concurrent;
using System.Configuration.Assemblies;
using System.Dynamic;
using System.IO.Pipes;
using System.Security.Cryptography.X509Certificates;
namespace PowerForDis
{
    class PowerFordisUser
    {
        protected string nameU;
        protected int age;
        protected double wight;
        protected double hight;

        public PowerFordisUser(string nameU, int age, double wight, double hight)
        {
            this.nameU = nameU;
            this.age = age;
            this.wight = wight;
            this.hight = hight;
        }
        public string NameU
        {
            get {return nameU;}
            set {nameU = value;}
        }
        public int Age
        {
            get {return age;}
            set {age = value;}
        }
        public double Wight
        {
            get {return wight;}
            set {wight = value;}
        }
        public double Hight
        {
            get {return hight;}
            set {hight = value;}
        }
        public virtual string workoutsummery()
        {
            return $"the {nameU} finished his workout";
        }
        public virtual bool workoutsafty()
        {
            return true;
        }
        public virtual string workoutinstraction()
        {
            return $"Hi {nameU} dont forget to do this easy and slow";
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"{nameU} {age} {wight} {hight}");
        }
    }
}
