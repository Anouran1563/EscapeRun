namespace EscapeRun2
{
    partial class FormCreate
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
            btnBack = new Button();
            btnEnter = new Button();
            btnGen = new Button();
            gBoxGender = new GroupBox();
            rBtnM = new RadioButton();
            rBtnF = new RadioButton();
            cBoxRole = new ComboBox();
            txtName = new TextBox();
            pbChar = new PictureBox();
            lblName = new Label();
            gBoxGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbChar).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 494);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(93, 23);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back to Start";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(555, 494);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(93, 23);
            btnEnter.TabIndex = 1;
            btnEnter.Text = "Enter Game";
            btnEnter.UseVisualStyleBackColor = true;
            // 
            // btnGen
            // 
            btnGen.Location = new Point(258, 494);
            btnGen.Name = "btnGen";
            btnGen.Size = new Size(93, 23);
            btnGen.TabIndex = 2;
            btnGen.Text = "Generate Character";
            btnGen.UseVisualStyleBackColor = true;
            // 
            // gBoxGender
            // 
            gBoxGender.Controls.Add(rBtnM);
            gBoxGender.Controls.Add(rBtnF);
            gBoxGender.Location = new Point(12, 317);
            gBoxGender.Name = "gBoxGender";
            gBoxGender.Size = new Size(200, 100);
            gBoxGender.TabIndex = 3;
            gBoxGender.TabStop = false;
            gBoxGender.Text = "Gender";
            // 
            // rBtnM
            // 
            rBtnM.AutoSize = true;
            rBtnM.Location = new Point(26, 46);
            rBtnM.Name = "rBtnM";
            rBtnM.Size = new Size(55, 21);
            rBtnM.TabIndex = 1;
            rBtnM.TabStop = true;
            rBtnM.Text = "Male";
            rBtnM.UseVisualStyleBackColor = true;
            // 
            // rBtnF
            // 
            rBtnF.AutoSize = true;
            rBtnF.Location = new Point(127, 46);
            rBtnF.Name = "rBtnF";
            rBtnF.Size = new Size(67, 21);
            rBtnF.TabIndex = 0;
            rBtnF.TabStop = true;
            rBtnF.Text = "Female";
            rBtnF.UseVisualStyleBackColor = true;
            // 
            // cBoxRole
            // 
            cBoxRole.FormattingEnabled = true;
            cBoxRole.Items.AddRange(new object[] { "Human", "Knight" });
            cBoxRole.Location = new Point(12, 233);
            cBoxRole.Name = "cBoxRole";
            cBoxRole.Size = new Size(145, 25);
            cBoxRole.TabIndex = 4;
            cBoxRole.Text = "Choose your Theme";
            // 
            // txtName
            // 
            txtName.Location = new Point(34, 39);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 25);
            txtName.TabIndex = 5;
            txtName.Text = "Name";
            // 
            // pbChar
            // 
            pbChar.Image = Properties.Resources.nullis;
            pbChar.Location = new Point(316, 90);
            pbChar.Name = "pbChar";
            pbChar.Size = new Size(120, 247);
            pbChar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbChar.TabIndex = 6;
            pbChar.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(368, 356);
            lblName.Name = "lblName";
            lblName.Size = new Size(17, 17);
            lblName.TabIndex = 7;
            lblName.Text = "...";
            // 
            // FormCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 529);
            Controls.Add(lblName);
            Controls.Add(pbChar);
            Controls.Add(txtName);
            Controls.Add(cBoxRole);
            Controls.Add(gBoxGender);
            Controls.Add(btnGen);
            Controls.Add(btnEnter);
            Controls.Add(btnBack);
            Name = "FormCreate";
            Text = "FormCreate";
            gBoxGender.ResumeLayout(false);
            gBoxGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbChar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnEnter;
        private Button btnGen;
        private GroupBox gBoxGender;
        private RadioButton rBtnF;
        private ComboBox cBoxRole;
        private RadioButton rBtnM;
        private TextBox txtName;
        private PictureBox pbChar;
        private Label lblName;
    }
}