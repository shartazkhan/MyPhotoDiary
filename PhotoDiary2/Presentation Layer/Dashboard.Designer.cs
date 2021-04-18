
namespace PhotoDiary2.Presentation_Layer
{
    partial class Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBrowse = new Guna.UI2.WinForms.Guna2Button();
            this.labelUsername = new Guna.UI.WinForms.GunaLabel();
            this.textBoxPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.radioButtonModerate = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonHigh = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonLow = new Guna.UI2.WinForms.Guna2RadioButton();
            this.buttonPost = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxStory = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.buttonDelete = new Guna.UI2.WinForms.Guna2Button();
            this.buttonUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.elipseUpdate = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elipseAdd = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.buttonLogout = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonGallery = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.buttonRefreshList = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.buttonRefreshList);
            this.panel1.Controls.Add(this.buttonBrowse);
            this.panel1.Controls.Add(this.labelUsername);
            this.panel1.Controls.Add(this.textBoxPath);
            this.panel1.Controls.Add(this.radioButtonModerate);
            this.panel1.Controls.Add(this.radioButtonHigh);
            this.panel1.Controls.Add(this.radioButtonLow);
            this.panel1.Controls.Add(this.buttonPost);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(168, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 536);
            this.panel1.TabIndex = 6;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.CheckedState.Parent = this.buttonBrowse;
            this.buttonBrowse.CustomImages.Parent = this.buttonBrowse;
            this.buttonBrowse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonBrowse.ForeColor = System.Drawing.Color.White;
            this.buttonBrowse.HoverState.Parent = this.buttonBrowse;
            this.buttonBrowse.Location = new System.Drawing.Point(191, 420);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.ShadowDecoration.Parent = this.buttonBrowse;
            this.buttonBrowse.Size = new System.Drawing.Size(79, 36);
            this.buttonBrowse.TabIndex = 15;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.DimGray;
            this.labelUsername.Location = new System.Drawing.Point(15, 16);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(67, 25);
            this.labelUsername.TabIndex = 12;
            this.labelUsername.Text = "Hello, ";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPath.DefaultText = "";
            this.textBoxPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPath.DisabledState.Parent = this.textBoxPath;
            this.textBoxPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPath.FocusedState.Parent = this.textBoxPath;
            this.textBoxPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPath.HoverState.Parent = this.textBoxPath;
            this.textBoxPath.Location = new System.Drawing.Point(38, 420);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.PasswordChar = '\0';
            this.textBoxPath.PlaceholderText = "";
            this.textBoxPath.SelectedText = "";
            this.textBoxPath.ShadowDecoration.Parent = this.textBoxPath;
            this.textBoxPath.Size = new System.Drawing.Size(147, 36);
            this.textBoxPath.TabIndex = 16;
            // 
            // radioButtonModerate
            // 
            this.radioButtonModerate.AutoSize = true;
            this.radioButtonModerate.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonModerate.CheckedState.BorderThickness = 0;
            this.radioButtonModerate.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonModerate.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioButtonModerate.CheckedState.InnerOffset = -4;
            this.radioButtonModerate.Location = new System.Drawing.Point(380, 439);
            this.radioButtonModerate.Name = "radioButtonModerate";
            this.radioButtonModerate.Size = new System.Drawing.Size(70, 17);
            this.radioButtonModerate.TabIndex = 17;
            this.radioButtonModerate.TabStop = true;
            this.radioButtonModerate.Text = "Moderate";
            this.radioButtonModerate.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonModerate.UncheckedState.BorderThickness = 2;
            this.radioButtonModerate.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioButtonModerate.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radioButtonModerate.UseVisualStyleBackColor = true;
            // 
            // radioButtonHigh
            // 
            this.radioButtonHigh.AutoSize = true;
            this.radioButtonHigh.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonHigh.CheckedState.BorderThickness = 0;
            this.radioButtonHigh.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonHigh.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioButtonHigh.CheckedState.InnerOffset = -4;
            this.radioButtonHigh.Location = new System.Drawing.Point(321, 439);
            this.radioButtonHigh.Name = "radioButtonHigh";
            this.radioButtonHigh.Size = new System.Drawing.Size(47, 17);
            this.radioButtonHigh.TabIndex = 19;
            this.radioButtonHigh.TabStop = true;
            this.radioButtonHigh.Text = "High";
            this.radioButtonHigh.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonHigh.UncheckedState.BorderThickness = 2;
            this.radioButtonHigh.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioButtonHigh.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radioButtonHigh.UseVisualStyleBackColor = true;
            // 
            // radioButtonLow
            // 
            this.radioButtonLow.AutoSize = true;
            this.radioButtonLow.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonLow.CheckedState.BorderThickness = 0;
            this.radioButtonLow.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonLow.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioButtonLow.CheckedState.InnerOffset = -4;
            this.radioButtonLow.Location = new System.Drawing.Point(460, 439);
            this.radioButtonLow.Name = "radioButtonLow";
            this.radioButtonLow.Size = new System.Drawing.Size(45, 17);
            this.radioButtonLow.TabIndex = 18;
            this.radioButtonLow.TabStop = true;
            this.radioButtonLow.Text = "Low";
            this.radioButtonLow.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonLow.UncheckedState.BorderThickness = 2;
            this.radioButtonLow.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioButtonLow.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radioButtonLow.UseVisualStyleBackColor = true;
            // 
            // buttonPost
            // 
            this.buttonPost.CheckedState.Parent = this.buttonPost;
            this.buttonPost.CustomImages.Parent = this.buttonPost;
            this.buttonPost.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonPost.ForeColor = System.Drawing.Color.White;
            this.buttonPost.HoverState.Parent = this.buttonPost;
            this.buttonPost.Location = new System.Drawing.Point(670, 420);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.ShadowDecoration.Parent = this.buttonPost;
            this.buttonPost.Size = new System.Drawing.Size(180, 36);
            this.buttonPost.TabIndex = 14;
            this.buttonPost.Text = "Post";
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.textBoxTitle);
            this.panel2.Controls.Add(this.textBoxStory);
            this.panel2.Location = new System.Drawing.Point(20, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(841, 337);
            this.panel2.TabIndex = 13;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxTitle.DefaultText = "";
            this.textBoxTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxTitle.DisabledState.Parent = this.textBoxTitle;
            this.textBoxTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxTitle.FocusedState.Parent = this.textBoxTitle;
            this.textBoxTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxTitle.HoverState.Parent = this.textBoxTitle;
            this.textBoxTitle.Location = new System.Drawing.Point(507, 15);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.PasswordChar = '\0';
            this.textBoxTitle.PlaceholderText = "Title";
            this.textBoxTitle.SelectedText = "";
            this.textBoxTitle.ShadowDecoration.Parent = this.textBoxTitle;
            this.textBoxTitle.Size = new System.Drawing.Size(200, 36);
            this.textBoxTitle.TabIndex = 1;
            // 
            // textBoxStory
            // 
            this.textBoxStory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxStory.DefaultText = "";
            this.textBoxStory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxStory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxStory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxStory.DisabledState.Parent = this.textBoxStory;
            this.textBoxStory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxStory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxStory.FocusedState.Parent = this.textBoxStory;
            this.textBoxStory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxStory.HoverState.Parent = this.textBoxStory;
            this.textBoxStory.Location = new System.Drawing.Point(507, 57);
            this.textBoxStory.Multiline = true;
            this.textBoxStory.Name = "textBoxStory";
            this.textBoxStory.PasswordChar = '\0';
            this.textBoxStory.PlaceholderText = "Write your story in 250 word";
            this.textBoxStory.SelectedText = "";
            this.textBoxStory.ShadowDecoration.Parent = this.textBoxStory;
            this.textBoxStory.Size = new System.Drawing.Size(320, 266);
            this.textBoxStory.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.CheckedState.Parent = this.buttonAdd;
            this.buttonAdd.CustomImages.Parent = this.buttonAdd;
            this.buttonAdd.FillColor = System.Drawing.Color.MediumAquamarine;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.HoverState.Parent = this.buttonAdd;
            this.buttonAdd.Location = new System.Drawing.Point(0, 237);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.ShadowDecoration.Parent = this.buttonAdd;
            this.buttonAdd.Size = new System.Drawing.Size(168, 46);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.CheckedState.Parent = this.buttonDelete;
            this.buttonDelete.CustomImages.Parent = this.buttonDelete;
            this.buttonDelete.FillColor = System.Drawing.Color.MediumAquamarine;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.HoverState.Parent = this.buttonDelete;
            this.buttonDelete.Location = new System.Drawing.Point(0, 347);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.ShadowDecoration.Parent = this.buttonDelete;
            this.buttonDelete.Size = new System.Drawing.Size(168, 46);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.CheckedState.Parent = this.buttonUpdate;
            this.buttonUpdate.CustomImages.Parent = this.buttonUpdate;
            this.buttonUpdate.FillColor = System.Drawing.Color.MediumAquamarine;
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.HoverState.Parent = this.buttonUpdate;
            this.buttonUpdate.Location = new System.Drawing.Point(0, 401);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.ShadowDecoration.Parent = this.buttonUpdate;
            this.buttonUpdate.Size = new System.Drawing.Size(168, 46);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // elipseUpdate
            // 
            this.elipseUpdate.TargetControl = this.panel1;
            // 
            // elipseAdd
            // 
            this.elipseAdd.TargetControl = this.panel1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.dataGridView1.Location = new System.Drawing.Point(1057, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(248, 533);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridView1.ThemeStyle.ReadOnly = true;
            this.dataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            this.dataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // buttonLogout
            // 
            this.buttonLogout.CheckedState.Parent = this.buttonLogout;
            this.buttonLogout.CustomImages.Parent = this.buttonLogout;
            this.buttonLogout.FillColor = System.Drawing.Color.White;
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.buttonLogout.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.buttonLogout.HoverState.FillColor = System.Drawing.Color.LightCoral;
            this.buttonLogout.HoverState.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.HoverState.Parent = this.buttonLogout;
            this.buttonLogout.Location = new System.Drawing.Point(0, 458);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.ShadowDecoration.Parent = this.buttonLogout;
            this.buttonLogout.Size = new System.Drawing.Size(168, 46);
            this.buttonLogout.TabIndex = 13;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel1.Location = new System.Drawing.Point(0, -1);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(168, 198);
            this.guna2Panel1.TabIndex = 15;
            // 
            // buttonGallery
            // 
            this.buttonGallery.CheckedState.Parent = this.buttonGallery;
            this.buttonGallery.CustomImages.Parent = this.buttonGallery;
            this.buttonGallery.FillColor = System.Drawing.Color.MediumAquamarine;
            this.buttonGallery.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonGallery.ForeColor = System.Drawing.Color.White;
            this.buttonGallery.HoverState.Parent = this.buttonGallery;
            this.buttonGallery.Location = new System.Drawing.Point(0, 292);
            this.buttonGallery.Name = "buttonGallery";
            this.buttonGallery.ShadowDecoration.Parent = this.buttonGallery;
            this.buttonGallery.Size = new System.Drawing.Size(168, 46);
            this.buttonGallery.TabIndex = 16;
            this.buttonGallery.Text = " Gallery";
            this.buttonGallery.Click += new System.EventHandler(this.buttonShowSotry_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(15, 28);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(137, 126);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 14;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // buttonRefreshList
            // 
            this.buttonRefreshList.AutoRoundedCorners = true;
            this.buttonRefreshList.BorderRadius = 18;
            this.buttonRefreshList.CheckedState.Parent = this.buttonRefreshList;
            this.buttonRefreshList.CustomImages.Parent = this.buttonRefreshList;
            this.buttonRefreshList.FillColor = System.Drawing.Color.MediumAquamarine;
            this.buttonRefreshList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonRefreshList.ForeColor = System.Drawing.Color.White;
            this.buttonRefreshList.HoverState.Parent = this.buttonRefreshList;
            this.buttonRefreshList.Image = global::PhotoDiary2.Properties.Resources.pngwing_com;
            this.buttonRefreshList.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonRefreshList.ImageSize = new System.Drawing.Size(25, 25);
            this.buttonRefreshList.Location = new System.Drawing.Point(736, 12);
            this.buttonRefreshList.Name = "buttonRefreshList";
            this.buttonRefreshList.ShadowDecoration.Parent = this.buttonRefreshList;
            this.buttonRefreshList.Size = new System.Drawing.Size(125, 38);
            this.buttonRefreshList.TabIndex = 20;
            this.buttonRefreshList.Text = "Refresh List";
            this.buttonRefreshList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.buttonRefreshList.Click += new System.EventHandler(this.buttonRefreshList_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(470, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1305, 533);
            this.Controls.Add(this.buttonGallery);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button buttonAdd;
        private Guna.UI2.WinForms.Guna2Button buttonDelete;
        private Guna.UI2.WinForms.Guna2Button buttonUpdate;
        private Guna.UI2.WinForms.Guna2Elipse elipseUpdate;
        private Guna.UI2.WinForms.Guna2Elipse elipseAdd;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private Guna.UI.WinForms.GunaLabel labelUsername;
        private Guna.UI2.WinForms.Guna2Button buttonBrowse;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPath;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonModerate;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonHigh;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonLow;
        private Guna.UI2.WinForms.Guna2Button buttonPost;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxTitle;
        private Guna.UI2.WinForms.Guna2TextBox textBoxStory;
        private Guna.UI2.WinForms.Guna2Button buttonLogout;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button buttonGallery;
        private Guna.UI2.WinForms.Guna2Button buttonRefreshList;
    }
}