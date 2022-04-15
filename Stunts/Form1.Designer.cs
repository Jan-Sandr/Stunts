
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
            this.labelExperiences = new System.Windows.Forms.Label();
            this.textBoxExperiences = new System.Windows.Forms.TextBox();
            this.checkBoxEquipment = new System.Windows.Forms.CheckBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxVideoLink = new System.Windows.Forms.TextBox();
            this.numericUpDownDifficulty = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialogSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.pictureBoxNoVideo = new System.Windows.Forms.PictureBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboBoxCategory2 = new System.Windows.Forms.ComboBox();
            this.labelEquipment2 = new System.Windows.Forms.Label();
            this.checkBoxEquipment2 = new System.Windows.Forms.CheckBox();
            this.labelFiltration = new System.Windows.Forms.Label();
            this.labelEdit = new System.Windows.Forms.Label();
            this.checkBoxShowDifficulty = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDifficulty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Gymnastika",
            "Parkour",
            "Jiná",
            "Všechny"});
            this.comboBoxCategory.Location = new System.Drawing.Point(369, 53);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(241, 32);
            this.comboBoxCategory.TabIndex = 0;
            this.comboBoxCategory.Text = "Všechny";
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCategorySelectedIndexChanged);
            // 
            // comboBoxDifficulty
            // 
            this.comboBoxDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxDifficulty.FormattingEnabled = true;
            this.comboBoxDifficulty.Items.AddRange(new object[] {
            "1-3",
            "4-6",
            "7-10",
            "Všechny"});
            this.comboBoxDifficulty.Location = new System.Drawing.Point(369, 91);
            this.comboBoxDifficulty.Name = "comboBoxDifficulty";
            this.comboBoxDifficulty.Size = new System.Drawing.Size(241, 32);
            this.comboBoxDifficulty.TabIndex = 1;
            this.comboBoxDifficulty.Text = "Všechny";
            this.comboBoxDifficulty.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDifficultySelectedIndexChanged);
            // 
            // listBoxStunts
            // 
            this.listBoxStunts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxStunts.FormattingEnabled = true;
            this.listBoxStunts.ItemHeight = 24;
            this.listBoxStunts.Location = new System.Drawing.Point(12, 12);
            this.listBoxStunts.Name = "listBoxStunts";
            this.listBoxStunts.Size = new System.Drawing.Size(234, 148);
            this.listBoxStunts.TabIndex = 3;
            this.listBoxStunts.SelectedIndexChanged += new System.EventHandler(this.ListBoxStuntsSelectedIndexChanged);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEdit.Location = new System.Drawing.Point(953, 522);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(108, 33);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Editovat";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.DatabaseActionButtonsClick);
            // 
            // label1Category
            // 
            this.label1Category.AutoSize = true;
            this.label1Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1Category.Location = new System.Drawing.Point(252, 55);
            this.label1Category.Name = "label1Category";
            this.label1Category.Size = new System.Drawing.Size(105, 24);
            this.label1Category.TabIndex = 5;
            this.label1Category.Text = "Kategorie:";
            // 
            // label1Difficulty
            // 
            this.label1Difficulty.AutoSize = true;
            this.label1Difficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1Difficulty.Location = new System.Drawing.Point(252, 94);
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
            this.labelEquipment.Location = new System.Drawing.Point(252, 132);
            this.labelEquipment.Name = "labelEquipment";
            this.labelEquipment.Size = new System.Drawing.Size(254, 24);
            this.labelEquipment.TabIndex = 7;
            this.labelEquipment.Text = "Potřeba nějakého náčiní ?";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxName.Location = new System.Drawing.Point(869, 84);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(303, 29);
            this.textBoxName.TabIndex = 10;
            // 
            // webBrowserVideo
            // 
            this.webBrowserVideo.Location = new System.Drawing.Point(12, 255);
            this.webBrowserVideo.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserVideo.Name = "webBrowserVideo";
            this.webBrowserVideo.ScriptErrorsSuppressed = true;
            this.webBrowserVideo.ScrollBarsEnabled = false;
            this.webBrowserVideo.Size = new System.Drawing.Size(600, 300);
            this.webBrowserVideo.TabIndex = 12;
            this.webBrowserVideo.Visible = false;
            this.webBrowserVideo.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBrowserVideoDocumentCompleted);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(679, 84);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(79, 24);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Jméno:";
            // 
            // label2Difficulty
            // 
            this.label2Difficulty.AutoSize = true;
            this.label2Difficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2Difficulty.Location = new System.Drawing.Point(679, 118);
            this.label2Difficulty.Name = "label2Difficulty";
            this.label2Difficulty.Size = new System.Drawing.Size(103, 24);
            this.label2Difficulty.TabIndex = 15;
            this.label2Difficulty.Text = "Obtížnost:";
            // 
            // labelRequirements
            // 
            this.labelRequirements.AutoSize = true;
            this.labelRequirements.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRequirements.Location = new System.Drawing.Point(679, 186);
            this.labelRequirements.Name = "labelRequirements";
            this.labelRequirements.Size = new System.Drawing.Size(115, 24);
            this.labelRequirements.TabIndex = 17;
            this.labelRequirements.Text = "Požadavky:";
            // 
            // textBoxRequirements
            // 
            this.textBoxRequirements.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxRequirements.Location = new System.Drawing.Point(869, 186);
            this.textBoxRequirements.Multiline = true;
            this.textBoxRequirements.Name = "textBoxRequirements";
            this.textBoxRequirements.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRequirements.Size = new System.Drawing.Size(303, 75);
            this.textBoxRequirements.TabIndex = 16;
            // 
            // progressBarDifficulty
            // 
            this.progressBarDifficulty.BackColor = System.Drawing.Color.White;
            this.progressBarDifficulty.Enabled = false;
            this.progressBarDifficulty.ForeColor = System.Drawing.Color.White;
            this.progressBarDifficulty.Location = new System.Drawing.Point(869, 119);
            this.progressBarDifficulty.Name = "progressBarDifficulty";
            this.progressBarDifficulty.Size = new System.Drawing.Size(303, 29);
            this.progressBarDifficulty.TabIndex = 18;
            this.progressBarDifficulty.Value = 50;
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInstructions.Location = new System.Drawing.Point(679, 267);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(76, 24);
            this.labelInstructions.TabIndex = 20;
            this.labelInstructions.Text = "Návod:";
            // 
            // textBoxInstructions
            // 
            this.textBoxInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxInstructions.Location = new System.Drawing.Point(869, 267);
            this.textBoxInstructions.Multiline = true;
            this.textBoxInstructions.Name = "textBoxInstructions";
            this.textBoxInstructions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInstructions.Size = new System.Drawing.Size(303, 78);
            this.textBoxInstructions.TabIndex = 19;
            // 
            // labelAdvancedTechniques
            // 
            this.labelAdvancedTechniques.AutoSize = true;
            this.labelAdvancedTechniques.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAdvancedTechniques.Location = new System.Drawing.Point(679, 351);
            this.labelAdvancedTechniques.Name = "labelAdvancedTechniques";
            this.labelAdvancedTechniques.Size = new System.Drawing.Size(186, 24);
            this.labelAdvancedTechniques.TabIndex = 22;
            this.labelAdvancedTechniques.Text = "Pokročilé techniky:";
            // 
            // textBoxAdvancedTechniques
            // 
            this.textBoxAdvancedTechniques.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAdvancedTechniques.Location = new System.Drawing.Point(869, 351);
            this.textBoxAdvancedTechniques.Multiline = true;
            this.textBoxAdvancedTechniques.Name = "textBoxAdvancedTechniques";
            this.textBoxAdvancedTechniques.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAdvancedTechniques.Size = new System.Drawing.Size(303, 81);
            this.textBoxAdvancedTechniques.TabIndex = 21;
            // 
            // labelExperiences
            // 
            this.labelExperiences.AutoSize = true;
            this.labelExperiences.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelExperiences.Location = new System.Drawing.Point(679, 438);
            this.labelExperiences.Name = "labelExperiences";
            this.labelExperiences.Size = new System.Drawing.Size(117, 24);
            this.labelExperiences.TabIndex = 24;
            this.labelExperiences.Text = "Zkušenosti:";
            // 
            // textBoxExperiences
            // 
            this.textBoxExperiences.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxExperiences.Location = new System.Drawing.Point(869, 438);
            this.textBoxExperiences.Multiline = true;
            this.textBoxExperiences.Name = "textBoxExperiences";
            this.textBoxExperiences.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxExperiences.Size = new System.Drawing.Size(303, 78);
            this.textBoxExperiences.TabIndex = 23;
            // 
            // checkBoxEquipment
            // 
            this.checkBoxEquipment.AutoSize = true;
            this.checkBoxEquipment.Location = new System.Drawing.Point(760, 157);
            this.checkBoxEquipment.Name = "checkBoxEquipment";
            this.checkBoxEquipment.Size = new System.Drawing.Size(15, 14);
            this.checkBoxEquipment.TabIndex = 29;
            this.checkBoxEquipment.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd.Location = new System.Drawing.Point(839, 522);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(108, 33);
            this.buttonAdd.TabIndex = 30;
            this.buttonAdd.Text = "Přidání";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.DatabaseActionButtonsClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.Location = new System.Drawing.Point(1067, 522);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(108, 33);
            this.buttonDelete.TabIndex = 31;
            this.buttonDelete.Text = "Smazat";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.DatabaseActionButtonsClick);
            // 
            // textBoxVideoLink
            // 
            this.textBoxVideoLink.Location = new System.Drawing.Point(12, 228);
            this.textBoxVideoLink.Name = "textBoxVideoLink";
            this.textBoxVideoLink.Size = new System.Drawing.Size(600, 20);
            this.textBoxVideoLink.TabIndex = 32;
            // 
            // numericUpDownDifficulty
            // 
            this.numericUpDownDifficulty.Location = new System.Drawing.Point(869, 155);
            this.numericUpDownDifficulty.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownDifficulty.Name = "numericUpDownDifficulty";
            this.numericUpDownDifficulty.Size = new System.Drawing.Size(301, 20);
            this.numericUpDownDifficulty.TabIndex = 33;
            this.numericUpDownDifficulty.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownDifficulty.ValueChanged += new System.EventHandler(this.NumericUpDownDifficultyValueChanged);
            // 
            // saveFileDialogSaveFile
            // 
            this.saveFileDialogSaveFile.Filter = "csv|*.csv";
            // 
            // pictureBoxNoVideo
            // 
            this.pictureBoxNoVideo.Location = new System.Drawing.Point(12, 255);
            this.pictureBoxNoVideo.Name = "pictureBoxNoVideo";
            this.pictureBoxNoVideo.Size = new System.Drawing.Size(600, 300);
            this.pictureBoxNoVideo.TabIndex = 34;
            this.pictureBoxNoVideo.TabStop = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave.Location = new System.Drawing.Point(725, 522);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(108, 33);
            this.buttonSave.TabIndex = 35;
            this.buttonSave.Text = "Uložit";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSaveClick);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCategory.Location = new System.Drawing.Point(679, 51);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(105, 24);
            this.labelCategory.TabIndex = 36;
            this.labelCategory.Text = "Kategorie:";
            // 
            // comboBoxCategory2
            // 
            this.comboBoxCategory2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxCategory2.FormattingEnabled = true;
            this.comboBoxCategory2.Items.AddRange(new object[] {
            "Gymnastika",
            "Parkour",
            "Jiná",
            "Všechny"});
            this.comboBoxCategory2.Location = new System.Drawing.Point(869, 47);
            this.comboBoxCategory2.Name = "comboBoxCategory2";
            this.comboBoxCategory2.Size = new System.Drawing.Size(303, 32);
            this.comboBoxCategory2.TabIndex = 37;
            // 
            // labelEquipment2
            // 
            this.labelEquipment2.AutoSize = true;
            this.labelEquipment2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEquipment2.Location = new System.Drawing.Point(679, 151);
            this.labelEquipment2.Name = "labelEquipment2";
            this.labelEquipment2.Size = new System.Drawing.Size(75, 24);
            this.labelEquipment2.TabIndex = 38;
            this.labelEquipment2.Text = "Náčiní:";
            // 
            // checkBoxEquipment2
            // 
            this.checkBoxEquipment2.AutoSize = true;
            this.checkBoxEquipment2.Location = new System.Drawing.Point(595, 142);
            this.checkBoxEquipment2.Name = "checkBoxEquipment2";
            this.checkBoxEquipment2.Size = new System.Drawing.Size(15, 14);
            this.checkBoxEquipment2.TabIndex = 39;
            this.checkBoxEquipment2.UseVisualStyleBackColor = true;
            this.checkBoxEquipment2.CheckedChanged += new System.EventHandler(this.CheckBoxEquipment2CheckedChanged);
            // 
            // labelFiltration
            // 
            this.labelFiltration.AutoSize = true;
            this.labelFiltration.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.labelFiltration.Location = new System.Drawing.Point(362, 2);
            this.labelFiltration.Name = "labelFiltration";
            this.labelFiltration.Size = new System.Drawing.Size(130, 37);
            this.labelFiltration.TabIndex = 40;
            this.labelFiltration.Text = "Filtrace";
            // 
            // labelEdit
            // 
            this.labelEdit.AutoSize = true;
            this.labelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.labelEdit.Location = new System.Drawing.Point(832, 7);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Size = new System.Drawing.Size(130, 37);
            this.labelEdit.TabIndex = 41;
            this.labelEdit.Text = "Editace";
            // 
            // checkBoxShowDifficulty
            // 
            this.checkBoxShowDifficulty.AutoSize = true;
            this.checkBoxShowDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.checkBoxShowDifficulty.Location = new System.Drawing.Point(12, 166);
            this.checkBoxShowDifficulty.Name = "checkBoxShowDifficulty";
            this.checkBoxShowDifficulty.Size = new System.Drawing.Size(175, 28);
            this.checkBoxShowDifficulty.TabIndex = 42;
            this.checkBoxShowDifficulty.Text = "Zobrazit obtížnost";
            this.checkBoxShowDifficulty.UseVisualStyleBackColor = true;
            this.checkBoxShowDifficulty.CheckedChanged += new System.EventHandler(this.CheckBoxShowDifficultyCheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 562);
            this.Controls.Add(this.checkBoxShowDifficulty);
            this.Controls.Add(this.labelEdit);
            this.Controls.Add(this.labelFiltration);
            this.Controls.Add(this.checkBoxEquipment2);
            this.Controls.Add(this.labelEquipment2);
            this.Controls.Add(this.comboBoxCategory2);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.pictureBoxNoVideo);
            this.Controls.Add(this.numericUpDownDifficulty);
            this.Controls.Add(this.textBoxVideoLink);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.checkBoxEquipment);
            this.Controls.Add(this.labelExperiences);
            this.Controls.Add(this.textBoxExperiences);
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
            this.Controls.Add(this.comboBoxDifficulty);
            this.Controls.Add(this.comboBoxCategory);
            this.Name = "Form1";
            this.Text = "Stunts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ApplicationClosing);
            this.Load += new System.EventHandler(this.ApplicationLoaded);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDifficulty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxDifficulty;
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
        private System.Windows.Forms.Label labelExperiences;
        private System.Windows.Forms.TextBox textBoxExperiences;
        private System.Windows.Forms.CheckBox checkBoxEquipment;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxVideoLink;
        private System.Windows.Forms.NumericUpDown numericUpDownDifficulty;
        private System.Windows.Forms.SaveFileDialog saveFileDialogSaveFile;
        private System.Windows.Forms.PictureBox pictureBoxNoVideo;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.ComboBox comboBoxCategory2;
        private System.Windows.Forms.Label labelEquipment2;
        private System.Windows.Forms.CheckBox checkBoxEquipment2;
        private System.Windows.Forms.Label labelFiltration;
        private System.Windows.Forms.Label labelEdit;
        private System.Windows.Forms.CheckBox checkBoxShowDifficulty;
    }
}

