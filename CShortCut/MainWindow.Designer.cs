namespace CShortCut
{
    partial class fZenTekAsia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fZenTekAsia));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvShortCutShow = new System.Windows.Forms.DataGridView();
            this.btnAddShortcut = new System.Windows.Forms.Button();
            this.btnEditShortCut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShortCutShow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome From Colletion Of Keyboard Short Cut";
            // 
            // dgvShortCutShow
            // 
            this.dgvShortCutShow.AllowUserToAddRows = false;
            this.dgvShortCutShow.AllowUserToDeleteRows = false;
            this.dgvShortCutShow.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvShortCutShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShortCutShow.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvShortCutShow.Location = new System.Drawing.Point(12, 48);
            this.dgvShortCutShow.Name = "dgvShortCutShow";
            this.dgvShortCutShow.Size = new System.Drawing.Size(585, 203);
            this.dgvShortCutShow.TabIndex = 1;
            // 
            // btnAddShortcut
            // 
            this.btnAddShortcut.Location = new System.Drawing.Point(12, 257);
            this.btnAddShortcut.Name = "btnAddShortcut";
            this.btnAddShortcut.Size = new System.Drawing.Size(75, 28);
            this.btnAddShortcut.TabIndex = 4;
            this.btnAddShortcut.Text = "Add";
            this.btnAddShortcut.UseVisualStyleBackColor = true;
            this.btnAddShortcut.Click += new System.EventHandler(this.btnAddShortcut_Click);
            // 
            // btnEditShortCut
            // 
            this.btnEditShortCut.Location = new System.Drawing.Point(267, 257);
            this.btnEditShortCut.Name = "btnEditShortCut";
            this.btnEditShortCut.Size = new System.Drawing.Size(75, 28);
            this.btnEditShortCut.TabIndex = 4;
            this.btnEditShortCut.Text = "Edit";
            this.btnEditShortCut.UseVisualStyleBackColor = true;
            this.btnEditShortCut.Click += new System.EventHandler(this.btnEditShortCut_Click);
            // 
            // fZenTekAsia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(609, 303);
            this.Controls.Add(this.btnEditShortCut);
            this.Controls.Add(this.btnAddShortcut);
            this.Controls.Add(this.dgvShortCutShow);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fZenTekAsia";
            this.Text = "Computer ShortCut";
            this.Load += new System.EventHandler(this.fZenTekAsia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShortCutShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvShortCutShow;
        private System.Windows.Forms.Button btnAddShortcut;
        private System.Windows.Forms.Button btnEditShortCut;
    }
}

