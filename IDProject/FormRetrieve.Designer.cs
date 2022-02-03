namespace IDProject
{
    partial class FormRetrieve
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
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator1 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRetrieve));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.barCodeControl1 = new DevExpress.XtraEditors.BarCodeControl();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtmname = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtregion = new System.Windows.Forms.TextBox();
            this.txtchapter = new System.Windows.Forms.TextBox();
            this.txtbdate = new System.Windows.Forms.TextBox();
            this.txtdateissued = new System.Windows.Forms.TextBox();
            this.txtdateexpired = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblname = new DevExpress.XtraEditors.LabelControl();
            this.lblchapter = new DevExpress.XtraEditors.LabelControl();
            this.lblprovince = new DevExpress.XtraEditors.LabelControl();
            this.qrcode = new DevExpress.XtraEditors.BarCodeControl();
            this.txtprovince = new System.Windows.Forms.TextBox();
            this.txtmobileno = new System.Windows.Forms.TextBox();
            this.txtbloodtype = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txttinno = new System.Windows.Forms.TextBox();
            this.txtsssno = new System.Windows.Forms.TextBox();
            this.txtcontactpersonaddress = new System.Windows.Forms.TextBox();
            this.txtcontactpersonfullname = new System.Windows.Forms.TextBox();
            this.txtcontactpersonmobileno = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtdatesurvived = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtchaptercountries = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.searchLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pic1by1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtchaptercountries.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1by1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(23, 310);
            this.listBox1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(397, 323);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(639, 196);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(639, 249);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // barCodeControl1
            // 
            this.barCodeControl1.Appearance.BackColor = System.Drawing.Color.Black;
            this.barCodeControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.barCodeControl1.Appearance.Options.UseBackColor = true;
            this.barCodeControl1.Appearance.Options.UseForeColor = true;
            this.barCodeControl1.AutoModule = true;
            this.barCodeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barCodeControl1.HorizontalTextAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.barCodeControl1.Location = new System.Drawing.Point(453, 344);
            this.barCodeControl1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.barCodeControl1.Name = "barCodeControl1";
            this.barCodeControl1.Size = new System.Drawing.Size(185, 62);
            this.barCodeControl1.Symbology = code128Generator1;
            this.barCodeControl1.TabIndex = 5;
            this.barCodeControl1.Text = "7600000109274";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(673, 473);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Chapter:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(798, 468);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(300, 37);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 1436);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 51);
            this.button1.TabIndex = 11;
            this.button1.Text = "Preview Front";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(145, 1030);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 33);
            this.label10.TabIndex = 31;
            this.label10.Text = "Chapter:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(158, 968);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 33);
            this.label9.TabIndex = 30;
            this.label9.Text = "Region:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 1280);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 33);
            this.label7.TabIndex = 29;
            this.label7.Text = "Date of Expired:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(114, 845);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 33);
            this.label6.TabIndex = 28;
            this.label6.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 783);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 33);
            this.label5.TabIndex = 27;
            this.label5.Text = "Middle Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 1218);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 33);
            this.label4.TabIndex = 26;
            this.label4.Text = "Date of Issued:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(86, 1093);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 33);
            this.label8.TabIndex = 25;
            this.label8.Text = "Date of Birth:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(145, 908);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 33);
            this.label11.TabIndex = 24;
            this.label11.Text = "Address:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(114, 720);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 33);
            this.label12.TabIndex = 23;
            this.label12.Text = "First Name:";
            // 
            // txtfname
            // 
            this.txtfname.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfname.Location = new System.Drawing.Point(275, 714);
            this.txtfname.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(360, 40);
            this.txtfname.TabIndex = 32;
            // 
            // txtmname
            // 
            this.txtmname.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmname.Location = new System.Drawing.Point(275, 776);
            this.txtmname.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtmname.Name = "txtmname";
            this.txtmname.Size = new System.Drawing.Size(360, 40);
            this.txtmname.TabIndex = 33;
            // 
            // txtlname
            // 
            this.txtlname.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlname.Location = new System.Drawing.Point(275, 839);
            this.txtlname.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(360, 40);
            this.txtlname.TabIndex = 34;
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(275, 901);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(360, 40);
            this.txtaddress.TabIndex = 35;
            // 
            // txtregion
            // 
            this.txtregion.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtregion.Location = new System.Drawing.Point(275, 961);
            this.txtregion.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtregion.Name = "txtregion";
            this.txtregion.Size = new System.Drawing.Size(360, 40);
            this.txtregion.TabIndex = 36;
            // 
            // txtchapter
            // 
            this.txtchapter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchapter.Location = new System.Drawing.Point(275, 1024);
            this.txtchapter.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtchapter.Name = "txtchapter";
            this.txtchapter.Size = new System.Drawing.Size(360, 40);
            this.txtchapter.TabIndex = 37;
            // 
            // txtbdate
            // 
            this.txtbdate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbdate.Location = new System.Drawing.Point(275, 1085);
            this.txtbdate.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtbdate.Name = "txtbdate";
            this.txtbdate.Size = new System.Drawing.Size(360, 40);
            this.txtbdate.TabIndex = 38;
            // 
            // txtdateissued
            // 
            this.txtdateissued.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdateissued.Location = new System.Drawing.Point(275, 1211);
            this.txtdateissued.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtdateissued.Name = "txtdateissued";
            this.txtdateissued.Size = new System.Drawing.Size(365, 40);
            this.txtdateissued.TabIndex = 39;
            // 
            // txtdateexpired
            // 
            this.txtdateexpired.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdateexpired.Location = new System.Drawing.Point(275, 1274);
            this.txtdateexpired.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtdateexpired.Name = "txtdateexpired";
            this.txtdateexpired.Size = new System.Drawing.Size(365, 40);
            this.txtdateexpired.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(211, 658);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 33);
            this.label13.TabIndex = 41;
            this.label13.Text = "ID:";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(275, 650);
            this.txtid.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(360, 40);
            this.txtid.TabIndex = 42;
            // 
            // lblname
            // 
            this.lblname.Appearance.BackColor = System.Drawing.Color.Black;
            this.lblname.Appearance.Font = new System.Drawing.Font("Arial", 7.25F, System.Drawing.FontStyle.Bold);
            this.lblname.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblname.Appearance.Options.UseBackColor = true;
            this.lblname.Appearance.Options.UseFont = true;
            this.lblname.Appearance.Options.UseForeColor = true;
            this.lblname.Location = new System.Drawing.Point(1532, 1133);
            this.lblname.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(222, 26);
            this.lblname.TabIndex = 44;
            this.lblname.Text = "Juan Pedro Dela Cruz";
            // 
            // lblchapter
            // 
            this.lblchapter.Appearance.BackColor = System.Drawing.Color.Black;
            this.lblchapter.Appearance.Font = new System.Drawing.Font("Arial", 7.25F, System.Drawing.FontStyle.Bold);
            this.lblchapter.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblchapter.Appearance.Options.UseBackColor = true;
            this.lblchapter.Appearance.Options.UseFont = true;
            this.lblchapter.Appearance.Options.UseForeColor = true;
            this.lblchapter.Location = new System.Drawing.Point(1532, 1172);
            this.lblchapter.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.lblchapter.Name = "lblchapter";
            this.lblchapter.Size = new System.Drawing.Size(100, 26);
            this.lblchapter.TabIndex = 45;
            this.lblchapter.Text = "Rho Delta";
            // 
            // lblprovince
            // 
            this.lblprovince.Appearance.BackColor = System.Drawing.Color.Red;
            this.lblprovince.Appearance.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprovince.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblprovince.Appearance.Options.UseBackColor = true;
            this.lblprovince.Appearance.Options.UseFont = true;
            this.lblprovince.Appearance.Options.UseForeColor = true;
            this.lblprovince.Location = new System.Drawing.Point(1532, 1267);
            this.lblprovince.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.lblprovince.Name = "lblprovince";
            this.lblprovince.Size = new System.Drawing.Size(125, 24);
            this.lblprovince.TabIndex = 46;
            this.lblprovince.Text = "labelControl2";
            // 
            // qrcode
            // 
            this.qrcode.Appearance.BackColor = System.Drawing.Color.Black;
            this.qrcode.Appearance.ForeColor = System.Drawing.Color.White;
            this.qrcode.Appearance.Options.UseBackColor = true;
            this.qrcode.Appearance.Options.UseForeColor = true;
            this.qrcode.AutoModule = true;
            this.qrcode.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.qrcode.Location = new System.Drawing.Point(1708, 935);
            this.qrcode.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.qrcode.Name = "qrcode";
            this.qrcode.Padding = new System.Windows.Forms.Padding(23, 4, 23, 0);
            this.qrcode.ShowText = false;
            this.qrcode.ShowToolTips = false;
            this.qrcode.Size = new System.Drawing.Size(180, 191);
            qrCodeGenerator1.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version1;
            this.qrcode.Symbology = qrCodeGenerator1;
            this.qrcode.TabIndex = 47;
            this.qrcode.Text = "63600000200003";
            // 
            // txtprovince
            // 
            this.txtprovince.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprovince.Location = new System.Drawing.Point(275, 1149);
            this.txtprovince.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtprovince.Name = "txtprovince";
            this.txtprovince.Size = new System.Drawing.Size(360, 40);
            this.txtprovince.TabIndex = 49;
            // 
            // txtmobileno
            // 
            this.txtmobileno.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmobileno.Location = new System.Drawing.Point(1016, 714);
            this.txtmobileno.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtmobileno.Name = "txtmobileno";
            this.txtmobileno.Size = new System.Drawing.Size(360, 40);
            this.txtmobileno.TabIndex = 50;
            // 
            // txtbloodtype
            // 
            this.txtbloodtype.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbloodtype.Location = new System.Drawing.Point(1016, 776);
            this.txtbloodtype.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtbloodtype.Name = "txtbloodtype";
            this.txtbloodtype.Size = new System.Drawing.Size(360, 40);
            this.txtbloodtype.TabIndex = 51;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(666, 720);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 33);
            this.label14.TabIndex = 52;
            this.label14.Text = "Mobile No.:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(666, 783);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(158, 33);
            this.label15.TabIndex = 53;
            this.label15.Text = "Blood Type:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(666, 845);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 33);
            this.label16.TabIndex = 54;
            this.label16.Text = "SSS No.:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(666, 908);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(118, 33);
            this.label17.TabIndex = 55;
            this.label17.Text = "TIN No.:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(666, 968);
            this.label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(322, 33);
            this.label18.TabIndex = 56;
            this.label18.Text = "Contact Person FullName:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(666, 1030);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(306, 33);
            this.label19.TabIndex = 57;
            this.label19.Text = "Contact Person Address:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(666, 1093);
            this.label20.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(338, 33);
            this.label20.TabIndex = 58;
            this.label20.Text = "Contact Person Mobile No.:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(138, 1155);
            this.label21.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(125, 33);
            this.label21.TabIndex = 59;
            this.label21.Text = "Province:";
            // 
            // txttinno
            // 
            this.txttinno.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttinno.Location = new System.Drawing.Point(1016, 901);
            this.txttinno.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txttinno.Name = "txttinno";
            this.txttinno.Size = new System.Drawing.Size(360, 40);
            this.txttinno.TabIndex = 61;
            // 
            // txtsssno
            // 
            this.txtsssno.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsssno.Location = new System.Drawing.Point(1016, 839);
            this.txtsssno.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtsssno.Name = "txtsssno";
            this.txtsssno.Size = new System.Drawing.Size(360, 40);
            this.txtsssno.TabIndex = 60;
            // 
            // txtcontactpersonaddress
            // 
            this.txtcontactpersonaddress.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontactpersonaddress.Location = new System.Drawing.Point(1016, 1024);
            this.txtcontactpersonaddress.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtcontactpersonaddress.Name = "txtcontactpersonaddress";
            this.txtcontactpersonaddress.Size = new System.Drawing.Size(360, 40);
            this.txtcontactpersonaddress.TabIndex = 63;
            // 
            // txtcontactpersonfullname
            // 
            this.txtcontactpersonfullname.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontactpersonfullname.Location = new System.Drawing.Point(1016, 961);
            this.txtcontactpersonfullname.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtcontactpersonfullname.Name = "txtcontactpersonfullname";
            this.txtcontactpersonfullname.Size = new System.Drawing.Size(360, 40);
            this.txtcontactpersonfullname.TabIndex = 62;
            // 
            // txtcontactpersonmobileno
            // 
            this.txtcontactpersonmobileno.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontactpersonmobileno.Location = new System.Drawing.Point(1016, 1085);
            this.txtcontactpersonmobileno.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtcontactpersonmobileno.Name = "txtcontactpersonmobileno";
            this.txtcontactpersonmobileno.Size = new System.Drawing.Size(360, 40);
            this.txtcontactpersonmobileno.TabIndex = 64;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(73, 1343);
            this.label22.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(189, 33);
            this.label22.TabIndex = 65;
            this.label22.Text = "Date Survived:";
            // 
            // txtdatesurvived
            // 
            this.txtdatesurvived.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdatesurvived.Location = new System.Drawing.Point(275, 1336);
            this.txtdatesurvived.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtdatesurvived.Name = "txtdatesurvived";
            this.txtdatesurvived.Size = new System.Drawing.Size(365, 40);
            this.txtdatesurvived.TabIndex = 66;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(574, 1436);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(286, 51);
            this.button2.TabIndex = 67;
            this.button2.Text = "Preview Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtchaptercountries
            // 
            this.txtchaptercountries.Location = new System.Drawing.Point(88, 25);
            this.txtchaptercountries.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtchaptercountries.Name = "txtchaptercountries";
            this.txtchaptercountries.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.txtchaptercountries.Properties.Appearance.Options.UseFont = true;
            this.txtchaptercountries.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtchaptercountries.Properties.NullText = "";
            this.txtchaptercountries.Properties.PopupView = this.gridView3;
            this.txtchaptercountries.Size = new System.Drawing.Size(336, 48);
            this.txtchaptercountries.TabIndex = 70;
            this.txtchaptercountries.EditValueChanged += new System.EventHandler(this.txtchaptercountries_EditValueChanged);
            // 
            // gridView3
            // 
            this.gridView3.DetailHeight = 634;
            this.gridView3.FixedLineWidth = 4;
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // searchLookUpEdit1
            // 
            this.searchLookUpEdit1.Location = new System.Drawing.Point(88, 80);
            this.searchLookUpEdit1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.searchLookUpEdit1.Name = "searchLookUpEdit1";
            this.searchLookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.searchLookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit1.Properties.PopupView = this.searchLookUpEdit1View;
            this.searchLookUpEdit1.Size = new System.Drawing.Size(336, 48);
            this.searchLookUpEdit1.TabIndex = 71;
            this.searchLookUpEdit1.EditValueChanged += new System.EventHandler(this.searchLookUpEdit1_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.DetailHeight = 634;
            this.searchLookUpEdit1View.FixedLineWidth = 4;
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // pic1by1
            // 
            this.pic1by1.Location = new System.Drawing.Point(1531, 935);
            this.pic1by1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.pic1by1.Name = "pic1by1";
            this.pic1by1.Size = new System.Drawing.Size(174, 191);
            this.pic1by1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1by1.TabIndex = 48;
            this.pic1by1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1513, 707);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(380, 626);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 43;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(1063, 249);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(286, 172);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Location = new System.Drawing.Point(1583, 99);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(726, 460);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Location = new System.Drawing.Point(647, 292);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(106, 41);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(442, 27);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(608, 394);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1063, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormRetrieve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2052, 1554);
            this.Controls.Add(this.searchLookUpEdit1);
            this.Controls.Add(this.txtchaptercountries);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtdatesurvived);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtcontactpersonmobileno);
            this.Controls.Add(this.txtcontactpersonaddress);
            this.Controls.Add(this.txtcontactpersonfullname);
            this.Controls.Add(this.txttinno);
            this.Controls.Add(this.txtsssno);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtbloodtype);
            this.Controls.Add(this.txtmobileno);
            this.Controls.Add(this.txtprovince);
            this.Controls.Add(this.pic1by1);
            this.Controls.Add(this.qrcode);
            this.Controls.Add(this.lblprovince);
            this.Controls.Add(this.lblchapter);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtdateexpired);
            this.Controls.Add(this.txtdateissued);
            this.Controls.Add(this.txtbdate);
            this.Controls.Add(this.txtchapter);
            this.Controls.Add(this.txtregion);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtmname);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.barCodeControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "FormRetrieve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3";
            this.Load += new System.EventHandler(this.FormRetrieve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtchaptercountries.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1by1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.BarCodeControl barCodeControl1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtmname;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtregion;
        private System.Windows.Forms.TextBox txtchapter;
        private System.Windows.Forms.TextBox txtbdate;
        private System.Windows.Forms.TextBox txtdateissued;
        private System.Windows.Forms.TextBox txtdateexpired;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.PictureBox pictureBox6;
        private DevExpress.XtraEditors.LabelControl lblname;
        private DevExpress.XtraEditors.LabelControl lblchapter;
        private DevExpress.XtraEditors.LabelControl lblprovince;
        public DevExpress.XtraEditors.BarCodeControl qrcode;
        public System.Windows.Forms.PictureBox pic1by1;
        private System.Windows.Forms.TextBox txtprovince;
        private System.Windows.Forms.TextBox txtmobileno;
        private System.Windows.Forms.TextBox txtbloodtype;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txttinno;
        private System.Windows.Forms.TextBox txtsssno;
        private System.Windows.Forms.TextBox txtcontactpersonaddress;
        private System.Windows.Forms.TextBox txtcontactpersonfullname;
        private System.Windows.Forms.TextBox txtcontactpersonmobileno;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtdatesurvived;
        private System.Windows.Forms.Button button2;
        private DevExpress.XtraEditors.SearchLookUpEdit txtchaptercountries;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
    }
}