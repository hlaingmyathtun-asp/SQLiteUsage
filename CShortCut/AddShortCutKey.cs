using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CShortCut
{
    public partial class tAddEditShortCutKey : Form
    {

        private bool isEdit = false;

        private SQLiteAccess sql = new SQLiteAccess();

        private fZenTekAsia fZenTekAsia;

        private long selectedRow;



        public tAddEditShortCutKey()
        {
            InitializeComponent();
          
        }

       
        public tAddEditShortCutKey(fZenTekAsia fZenTek)
        {
            InitializeComponent();
            lblAddEditTitle.Text = "Add Short Cut Key";
            fZenTekAsia = fZenTek;
            isEdit = false;

        }

        public tAddEditShortCutKey(string edit,long rowIndex, fZenTekAsia fZenTek)
        {
            InitializeComponent();
            lblAddEditTitle.Text = edit;
            fZenTekAsia = fZenTek;
            selectedRow = rowIndex;
            isEdit = true;
        }
      







        private void btnSaved_Click(object sender, EventArgs e)
        {
            if(isEdit)
            {

                try
                {
                    var tableUpdate = SQLiteAccess.ReadSelectedShortCutKey(selectedRow);

                         if (tableUpdate == null)
                        {
                            MessageBox.Show("no record found for the selected row");
                        }
                         if (string.IsNullOrWhiteSpace(tbKeyboardShortCut.Text))
                        {
                            MessageBox.Show(" ShortCut key should not be blank");
                            return;
                        }
                        if (string.IsNullOrEmpty(tbDefinition.Text))
                        {
                            MessageBox.Show(" definition should not be blank");
                            return;

                        }

                        tableUpdate.ShortCutKey = tbKeyboardShortCut.Text;
                        tableUpdate.Definition = tbDefinition.Text;


                SQLiteAccess.EditShortCutKey(new CShortCutData
                {
                    id = tableUpdate.id,
                    Definition = tableUpdate.Definition,
                    ShortCutKey = tableUpdate.ShortCutKey,

                });

                        fZenTekAsia.Reloading();
                        MessageBox.Show("Successfully edited");

                        this.Close();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



            }
            else
            {

                try
                {
                    CShortCutData cShortCutData = new CShortCutData();
                    cShortCutData.ShortCutKey = tbKeyboardShortCut.Text;
                    cShortCutData.Definition = tbDefinition.Text;

                    SQLiteAccess.InsertShortCutKey(cShortCutData);

                    fZenTekAsia.Reloading();
                    MessageBox.Show("Successfully added");
                    
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               



            }

        }

        private void InsertShortCut(CShortCutData cshortCut)
        {
            SQLiteAccess.InsertShortCutKey(cshortCut);
            
        }

        private void btnCancelled_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
