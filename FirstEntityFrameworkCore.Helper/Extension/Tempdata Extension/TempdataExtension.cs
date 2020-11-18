using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEntityFrameworkCore.Helper.Extension.Tempdata_Extension
{
    public static class TempdataExtension
    {
        public static void MyPut<T>(this ITempDataDictionary tempdata, string key, T value) where T : class
        {
            tempdata[key] = JsonConvert.SerializeObject(value);
        }

        public static T MyGet<T>(this ITempDataDictionary tempdata, string key) where T : class
        {
            object o;

            tempdata.TryGetValue(key, out o);

            return o == null ? null : JsonConvert.DeserializeObject<T>((string)o);
        }

    }
}
