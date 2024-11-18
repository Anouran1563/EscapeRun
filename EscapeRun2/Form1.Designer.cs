namespace EscapeRun2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnCreate = new Button();
            btnCfg = new Button();
            btnExt = new Button();
            btnStart = new Button();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(157, 137);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(128, 50);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create Game";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnCfg
            // 
            btnCfg.Location = new Point(157, 219);
            btnCfg.Name = "btnCfg";
            btnCfg.Size = new Size(128, 50);
            btnCfg.TabIndex = 1;
            btnCfg.Text = "Settings";
            btnCfg.UseVisualStyleBackColor = true;
            btnCfg.Click += btnOptn_Click;
            // 
            // btnExt
            // 
            btnExt.Location = new Point(157, 303);
            btnExt.Name = "btnExt";
            btnExt.Size = new Size(128, 50);
            btnExt.TabIndex = 2;
            btnExt.Text = "Exit";
            btnExt.UseVisualStyleBackColor = true;
            btnExt.Click += btnExit_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(157, 71);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(128, 50);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start Game";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStrt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(475, 485);
            Controls.Add(btnStart);
            Controls.Add(btnExt);
            Controls.Add(btnCfg);
            Controls.Add(btnCreate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreate;
        private Button btnCfg;
        private Button btnExt;
        private Button btnStart;
    }
}
