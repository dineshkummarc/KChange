using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KChangeLogger.BaseClasses
{
    public partial class BaseContextForm : Form
    {

        public KChangeDataContextDataContext Data = new KChangeDataContextDataContext();
        public BaseContextForm()
        {
            InitializeComponent();
        }
    }
}
