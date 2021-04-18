
namespace PhotoDiary2.Presentation_Layer
{
    partial class AddStory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxStory = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonPost = new Guna.UI2.WinForms.Guna2Button();
            this.buttonBrowse = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.radioButtonModerate = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonLow = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonHigh = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.elipseAdd = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBoxTitle);
            this.panel1.Controls.Add(this.textBoxStory);
            this.panel1.Location = new System.Drawing.Point(23, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 337);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(470, 308);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.textBoxStory.PlaceholderText = "Write your story in 100 word";
            this.textBoxStory.SelectedText = "";
            this.textBoxStory.ShadowDecoration.Parent = this.textBoxStory;
            this.textBoxStory.Size = new System.Drawing.Size(320, 266);
            this.textBoxStory.TabIndex = 2;
            // 
            // buttonPost
            // 
            this.buttonPost.CheckedState.Parent = this.buttonPost;
            this.buttonPost.CustomImages.Parent = this.buttonPost;
            this.buttonPost.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonPost.ForeColor = System.Drawing.Color.White;
            this.buttonPost.HoverState.Parent = this.buttonPost;
            this.buttonPost.Location = new System.Drawing.Point(670, 376);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.ShadowDecoration.Parent = this.buttonPost;
            this.buttonPost.Size = new System.Drawing.Size(180, 36);
            this.buttonPost.TabIndex = 1;
            this.buttonPost.Text = "Post";
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.CheckedState.Parent = this.buttonBrowse;
            this.buttonBrowse.CustomImages.Parent = this.buttonBrowse;
            this.buttonBrowse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonBrowse.ForeColor = System.Drawing.Color.White;
            this.buttonBrowse.HoverState.Parent = this.buttonBrowse;
            this.buttonBrowse.Location = new System.Drawing.Point(191, 376);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.ShadowDecoration.Parent = this.buttonBrowse;
            this.buttonBrowse.Size = new System.Drawing.Size(79, 36);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
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
            this.textBoxPath.Location = new System.Drawing.Point(38, 376);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.PasswordChar = '\0';
            this.textBoxPath.PlaceholderText = "";
            this.textBoxPath.SelectedText = "";
            this.textBoxPath.ShadowDecoration.Parent = this.textBoxPath;
            this.textBoxPath.Size = new System.Drawing.Size(147, 36);
            this.textBoxPath.TabIndex = 3;
            // 
            // radioButtonModerate
            // 
            this.radioButtonModerate.AutoSize = true;
            this.radioButtonModerate.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonModerate.CheckedState.BorderThickness = 0;
            this.radioButtonModerate.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonModerate.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioButtonModerate.CheckedState.InnerOffset = -4;
            this.radioButtonModerate.Location = new System.Drawing.Point(530, 395);
            this.radioButtonModerate.Name = "radioButtonModerate";
            this.radioButtonModerate.Size = new System.Drawing.Size(70, 17);
            this.radioButtonModerate.TabIndex = 3;
            this.radioButtonModerate.TabStop = true;
            this.radioButtonModerate.Text = "Moderate";
            this.radioButtonModerate.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonModerate.UncheckedState.BorderThickness = 2;
            this.radioButtonModerate.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioButtonModerate.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radioButtonModerate.UseVisualStyleBackColor = true;
            // 
            // radioButtonLow
            // 
            this.radioButtonLow.AutoSize = true;
            this.radioButtonLow.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonLow.CheckedState.BorderThickness = 0;
            this.radioButtonLow.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonLow.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioButtonLow.CheckedState.InnerOffset = -4;
            this.radioButtonLow.Location = new System.Drawing.Point(610, 395);
            this.radioButtonLow.Name = "radioButtonLow";
            this.radioButtonLow.Size = new System.Drawing.Size(45, 17);
            this.radioButtonLow.TabIndex = 4;
            this.radioButtonLow.TabStop = true;
            this.radioButtonLow.Text = "Low";
            this.radioButtonLow.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonLow.UncheckedState.BorderThickness = 2;
            this.radioButtonLow.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioButtonLow.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radioButtonLow.UseVisualStyleBackColor = true;
            // 
            // radioButtonHigh
            // 
            this.radioButtonHigh.AutoSize = true;
            this.radioButtonHigh.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonHigh.CheckedState.BorderThickness = 0;
            this.radioButtonHigh.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonHigh.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioButtonHigh.CheckedState.InnerOffset = -4;
            this.radioButtonHigh.Location = new System.Drawing.Point(471, 395);
            this.radioButtonHigh.Name = "radioButtonHigh";
            this.radioButtonHigh.Size = new System.Drawing.Size(47, 17);
            this.radioButtonHigh.TabIndex = 5;
            this.radioButtonHigh.TabStop = true;
            this.radioButtonHigh.Text = "High";
            this.radioButtonHigh.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonHigh.UncheckedState.BorderThickness = 2;
            this.radioButtonHigh.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioButtonHigh.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radioButtonHigh.UseVisualStyleBackColor = true;
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.CheckedState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.HoverState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(276, 376);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.ShadowDecoration.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(176, 36);
            this.guna2DateTimePicker1.TabIndex = 6;
            this.guna2DateTimePicker1.Value = new System.DateTime(2021, 4, 17, 4, 12, 4, 473);
            // 
            // elipseAdd
            // 
            this.elipseAdd.TargetControl = this;
            // 
            // AddStory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.radioButtonModerate);
            this.Controls.Add(this.radioButtonHigh);
            this.Controls.Add(this.radioButtonLow);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.panel1);
            this.Name = "AddStory";
            this.Size = new System.Drawing.Size(886, 447);
            this.Load += new System.EventHandler(this.AddStory_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPath;
        private Guna.UI2.WinForms.Guna2Button buttonBrowse;
        private Guna.UI2.WinForms.Guna2Button buttonPost;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxTitle;
        private Guna.UI2.WinForms.Guna2TextBox textBoxStory;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonModerate;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonLow;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonHigh;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2Elipse elipseAdd;
    }
}
