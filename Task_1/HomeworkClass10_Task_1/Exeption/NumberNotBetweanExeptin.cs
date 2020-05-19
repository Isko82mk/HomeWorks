using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkClass10_Task_1.Exeption
{
    public class NumberNotBetweanExeptin : Exception
    {
        public NumberNotBetweanExeptin(){}

        public NumberNotBetweanExeptin(string mesage) : base(mesage){}
        
    }
}
