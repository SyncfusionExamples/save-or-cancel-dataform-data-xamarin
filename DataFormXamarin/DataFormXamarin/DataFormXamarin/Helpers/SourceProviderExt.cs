using Syncfusion.XForms.DataForm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataFormXamarin
{
    public class SourceProviderExt : SourceProvider
    {
        public override IList GetSource(string sourceName)
        {
            var list = new List<string>();
            if (sourceName == "Fruits")
            {
                list.Add("Apple");
                list.Add("Orange");
                list.Add("Pine Apple");
            }
            return list;
        }
    }
}
