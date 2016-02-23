﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineLibiraryCS
{
    class Program
    {
        public Dictionary<string, Dictionary<string, double>> Critics = new Dictionary<string, Dictionary<string, double>>
        {
            {
                "Eissa",
                new Dictionary<string,double>
                {
                    {"Lady in the Water",2.5},
                    {"Snakes on a Plane",3.5},
                    {"Just My Luck",3.0},
                    {"Superman Returns",3.5},
                    {"You, Me and Dupree",2.5},
                    {"The Night Listener",3.0}
                }
            },
            {
                "Atef",
                new Dictionary<string,double>
                {
                    {"Lady in the Water",3.0},
                    {"Snakes on a Plane",3.5},
                    {"Just My Luck",1.5},
                    {"Superman Returns",5.0},
                    {"The Night Listener",3.0},
                    {"You, Me and Dupree",3.5}
                }
            },
            {
                "Hassan",
                new Dictionary<string,double>
                {
                    {"Lady in the Water",2.5},
                    {"Snakes on a Plane",3.0},
                    {"Superman Returns",3.5},
                    {"The Night Listener",4.0}
                }
            },
            {
                "Abdo",
                new Dictionary<string,double>
                {
                    {"Snakes on a Plane",3.5},
                    {"Just My Luck",3.0},
                    {"The Night Listener",4.5},
                    {"Superman Returns",4.0},
                    {"You, Me and Dupree",2.5}                    
                }
            },
            {
                "Soly",
                new Dictionary<string,double>
                {
                    {"Lady in the Water",3.0},
                    {"Snakes on a Plane",4.0},
                    {"Just My Luck",2.0},
                    {"Superman Returns",3.0},
                    {"The Night Listener",3.0},
                    {"You, Me and Dupree",2.0}
                }
            },
            {
                "Sleem",
                new Dictionary<string,double>
                {
                    {"Lady in the Water",3.0},
                    {"Snakes on a Plane",4.0},
                    {"The Night Listener",3.0},
                    {"Superman Returns",5.0},
                    {"You, Me and Dupree",3.5}
                }
            },
            {
                "Gaber",
                new Dictionary<string,double>
                {
                    {"Snakes on a Plane",4.5},
                    {"You, Me and Dupree",1.0},
                    {"Superman Returns",4.0}
                }
            }
        };



        static void Main(string[] args)
        {
        }
    }
}