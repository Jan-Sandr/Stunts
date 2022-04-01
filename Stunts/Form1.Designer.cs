
namespace Stunts
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxDifficulty = new System.Windows.Forms.ComboBox();
            this.comboBoxEquipment = new System.Windows.Forms.ComboBox();
            this.listBoxStunts = new System.Windows.Forms.ListBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelCategory = new System.Windows.Forms.Label();
            this.label1Difficulty = new System.Windows.Forms.Label();
            this.labelEquipment = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.webBrowserVideo = new System.Windows.Forms.WebBrowser();
            this.labelName = new System.Windows.Forms.Label();
            this.progressBarDifficulty = new System.Windows.Forms.ProgressBar();
            this.label2Difficulty = new System.Windows.Forms.Label();
            this.labelRequirements = new System.Windows.Forms.Label();
            this.textBoxRequirements = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Parkour",
            "Gymnastika"});
            this.comboBoxCategory.Location = new System.Drawing.Point(291, 10);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(241, 32);
            this.comboBoxCategory.TabIndex = 0;
            this.comboBoxCategory.Text = "Všechny";
            // 
            // comboBoxDifficulty
            // 
            this.comboBoxDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxDifficulty.FormattingEnabled = true;
            this.comboBoxDifficulty.Items.AddRange(new object[] {
            "1-3",
            "4-6",
            "7-10"});
            this.comboBoxDifficulty.Location = new System.Drawing.Point(291, 48);
            this.comboBoxDifficulty.Name = "comboBoxDifficulty";
            this.comboBoxDifficulty.Size = new System.Drawing.Size(241, 32);
            this.comboBoxDifficulty.TabIndex = 1;
            this.comboBoxDifficulty.Text = "Všechny";
            // 
            // comboBoxEquipment
            // 
            this.comboBoxEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxEquipment.FormattingEnabled = true;
            this.comboBoxEquipment.Items.AddRange(new object[] {
            "Ano",
            "Ne"});
            this.comboBoxEquipment.Location = new System.Drawing.Point(434, 86);
            this.comboBoxEquipment.Name = "comboBoxEquipment";
            this.comboBoxEquipment.Size = new System.Drawing.Size(98, 32);
            this.comboBoxEquipment.TabIndex = 2;
            this.comboBoxEquipment.Text = "Ano/Ne";
            // 
            // listBoxStunts
            // 
            this.listBoxStunts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxStunts.FormattingEnabled = true;
            this.listBoxStunts.ItemHeight = 24;
            this.listBoxStunts.Location = new System.Drawing.Point(12, 12);
            this.listBoxStunts.Name = "listBoxStunts";
            this.listBoxStunts.Size = new System.Drawing.Size(159, 148);
            this.listBoxStunts.TabIndex = 3;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEdit.Location = new System.Drawing.Point(177, 127);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(355, 33);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Editace";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCategory.Location = new System.Drawing.Point(174, 12);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(105, 24);
            this.labelCategory.TabIndex = 5;
            this.labelCategory.Text = "Kategorie:";
            // 
            // label1Difficulty
            // 
            this.label1Difficulty.AutoSize = true;
            this.label1Difficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1Difficulty.Location = new System.Drawing.Point(174, 51);
            this.label1Difficulty.Name = "label1Difficulty";
            this.label1Difficulty.Size = new System.Drawing.Size(111, 24);
            this.label1Difficulty.TabIndex = 6;
            this.label1Difficulty.Text = "Náročnost:";
            // 
            // labelEquipment
            // 
            this.labelEquipment.AutoSize = true;
            this.labelEquipment.BackColor = System.Drawing.Color.Transparent;
            this.labelEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEquipment.Location = new System.Drawing.Point(174, 89);
            this.labelEquipment.Name = "labelEquipment";
            this.labelEquipment.Size = new System.Drawing.Size(254, 24);
            this.labelEquipment.TabIndex = 7;
            this.labelEquipment.Text = "Potřeba nějakého náčiní ?";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(656, 402);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 29);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(690, 345);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 29);
            this.textBox2.TabIndex = 9;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxName.Location = new System.Drawing.Point(676, 13);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(144, 29);
            this.textBoxName.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox4.Location = new System.Drawing.Point(602, 357);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 29);
            this.textBox4.TabIndex = 11;
            // 
            // webBrowserVideo
            // 
            this.webBrowserVideo.Location = new System.Drawing.Point(12, 166);
            this.webBrowserVideo.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserVideo.Name = "webBrowserVideo";
            this.webBrowserVideo.Size = new System.Drawing.Size(520, 284);
            this.webBrowserVideo.TabIndex = 12;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(551, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(79, 24);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Jméno:";
            // 
            // progressBarDifficulty
            // 
            this.progressBarDifficulty.ForeColor = System.Drawing.Color.Lime;
            this.progressBarDifficulty.Location = new System.Drawing.Point(676, 48);
            this.progressBarDifficulty.Maximum = 10;
            this.progressBarDifficulty.Name = "progressBarDifficulty";
            this.progressBarDifficulty.Size = new System.Drawing.Size(144, 29);
            this.progressBarDifficulty.TabIndex = 14;
            // 
            // label2Difficulty
            // 
            this.label2Difficulty.AutoSize = true;
            this.label2Difficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2Difficulty.Location = new System.Drawing.Point(551, 47);
            this.label2Difficulty.Name = "label2Difficulty";
            this.label2Difficulty.Size = new System.Drawing.Size(103, 24);
            this.label2Difficulty.TabIndex = 15;
            this.label2Difficulty.Text = "Obtížnost:";
            // 
            // labelRequirements
            // 
            this.labelRequirements.AutoSize = true;
            this.labelRequirements.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRequirements.Location = new System.Drawing.Point(551, 86);
            this.labelRequirements.Name = "labelRequirements";
            this.labelRequirements.Size = new System.Drawing.Size(115, 24);
            this.labelRequirements.TabIndex = 17;
            this.labelRequirements.Text = "Požadavky:";
            // 
            // textBoxRequirements
            // 
            this.textBoxRequirements.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxRequirements.Location = new System.Drawing.Point(676, 86);
            this.textBoxRequirements.Multiline = true;
            this.textBoxRequirements.Name = "textBoxRequirements";
            this.textBoxRequirements.Size = new System.Drawing.Size(251, 78);
            this.textBoxRequirements.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 457);
            this.Controls.Add(this.labelRequirements);
            this.Controls.Add(this.textBoxRequirements);
            this.Controls.Add(this.label2Difficulty);
            this.Controls.Add(this.progressBarDifficulty);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.webBrowserVideo);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelEquipment);
            this.Controls.Add(this.label1Difficulty);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.listBoxStunts);
            this.Controls.Add(this.comboBoxEquipment);
            this.Controls.Add(this.comboBoxDifficulty);
            this.Controls.Add(this.comboBoxCategory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxDifficulty;
        private System.Windows.Forms.ComboBox comboBoxEquipment;
        private System.Windows.Forms.ListBox listBoxStunts;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label label1Difficulty;
        private System.Windows.Forms.Label labelEquipment;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.WebBrowser webBrowserVideo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ProgressBar progressBarDifficulty;
        private System.Windows.Forms.Label label2Difficulty;
        private System.Windows.Forms.Label labelRequirements;
        private System.Windows.Forms.TextBox textBoxRequirements;
    }
}

