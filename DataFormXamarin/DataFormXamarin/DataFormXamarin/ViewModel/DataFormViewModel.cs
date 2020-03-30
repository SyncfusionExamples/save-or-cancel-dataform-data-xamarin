using System;
using System.Collections.Generic;
using System.Text;

namespace DataFormXamarin
{

    public class DataFormViewModel
    {
        private DataFormModel dataObject;
        public DataFormModel DataObject
        {
            get { return this.dataObject; }
            set { this.dataObject = value; }
        }
        public DataFormViewModel()
        {
            this.dataObject = new DataFormModel();
        }
    }
}
