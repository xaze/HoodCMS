using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HoodCMS.Web
{
    public class Helpers
    {
        public static string Headline(string text)
        {
            return string.Format("<div class=\"headline\"><h2 class=\"Orange\">{0}</h2></div", text);
        }
    }
}