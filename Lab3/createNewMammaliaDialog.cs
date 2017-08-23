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
    public partial class createNewMammaliaDialog : Form
    {
        bool multicellularDlg = false;
        bool aerobeDlg = false;
        bool dioeciousDlg = false;
        string phylumDlg = "Хордовые";
        string classisDlg = "Млекопитающие";
        string speciesDlg = "Not defined";
        int weightDlg = 0;
        string habitatDlg1 = "Not defined";
        string habitatDlg2 = "Not defined";
        string habitatDlg3 = "Not defined";
        string habitatDlg4 = "Not defined";

        public createNewMammaliaDialog(bool multicellular = false, bool aerobe = false, bool dioecious = false,
            string phylum = "Хордовые", string classis = "Млекопитающие",
            string species = "Not defined", int weight = 0, string habitat1 = "Not defined",
            string habitat2 = "Not defined", string habitat3 = "Not defined", string habitat4 = "Not defined")
        {
            multicellularDlg = multicellular;
            aerobeDlg = aerobe;
            dioeciousDlg = dioecious;
            phylumDlg = phylum;
            classisDlg = classis;
            speciesDlg = species;
            weightDlg = weight;
            habitatDlg1 = habitat1;
            habitatDlg2 = habitat2;
            habitatDlg3 = habitat3;
            habitatDlg4 = habitat4;
            InitializeComponent();
        }
        Mammalia mam;
        public createNewMammaliaDialog(Mammalia mam)
        {
            this.mam = mam;
            multicellularDlg = mam.Multicellular;
            aerobeDlg = mam.Aerobe;
            dioeciousDlg = mam.Dioecious;
            phylumDlg = mam.Phylum;
            classisDlg = mam.Classis;
            speciesDlg = mam.Species;
            weightDlg = mam.Weight;
            habitatDlg1 = mam[0];
            habitatDlg2 = mam[1];
            habitatDlg3 = mam[2];
            habitatDlg4 = mam[3];
            InitializeComponent();
        }

        public bool MulticellularDlg
        {
            set
            {
                radioMulticellularYes.Checked = value;
                radioMulticellularNo.Checked = !value;
            }
            get
            { return multicellularDlg; }
        }

        public bool AerobeDlg
        {
            set
            {
                checkBoxAerobeYes.Checked = value;
                checkBoxAerobeNo.Checked = !value;
            }
            get
            { return aerobeDlg; }
        }
        public bool DioeciousDlg
        {
            set
            {
                checkBoxDioeciousYes.Checked = value;
                checkBoxDioeciousNo.Checked = !value;
            }
            get
            { return dioeciousDlg; }
        }

        public string PhylumDlg
        {
            set
            { this.textBoxPhylum.Text = value; }
            get
            { return this.textBoxPhylum.Text; }
        }

        public string ClassisDlg
        {
            set
            { this.textBoxClassis.Text = value; }
            get
            { return this.textBoxClassis.Text; }
        }

        public string SpeciesDlg
        {
            set
            { this.textBoxSpecies.Text = value; }
            get
            { return this.textBoxSpecies.Text; }
        }
        public int WeightDlg
        {
            set
            { numericUpDownWeight.Value = value; }
            get
            { return (int)numericUpDownWeight.Value; }
        }

        public string HabitatDlg1
        {
            set
            { this.textBoxHabitat1.Text = value; }
            get
            { return this.textBoxHabitat1.Text; }
        }
        public string HabitatDlg2
        {
            set
            { this.textBoxHabitat2.Text = value; }
            get
            { return this.textBoxHabitat2.Text; }
        }
        public string HabitatDlg3
        {
            set
            { this.textBoxHabitat3.Text = value; }
            get
            { return this.textBoxHabitat3.Text; }
        }
        public string HabitatDlg4
        {
            set
            { this.textBoxHabitat4.Text = value; }
            get
            { return this.textBoxHabitat4.Text; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }


        private void radioMulticellularYes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMulticellularYes.Checked)
            {
                multicellularDlg = true;
            }
            if (radioMulticellularNo.Checked)
            {
                multicellularDlg = false;
            }
        }

        private void radioMulticellularNo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMulticellularYes.Checked)
            {
                multicellularDlg = true;
            }
            if (radioMulticellularNo.Checked)
            {
                multicellularDlg = false;
            }
        }

        private void checkBoxAerobeYes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAerobeYes.Checked)
            {
                aerobeDlg = true;
                checkBoxAerobeNo.Checked = false;
                checkBoxAerobeYes.Checked = true;
            }
            if (checkBoxAerobeNo.Checked)
            {
                aerobeDlg = false;
                checkBoxAerobeNo.Checked = true;
                checkBoxAerobeYes.Checked = false;
            }
        }

        private void checkBoxAerobeNo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAerobeNo.Checked)
            {
                aerobeDlg = false;
                checkBoxAerobeNo.Checked = true;
                checkBoxAerobeYes.Checked = false;
            }
            else
            {
                aerobeDlg = true;
                checkBoxAerobeNo.Checked = false;
                checkBoxAerobeYes.Checked = true;
            }
        }

        private void checkBoxDioeciousYes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDioeciousYes.Checked)
            {
                dioeciousDlg = true;
                checkBoxDioeciousNo.Checked = false;
                checkBoxDioeciousYes.Checked = true;
            }
            else
            {
                dioeciousDlg = false;
                checkBoxDioeciousNo.Checked = true;
                checkBoxDioeciousYes.Checked = false;
            }
        }

        private void checkBoxDioeciousNo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDioeciousNo.Checked)
            {
                dioeciousDlg = false;
                checkBoxDioeciousNo.Checked = true;
                checkBoxDioeciousYes.Checked = false;
            }
            else
            {
                dioeciousDlg = true;
                checkBoxDioeciousNo.Checked = false;
                checkBoxDioeciousYes.Checked = true;
            }
        }

        private void exitDiolog_Click(object sender, EventArgs e)
        {
            if (mam != null)
            {
                this.MulticellularDlg = mam.Multicellular;
                this.AerobeDlg = mam.Aerobe;
                this.DioeciousDlg = mam.Dioecious;
                this.PhylumDlg = mam.Phylum;
                this.ClassisDlg = mam.Classis;
                this.SpeciesDlg = mam.Species;
                this.WeightDlg = mam.Weight;
                this.HabitatDlg1 = mam[0];
                this.HabitatDlg2 = mam[1];
                this.HabitatDlg3 = mam[2];
                this.HabitatDlg4 = mam[3];
            }
        }
    }
}
