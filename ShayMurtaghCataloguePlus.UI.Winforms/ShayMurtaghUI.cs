using ShayMurtaghClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using WinformsAppDotNetFramework;
using WinformsAppDotNetFramework.Helpers;

namespace WinformsApp
{
    public partial class ShayMurtaghUI : Form
    {
        public ShayMurtaghUI()
        {
            Thread t = new Thread(new ThreadStart(splash));
            t.Start();
            Thread.Sleep(2500);
            t.Abort();
            InitializeComponent();
        }

        public void splash()
        {
            Application.Run(new SPLASH());
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            //Validate L and Dmax textboxes. 

            double l = 0;
            double dmax = 0;

            bool isLValid = double.TryParse(txtL.Text, out l);
            bool isDmaxValid = double.TryParse(txtDmax.Text, out dmax);

            if (isLValid && isDmaxValid && l>=0 && dmax >=0 )
            {
                PopulateOptimumDesignTable();
                PopulateBeamTable(ybeamTypes, dgvYbeams);
                PopulateBeamTable(ubeamTypes, dgvUbeams);
                PopulateBeamTable(boxbeamTypes, dgvBoxbeams);
                PopulateBeamTable(tbeamTypes, dgvTBeams);
                PopulateBeamTable(tybeamTypes, dgvTYbeams);
                PopulateBeamTable(wbeamTypes, dgvWbeams);
                PopulateBeamTable(mbeamTypes, dgvMbeams);
                PopulateBeamTable(mybeamTypes, dgvMybeams);
            }
            else
            {
                MessageBox.Show("Invalid values for L and Dmax entered - please check input and try again.");
            }           
        }

        private List<string> ybeamTypes = new List<string> { "Y1", "Y2", "Y3", "Y4", "Y5", "Y6", "Y7", "Y8" };
        private List<string> ubeamTypes = new List<string> { "U1", "U3", "U5", "U7", "U8", "U9", "U10", "U11", "U12" };
        private List<string> boxbeamTypes = new List<string> { "Box300", "Box400", "Box500", "Box600", "Box700", "Box800" };
        private List<string> tbeamTypes = new List<string> { "T1", "T2", "T3", "T4", "T5", "T6", "T7", "T8", "T9", "T10" };
        private List<string> tybeamTypes = new List<string> { "TY1", "TY2", "TY3", "TY4", "TY5", "TY6", "TY7", "TY8", "TY9", "TY10", "TY11" };
        private List<string> wbeamTypes = new List<string> { "W1", "W3", "W5", "W7", "W8", "W9", "W10", "W11", "W12", "W12", "W13", "W14", "W15", "W16", "W17", "W18", "W19" };
        private List<string> mbeamTypes = new List<string> { "M2", "M3", "M4", "M5", "M6", "M7", "M8", "M9", "M10" };
        private List<string> mybeamTypes = new List<string> { "MY1", "MY2", "MY3", "MY4", "MY5", "MY6", "MY7" };

        private void PopulateOptimumDesignTable()
        {
            DGVHelpers.RemoveAllRows(dgvOptimumDesigns);

            double dmax = double.Parse(txtDmax.Text);
            double L = double.Parse(txtL.Text);

            IManufacturer beamCatalogue = new ShayMurtagh();
            List<IBeam> fullCatalogue = beamCatalogue.GetFullCatalogue();

            SuitableSections ss = new SuitableSections(L, dmax, fullCatalogue);
            List<DesignVerification> suitableDesigns = ss.GetSuitableSections();

            //Add a row in the dgv for each suitable section, keeping track of row index using
            //variable counter.             
            int counter = 0;
            foreach (DesignVerification design in suitableDesigns)
            {
                dgvOptimumDesigns.Rows.Add();
                dgvOptimumDesigns.Rows[counter].Cells[0].Value = design.Beam.Type;
                dgvOptimumDesigns.Rows[counter].Cells[1].Value = design.Beam.Spacing;
                dgvOptimumDesigns.Rows[counter].Cells[2].Value = design.Beam.Lmin;
                dgvOptimumDesigns.Rows[counter].Cells[3].Value = design.Beam.Lmax;
                dgvOptimumDesigns.Rows[counter].Cells[4].Value = design.Beam.Dtot;
                dgvOptimumDesigns.Rows[counter].Cells[5].Value = design.RemainingDepth;
                counter++;
            }

            if (suitableDesigns.Count == 0)
            {
                MessageBox.Show("No suitable designs found!");
            }
        }

        private void PopulateBeamTable(List<string> beamTypes, DataGridView dgv)
        {
            DGVHelpers.RemoveAllRows(dgv);

            //Design data
            double dmax = double.Parse(txtDmax.Text);
            double L = double.Parse(txtL.Text);

            //Get a list of Y8 Beams 
            var catalogue = new ShayMurtagh();
            List<IBeam> fullCatalogue = catalogue.GetFullCatalogue();

            int counter = 0;

            foreach (string beamType in beamTypes)
            {
                //Add a row to dgv
                dgv.Rows.Add();

                //Get a list of YX beam arrangements, sorted by spacing from smallest to largest. 
                List<IBeam> beamTypeSpacings = fullCatalogue.Where(x => x.Type == beamType).ToList().OrderBy(x => x.Spacing).ToList();

                //Set the type column to the type e.g. Y8 of the first object in the ybeamTypeSpacings List. 
                dgv.Rows[counter].Cells[0].Value = beamTypeSpacings[0].Type;

                //For each of the 1m/2m/3m spacings, create a design verification and output "sectionok" to the respective column. 
                for (int i = 0; i < beamTypeSpacings.Count; i++)
                {
                    var verification = new DesignVerification(beamTypeSpacings[i], L, dmax);
                    if (verification.sectionOk)
                    {
                        dgv.Rows[counter].Cells[i + 1].Style.ForeColor = System.Drawing.Color.Green;
                        dgv.Rows[counter].Cells[i + 1].Value = "✔";
                        dgv.Rows[counter].Cells[8].Value = verification.RemainingDepth;
                        dgv.Rows[counter].Cells[8].Style.ForeColor = System.Drawing.Color.Black;
                    }
                    else
                    {
                        dgv.Rows[counter].Cells[i + 1].Style.ForeColor = System.Drawing.Color.Red;
                        dgv.Rows[counter].Cells[i + 1].Value = "X";
                        dgv.Rows[counter].Cells[8].Value = "N/A";
                        dgv.Rows[counter].Cells[8].Style.ForeColor = System.Drawing.Color.LightGray;

                    }
                }

                //Report Db+Dslab+Dtotal, and RemDepth if any of the spacings are acceptable
                dgv.Rows[counter].Cells[5].Value = beamTypeSpacings[0].Dbeam;
                dgv.Rows[counter].Cells[6].Value = beamTypeSpacings[0].Dslab;
                dgv.Rows[counter].Cells[7].Value = beamTypeSpacings[0].Dtot;

                counter++;

                DeleteLastRowIfBlank(dgv);
            }
        }

        private void DeleteLastRowIfBlank(DataGridView dgv)
        {
            if (dgv.Rows[dgv.Rows.Count-1].Cells[0].Value == "")
            {
                dgv.Rows.RemoveAt(dgv.Rows.Count - 1);
            }

        }






        #region EventHandler Graveyard

        private void btnCalculate_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void ShayMurtaghUI_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tpUBeam_Click(object sender, EventArgs e)
        {

        }

        private void dgvTBeams_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        #endregion

        
    }
}
