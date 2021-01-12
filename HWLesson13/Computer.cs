using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HWLesson13
{
    [DebuggerDisplay("Price {price*3.67} $")]
    class Computer
    {
        public string model;
        public int price;
        public int numberOfProcessor;
        public float screenSize;
        public bool isTurnOn;

        public int tellMeThePrice()
        {
            return price;
        }

        public float tellMeTheScreenSize()
        {
            return screenSize;
        }

        public void turnOn()
        {
            if (isTurnOn) 
            {
                Console.WriteLine($"{model} is on");
            }
            else
            {
                isTurnOn = true;
                Console.WriteLine($"turning on {model}...");
            }
        }

        public void turnOff()
        {
            if (!isTurnOn)
            {
                Console.WriteLine($"{model} is off");
            }
            else
            {
                isTurnOn = false;
                Console.WriteLine($"turning off {model}...");
            }
        }

        public void AddProcessor(int processors)
        {
            numberOfProcessor = numberOfProcessor + processors;
            Console.WriteLine($"{model} has got {processors} new processors. and now have {numberOfProcessor} processors");
        }

        public override string ToString()
        {
            return $"Computer's model:{model}; price:{price}; numberOfProcessor:{numberOfProcessor};" +
                $" screenSize:{screenSize}; isTurnOn:{isTurnOn}";
        }
    }
}
