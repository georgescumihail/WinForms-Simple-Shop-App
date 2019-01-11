namespace Mihail_Georgescu_1051_Project
{
    partial class Edit_Form
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
            this.components = new System.ComponentModel.Container();
            this.tbEditNume = new System.Windows.Forms.TextBox();
            this.tbEditPrenume = new System.Windows.Forms.TextBox();
            this.tbEditAdresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEditSalveaza = new System.Windows.Forms.Button();
            this.epNumeEdit = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPrenumeEdit = new System.Windows.Forms.ErrorProvider(this.components);
            this.epAdresaEdit = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epNumeEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrenumeEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAdresaEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEditNume
            // 
            this.tbEditNume.Location = new System.Drawing.Point(129, 78);
            this.tbEditNume.Name = "tbEditNume";
            this.tbEditNume.Size = new System.Drawing.Size(159, 22);
            this.tbEditNume.TabIndex = 0;
            // 
            // tbEditPrenume
            // 
            this.tbEditPrenume.Location = new System.Drawing.Point(129, 141);
            this.tbEditPrenume.Name = "tbEditPrenume";
            this.tbEditPrenume.Size = new System.Drawing.Size(159, 22);
            this.tbEditPrenume.TabIndex = 1;
            // 
            // tbEditAdresa
            // 
            this.tbEditAdresa.Location = new System.Drawing.Point(129, 201);
            this.tbEditAdresa.Name = "tbEditAdresa";
            this.tbEditAdresa.Size = new System.Drawing.Size(159, 22);
            this.tbEditAdresa.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address";
            // 
            // tbEditSalveaza
            // 
            this.tbEditSalveaza.BackColor = System.Drawing.SystemColors.Highlight;
            this.tbEditSalveaza.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbEditSalveaza.Location = new System.Drawing.Point(168, 265);
            this.tbEditSalveaza.Name = "tbEditSalveaza";
            this.tbEditSalveaza.Size = new System.Drawing.Size(120, 35);
            this.tbEditSalveaza.TabIndex = 7;
            this.tbEditSalveaza.Text = "Save";
            this.tbEditSalveaza.UseVisualStyleBackColor = false;
            this.tbEditSalveaza.Click += new System.EventHandler(this.tbEditSalveaza_Click);
            // 
            // epNumeEdit
            // 
            this.epNumeEdit.ContainerControl = this;
            // 
            // epPrenumeEdit
            // 
            this.epPrenumeEdit.ContainerControl = this;
            // 
            // epAdresaEdit
            // 
            this.epAdresaEdit.ContainerControl = this;
            // 
            // Edit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 344);
            this.Controls.Add(this.tbEditSalveaza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEditAdresa);
            this.Controls.Add(this.tbEditPrenume);
            this.Controls.Add(this.tbEditNume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Edit_Form";
            this.Text = "New Client";
            this.Load += new System.EventHandler(this.Edit_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epNumeEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrenumeEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAdresaEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEditNume;
        private System.Windows.Forms.TextBox tbEditPrenume;
        private System.Windows.Forms.TextBox tbEditAdresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button tbEditSalveaza;
        private System.Windows.Forms.ErrorProvider epNumeEdit;
        private System.Windows.Forms.ErrorProvider epPrenumeEdit;
        private System.Windows.Forms.ErrorProvider epAdresaEdit;
    }
}