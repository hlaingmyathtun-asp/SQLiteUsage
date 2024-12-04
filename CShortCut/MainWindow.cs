using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Threading;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Runtime.InteropServices.ComTypes;

namespace CShortCut
{
    public partial class fZenTekAsia : Form
    {
        List<CShortCutData> cShortCutDatas = new List<CShortCutData>();
        public fZenTekAsia()
        {
            InitializeComponent();
            
         
           
        }



        /// <summary>
        /// Loading SQL data (reading the table )
        /// </summary>
       public void LoadData()
        {
            cShortCutDatas = SQLiteAccess.LoadShortCut();
        }


        private void btnAddShortcut_Click(object sender, EventArgs e)
        {
           
            if (!FormUtiltiy.IsOpenForm("AddShortCutKey"))
            {

                var addShortCut = new tAddEditShortCutKey(this);
                addShortCut.ShowDialog();

            }
        }

       

        private void btnDeleteShortcut_Click(object sender, EventArgs e)
        {
            var id = (long) dgvShortCutShow.CurrentRow.Cells["id"].Value;
            SQLiteAccess.DeleteShortCutKey(id);
            Reloading();

        }

        private void btnEditShortCut_Click(object sender, EventArgs e)
        {
            if (!FormUtiltiy.IsOpenForm("AddShortCutKey"))
            {
                var id = (long)dgvShortCutShow.CurrentRow.Cells["id"].Value;
                var addShortCut = new tAddEditShortCutKey("Edit Short Cut Key",id,this);
                addShortCut.ShowDialog();

            }
        }

        /// <summary>
        /// Loading the window data from data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fZenTekAsia_Load(object sender, EventArgs e)
        {

            LoadData();
            dgvShortCutShow.DataSource = cShortCutDatas;

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Reloading();
        }

        public void Reloading()
        {

            LoadData();
            dgvShortCutShow.DataSource = cShortCutDatas;

            dgvShortCutShow.Update();
            dgvShortCutShow.Refresh();
        }

       
    }
}
