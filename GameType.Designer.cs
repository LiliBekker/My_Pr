namespace VoicedAndDeafConsonants
{
    partial class GameType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameType));
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonHard = new System.Windows.Forms.Button();
            this.buttonSoft = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBack.BackColor = System.Drawing.Color.Honeydew;
            this.buttonBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBack.BackgroundImage")));
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.ForeColor = System.Drawing.Color.Maroon;
            this.buttonBack.Location = new System.Drawing.Point(85, 38);
            this.buttonBack.MaximumSize = new System.Drawing.Size(340, 150);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(60, 60);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonHard
            // 
            this.buttonHard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonHard.BackColor = System.Drawing.Color.Honeydew;
            this.buttonHard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHard.BackgroundImage")));
            this.buttonHard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHard.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHard.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonHard.Location = new System.Drawing.Point(300, 196);
            this.buttonHard.MaximumSize = new System.Drawing.Size(340, 150);
            this.buttonHard.Name = "buttonHard";
            this.buttonHard.Size = new System.Drawing.Size(200, 105);
            this.buttonHard.TabIndex = 1;
            this.buttonHard.Text = "Твердые согласные";
            this.buttonHard.UseVisualStyleBackColor = false;
            this.buttonHard.Click += new System.EventHandler(this.buttonHard_Click);
            // 
            // buttonSoft
            // 
            this.buttonSoft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSoft.BackColor = System.Drawing.Color.Honeydew;
            this.buttonSoft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSoft.BackgroundImage")));
            this.buttonSoft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSoft.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSoft.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonSoft.Location = new System.Drawing.Point(300, 303);
            this.buttonSoft.MaximumSize = new System.Drawing.Size(340, 150);
            this.buttonSoft.Name = "buttonSoft";
            this.buttonSoft.Size = new System.Drawing.Size(200, 105);
            this.buttonSoft.TabIndex = 2;
            this.buttonSoft.Text = "Мягкие согласные";
            this.buttonSoft.UseVisualStyleBackColor = false;
            this.buttonSoft.Click += new System.EventHandler(this.buttonSoft_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 179);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите какие согласные будем учить";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAll
            // 
            this.buttonAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAll.BackColor = System.Drawing.Color.Honeydew;
            this.buttonAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAll.BackgroundImage")));
            this.buttonAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAll.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAll.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonAll.Location = new System.Drawing.Point(300, 410);
            this.buttonAll.MaximumSize = new System.Drawing.Size(340, 150);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(200, 105);
            this.buttonAll.TabIndex = 3;
            this.buttonAll.Text = "Все согласные ";
            this.buttonAll.UseVisualStyleBackColor = false;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // GameType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAll);
            this.Controls.Add(this.buttonSoft);
            this.Controls.Add(this.buttonHard);
            this.Controls.Add(this.buttonBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Звонкие и глухие согласные";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonHard;
        private System.Windows.Forms.Button buttonSoft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAll;
    }
}