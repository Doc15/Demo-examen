using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SystAnalys_lr1
{
    public partial class frmAnalysis : Form
    {
        public frmAnalysis()
        {
            InitializeComponent();
        }
        public void SetNodes(clsNode[] nodes)
        {
            olvNodes.SetObjects(nodes);
        }
    }
}
