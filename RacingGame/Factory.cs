﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame
{
    public static class Factory
    {
        public static Random Random = new Random();
        private static int randomNumber;
        public static Punter GetAPerson(int id)
        {
            switch (id)
            {
                case 0:
                    return new Jerry();
                case 1:
                    return new Al();
                case 2:
                    return new Tom();
            }
            return new Jerry();
        }
        public static Thing GetAThing(int id)
        {
            switch (id)
            {
                case 0:
                    return new Larry();
                case 1:
                    return new Curly();
                case 2:
                    return new Moe();
                case 3:
                    return new Shemp();
            }
            return new Larry();
        }
        //Generates a random number to advance the ghosts 
        public static int Number()
        {
            return randomNumber = Random.Next(0, 10);
        }
    }
}


