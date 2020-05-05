using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Laba1
{
    class Class_country
    {
        public string Name;
        public string President;
        public int Square;
        public int Amount;
        public string Timezone;


        public Class_country(string _name, string _president, int _square, int _amount, string _timezone)
        {
            Name = _name;
            President = _president;
            Square = _square;
            Amount = _amount;
            Timezone = _timezone;

            if(!Regex.IsMatch(Name, @"^[\p{L}\p{M}' \.\-]+$") || !Regex.IsMatch(President, @"^[\p{L}\p{M}' \.\-]+$") )
            {
                throw new Exception("Invalid string data!");
            }

        }

        

    }
}
