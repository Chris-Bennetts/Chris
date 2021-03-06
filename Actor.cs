﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxGooseCorn
{
    class Actor
    {
        //can hold one of two values - true or false
        private Bank bank;
        public string Name { get; private set; }

        internal Cast Cast
        {
            get => default(Cast);
            set
            {
            }
        }

        public Actor(string name)
        {
            Name = name;
            bank = Bank.LEFT;
        }

        public String getPosition()
        {
            if (bank == Bank.LEFT) 
                return "The "+ Name +" is on the left bank\n";
            else
                return "The " + Name + " is on the right bank\n";
        }

        public void changeBank()
        {
            if (bank == Bank.LEFT)
                bank = Bank.RIGHT;
            else
                bank = Bank.LEFT;
        }
    }
}

