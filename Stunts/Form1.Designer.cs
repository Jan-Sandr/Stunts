
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
            this.comboBox1Category = new System.Windows.Forms.ComboBox();
            this.comboBoxDifficulty = new System.Windows.Forms.ComboBox();
            this.comboBoxEquipment = new System.Windows.Forms.ComboBox();
            this.listBoxStunts = new System.Windows.Forms.ListBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.label1Category = new System.Windows.Forms.Label();
            this.label1Difficulty = new System.Windows.Forms.Label();
            this.labelEquipment = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.webBrowserVideo = new System.Windows.Forms.WebBrowser();
            this.labelName = new System.Windows.Forms.Label();
            this.label2Difficulty = new System.Windows.Forms.Label();
            this.labelRequirements = new System.Windows.Forms.Label();
            this.textBoxRequirements = new System.Windows.Forms.TextBox();
            this.progressBarDifficulty = new System.Windows.Forms.ProgressBar();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.textBoxInstructions = new System.Windows.Forms.TextBox();
            this.labelAdvancedTechniques = new System.Windows.Forms.Label();
            this.textBoxAdvancedTechniques = new System.Windows.Forms.TextBox();
            this.labelRecommendation = new System.Windows.Forms.Label();
            this.textBoxRecommendation = new System.Windows.Forms.TextBox();
            this.panelNoVideo = new System.Windows.Forms.Panel();
            this.label2Category = new System.Windows.Forms.Label();
            this.comboBox2Category = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox1Category
            // 
            this.comboBox1Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1Category.FormattingEnabled = true;
            this.comboBox1Category.Items.AddRange(new object[] {
            "Parkour",
            "Gymnastika"});
            this.comboBox1Category.Location = new System.Drawing.Point(291, 10);
            this.comboBox1Category.Name = "comboBox1Category";
            this.comboBox1Category.Size = new System.Drawing.Size(241, 32);
            this.comboBox1Category.TabIndex = 0;
            this.comboBox1Category.Text = "Všechny";
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
            // label1Category
            // 
            this.label1Category.AutoSize = true;
            this.label1Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1Category.Location = new System.Drawing.Point(174, 12);
            this.label1Category.Name = "label1Category";
            this.label1Category.Size = new System.Drawing.Size(105, 24);
            this.label1Category.TabIndex = 5;
            this.label1Category.Text = "Kategorie:";
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
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxName.Location = new System.Drawing.Point(741, 13);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(303, 29);
            this.textBoxName.TabIndex = 10;
            // 
            // webBrowserVideo
            // 
            this.webBrowserVideo.Location = new System.Drawing.Point(12, 166);
            this.webBrowserVideo.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserVideo.Name = "webBrowserVideo";
            this.webBrowserVideo.Size = new System.Drawing.Size(520, 283);
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
            this.labelRequirements.Location = new System.Drawing.Point(551, 115);
            this.labelRequirements.Name = "labelRequirements";
            this.labelRequirements.Size = new System.Drawing.Size(115, 24);
            this.labelRequirements.TabIndex = 17;
            this.labelRequirements.Text = "Požadavky:";
            // 
            // textBoxRequirements
            // 
            this.textBoxRequirements.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxRequirements.Location = new System.Drawing.Point(741, 115);
            this.textBoxRequirements.Multiline = true;
            this.textBoxRequirements.Name = "textBoxRequirements";
            this.textBoxRequirements.Size = new System.Drawing.Size(303, 75);
            this.textBoxRequirements.TabIndex = 16;
            // 
            // progressBarDifficulty
            // 
            this.progressBarDifficulty.BackColor = System.Drawing.Color.White;
            this.progressBarDifficulty.ForeColor = System.Drawing.Color.White;
            this.progressBarDifficulty.Location = new System.Drawing.Point(741, 48);
            this.progressBarDifficulty.Name = "progressBarDifficulty";
            this.progressBarDifficulty.Size = new System.Drawing.Size(303, 29);
            this.progressBarDifficulty.TabIndex = 18;
            this.progressBarDifficulty.Value = 50;
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInstructions.Location = new System.Drawing.Point(551, 196);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(76, 24);
            this.labelInstructions.TabIndex = 20;
            this.labelInstructions.Text = "Návod:";
            // 
            // textBoxInstructions
            // 
            this.textBoxInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxInstructions.Location = new System.Drawing.Point(741, 196);
            this.textBoxInstructions.Multiline = true;
            this.textBoxInstructions.Name = "textBoxInstructions";
            this.textBoxInstructions.Size = new System.Drawing.Size(303, 78);
            this.textBoxInstructions.TabIndex = 19;
            // 
            // labelAdvancedTechniques
            // 
            this.labelAdvancedTechniques.AutoSize = true;
            this.labelAdvancedTechniques.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAdvancedTechniques.Location = new System.Drawing.Point(551, 280);
            this.labelAdvancedTechniques.Name = "labelAdvancedTechniques";
            this.labelAdvancedTechniques.Size = new System.Drawing.Size(186, 24);
            this.labelAdvancedTechniques.TabIndex = 22;
            this.labelAdvancedTechniques.Text = "Pokročilé techniky:";
            // 
            // textBoxAdvancedTechniques
            // 
            this.textBoxAdvancedTechniques.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAdvancedTechniques.Location = new System.Drawing.Point(741, 280);
            this.textBoxAdvancedTechniques.Multiline = true;
            this.textBoxAdvancedTechniques.Name = "textBoxAdvancedTechniques";
            this.textBoxAdvancedTechniques.Size = new System.Drawing.Size(303, 81);
            this.textBoxAdvancedTechniques.TabIndex = 21;
            // 
            // labelRecommendation
            // 
            this.labelRecommendation.AutoSize = true;
            this.labelRecommendation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRecommendation.Location = new System.Drawing.Point(551, 367);
            this.labelRecommendation.Name = "labelRecommendation";
            this.labelRecommendation.Size = new System.Drawing.Size(125, 24);
            this.labelRecommendation.TabIndex = 24;
            this.labelRecommendation.Text = "Doporučení:";
            // 
            // textBoxRecommendation
            // 
            this.textBoxRecommendation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxRecommendation.Location = new System.Drawing.Point(741, 367);
            this.textBoxRecommendation.Multiline = true;
            this.textBoxRecommendation.Name = "textBoxRecommendation";
            this.textBoxRecommendation.Size = new System.Drawing.Size(303, 78);
            this.textBoxRecommendation.TabIndex = 23;
            // 
            // panelNoVideo
            // 
            this.panelNoVideo.AutoSize = true;
            this.panelNoVideo.Location = new System.Drawing.Point(116, 230);
            this.panelNoVideo.Name = "panelNoVideo";
            this.panelNoVideo.Size = new System.Drawing.Size(416, 219);
            this.panelNoVideo.TabIndex = 25;
            // 
            // label2Category
            // 
            this.label2Category.AutoSize = true;
            this.label2Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2Category.Location = new System.Drawing.Point(551, 83);
            this.label2Category.Name = "label2Category";
            this.label2Category.Size = new System.Drawing.Size(105, 24);
            this.label2Category.TabIndex = 27;
            this.label2Category.Text = "Kategorie:";
            // 
            // comboBox2Category
            // 
            this.comboBox2Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox2Category.FormattingEnabled = true;
            this.comboBox2Category.Items.AddRange(new object[] {
            "Parkour",
            "Gymnastika"});
            this.comboBox2Category.Location = new System.Drawing.Point(741, 80);
            this.comboBox2Category.Name = "comboBox2Category";
            this.comboBox2Category.Size = new System.Drawing.Size(303, 32);
            this.comboBox2Category.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 461);
            this.Controls.Add(this.comboBox2Category);
            this.Controls.Add(this.label2Category);
            this.Controls.Add(this.panelNoVideo);
            this.Controls.Add(this.labelRecommendation);
            this.Controls.Add(this.textBoxRecommendation);
            this.Controls.Add(this.labelAdvancedTechniques);
            this.Controls.Add(this.textBoxAdvancedTechniques);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.textBoxInstructions);
            this.Controls.Add(this.progressBarDifficulty);
            this.Controls.Add(this.labelRequirements);
            this.Controls.Add(this.textBoxRequirements);
            this.Controls.Add(this.label2Difficulty);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.webBrowserVideo);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelEquipment);
            this.Controls.Add(this.label1Difficulty);
            this.Controls.Add(this.label1Category);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.listBoxStunts);
            this.Controls.Add(this.comboBoxEquipment);
            this.Controls.Add(this.comboBoxDifficulty);
            this.Controls.Add(this.comboBox1Category);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1Category;
        private System.Windows.Forms.ComboBox comboBoxDifficulty;
        private System.Windows.Forms.ComboBox comboBoxEquipment;
        private System.Windows.Forms.ListBox listBoxStunts;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label label1Category;
        private System.Windows.Forms.Label label1Difficulty;
        private System.Windows.Forms.Label labelEquipment;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.WebBrowser webBrowserVideo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label2Difficulty;
        private System.Windows.Forms.Label labelRequirements;
        private System.Windows.Forms.TextBox textBoxRequirements;
        private System.Windows.Forms.ProgressBar progressBarDifficulty;
        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.TextBox textBoxInstructions;
        private System.Windows.Forms.Label labelAdvancedTechniques;
        private System.Windows.Forms.TextBox textBoxAdvancedTechniques;
        private System.Windows.Forms.Label labelRecommendation;
        private System.Windows.Forms.TextBox textBoxRecommendation;
        private System.Windows.Forms.Panel panelNoVideo;
        private System.Windows.Forms.Label label2Category;
        private System.Windows.Forms.ComboBox comboBox2Category;
    }
}

