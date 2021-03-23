using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString;

            inputString = Console.ReadLine();
            
            // Console.WriteLine("Hello, World.");
            // Console.WriteLine(inputString);

            var valuePattern = @"[\d]+(?=[a-z]+\^)?";
            var variablePattern = @"(?<=[\d])?[a-z]+";
            var powerPattern = @"(?<=\^)[\d]+";

            var _value = 0;
            var _variables = new List<Variable>();
            var _power = 0;
            if(!int.TryParse(new Regex(valuePattern).Match(inputString).ToString(), out _value)) _value = 1;
            var variables = new Regex(variablePattern).Matches(inputString);
            var powers = new Regex(powerPattern).Matches(inputString);

            for(var i=0;i<variables.Count;i++)
            {
                var varBase = variables[i].ToString();
                var varPower = powers.Count > 0 ? powers[i].ToString() : null;
                // _variables.Add(new Variable(variables[i].ToString(), powers[i]?.ToString()));
                _variables.Add(new Variable(varBase, varPower));
            }
            
            Console.WriteLine(_value);
            foreach (var _variable in _variables)
            {
                Console.WriteLine(_variable.Evaluate());
            }

        }
    }

    internal class Variable
    {
        private readonly string _base;
        private readonly int _power;

        public Variable(string varBase, string power)
        {
            _base = varBase;
            if(!int.TryParse(power, out _power)) _power = 0;
        }

        public string Evaluate()
        {
            return _power > 0 ? $"{_base}^{_power}" : _base;
        }
    }
}