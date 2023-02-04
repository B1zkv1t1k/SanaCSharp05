﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Currency
    {
        protected string Name;
        public string name
        {
            set
            {
                if (value != "")
                {
                    Name = value;
                }
            }
            get { return Name; }
        }
        protected int ExRate;
        public int exRate
        {
            set
            {
                if(value > 0)
                {
                    ExRate= value;
                }
            }
            get { return ExRate; }
        }

        public Currency()
        {

        }   
        public Currency(string name, int exRate)
        {
            Name = name;
            ExRate = exRate;
        }
        public Currency(int exRate)
        {
            ExRate = exRate;
        }


    }
}