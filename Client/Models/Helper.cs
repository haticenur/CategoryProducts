using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Client.Models
{
    public class Helper
    {
        static List<string> _sayfalar;

        public static List<string> Sayfalar
        {
            get
            {

                if (_sayfalar == null)
                {
                    _sayfalar = new List<string>();
                    _sayfalar.Add("");
                    _sayfalar.Add("");
                }

                return _sayfalar;
            }
            set { Helper._sayfalar = value; }

        }

    }
}