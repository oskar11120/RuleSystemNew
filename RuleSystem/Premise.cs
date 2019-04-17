﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSystem
{
    public abstract class Premise
    {

        public abstract bool? Verify();
        protected bool isBigger<T>(Variable<T> input1, Variable<T> input2)
        {
            if (!(input1 is Real) || !(input2 is Real)) throw new Exception();
            else
            {
                bool prawda = (((input1 as Real).Value as float?) > ((input2 as Real).Value as float?));
                return prawda;
            }
        }
        protected bool isSmaller<T>(Variable<T> input1, Variable<T> input2)
        {
            return isBigger(input2, input1);
        }
        protected static bool isEven<T>(Variable<T> input1, Variable<T> input2)
        {
            bool prawda = (input1.Value.Equals(input2.Value));
            return prawda;
        }
        protected bool isBiggerOrEven<T>(Variable<T> input1, Variable<T> input2)
        {
            return (isEven(input1, input2) || isBigger(input1, input2));
        }
        protected bool isSmallerOrEven<T>(Variable<T> input1, Variable<T> input2)
        {
            return (isEven(input2, input1) || isSmaller(input2, input1));
        }
        protected bool isNotEven<T>(Variable<T> input1, Variable<T> input2)
        {
            return !isEven(input1, input2);
        }
    }
}