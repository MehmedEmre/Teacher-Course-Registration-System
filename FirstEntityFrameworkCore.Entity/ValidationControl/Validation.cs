using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEntityFrameworkCore.Entity.ValidationControl
{
    public class Validation<T>:IDisposable
    {
        public T objectModel { set; get; }

        public List<String> ErrorList { set; get; }


        public Validation()
        {
            ErrorList = new List<String>();
        }

        public void Dispose()
        {
          
        }
    }
}
