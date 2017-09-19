/********************
 * Joshua Romito   
 * Septemeber 19th 2017
 * CP_330 - Lab_02
 *********************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02
{
    class Worker
    {
        //declaring fields
        private double _upperLimit;
        private string _classification;
        private string _name;
        private Worker _nextInCommand;
        
        public void Authorize(double amount)
        {
            //if our amount is less than or equal to the upper limit
            if (amount <= _upperLimit)
            {
                Console.WriteLine("The amount " + amount + " is okayed by " + _name + " (" + _classification + ").");
            }
            else   // if amount is greater than 
            {
                //if we have a next in command
                if (_nextInCommand != null)
                {
                    //then call authorize
                    _nextInCommand.Authorize(amount);
                }
            }
        }

        //Constructor - assigning fields based on parameters
        public Worker(string name, double upperLimit, string classification, Worker nextInCommand)
        {
            _name = name;
            _upperLimit = upperLimit;
            _classification = classification;
            _nextInCommand = nextInCommand;
        }
    }
}
