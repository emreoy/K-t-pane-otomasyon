namespace NTKlibrary
{
    partial class frmOgrenci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOgrenci));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtARA = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.txtADRES = new System.Windows.Forms.RichTextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblCEP = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.grbBABA = new DevExpress.XtraEditors.GroupControl();
            this.lblTELBABA = new DevExpress.XtraEditors.LabelControl();
            this.grbANNE = new DevExpress.XtraEditors.GroupControl();
            this.lblTELANNE = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lblCINSIYET = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblALAN = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lblSINIF = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblNO = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.picRESIM = new DevExpress.XtraEditors.PictureEdit();
            this.lblISIM = new DevExpress.XtraEditors.LabelControl();
            this.lblSAYI = new DevExpress.XtraEditors.LabelControl();
            this.txtKARTID = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtARA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbBABA)).BeginInit();
            this.grbBABA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbANNE)).BeginInit();
            this.grbANNE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRESIM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKARTID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 78);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(372, 430);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "NO";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ÖGRENCİ İSİM";
            this.columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SINIF";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ALAN";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            this.columnHeader5.Width = 0;
            // 
            // txtARA
            // 
            this.txtARA.Location = new System.Drawing.Point(53, 44);
            this.txtARA.Name = "txtARA";
            this.txtARA.Size = new System.Drawing.Size(331, 20);
            this.txtARA.TabIndex = 1;
            this.txtARA.EditValueChanged += new System.EventHandler(this.txtARA_EditValueChanged);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(12, 42);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureEdit1.Properties.InitialImage")));
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(35, 30);
            this.pictureEdit1.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.groupControl4);
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Location = new System.Drawing.Point(390, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(942, 420);
            this.groupControl1.TabIndex = 3;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.txtADRES);
            this.groupControl4.Controls.Add(this.labelControl7);
            this.groupControl4.Controls.Add(this.labelControl3);
            this.groupControl4.Controls.Add(this.lblCEP);
            this.groupControl4.Location = new System.Drawing.Point(698, 23);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(239, 186);
            this.groupControl4.TabIndex = 4;
            this.groupControl4.Text = "İletişim Bilgileri";
            // 
            // txtADRES
            // 
            this.txtADRES.BackColor = System.Drawing.SystemColors.Control;
            this.txtADRES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtADRES.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtADRES.Location = new System.Drawing.Point(11, 82);
            this.txtADRES.Name = "txtADRES";
            this.txtADRES.Size = new System.Drawing.Size(213, 88);
            this.txtADRES.TabIndex = 6;
            this.txtADRES.Text = "";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(24, 58);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(47, 18);
            this.labelControl7.TabIndex = 5;
            this.labelControl7.Text = "Adres :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(11, 34);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 18);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Cep Tel :";
            // 
            // lblCEP
            // 
            this.lblCEP.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCEP.Appearance.Options.UseFont = true;
            this.lblCEP.Location = new System.Drawing.Point(86, 34);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(25, 18);
            this.lblCEP.TabIndex = 3;
            this.lblCEP.Text = "-----";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.grbBABA);
            this.groupControl3.Controls.Add(this.grbANNE);
            this.groupControl3.Location = new System.Drawing.Point(470, 23);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(222, 186);
            this.groupControl3.TabIndex = 3;
            this.groupControl3.Text = "Aile Bilgileri";
            // 
            // grbBABA
            // 
            this.grbBABA.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbBABA.AppearanceCaption.Options.UseFont = true;
            this.grbBABA.Controls.Add(this.lblTELBABA);
            this.grbBABA.Location = new System.Drawing.Point(5, 103);
            this.grbBABA.Name = "grbBABA";
            this.grbBABA.Size = new System.Drawing.Size(212, 67);
            this.grbBABA.TabIndex = 5;
            this.grbBABA.Text = "BABA";
            // 
            // lblTELBABA
            // 
            this.lblTELBABA.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTELBABA.Appearance.Options.UseFont = true;
            this.lblTELBABA.Location = new System.Drawing.Point(28, 38);
            this.lblTELBABA.Name = "lblTELBABA";
            this.lblTELBABA.Size = new System.Drawing.Size(25, 18);
            this.lblTELBABA.TabIndex = 12;
            this.lblTELBABA.Text = "-----";
            // 
            // grbANNE
            // 
            this.grbANNE.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbANNE.AppearanceCaption.Options.UseFont = true;
            this.grbANNE.Controls.Add(this.lblTELANNE);
            this.grbANNE.Location = new System.Drawing.Point(5, 30);
            this.grbANNE.Name = "grbANNE";
            this.grbANNE.Size = new System.Drawing.Size(212, 67);
            this.grbANNE.TabIndex = 4;
            this.grbANNE.Text = "ANNE";
            // 
            // lblTELANNE
            // 
            this.lblTELANNE.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTELANNE.Appearance.Options.UseFont = true;
            this.lblTELANNE.Location = new System.Drawing.Point(28, 38);
            this.lblTELANNE.Name = "lblTELANNE";
            this.lblTELANNE.Size = new System.Drawing.Size(25, 18);
            this.lblTELANNE.TabIndex = 11;
            this.lblTELANNE.Text = "-----";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.lblCINSIYET);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.lblALAN);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.lblSINIF);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.lblNO);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.picRESIM);
            this.groupControl2.Controls.Add(this.lblISIM);
            this.groupControl2.Location = new System.Drawing.Point(5, 23);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(459, 186);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Kişisel Bilgiler";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(148, 141);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(59, 18);
            this.labelControl8.TabIndex = 10;
            this.labelControl8.Text = "Cinsiyet :";
            // 
            // lblCINSIYET
            // 
            this.lblCINSIYET.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCINSIYET.Appearance.Options.UseFont = true;
            this.lblCINSIYET.Location = new System.Drawing.Point(216, 141);
            this.lblCINSIYET.Name = "lblCINSIYET";
            this.lblCINSIYET.Size = new System.Drawing.Size(25, 18);
            this.lblCINSIYET.TabIndex = 9;
            this.lblCINSIYET.Text = "-----";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(170, 116);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 18);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Alan :";
            // 
            // lblALAN
            // 
            this.lblALAN.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblALAN.Appearance.Options.UseFont = true;
            this.lblALAN.Location = new System.Drawing.Point(216, 116);
            this.lblALAN.Name = "lblALAN";
            this.lblALAN.Size = new System.Drawing.Size(25, 18);
            this.lblALAN.TabIndex = 7;
            this.lblALAN.Text = "-----";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(172, 88);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(35, 18);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "Sınıf :";
            // 
            // lblSINIF
            // 
            this.lblSINIF.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSINIF.Appearance.Options.UseFont = true;
            this.lblSINIF.Location = new System.Drawing.Point(216, 88);
            this.lblSINIF.Name = "lblSINIF";
            this.lblSINIF.Size = new System.Drawing.Size(25, 18);
            this.lblSINIF.TabIndex = 5;
            this.lblSINIF.Text = "-----";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(179, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(28, 18);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "No :";
            // 
            // lblNO
            // 
            this.lblNO.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNO.Appearance.Options.UseFont = true;
            this.lblNO.Location = new System.Drawing.Point(216, 62);
            this.lblNO.Name = "lblNO";
            this.lblNO.Size = new System.Drawing.Size(25, 18);
            this.lblNO.TabIndex = 3;
            this.lblNO.Text = "-----";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(169, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 18);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "İsim :";
            // 
            // picRESIM
            // 
            this.picRESIM.Cursor = System.Windows.Forms.Cursors.Default;
            this.picRESIM.Location = new System.Drawing.Point(5, 23);
            this.picRESIM.Name = "picRESIM";
            this.picRESIM.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.picRESIM.Properties.Appearance.Options.UseBackColor = true;
            this.picRESIM.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picRESIM.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picRESIM.Size = new System.Drawing.Size(138, 155);
            this.picRESIM.TabIndex = 0;
            // 
            // lblISIM
            // 
            this.lblISIM.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblISIM.Appearance.Options.UseFont = true;
            this.lblISIM.Location = new System.Drawing.Point(216, 34);
            this.lblISIM.Name = "lblISIM";
            this.lblISIM.Size = new System.Drawing.Size(25, 18);
            this.lblISIM.TabIndex = 1;
            this.lblISIM.Text = "-----";
            // 
            // lblSAYI
            // 
            this.lblSAYI.Location = new System.Drawing.Point(39, 516);
            this.lblSAYI.Name = "lblSAYI";
            this.lblSAYI.Size = new System.Drawing.Size(0, 13);
            this.lblSAYI.TabIndex = 4;
            // 
            // txtKARTID
            // 
            this.txtKARTID.Location = new System.Drawing.Point(53, 11);
            this.txtKARTID.Name = "txtKARTID";
            this.txtKARTID.Size = new System.Drawing.Size(331, 20);
            this.txtKARTID.TabIndex = 13;
            this.txtKARTID.EditValueChanged += new System.EventHandler(this.txtKARTID_EditValueChanged);
            this.txtKARTID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKARTID_KeyPress);
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(12, 7);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureEdit2.Properties.InitialImage")));
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit2.Size = new System.Drawing.Size(35, 30);
            this.pictureEdit2.TabIndex = 12;
            this.pictureEdit2.Click += new System.EventHandler(this.pictureEdit2_Click);
            // 
            // frmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 541);
            this.Controls.Add(this.txtKARTID);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.lblSAYI);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.txtARA);
            this.Controls.Add(this.listView1);
            this.Name = "frmOgrenci";
            this.Text = "ÖGRENCİ";
            this.Load += new System.EventHandler(this.frmOgrenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtARA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grbBABA)).EndInit();
            this.grbBABA.ResumeLayout(false);
            this.grbBABA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbANNE)).EndInit();
            this.grbANNE.ResumeLayout(false);
            this.grbANNE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRESIM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKARTID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private DevExpress.XtraEditors.TextEdit txtARA;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private DevExpress.XtraEditors.LabelControl lblSAYI;
        private DevExpress.XtraEditors.PictureEdit picRESIM;
        private DevExpress.XtraEditors.LabelControl lblISIM;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl lblCINSIYET;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lblALAN;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl lblSINIF;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblNO;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl grbBABA;
        private DevExpress.XtraEditors.LabelControl lblTELBABA;
        private DevExpress.XtraEditors.GroupControl grbANNE;
        private DevExpress.XtraEditors.LabelControl lblTELANNE;
        private System.Windows.Forms.RichTextBox txtADRES;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblCEP;
        private DevExpress.XtraEditors.TextEdit txtKARTID;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
    }
}