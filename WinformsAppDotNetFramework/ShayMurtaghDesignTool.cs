using ConcreteBridgeBeams;
using ShayMurtaghClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsAppDotNetFramework.Helpers;

namespace WinformsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            PopulateOptimumDesignTable();
            PopulateBeamTable(ybeamTypes, dgvYbeams);
            PopulateBeamTable(boxbeamTypes, dgvBoxbeams);

            //PopulateBeamTable(ubeamTypes, dgvUbeams);
        }

        private List<string> ybeamTypes = new List<string> { "Y1", "Y2", "Y3", "Y4", "Y5", "Y6", "Y7", "Y8" };
        private List<string> ubeamTypes = new List<string> { "U1", "U3", "U5", "U7", "U8", "U9", "U10", "U11", "U12" };
        private List<string> boxbeamTypes = new List<string> { "Box300", "Box400", "Box500", "Box600", "Box700", "Box800"};


        private void PopulateOptimumDesignTable()
        {
            DGVHelpers.RemoveAllRows(dgvOptimumDesigns);

            double dmax = double.Parse(txtDmax.Text);
            double L = double.Parse(txtL.Text);

            BeamCatalogue beamCatalogue = new BeamCatalogue();
            List<IBeam> fullCatalogue = beamCatalogue.GetFullCatalogue();

            SuitableSections ss = new SuitableSections(L, dmax, fullCatalogue);
            var suitableDesigns = ss.GetSuitableSections();

            //Parse to dgv
            int numberOfDesigns = suitableDesigns.Count();
            int counter = 0;

            foreach (DesignVerification design in suitableDesigns)
            {
                dgvOptimumDesigns.Rows.Add();
                dgvOptimumDesigns.Rows[counter].Cells[0].Value = design.Beam.Type;
                dgvOptimumDesigns.Rows[counter].Cells[1].Value = design.Beam.Spacing;
                dgvOptimumDesigns.Rows[counter].Cells[2].Value = design.Beam.Lmin;
                dgvOptimumDesigns.Rows[counter].Cells[3].Value = design.Beam.Lmax;
                dgvOptimumDesigns.Rows[counter].Cells[4].Value = design.Beam.Dbeam;
                dgvOptimumDesigns.Rows[counter].Cells[5].Value = design.Beam.Dslab;
                dgvOptimumDesigns.Rows[counter].Cells[6].Value = design.Beam.Dtot;
                dgvOptimumDesigns.Rows[counter].Cells[7].Value = "";
                dgvOptimumDesigns.Rows[counter].Cells[8].Value = design.Util;
                dgvOptimumDesigns.Rows[counter].Cells[9].Value = design.RemainingDepth;
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
            var catalogue = new BeamCatalogue();
            List<IBeam> fullCatalogue = catalogue.GetFullCatalogue();

            int counter = 0;

            foreach (string beamType in beamTypes)
            {
                //Add a row to dgv
                dgv.Rows.Add();

                //Get a list of YX beam arrangements, sorted by spacing from smallest to largest. 
                List<IBeam> beamTypeSpacings = fullCatalogue.Where(x => x.Type.Contains(beamType)).ToList().OrderBy(x => x.Spacing).ToList();

                //Set the type column to the type e.g. Y8 of the first object in the ybeamTypeSpacings List. 
                dgvYbeams.Rows[counter].Cells[0].Value = beamTypeSpacings[0].Type;

                //For each of the 1m/2m/3m spacings, create a design verification and output "sectionok" to the respective column. 
                for (int i = 0; i < beamTypeSpacings.Count; i++)
                {
                    var verification = new DesignVerification(beamTypeSpacings[i], L, dmax);
                    if (verification.sectionOk)
                    {
                        dgv.Rows[counter].Cells[i + 1].Style.ForeColor = System.Drawing.Color.Green;
                        dgv.Rows[counter].Cells[i + 1].Value = "✔";
                        dgv.Rows[counter].Cells[8].Value = verification.RemainingDepth;
                    }
                    else
                    {
                        dgv.Rows[counter].Cells[i + 1].Style.ForeColor = System.Drawing.Color.Red;
                        dgv.Rows[counter].Cells[i + 1].Value = "X";
                        dgv.Rows[counter].Cells[8].Value = "N/A";
                        dgv.Rows[counter].Cells[8].Style.ForeColor = System.Drawing.Color.LightGray;

                    }

                    dgv.Rows[counter].Cells[5].Value = beamTypeSpacings[0].Dbeam;
                    dgv.Rows[counter].Cells[6].Value = beamTypeSpacings[0].Dslab;
                    dgv.Rows[counter].Cells[7].Value = beamTypeSpacings[0].Dtot;
                }

                counter++;
            }
        }







        #region Event Graveyward

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }
    }
}
