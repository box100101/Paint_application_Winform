namespace Paint
{
    partial class Form1
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnNewFile = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.picked_color = new System.Windows.Forms.Button();
            this.btnColorDialog = new System.Windows.Forms.Button();
            this.btnBrownColor = new System.Windows.Forms.Button();
            this.btnYellowColor = new System.Windows.Forms.Button();
            this.btnPurpleColor = new System.Windows.Forms.Button();
            this.btnRedColor = new System.Windows.Forms.Button();
            this.btnGreenColor = new System.Windows.Forms.Button();
            this.btnBlueColor = new System.Windows.Forms.Button();
            this.btnOrangeColor = new System.Windows.Forms.Button();
            this.btnBlackColor = new System.Windows.Forms.Button();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.comboBoxLine = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBoxPixel = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFillPolygon = new System.Windows.Forms.Button();
            this.btnPolygon = new System.Windows.Forms.Button();
            this.btnFillRectangle = new System.Windows.Forms.Button();
            this.btnFillSquare = new System.Windows.Forms.Button();
            this.btnFillEllipse = new System.Windows.Forms.Button();
            this.btnFillCircle = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_fill = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnPencil = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnMode = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 1;
            this.tabControl.Size = new System.Drawing.Size(1318, 150);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSaveFile);
            this.tabPage1.Controls.Add(this.btnNewFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1310, 121);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "File";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.BackColor = System.Drawing.Color.White;
            this.btnSaveFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveFile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSaveFile.FlatAppearance.BorderSize = 0;
            this.btnSaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveFile.ForeColor = System.Drawing.Color.Black;
            this.btnSaveFile.Image = global::Paint.Properties.Resources.icons8_save_close_40;
            this.btnSaveFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveFile.Location = new System.Drawing.Point(81, 0);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(80, 121);
            this.btnSaveFile.TabIndex = 2;
            this.btnSaveFile.Text = "Save File";
            this.btnSaveFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaveFile.UseVisualStyleBackColor = false;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnNewFile
            // 
            this.btnNewFile.BackColor = System.Drawing.Color.White;
            this.btnNewFile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNewFile.FlatAppearance.BorderSize = 0;
            this.btnNewFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewFile.ForeColor = System.Drawing.Color.Black;
            this.btnNewFile.Image = global::Paint.Properties.Resources.icons8_new_copy_40;
            this.btnNewFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNewFile.Location = new System.Drawing.Point(0, 0);
            this.btnNewFile.Name = "btnNewFile";
            this.btnNewFile.Size = new System.Drawing.Size(80, 121);
            this.btnNewFile.TabIndex = 1;
            this.btnNewFile.Text = "New File";
            this.btnNewFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewFile.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.groupControl5);
            this.tabPage2.Controls.Add(this.groupControl4);
            this.tabPage2.Controls.Add(this.groupControl3);
            this.tabPage2.Controls.Add(this.groupControl2);
            this.tabPage2.Controls.Add(this.groupControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1310, 121);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Home";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupControl5
            // 
            this.groupControl5.AppearanceCaption.BorderColor = System.Drawing.Color.White;
            this.groupControl5.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl5.CaptionLocation = DevExpress.Utils.Locations.Bottom;
            this.groupControl5.Controls.Add(this.picked_color);
            this.groupControl5.Controls.Add(this.btnColorDialog);
            this.groupControl5.Controls.Add(this.btnBrownColor);
            this.groupControl5.Controls.Add(this.btnYellowColor);
            this.groupControl5.Controls.Add(this.btnPurpleColor);
            this.groupControl5.Controls.Add(this.btnRedColor);
            this.groupControl5.Controls.Add(this.btnGreenColor);
            this.groupControl5.Controls.Add(this.btnBlueColor);
            this.groupControl5.Controls.Add(this.btnOrangeColor);
            this.groupControl5.Controls.Add(this.btnBlackColor);
            this.groupControl5.Location = new System.Drawing.Point(1038, 0);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(270, 120);
            this.groupControl5.TabIndex = 2;
            this.groupControl5.Text = "Color";
            // 
            // picked_color
            // 
            this.picked_color.BackColor = System.Drawing.Color.White;
            this.picked_color.Location = new System.Drawing.Point(208, 18);
            this.picked_color.Name = "picked_color";
            this.picked_color.Size = new System.Drawing.Size(46, 43);
            this.picked_color.TabIndex = 3;
            this.picked_color.UseVisualStyleBackColor = false;
            // 
            // btnColorDialog
            // 
            this.btnColorDialog.BackColor = System.Drawing.Color.Transparent;
            this.btnColorDialog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColorDialog.FlatAppearance.BorderSize = 0;
            this.btnColorDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorDialog.Font = new System.Drawing.Font("Tahoma", 7.5F);
            this.btnColorDialog.Image = global::Paint.Properties.Resources.icons8_color_wheel_40;
            this.btnColorDialog.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnColorDialog.Location = new System.Drawing.Point(153, 0);
            this.btnColorDialog.Name = "btnColorDialog";
            this.btnColorDialog.Size = new System.Drawing.Size(55, 78);
            this.btnColorDialog.TabIndex = 1;
            this.btnColorDialog.Text = "Edit Colors";
            this.btnColorDialog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnColorDialog.UseVisualStyleBackColor = false;
            this.btnColorDialog.Click += new System.EventHandler(this.btnColorDialog_Click);
            // 
            // btnBrownColor
            // 
            this.btnBrownColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrownColor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBrownColor.FlatAppearance.BorderSize = 0;
            this.btnBrownColor.Image = global::Paint.Properties.Resources.icons8_brown_square_30;
            this.btnBrownColor.Location = new System.Drawing.Point(123, 43);
            this.btnBrownColor.Name = "btnBrownColor";
            this.btnBrownColor.Size = new System.Drawing.Size(30, 30);
            this.btnBrownColor.TabIndex = 2;
            this.btnBrownColor.UseVisualStyleBackColor = true;
            this.btnBrownColor.Click += new System.EventHandler(this.btnBrownColor_Click);
            // 
            // btnYellowColor
            // 
            this.btnYellowColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYellowColor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnYellowColor.FlatAppearance.BorderSize = 0;
            this.btnYellowColor.Image = global::Paint.Properties.Resources.icons8_yellow_square_30;
            this.btnYellowColor.Location = new System.Drawing.Point(123, 7);
            this.btnYellowColor.Name = "btnYellowColor";
            this.btnYellowColor.Size = new System.Drawing.Size(30, 30);
            this.btnYellowColor.TabIndex = 2;
            this.btnYellowColor.UseVisualStyleBackColor = true;
            this.btnYellowColor.Click += new System.EventHandler(this.btnYellowColor_Click);
            // 
            // btnPurpleColor
            // 
            this.btnPurpleColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPurpleColor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPurpleColor.FlatAppearance.BorderSize = 0;
            this.btnPurpleColor.Image = global::Paint.Properties.Resources.icons8_purple_square_30;
            this.btnPurpleColor.Location = new System.Drawing.Point(87, 42);
            this.btnPurpleColor.Name = "btnPurpleColor";
            this.btnPurpleColor.Size = new System.Drawing.Size(30, 30);
            this.btnPurpleColor.TabIndex = 2;
            this.btnPurpleColor.UseVisualStyleBackColor = true;
            this.btnPurpleColor.Click += new System.EventHandler(this.btnPurpleColor_Click);
            // 
            // btnRedColor
            // 
            this.btnRedColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRedColor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRedColor.FlatAppearance.BorderSize = 0;
            this.btnRedColor.Image = global::Paint.Properties.Resources.icons8_red_square_30;
            this.btnRedColor.Location = new System.Drawing.Point(87, 7);
            this.btnRedColor.Name = "btnRedColor";
            this.btnRedColor.Size = new System.Drawing.Size(30, 30);
            this.btnRedColor.TabIndex = 2;
            this.btnRedColor.UseVisualStyleBackColor = true;
            this.btnRedColor.Click += new System.EventHandler(this.btnRedColor_Click);
            // 
            // btnGreenColor
            // 
            this.btnGreenColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGreenColor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGreenColor.FlatAppearance.BorderSize = 0;
            this.btnGreenColor.Image = global::Paint.Properties.Resources.icons8_green_square_30;
            this.btnGreenColor.Location = new System.Drawing.Point(51, 42);
            this.btnGreenColor.Name = "btnGreenColor";
            this.btnGreenColor.Size = new System.Drawing.Size(30, 30);
            this.btnGreenColor.TabIndex = 3;
            this.btnGreenColor.UseVisualStyleBackColor = true;
            this.btnGreenColor.Click += new System.EventHandler(this.btnGreenColor_Click);
            // 
            // btnBlueColor
            // 
            this.btnBlueColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlueColor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBlueColor.FlatAppearance.BorderSize = 0;
            this.btnBlueColor.Image = global::Paint.Properties.Resources.icons8_blue_square_30;
            this.btnBlueColor.Location = new System.Drawing.Point(15, 42);
            this.btnBlueColor.Name = "btnBlueColor";
            this.btnBlueColor.Size = new System.Drawing.Size(30, 30);
            this.btnBlueColor.TabIndex = 2;
            this.btnBlueColor.UseVisualStyleBackColor = true;
            this.btnBlueColor.Click += new System.EventHandler(this.btnBlueColor_Click);
            // 
            // btnOrangeColor
            // 
            this.btnOrangeColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrangeColor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOrangeColor.FlatAppearance.BorderSize = 0;
            this.btnOrangeColor.Image = global::Paint.Properties.Resources.icons8_orange_square_30;
            this.btnOrangeColor.Location = new System.Drawing.Point(51, 7);
            this.btnOrangeColor.Name = "btnOrangeColor";
            this.btnOrangeColor.Size = new System.Drawing.Size(30, 30);
            this.btnOrangeColor.TabIndex = 4;
            this.btnOrangeColor.UseVisualStyleBackColor = true;
            this.btnOrangeColor.Click += new System.EventHandler(this.btnOrangeColor_Click);
            // 
            // btnBlackColor
            // 
            this.btnBlackColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlackColor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBlackColor.FlatAppearance.BorderSize = 0;
            this.btnBlackColor.Image = global::Paint.Properties.Resources.icons8_black_large_square_30;
            this.btnBlackColor.Location = new System.Drawing.Point(15, 7);
            this.btnBlackColor.Name = "btnBlackColor";
            this.btnBlackColor.Size = new System.Drawing.Size(30, 30);
            this.btnBlackColor.TabIndex = 1;
            this.btnBlackColor.UseVisualStyleBackColor = true;
            this.btnBlackColor.Click += new System.EventHandler(this.btnBlackColor_Click);
            // 
            // groupControl4
            // 
            this.groupControl4.AppearanceCaption.BorderColor = System.Drawing.Color.White;
            this.groupControl4.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl4.CaptionLocation = DevExpress.Utils.Locations.Bottom;
            this.groupControl4.Controls.Add(this.comboBoxLine);
            this.groupControl4.Controls.Add(this.pictureBox2);
            this.groupControl4.Controls.Add(this.comboBoxPixel);
            this.groupControl4.Controls.Add(this.pictureBox1);
            this.groupControl4.Location = new System.Drawing.Point(837, 0);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(200, 120);
            this.groupControl4.TabIndex = 5;
            this.groupControl4.Text = "Style";
            // 
            // comboBoxLine
            // 
            this.comboBoxLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxLine.FormattingEnabled = true;
            this.comboBoxLine.Items.AddRange(new object[] {
            "__________",
            "..................",
            "---------------",
            "-..-..-..-..-..-..-"});
            this.comboBoxLine.Location = new System.Drawing.Point(115, 48);
            this.comboBoxLine.Name = "comboBoxLine";
            this.comboBoxLine.Size = new System.Drawing.Size(70, 24);
            this.comboBoxLine.TabIndex = 2;
            this.comboBoxLine.Text = "__________";
            this.comboBoxLine.SelectedIndexChanged += new System.EventHandler(this.comboBoxLine_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Paint.Properties.Resources.icons8_dashed_line_40;
            this.pictureBox2.Location = new System.Drawing.Point(130, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // comboBoxPixel
            // 
            this.comboBoxPixel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxPixel.FormattingEnabled = true;
            this.comboBoxPixel.Items.AddRange(new object[] {
            "1 pixel",
            "2 pixel",
            "3 pixel",
            "4 pixel",
            "5 pixel"});
            this.comboBoxPixel.Location = new System.Drawing.Point(10, 48);
            this.comboBoxPixel.Name = "comboBoxPixel";
            this.comboBoxPixel.Size = new System.Drawing.Size(70, 24);
            this.comboBoxPixel.TabIndex = 1;
            this.comboBoxPixel.Text = "1 pixel";
            this.comboBoxPixel.SelectedIndexChanged += new System.EventHandler(this.comboBoxPixel_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Paint.Properties.Resources.icons8_line_width_40;
            this.pictureBox1.Location = new System.Drawing.Point(25, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.BorderColor = System.Drawing.Color.White;
            this.groupControl3.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl3.CaptionLocation = DevExpress.Utils.Locations.Bottom;
            this.groupControl3.Controls.Add(this.panel1);
            this.groupControl3.Location = new System.Drawing.Point(604, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(232, 120);
            this.groupControl3.TabIndex = 4;
            this.groupControl3.Text = "Shapes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnFillPolygon);
            this.panel1.Controls.Add(this.btnPolygon);
            this.panel1.Controls.Add(this.btnFillRectangle);
            this.panel1.Controls.Add(this.btnFillSquare);
            this.panel1.Controls.Add(this.btnFillEllipse);
            this.panel1.Controls.Add(this.btnFillCircle);
            this.panel1.Controls.Add(this.btnEllipse);
            this.panel1.Controls.Add(this.btnRectangle);
            this.panel1.Controls.Add(this.btnCircle);
            this.panel1.Controls.Add(this.btnSquare);
            this.panel1.Controls.Add(this.btnLine);
            this.panel1.Location = new System.Drawing.Point(5, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 80);
            this.panel1.TabIndex = 3;
            // 
            // btnFillPolygon
            // 
            this.btnFillPolygon.BackColor = System.Drawing.Color.White;
            this.btnFillPolygon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFillPolygon.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFillPolygon.FlatAppearance.BorderSize = 0;
            this.btnFillPolygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFillPolygon.Image = global::Paint.Properties.Resources.icons8_tools_30;
            this.btnFillPolygon.Location = new System.Drawing.Point(147, 39);
            this.btnFillPolygon.Name = "btnFillPolygon";
            this.btnFillPolygon.Size = new System.Drawing.Size(36, 36);
            this.btnFillPolygon.TabIndex = 11;
            this.btnFillPolygon.UseVisualStyleBackColor = false;
            this.btnFillPolygon.Click += new System.EventHandler(this.btnFillPolygon_Click);
            // 
            // btnPolygon
            // 
            this.btnPolygon.BackColor = System.Drawing.Color.White;
            this.btnPolygon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPolygon.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPolygon.FlatAppearance.BorderSize = 0;
            this.btnPolygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPolygon.Image = global::Paint.Properties.Resources.icons8_polygon_30;
            this.btnPolygon.Location = new System.Drawing.Point(181, 0);
            this.btnPolygon.Name = "btnPolygon";
            this.btnPolygon.Size = new System.Drawing.Size(36, 36);
            this.btnPolygon.TabIndex = 10;
            this.btnPolygon.UseVisualStyleBackColor = false;
            this.btnPolygon.Click += new System.EventHandler(this.btnPolygon_Click);
            // 
            // btnFillRectangle
            // 
            this.btnFillRectangle.BackColor = System.Drawing.Color.White;
            this.btnFillRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFillRectangle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFillRectangle.FlatAppearance.BorderSize = 0;
            this.btnFillRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFillRectangle.Image = global::Paint.Properties.Resources.icons8_rectangle_30;
            this.btnFillRectangle.Location = new System.Drawing.Point(110, 39);
            this.btnFillRectangle.Name = "btnFillRectangle";
            this.btnFillRectangle.Size = new System.Drawing.Size(36, 36);
            this.btnFillRectangle.TabIndex = 9;
            this.btnFillRectangle.UseVisualStyleBackColor = false;
            this.btnFillRectangle.Click += new System.EventHandler(this.btnFillRectangle_Click);
            // 
            // btnFillSquare
            // 
            this.btnFillSquare.BackColor = System.Drawing.Color.White;
            this.btnFillSquare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFillSquare.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFillSquare.FlatAppearance.BorderSize = 0;
            this.btnFillSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFillSquare.Image = global::Paint.Properties.Resources.icons8_fill_square_spinner_30;
            this.btnFillSquare.Location = new System.Drawing.Point(73, 39);
            this.btnFillSquare.Name = "btnFillSquare";
            this.btnFillSquare.Size = new System.Drawing.Size(36, 36);
            this.btnFillSquare.TabIndex = 8;
            this.btnFillSquare.UseVisualStyleBackColor = false;
            this.btnFillSquare.Click += new System.EventHandler(this.btnFillSquare_Click);
            // 
            // btnFillEllipse
            // 
            this.btnFillEllipse.BackColor = System.Drawing.Color.White;
            this.btnFillEllipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFillEllipse.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFillEllipse.FlatAppearance.BorderSize = 0;
            this.btnFillEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFillEllipse.Image = global::Paint.Properties.Resources.icons8_ellipse_30;
            this.btnFillEllipse.Location = new System.Drawing.Point(37, 39);
            this.btnFillEllipse.Name = "btnFillEllipse";
            this.btnFillEllipse.Size = new System.Drawing.Size(36, 36);
            this.btnFillEllipse.TabIndex = 7;
            this.btnFillEllipse.UseVisualStyleBackColor = false;
            this.btnFillEllipse.Click += new System.EventHandler(this.btnFillEllipse_Click);
            // 
            // btnFillCircle
            // 
            this.btnFillCircle.BackColor = System.Drawing.Color.White;
            this.btnFillCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFillCircle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFillCircle.FlatAppearance.BorderSize = 0;
            this.btnFillCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFillCircle.Image = global::Paint.Properties.Resources.icons8_fill_circle_30;
            this.btnFillCircle.Location = new System.Drawing.Point(0, 39);
            this.btnFillCircle.Name = "btnFillCircle";
            this.btnFillCircle.Size = new System.Drawing.Size(36, 36);
            this.btnFillCircle.TabIndex = 6;
            this.btnFillCircle.UseVisualStyleBackColor = false;
            this.btnFillCircle.Click += new System.EventHandler(this.btnFillCircle_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.BackColor = System.Drawing.Color.White;
            this.btnEllipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEllipse.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEllipse.FlatAppearance.BorderSize = 0;
            this.btnEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEllipse.Image = global::Paint.Properties.Resources.icons8_oval_30;
            this.btnEllipse.Location = new System.Drawing.Point(37, 0);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(36, 36);
            this.btnEllipse.TabIndex = 2;
            this.btnEllipse.UseVisualStyleBackColor = false;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.Color.White;
            this.btnRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRectangle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRectangle.FlatAppearance.BorderSize = 0;
            this.btnRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRectangle.Image = global::Paint.Properties.Resources.icons8_rectangular_30;
            this.btnRectangle.Location = new System.Drawing.Point(146, 0);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(36, 36);
            this.btnRectangle.TabIndex = 5;
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.BackColor = System.Drawing.Color.White;
            this.btnCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCircle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCircle.FlatAppearance.BorderSize = 0;
            this.btnCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCircle.Image = global::Paint.Properties.Resources.icons8_circle_30;
            this.btnCircle.Location = new System.Drawing.Point(0, 0);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(36, 36);
            this.btnCircle.TabIndex = 1;
            this.btnCircle.UseVisualStyleBackColor = false;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.Color.White;
            this.btnSquare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSquare.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSquare.FlatAppearance.BorderSize = 0;
            this.btnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquare.Image = global::Paint.Properties.Resources.icons8_square_spinner_30;
            this.btnSquare.Location = new System.Drawing.Point(110, 0);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(36, 36);
            this.btnSquare.TabIndex = 3;
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.White;
            this.btnLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLine.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLine.FlatAppearance.BorderSize = 0;
            this.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine.Image = global::Paint.Properties.Resources.icons8_line_30;
            this.btnLine.Location = new System.Drawing.Point(73, 0);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(36, 36);
            this.btnLine.TabIndex = 4;
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl2.Appearance.BackColor2 = System.Drawing.Color.White;
            this.groupControl2.Appearance.BorderColor = System.Drawing.Color.White;
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.Appearance.Options.UseBorderColor = true;
            this.groupControl2.AppearanceCaption.BorderColor = System.Drawing.Color.White;
            this.groupControl2.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl2.CaptionLocation = DevExpress.Utils.Locations.Bottom;
            this.groupControl2.Controls.Add(this.btnCopy);
            this.groupControl2.Controls.Add(this.btnPaste);
            this.groupControl2.Location = new System.Drawing.Point(481, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(122, 120);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Clipboard";
            // 
            // btnCopy
            // 
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Tahoma", 7.5F);
            this.btnCopy.Image = global::Paint.Properties.Resources.icons8_copy_40;
            this.btnCopy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCopy.Location = new System.Drawing.Point(60, 0);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(60, 78);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Copy";
            this.btnCopy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // btnPaste
            // 
            this.btnPaste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaste.FlatAppearance.BorderSize = 0;
            this.btnPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaste.Font = new System.Drawing.Font("Tahoma", 7.5F);
            this.btnPaste.Image = global::Paint.Properties.Resources.icons8_paste_40;
            this.btnPaste.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPaste.Location = new System.Drawing.Point(1, 0);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(60, 78);
            this.btnPaste.TabIndex = 4;
            this.btnPaste.Text = "Paste";
            this.btnPaste.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPaste.UseVisualStyleBackColor = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl1.Appearance.BackColor2 = System.Drawing.Color.White;
            this.groupControl1.Appearance.BorderColor = System.Drawing.Color.White;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Appearance.Options.UseBorderColor = true;
            this.groupControl1.AppearanceCaption.BackColor = System.Drawing.Color.White;
            this.groupControl1.AppearanceCaption.BackColor2 = System.Drawing.Color.White;
            this.groupControl1.AppearanceCaption.BorderColor = System.Drawing.Color.White;
            this.groupControl1.AppearanceCaption.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Bottom;
            this.groupControl1.Controls.Add(this.btn_fill);
            this.groupControl1.Controls.Add(this.btn_clear);
            this.groupControl1.Controls.Add(this.btnErase);
            this.groupControl1.Controls.Add(this.btnPencil);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnRedo);
            this.groupControl1.Controls.Add(this.btnUndo);
            this.groupControl1.Controls.Add(this.btnMode);
            this.groupControl1.Location = new System.Drawing.Point(-1, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(481, 120);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Tools";
            // 
            // btn_fill
            // 
            this.btn_fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fill.FlatAppearance.BorderSize = 0;
            this.btn_fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fill.Font = new System.Drawing.Font("Tahoma", 7.5F);
            this.btn_fill.Image = global::Paint.Properties.Resources.icons8_fill_color_401;
            this.btn_fill.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_fill.Location = new System.Drawing.Point(420, 0);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(60, 78);
            this.btn_fill.TabIndex = 7;
            this.btn_fill.Text = "Fill";
            this.btn_fill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_fill.UseVisualStyleBackColor = true;
            this.btn_fill.Click += new System.EventHandler(this.btn_fill_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Tahoma", 7.5F);
            this.btn_clear.Image = global::Paint.Properties.Resources.icons8_clear_40;
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_clear.Location = new System.Drawing.Point(240, 0);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(60, 78);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Clear";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btnErase
            // 
            this.btnErase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnErase.FlatAppearance.BorderSize = 0;
            this.btnErase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErase.Font = new System.Drawing.Font("Tahoma", 7.5F);
            this.btnErase.Image = global::Paint.Properties.Resources.icons8_erase_40;
            this.btnErase.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnErase.Location = new System.Drawing.Point(360, 0);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(60, 78);
            this.btnErase.TabIndex = 5;
            this.btnErase.Text = "Erase";
            this.btnErase.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnPencil
            // 
            this.btnPencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPencil.FlatAppearance.BorderSize = 0;
            this.btnPencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPencil.Font = new System.Drawing.Font("Tahoma", 7.5F);
            this.btnPencil.Image = global::Paint.Properties.Resources.icons8_pencil_drawing_40;
            this.btnPencil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPencil.Location = new System.Drawing.Point(300, 0);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(60, 78);
            this.btnPencil.TabIndex = 4;
            this.btnPencil.Text = "Pencil";
            this.btnPencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPencil.UseVisualStyleBackColor = true;
            this.btnPencil.Click += new System.EventHandler(this.btnPencil_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 7.5F);
            this.btnDelete.Image = global::Paint.Properties.Resources.icons8_delete_40;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(180, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 78);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnRedo
            // 
            this.btnRedo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRedo.FlatAppearance.BorderSize = 0;
            this.btnRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedo.Font = new System.Drawing.Font("Tahoma", 7.5F);
            this.btnRedo.Image = global::Paint.Properties.Resources.icons8_redo_40;
            this.btnRedo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRedo.Location = new System.Drawing.Point(120, 0);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(60, 78);
            this.btnRedo.TabIndex = 2;
            this.btnRedo.Text = "Redo";
            this.btnRedo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRedo.UseVisualStyleBackColor = true;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUndo.FlatAppearance.BorderSize = 0;
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndo.Font = new System.Drawing.Font("Tahoma", 7.5F);
            this.btnUndo.Image = global::Paint.Properties.Resources.icons8_undo_40;
            this.btnUndo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUndo.Location = new System.Drawing.Point(60, 0);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(60, 78);
            this.btnUndo.TabIndex = 1;
            this.btnUndo.Text = "Undo";
            this.btnUndo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnMode
            // 
            this.btnMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMode.FlatAppearance.BorderSize = 0;
            this.btnMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMode.Font = new System.Drawing.Font("Tahoma", 7.5F);
            this.btnMode.Image = global::Paint.Properties.Resources.icons8_picture_40;
            this.btnMode.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMode.Location = new System.Drawing.Point(0, 0);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(60, 78);
            this.btnMode.TabIndex = 1;
            this.btnMode.Text = "Draw Mode";
            this.btnMode.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMode.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 740);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1318, 0);
            this.panel2.TabIndex = 1;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 150);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1318, 590);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // Form1
            // 
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 740);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControl);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.IconOptions.Image = global::Paint.Properties.Resources.icons8_paint_palette_70;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = " ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button btnMode;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Button btnDelete;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnCopy;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private System.Windows.Forms.Button btnBlackColor;
        private System.Windows.Forms.Button btnBrownColor;
        private System.Windows.Forms.Button btnYellowColor;
        private System.Windows.Forms.Button btnPurpleColor;
        private System.Windows.Forms.Button btnRedColor;
        private System.Windows.Forms.Button btnGreenColor;
        private System.Windows.Forms.Button btnBlueColor;
        private System.Windows.Forms.Button btnOrangeColor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxPixel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBoxLine;
        private System.Windows.Forms.Button btnNewFile;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnColorDialog;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnPencil;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button picked_color;
        private System.Windows.Forms.Button btn_fill;
        private System.Windows.Forms.Button btnFillRectangle;
        private System.Windows.Forms.Button btnFillSquare;
        private System.Windows.Forms.Button btnFillEllipse;
        private System.Windows.Forms.Button btnFillCircle;
        private System.Windows.Forms.Button btnFillPolygon;
        private System.Windows.Forms.Button btnPolygon;
    }
}

