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
    public partial class Form1 : Form
    {
        MyList<Mammalia> mamList;
        public Form1(MyList<Mammalia> mamList)
        {
            this.mamList = mamList;
            InitializeComponent();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            mamList.AddNode(new Mammalia());
            MessageBox.Show("Добавлена запись:\n\n" + (new Mammalia()).ToString());
            showSpeciesInListBBox();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button1_Click(object sender, EventArgs e) //addDefoultMammalia
        {
            mamList.AddNode(new Mammalia());
            MessageBox.Show("Добавлена запись:\n\n" + (new Mammalia()).ToString());
            showSpeciesInListBBox();
        }

        private void button2_Click(object sender, EventArgs e)//addMammalia
        {
            createNewMammaliaDialog createDlg = new createNewMammaliaDialog();
            mamList.AddNode(new Mammalia());
            PutDefoltParamsToDialog(createDlg);
            createDlg.ShowDialog();
            GetAllParamsFromDialog(mamList, createDlg);
            MessageBox.Show("Добавлена запись:\n\n" + mamList.GetHeadData().ToString());
            showSpeciesInListBBox();
        }

        private void dataListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataListBox_DoubleClick(object sender, EventArgs e)
        {
            int index = dataListBox.SelectedIndex;
            if (index == -1)
            {
                showSpeciesInListBBox();
            }
            else
            {
                int indexMammalia = -1;
                foreach (Mammalia m in mamList)
                {
                    indexMammalia++;
                    if (indexMammalia == index)
                    {
                        MessageBox.Show(m.ToString());
                        break;
                    }
                }
            }
        }

        private void redactMammalia_Click(object sender, EventArgs e)
        {
            createNewMammaliaDialog redactDlg;
            if (mamList.ExistHead() == true)
            {
                redactDlg = new createNewMammaliaDialog(mamList.GetHeadData());
            }
            else
            {
                MessageBox.Show("В списке нет ни одной записи.");
                return;
            }
            PutAllParamsToDialog(mamList, redactDlg);
            redactDlg.ShowDialog();
            GetAllParamsFromDialog(mamList, redactDlg);
            MessageBox.Show(mamList.GetHeadData().ToString());
            showSpeciesInListBBox();
        }

        private void PutAllParamsToDialog(MyList<Mammalia> mamList, createNewMammaliaDialog dlg)
        {
            dlg.MulticellularDlg = mamList.GetHeadData().Multicellular;
            dlg.AerobeDlg = mamList.GetHeadData().Aerobe;
            dlg.DioeciousDlg = mamList.GetHeadData().Dioecious;
            dlg.PhylumDlg = mamList.GetHeadData().Phylum;
            dlg.ClassisDlg = mamList.GetHeadData().Classis;
            dlg.SpeciesDlg = mamList.GetHeadData().Species;
            dlg.WeightDlg = mamList.GetHeadData().Weight;
            dlg.HabitatDlg1 = mamList.GetHeadData()[0];
            dlg.HabitatDlg2 = mamList.GetHeadData()[1];
            dlg.HabitatDlg3 = mamList.GetHeadData()[2];
            dlg.HabitatDlg4 = mamList.GetHeadData()[3];
        }
        private void PutDefoltParamsToDialog(createNewMammaliaDialog dlg)
        {
            dlg.MulticellularDlg = false;
            dlg.AerobeDlg = false;
            dlg.DioeciousDlg = false;
            dlg.PhylumDlg = "Хордовые";
            dlg.ClassisDlg = "Млекопитающие";
        }

        private void GetAllParamsFromDialog(MyList<Mammalia> mamList, createNewMammaliaDialog dlg)
        {
            mamList.GetHeadData().Multicellular = dlg.MulticellularDlg;
            mamList.GetHeadData().Aerobe = dlg.AerobeDlg;
            mamList.GetHeadData().Dioecious = dlg.DioeciousDlg;
            mamList.GetHeadData().Phylum = dlg.PhylumDlg;
            mamList.GetHeadData().Classis = dlg.ClassisDlg;
            if (dlg.SpeciesDlg == "")
            {
                dlg.SpeciesDlg = "Not defined";
            }
            mamList.GetHeadData().Species = dlg.SpeciesDlg;
            mamList.GetHeadData().Weight = dlg.WeightDlg;
            mamList.GetHeadData()[0] = dlg.HabitatDlg1;
            mamList.GetHeadData()[1] = dlg.HabitatDlg2;
            mamList.GetHeadData()[2] = dlg.HabitatDlg3;
            mamList.GetHeadData()[3] = dlg.HabitatDlg4;
            for (int i = 0; i < 4; i++)
            {
                if (mamList.GetHeadData()[i] == "")
                {
                    mamList.GetHeadData()[i] = "Not defined";
                }
            }
        }

        private void showSpeciesInListBBox()
        {
            dataListBox.Items.Clear();
            foreach (Mammalia m in mamList)
            {
                dataListBox.Items.Add(m.Species);
            }
        }

        private void deleteMammalia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Удалена запись\n\n" + mamList.GetHeadData().ToString());
            mamList.RemoveHead();
            showSpeciesInListBBox();
        }

        private void toolStripAddMammalia_Click(object sender, EventArgs e)
        {
            createNewMammaliaDialog createDlg = new createNewMammaliaDialog();
            mamList.AddNode(new Mammalia());
            PutDefoltParamsToDialog(createDlg);
            createDlg.ShowDialog();
            GetAllParamsFromDialog(mamList, createDlg);
            MessageBox.Show("Добавлена запись:\n\n" + mamList.GetHeadData().ToString());
            showSpeciesInListBBox();
        }

        private void toolStripRedactMammalia_Click(object sender, EventArgs e)
        {
            createNewMammaliaDialog redactDlg;
            if (mamList.ExistHead() == true)
            {
                redactDlg = new createNewMammaliaDialog(mamList.GetHeadData());
            }
            else
            {
                MessageBox.Show("В списке нет ни одной записи.");
                return;
            }
            PutAllParamsToDialog(mamList, redactDlg);
            redactDlg.ShowDialog();
            GetAllParamsFromDialog(mamList, redactDlg);
            MessageBox.Show(mamList.GetHeadData().ToString());
            showSpeciesInListBBox();
        }

        private void toolStripDeleteMammalia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Удалена запись\n\n" + mamList.GetHeadData().ToString());
            mamList.RemoveHead();
            showSpeciesInListBBox();
        }

        private void showHead_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mamList.GetHeadData().ToString());
        }

        private void showAll_Click(object sender, EventArgs e)
        {
            showAllItemsOfList showWin = new showAllItemsOfList(mamList);
            showWin.ShowDialog();
        }

        private void сПараметрамиПоУмолчаниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mamList.AddNode(new Mammalia());
            MessageBox.Show("Добавлена запись:\n\n" + (new Mammalia()).ToString());
            showSpeciesInListBBox();
        }

        private void сЗадаваемымиПараметрамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createNewMammaliaDialog createDlg = new createNewMammaliaDialog();
            mamList.AddNode(new Mammalia());
            PutDefoltParamsToDialog(createDlg);
            createDlg.ShowDialog();
            GetAllParamsFromDialog(mamList, createDlg);
            MessageBox.Show("Добавлена запись:\n\n" + mamList.GetHeadData().ToString());
            showSpeciesInListBBox();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createNewMammaliaDialog redactDlg;
            if (mamList.ExistHead() == true)
            {
                redactDlg = new createNewMammaliaDialog(mamList.GetHeadData());
            }
            else
            {
                MessageBox.Show("В списке нет ни одной записи.");
                return;
            }
            PutAllParamsToDialog(mamList, redactDlg);
            redactDlg.ShowDialog();
            GetAllParamsFromDialog(mamList, redactDlg);
            MessageBox.Show(mamList.GetHeadData().ToString());
            showSpeciesInListBBox();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Удалена запись\n\n" + mamList.GetHeadData().ToString());
            mamList.RemoveHead();
            showSpeciesInListBBox();
        }

        private void toolStripShowHead_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mamList.GetHeadData().ToString());
        }

        private void отобразитьГоловуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mamList.GetHeadData().ToString());
        }

        private void toolStripShowAll_Click(object sender, EventArgs e)
        {
            showAllItemsOfList showWin = new showAllItemsOfList(mamList);
            showWin.ShowDialog();
        }

        private void отобразитьВесьСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showAllItemsOfList showWin = new showAllItemsOfList(mamList);
            showWin.ShowDialog();
        }
    }
}
