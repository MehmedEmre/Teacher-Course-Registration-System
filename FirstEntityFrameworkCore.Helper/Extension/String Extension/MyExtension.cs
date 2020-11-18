using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FirstEntityFrameworkCore.Helper.Extension.String_Extension
{
    public static class MyExtension
    {

        public static String MyTrimAndToLowerFunction(this String value)
        {
            String[] valueArray = value.ToLower().Split(' ');

            String newValue = "";

            foreach (String item in valueArray)
            {
                if (item != " ")
                {
                    newValue = newValue + item;
                }
            }

            return newValue;
        }

        public static String MyFirstLetterCapital(this String value)
        {

            String newValue = value.ToLower();

            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(newValue);
        }


    }

}
