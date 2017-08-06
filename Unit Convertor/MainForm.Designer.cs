using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace UnitConvertor
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MMBTU = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.MWH = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TCF = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.THERM = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.MTPA = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.GJ = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.MMTOE = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TCM = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.CUBICFEET = new MaterialSkin.Controls.MaterialLabel();
            this.CUBICMETERS = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.MMBOE = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // MMBTU
            // 
            this.MMBTU.Depth = 0;
            this.MMBTU.Hint = "";
            this.MMBTU.Location = new System.Drawing.Point(12, 138);
            this.MMBTU.MaxLength = 32767;
            this.MMBTU.MouseState = MaterialSkin.MouseState.HOVER;
            this.MMBTU.Name = "MMBTU";
            this.MMBTU.PasswordChar = '\0';
            this.MMBTU.SelectedText = "";
            this.MMBTU.SelectionLength = 0;
            this.MMBTU.SelectionStart = 0;
            this.MMBTU.Size = new System.Drawing.Size(100, 23);
            this.MMBTU.TabIndex = 7;
            this.MMBTU.TabStop = false;
            this.MMBTU.UseSystemPasswordChar = false;
            this.MMBTU.TextChanged += new System.EventHandler(this.MMBTU_TextChanged);
            // 
            // MWH
            // 
            this.MWH.Depth = 0;
            this.MWH.Hint = "";
            this.MWH.Location = new System.Drawing.Point(153, 138);
            this.MWH.MaxLength = 32767;
            this.MWH.MouseState = MaterialSkin.MouseState.HOVER;
            this.MWH.Name = "MWH";
            this.MWH.PasswordChar = '\0';
            this.MWH.SelectedText = "";
            this.MWH.SelectionLength = 0;
            this.MWH.SelectionStart = 0;
            this.MWH.Size = new System.Drawing.Size(100, 23);
            this.MWH.TabIndex = 9;
            this.MWH.TabStop = false;
            this.MWH.UseSystemPasswordChar = false;
            this.MWH.TextChanged += new System.EventHandler(this.MWH_TextChanged);
            // 
            // TCF
            // 
            this.TCF.Depth = 0;
            this.TCF.Hint = "";
            this.TCF.Location = new System.Drawing.Point(153, 75);
            this.TCF.MaxLength = 32767;
            this.TCF.MouseState = MaterialSkin.MouseState.HOVER;
            this.TCF.Name = "TCF";
            this.TCF.PasswordChar = '\0';
            this.TCF.SelectedText = "";
            this.TCF.SelectionLength = 0;
            this.TCF.SelectionStart = 0;
            this.TCF.Size = new System.Drawing.Size(100, 23);
            this.TCF.TabIndex = 10;
            this.TCF.TabStop = false;
            this.TCF.UseSystemPasswordChar = false;
            this.TCF.TextChanged += new System.EventHandler(this.TCF_TextChanged);
            // 
            // THERM
            // 
            this.THERM.Depth = 0;
            this.THERM.Hint = "";
            this.THERM.Location = new System.Drawing.Point(12, 210);
            this.THERM.MaxLength = 32767;
            this.THERM.MouseState = MaterialSkin.MouseState.HOVER;
            this.THERM.Name = "THERM";
            this.THERM.PasswordChar = '\0';
            this.THERM.SelectedText = "";
            this.THERM.SelectionLength = 0;
            this.THERM.SelectionStart = 0;
            this.THERM.Size = new System.Drawing.Size(100, 23);
            this.THERM.TabIndex = 11;
            this.THERM.TabStop = false;
            this.THERM.UseSystemPasswordChar = false;
            this.THERM.TextChanged += new System.EventHandler(this.THERM_TextChanged);
            // 
            // MTPA
            // 
            this.MTPA.Depth = 0;
            this.MTPA.Hint = "";
            this.MTPA.Location = new System.Drawing.Point(12, 75);
            this.MTPA.MaxLength = 32767;
            this.MTPA.MouseState = MaterialSkin.MouseState.HOVER;
            this.MTPA.Name = "MTPA";
            this.MTPA.PasswordChar = '\0';
            this.MTPA.SelectedText = "";
            this.MTPA.SelectionLength = 0;
            this.MTPA.SelectionStart = 0;
            this.MTPA.Size = new System.Drawing.Size(100, 23);
            this.MTPA.TabIndex = 12;
            this.MTPA.TabStop = false;
            this.MTPA.UseSystemPasswordChar = false;
            this.MTPA.TextChanged += new System.EventHandler(this.MTPA_TextChanged);
            // 
            // GJ
            // 
            this.GJ.Depth = 0;
            this.GJ.Hint = "";
            this.GJ.Location = new System.Drawing.Point(153, 210);
            this.GJ.MaxLength = 32767;
            this.GJ.MouseState = MaterialSkin.MouseState.HOVER;
            this.GJ.Name = "GJ";
            this.GJ.PasswordChar = '\0';
            this.GJ.SelectedText = "";
            this.GJ.SelectionLength = 0;
            this.GJ.SelectionStart = 0;
            this.GJ.Size = new System.Drawing.Size(100, 23);
            this.GJ.TabIndex = 13;
            this.GJ.TabStop = false;
            this.GJ.UseSystemPasswordChar = false;
            this.GJ.TextChanged += new System.EventHandler(this.GJ_TextChanged);
            // 
            // MMTOE
            // 
            this.MMTOE.Depth = 0;
            this.MMTOE.Hint = "";
            this.MMTOE.Location = new System.Drawing.Point(294, 210);
            this.MMTOE.MaxLength = 32767;
            this.MMTOE.MouseState = MaterialSkin.MouseState.HOVER;
            this.MMTOE.Name = "MMTOE";
            this.MMTOE.PasswordChar = '\0';
            this.MMTOE.SelectedText = "";
            this.MMTOE.SelectionLength = 0;
            this.MMTOE.SelectionStart = 0;
            this.MMTOE.Size = new System.Drawing.Size(100, 23);
            this.MMTOE.TabIndex = 14;
            this.MMTOE.TabStop = false;
            this.MMTOE.UseSystemPasswordChar = false;
            this.MMTOE.TextChanged += new System.EventHandler(this.MMTOE_TextChanged);
            // 
            // TCM
            // 
            this.TCM.Depth = 0;
            this.TCM.Hint = "";
            this.TCM.Location = new System.Drawing.Point(294, 75);
            this.TCM.MaxLength = 32767;
            this.TCM.MouseState = MaterialSkin.MouseState.HOVER;
            this.TCM.Name = "TCM";
            this.TCM.PasswordChar = '\0';
            this.TCM.SelectedText = "";
            this.TCM.SelectionLength = 0;
            this.TCM.SelectionStart = 0;
            this.TCM.Size = new System.Drawing.Size(100, 23);
            this.TCM.TabIndex = 15;
            this.TCM.TabStop = false;
            this.TCM.UseSystemPasswordChar = false;
            this.TCM.TextChanged += new System.EventHandler(this.TCM_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 98);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(43, 19);
            this.materialLabel1.TabIndex = 16;
            this.materialLabel1.Text = "mtpa";
            // 
            // CUBICFEET
            // 
            this.CUBICFEET.AutoSize = true;
            this.CUBICFEET.Depth = 0;
            this.CUBICFEET.Font = new System.Drawing.Font("Roboto", 11F);
            this.CUBICFEET.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CUBICFEET.Location = new System.Drawing.Point(149, 98);
            this.CUBICFEET.MouseState = MaterialSkin.MouseState.HOVER;
            this.CUBICFEET.Name = "CUBICFEET";
            this.CUBICFEET.Size = new System.Drawing.Size(27, 19);
            this.CUBICFEET.TabIndex = 17;
            this.CUBICFEET.Text = "tcf";
            this.CUBICFEET.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // CUBICMETERS
            // 
            this.CUBICMETERS.AutoSize = true;
            this.CUBICMETERS.Depth = 0;
            this.CUBICMETERS.Font = new System.Drawing.Font("Roboto", 11F);
            this.CUBICMETERS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CUBICMETERS.Location = new System.Drawing.Point(290, 98);
            this.CUBICMETERS.MouseState = MaterialSkin.MouseState.HOVER;
            this.CUBICMETERS.Name = "CUBICMETERS";
            this.CUBICMETERS.Size = new System.Drawing.Size(35, 19);
            this.CUBICMETERS.TabIndex = 18;
            this.CUBICMETERS.Text = "tcm";
            this.CUBICMETERS.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(8, 164);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(56, 19);
            this.materialLabel4.TabIndex = 19;
            this.materialLabel4.Text = "mmbtu";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(149, 164);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(43, 19);
            this.materialLabel5.TabIndex = 20;
            this.materialLabel5.Text = "MWh";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(290, 236);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(57, 19);
            this.materialLabel6.TabIndex = 21;
            this.materialLabel6.Text = "mmtoe";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(149, 236);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(27, 19);
            this.materialLabel7.TabIndex = 22;
            this.materialLabel7.Text = "GJ";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(8, 236);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(52, 19);
            this.materialLabel8.TabIndex = 23;
            this.materialLabel8.Text = "Therm";
            // 
            // MMBOE
            // 
            this.MMBOE.Depth = 0;
            this.MMBOE.Hint = "";
            this.MMBOE.Location = new System.Drawing.Point(294, 138);
            this.MMBOE.MaxLength = 32767;
            this.MMBOE.MouseState = MaterialSkin.MouseState.HOVER;
            this.MMBOE.Name = "MMBOE";
            this.MMBOE.PasswordChar = '\0';
            this.MMBOE.SelectedText = "";
            this.MMBOE.SelectionLength = 0;
            this.MMBOE.SelectionStart = 0;
            this.MMBOE.Size = new System.Drawing.Size(100, 23);
            this.MMBOE.TabIndex = 24;
            this.MMBOE.TabStop = false;
            this.MMBOE.UseSystemPasswordChar = false;
            this.MMBOE.TextChanged += new System.EventHandler(this.MMBOE_TextChanged);
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(290, 164);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(60, 19);
            this.materialLabel9.TabIndex = 25;
            this.materialLabel9.Text = "mmboe";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 275);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.MMBOE);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.CUBICMETERS);
            this.Controls.Add(this.CUBICFEET);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.TCM);
            this.Controls.Add(this.MMTOE);
            this.Controls.Add(this.GJ);
            this.Controls.Add(this.MTPA);
            this.Controls.Add(this.THERM);
            this.Controls.Add(this.TCF);
            this.Controls.Add(this.MWH);
            this.Controls.Add(this.MMBTU);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Unit Converter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSingleLineTextField MMBTU;
        private MaterialSingleLineTextField MWH;
        private MaterialSingleLineTextField TCF;
        private MaterialSingleLineTextField THERM;
        private MaterialSingleLineTextField MTPA;
        private MaterialSingleLineTextField GJ;
        private MaterialSingleLineTextField MMTOE;
        private MaterialSingleLineTextField TCM;
        private MaterialLabel materialLabel1;
        private MaterialLabel CUBICFEET;
        private MaterialLabel CUBICMETERS;
        private MaterialLabel materialLabel4;
        private MaterialLabel materialLabel5;
        private MaterialLabel materialLabel6;
        private MaterialLabel materialLabel7;
        private MaterialLabel materialLabel8;
        private MaterialSingleLineTextField MMBOE;
        private MaterialLabel materialLabel9;
    }
}