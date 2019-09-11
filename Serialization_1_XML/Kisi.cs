using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_1_XML
{
    [Serializable]
    public class Kisi
    {
        public string AdSoyad { get; set; }
        public int Yas { get; set; }

        public override string ToString()
        {
            return $"{AdSoyad} - {Yas}";
        }



    }
}
