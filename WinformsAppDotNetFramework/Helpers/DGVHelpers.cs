using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsAppDotNetFramework.Helpers
{
    public static class DGVHelpers
    {
        public static void RemoveAllRows(DataGridView dgv)
        {
            do
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    try
                    {
                        dgv.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (dgv.Rows.Count > 1);
        }
    }
}
