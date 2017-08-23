using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class showAllItemsOfList : Form
    {
        MyList<Mammalia> mamList;
        public showAllItemsOfList(MyList<Mammalia> mamList)
        {
            this.mamList = mamList;
            InitializeComponent();
            listBoxShowAllItems.Items.Clear();
            foreach (Mammalia m in mamList)
            {
                listBoxShowAllItems.Items.Add(m.ToString());
            }
        }

        private void listBoxShowAllItems_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}

