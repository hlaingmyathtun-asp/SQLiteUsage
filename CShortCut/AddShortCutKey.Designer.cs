namespace CShortCut
{
    partial class tAddEditShortCutKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tAddEditShortCutKey));
            this.lblAddEditTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKeyboardShortCut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDefinition = new System.Windows.Forms.TextBox();
            this.btnSaved = new System.Windows.Forms.Button();
            this.btnCancelled = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAddEditTitle
            // 
            this.lblAddEditTitle.AutoSize = true;
            this.lblAddEditTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEditTitle.Location = new System.Drawing.Point(206, 30);
            this.lblAddEditTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddEditTitle.Name = "lblAddEditTitle";
            this.lblAddEditTitle.Size = new System.Drawing.Size(0, 26);
            this.lblAddEditTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Keyboard ShortCut :";
            // 
            // tbKeyboardShortCut
            // 
            this.tbKeyboardShortCut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKeyboardShortCut.Location = new System.Drawing.Point(206, 90);
            this.tbKeyboardShortCut.Name = "tbKeyboardShortCut";
            this.tbKeyboardShortCut.Size = new System.Drawing.Size(337, 26);
            this.tbKeyboardShortCut.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Definition :";
            // 
            // tbDefinition
            // 
            this.tbDefinition.Location = new System.Drawing.Point(206, 162);
            this.tbDefinition.Name = "tbDefinition";
            this.tbDefinition.Size = new System.Drawing.Size(337, 26);
            this.tbDefinition.TabIndex = 2;
            // 
            // btnSaved
            // 
            this.btnSaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaved.Location = new System.Drawing.Point(202, 211);
            this.btnSaved.Name = "btnSaved";
            this.btnSaved.Size = new System.Drawing.Size(101, 47);
            this.btnSaved.TabIndex = 3;
            this.btnSaved.Text = "Save";
            this.btnSaved.UseVisualStyleBackColor = true;
            this.btnSaved.Click += new System.EventHandler(this.btnSaved_Click);
            // 
            // btnCancelled
            // 
            this.btnCancelled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelled.Location = new System.Drawing.Point(438, 211);
            this.btnCancelled.Name = "btnCancelled";
            this.btnCancelled.Size = new System.Drawing.Size(101, 47);
            this.btnCancelled.TabIndex = 3;
            this.btnCancelled.Text = "Cancel";
            this.btnCancelled.UseVisualStyleBackColor = true;
            this.btnCancelled.Click += new System.EventHandler(this.btnCancelled_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(625, 252);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 20);
            this.lblId.TabIndex = 4;
            this.lblId.Visible = false;
            // 
            // tAddEditShortCutKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 284);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnCancelled);
            this.Controls.Add(this.btnSaved);
            this.Controls.Add(this.tbDefinition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbKeyboardShortCut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAddEditTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "tAddEditShortCutKey";
            this.Text = "Short Cut Key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddEditTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKeyboardShortCut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDefinition;
        private System.Windows.Forms.Button btnSaved;
        private System.Windows.Forms.Button btnCancelled;
        private System.Windows.Forms.Label lblId;
    }
}