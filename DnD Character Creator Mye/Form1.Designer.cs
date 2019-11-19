namespace DnD_Character_Creator_Mye
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelRace = new System.Windows.Forms.Label();
            this.comboBoxRace = new System.Windows.Forms.ComboBox();
            this.panelAttributes = new System.Windows.Forms.Panel();
            this.buttonRandomize = new System.Windows.Forms.Button();
            this.textBoxPoints = new System.Windows.Forms.TextBox();
            this.buttonPlusCha = new System.Windows.Forms.Button();
            this.buttonMinusCha = new System.Windows.Forms.Button();
            this.buttonPlusWis = new System.Windows.Forms.Button();
            this.buttonMinusWis = new System.Windows.Forms.Button();
            this.buttonPlusInt = new System.Windows.Forms.Button();
            this.buttonMinusInt = new System.Windows.Forms.Button();
            this.buttonPlusCon = new System.Windows.Forms.Button();
            this.buttonMinusCon = new System.Windows.Forms.Button();
            this.buttonPlusDex = new System.Windows.Forms.Button();
            this.buttonMinusDex = new System.Windows.Forms.Button();
            this.buttonPlusStrength = new System.Windows.Forms.Button();
            this.buttonMinusStrength = new System.Windows.Forms.Button();
            this.textBoxDexPB = new System.Windows.Forms.TextBox();
            this.textBoxConPB = new System.Windows.Forms.TextBox();
            this.textBoxDexBonus = new System.Windows.Forms.TextBox();
            this.textBoxWisPB = new System.Windows.Forms.TextBox();
            this.textBoxDex = new System.Windows.Forms.TextBox();
            this.textBoxIntPB = new System.Windows.Forms.TextBox();
            this.textBoxConBonus = new System.Windows.Forms.TextBox();
            this.textBoxChaPB = new System.Windows.Forms.TextBox();
            this.textBoxCon = new System.Windows.Forms.TextBox();
            this.textBoxStrPB = new System.Windows.Forms.TextBox();
            this.textBoxWisBonus = new System.Windows.Forms.TextBox();
            this.textBoxWis = new System.Windows.Forms.TextBox();
            this.textBoxIntBonus = new System.Windows.Forms.TextBox();
            this.textBoxInt = new System.Windows.Forms.TextBox();
            this.textBoxChaBonus = new System.Windows.Forms.TextBox();
            this.textBoxCha = new System.Windows.Forms.TextBox();
            this.textBoxStrBonus = new System.Windows.Forms.TextBox();
            this.textBoxStr = new System.Windows.Forms.TextBox();
            this.labelInt = new System.Windows.Forms.Label();
            this.labelWis = new System.Windows.Forms.Label();
            this.labelCha = new System.Windows.Forms.Label();
            this.labelCon = new System.Windows.Forms.Label();
            this.labelDex = new System.Windows.Forms.Label();
            this.labelStr = new System.Windows.Forms.Label();
            this.labelAttributes = new System.Windows.Forms.Label();
            this.listBoxClasses = new System.Windows.Forms.ListBox();
            this.labelClasses = new System.Windows.Forms.Label();
            this.buttonAddClass = new System.Windows.Forms.Button();
            this.buttonRemoveClassLevel = new System.Windows.Forms.Button();
            this.comboBoxRandomizationMethods = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.panelAttributes.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(69, 24);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(121, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(12, 24);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(703, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCharacterToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newCharacterToolStripMenuItem
            // 
            this.newCharacterToolStripMenuItem.Name = "newCharacterToolStripMenuItem";
            this.newCharacterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newCharacterToolStripMenuItem.Text = "New Character";
            this.newCharacterToolStripMenuItem.Click += new System.EventHandler(this.newCharacterToolStripMenuItem_Click);
            // 
            // labelRace
            // 
            this.labelRace.AutoSize = true;
            this.labelRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRace.Location = new System.Drawing.Point(12, 60);
            this.labelRace.Name = "labelRace";
            this.labelRace.Size = new System.Drawing.Size(47, 20);
            this.labelRace.TabIndex = 3;
            this.labelRace.Text = "Race";
            // 
            // comboBoxRace
            // 
            this.comboBoxRace.FormattingEnabled = true;
            this.comboBoxRace.Location = new System.Drawing.Point(69, 60);
            this.comboBoxRace.Name = "comboBoxRace";
            this.comboBoxRace.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRace.TabIndex = 4;
            this.comboBoxRace.SelectedIndexChanged += new System.EventHandler(this.comboBoxRace_SelectedIndexChanged);
            // 
            // panelAttributes
            // 
            this.panelAttributes.Controls.Add(this.comboBoxRandomizationMethods);
            this.panelAttributes.Controls.Add(this.buttonRandomize);
            this.panelAttributes.Controls.Add(this.textBoxPoints);
            this.panelAttributes.Controls.Add(this.buttonPlusCha);
            this.panelAttributes.Controls.Add(this.buttonMinusCha);
            this.panelAttributes.Controls.Add(this.buttonPlusWis);
            this.panelAttributes.Controls.Add(this.buttonMinusWis);
            this.panelAttributes.Controls.Add(this.buttonPlusInt);
            this.panelAttributes.Controls.Add(this.buttonMinusInt);
            this.panelAttributes.Controls.Add(this.buttonPlusCon);
            this.panelAttributes.Controls.Add(this.buttonMinusCon);
            this.panelAttributes.Controls.Add(this.buttonPlusDex);
            this.panelAttributes.Controls.Add(this.buttonMinusDex);
            this.panelAttributes.Controls.Add(this.buttonPlusStrength);
            this.panelAttributes.Controls.Add(this.buttonMinusStrength);
            this.panelAttributes.Controls.Add(this.textBoxDexPB);
            this.panelAttributes.Controls.Add(this.textBoxConPB);
            this.panelAttributes.Controls.Add(this.textBoxDexBonus);
            this.panelAttributes.Controls.Add(this.textBoxWisPB);
            this.panelAttributes.Controls.Add(this.textBoxDex);
            this.panelAttributes.Controls.Add(this.textBoxIntPB);
            this.panelAttributes.Controls.Add(this.textBoxConBonus);
            this.panelAttributes.Controls.Add(this.textBoxChaPB);
            this.panelAttributes.Controls.Add(this.textBoxCon);
            this.panelAttributes.Controls.Add(this.textBoxStrPB);
            this.panelAttributes.Controls.Add(this.textBoxWisBonus);
            this.panelAttributes.Controls.Add(this.textBoxWis);
            this.panelAttributes.Controls.Add(this.textBoxIntBonus);
            this.panelAttributes.Controls.Add(this.textBoxInt);
            this.panelAttributes.Controls.Add(this.textBoxChaBonus);
            this.panelAttributes.Controls.Add(this.textBoxCha);
            this.panelAttributes.Controls.Add(this.textBoxStrBonus);
            this.panelAttributes.Controls.Add(this.textBoxStr);
            this.panelAttributes.Controls.Add(this.labelInt);
            this.panelAttributes.Controls.Add(this.labelWis);
            this.panelAttributes.Controls.Add(this.labelCha);
            this.panelAttributes.Controls.Add(this.labelCon);
            this.panelAttributes.Controls.Add(this.labelDex);
            this.panelAttributes.Controls.Add(this.labelStr);
            this.panelAttributes.Controls.Add(this.labelAttributes);
            this.panelAttributes.Location = new System.Drawing.Point(16, 109);
            this.panelAttributes.Name = "panelAttributes";
            this.panelAttributes.Size = new System.Drawing.Size(338, 258);
            this.panelAttributes.TabIndex = 5;
            // 
            // buttonRandomize
            // 
            this.buttonRandomize.Location = new System.Drawing.Point(150, 216);
            this.buttonRandomize.Name = "buttonRandomize";
            this.buttonRandomize.Size = new System.Drawing.Size(75, 23);
            this.buttonRandomize.TabIndex = 6;
            this.buttonRandomize.Text = "Randomize";
            this.buttonRandomize.UseVisualStyleBackColor = true;
            this.buttonRandomize.Click += new System.EventHandler(this.buttonRandomize_Click);
            // 
            // textBoxPoints
            // 
            this.textBoxPoints.Location = new System.Drawing.Point(232, 218);
            this.textBoxPoints.Name = "textBoxPoints";
            this.textBoxPoints.ReadOnly = true;
            this.textBoxPoints.Size = new System.Drawing.Size(35, 20);
            this.textBoxPoints.TabIndex = 26;
            // 
            // buttonPlusCha
            // 
            this.buttonPlusCha.Location = new System.Drawing.Point(304, 192);
            this.buttonPlusCha.Name = "buttonPlusCha";
            this.buttonPlusCha.Size = new System.Drawing.Size(25, 20);
            this.buttonPlusCha.TabIndex = 25;
            this.buttonPlusCha.Text = "+";
            this.buttonPlusCha.UseVisualStyleBackColor = true;
            this.buttonPlusCha.Click += new System.EventHandler(this.buttonPlusCha_Click);
            // 
            // buttonMinusCha
            // 
            this.buttonMinusCha.Location = new System.Drawing.Point(273, 192);
            this.buttonMinusCha.Name = "buttonMinusCha";
            this.buttonMinusCha.Size = new System.Drawing.Size(25, 20);
            this.buttonMinusCha.TabIndex = 24;
            this.buttonMinusCha.Text = "-";
            this.buttonMinusCha.UseVisualStyleBackColor = true;
            this.buttonMinusCha.Click += new System.EventHandler(this.buttonMinusCha_Click);
            // 
            // buttonPlusWis
            // 
            this.buttonPlusWis.Location = new System.Drawing.Point(304, 162);
            this.buttonPlusWis.Name = "buttonPlusWis";
            this.buttonPlusWis.Size = new System.Drawing.Size(25, 20);
            this.buttonPlusWis.TabIndex = 25;
            this.buttonPlusWis.Text = "+";
            this.buttonPlusWis.UseVisualStyleBackColor = true;
            this.buttonPlusWis.Click += new System.EventHandler(this.buttonPlusWis_Click);
            // 
            // buttonMinusWis
            // 
            this.buttonMinusWis.Location = new System.Drawing.Point(273, 162);
            this.buttonMinusWis.Name = "buttonMinusWis";
            this.buttonMinusWis.Size = new System.Drawing.Size(25, 20);
            this.buttonMinusWis.TabIndex = 24;
            this.buttonMinusWis.Text = "-";
            this.buttonMinusWis.UseVisualStyleBackColor = true;
            this.buttonMinusWis.Click += new System.EventHandler(this.buttonMinusWis_Click);
            // 
            // buttonPlusInt
            // 
            this.buttonPlusInt.Location = new System.Drawing.Point(304, 132);
            this.buttonPlusInt.Name = "buttonPlusInt";
            this.buttonPlusInt.Size = new System.Drawing.Size(25, 20);
            this.buttonPlusInt.TabIndex = 25;
            this.buttonPlusInt.Text = "+";
            this.buttonPlusInt.UseVisualStyleBackColor = true;
            this.buttonPlusInt.Click += new System.EventHandler(this.buttonPlusInt_Click);
            // 
            // buttonMinusInt
            // 
            this.buttonMinusInt.Location = new System.Drawing.Point(273, 132);
            this.buttonMinusInt.Name = "buttonMinusInt";
            this.buttonMinusInt.Size = new System.Drawing.Size(25, 20);
            this.buttonMinusInt.TabIndex = 24;
            this.buttonMinusInt.Text = "-";
            this.buttonMinusInt.UseVisualStyleBackColor = true;
            this.buttonMinusInt.Click += new System.EventHandler(this.buttonMinusInt_Click);
            // 
            // buttonPlusCon
            // 
            this.buttonPlusCon.Location = new System.Drawing.Point(304, 102);
            this.buttonPlusCon.Name = "buttonPlusCon";
            this.buttonPlusCon.Size = new System.Drawing.Size(25, 20);
            this.buttonPlusCon.TabIndex = 25;
            this.buttonPlusCon.Text = "+";
            this.buttonPlusCon.UseVisualStyleBackColor = true;
            this.buttonPlusCon.Click += new System.EventHandler(this.buttonPlusCon_Click);
            // 
            // buttonMinusCon
            // 
            this.buttonMinusCon.Location = new System.Drawing.Point(273, 102);
            this.buttonMinusCon.Name = "buttonMinusCon";
            this.buttonMinusCon.Size = new System.Drawing.Size(25, 20);
            this.buttonMinusCon.TabIndex = 24;
            this.buttonMinusCon.Text = "-";
            this.buttonMinusCon.UseVisualStyleBackColor = true;
            this.buttonMinusCon.Click += new System.EventHandler(this.buttonMinusCon_Click);
            // 
            // buttonPlusDex
            // 
            this.buttonPlusDex.Location = new System.Drawing.Point(304, 72);
            this.buttonPlusDex.Name = "buttonPlusDex";
            this.buttonPlusDex.Size = new System.Drawing.Size(25, 20);
            this.buttonPlusDex.TabIndex = 25;
            this.buttonPlusDex.Text = "+";
            this.buttonPlusDex.UseVisualStyleBackColor = true;
            this.buttonPlusDex.Click += new System.EventHandler(this.buttonPlusDex_Click);
            // 
            // buttonMinusDex
            // 
            this.buttonMinusDex.Location = new System.Drawing.Point(273, 72);
            this.buttonMinusDex.Name = "buttonMinusDex";
            this.buttonMinusDex.Size = new System.Drawing.Size(25, 20);
            this.buttonMinusDex.TabIndex = 24;
            this.buttonMinusDex.Text = "-";
            this.buttonMinusDex.UseVisualStyleBackColor = true;
            this.buttonMinusDex.Click += new System.EventHandler(this.buttonMinusDex_Click);
            // 
            // buttonPlusStrength
            // 
            this.buttonPlusStrength.Location = new System.Drawing.Point(304, 43);
            this.buttonPlusStrength.Name = "buttonPlusStrength";
            this.buttonPlusStrength.Size = new System.Drawing.Size(25, 20);
            this.buttonPlusStrength.TabIndex = 23;
            this.buttonPlusStrength.Text = "+";
            this.buttonPlusStrength.UseVisualStyleBackColor = true;
            this.buttonPlusStrength.Click += new System.EventHandler(this.buttonPlusStrength_Click);
            // 
            // buttonMinusStrength
            // 
            this.buttonMinusStrength.Location = new System.Drawing.Point(273, 43);
            this.buttonMinusStrength.Name = "buttonMinusStrength";
            this.buttonMinusStrength.Size = new System.Drawing.Size(25, 20);
            this.buttonMinusStrength.TabIndex = 6;
            this.buttonMinusStrength.Text = "-";
            this.buttonMinusStrength.UseVisualStyleBackColor = true;
            this.buttonMinusStrength.Click += new System.EventHandler(this.buttonMinusStrength_Click);
            // 
            // textBoxDexPB
            // 
            this.textBoxDexPB.Location = new System.Drawing.Point(232, 72);
            this.textBoxDexPB.Name = "textBoxDexPB";
            this.textBoxDexPB.ReadOnly = true;
            this.textBoxDexPB.Size = new System.Drawing.Size(35, 20);
            this.textBoxDexPB.TabIndex = 22;
            // 
            // textBoxConPB
            // 
            this.textBoxConPB.Location = new System.Drawing.Point(232, 102);
            this.textBoxConPB.Name = "textBoxConPB";
            this.textBoxConPB.ReadOnly = true;
            this.textBoxConPB.Size = new System.Drawing.Size(35, 20);
            this.textBoxConPB.TabIndex = 21;
            // 
            // textBoxDexBonus
            // 
            this.textBoxDexBonus.Location = new System.Drawing.Point(191, 72);
            this.textBoxDexBonus.Name = "textBoxDexBonus";
            this.textBoxDexBonus.ReadOnly = true;
            this.textBoxDexBonus.Size = new System.Drawing.Size(35, 20);
            this.textBoxDexBonus.TabIndex = 22;
            // 
            // textBoxWisPB
            // 
            this.textBoxWisPB.Location = new System.Drawing.Point(232, 162);
            this.textBoxWisPB.Name = "textBoxWisPB";
            this.textBoxWisPB.ReadOnly = true;
            this.textBoxWisPB.Size = new System.Drawing.Size(35, 20);
            this.textBoxWisPB.TabIndex = 20;
            // 
            // textBoxDex
            // 
            this.textBoxDex.Location = new System.Drawing.Point(150, 72);
            this.textBoxDex.Name = "textBoxDex";
            this.textBoxDex.ReadOnly = true;
            this.textBoxDex.Size = new System.Drawing.Size(35, 20);
            this.textBoxDex.TabIndex = 16;
            // 
            // textBoxIntPB
            // 
            this.textBoxIntPB.Location = new System.Drawing.Point(232, 132);
            this.textBoxIntPB.Name = "textBoxIntPB";
            this.textBoxIntPB.ReadOnly = true;
            this.textBoxIntPB.Size = new System.Drawing.Size(35, 20);
            this.textBoxIntPB.TabIndex = 19;
            // 
            // textBoxConBonus
            // 
            this.textBoxConBonus.Location = new System.Drawing.Point(191, 102);
            this.textBoxConBonus.Name = "textBoxConBonus";
            this.textBoxConBonus.ReadOnly = true;
            this.textBoxConBonus.Size = new System.Drawing.Size(35, 20);
            this.textBoxConBonus.TabIndex = 21;
            // 
            // textBoxChaPB
            // 
            this.textBoxChaPB.Location = new System.Drawing.Point(232, 192);
            this.textBoxChaPB.Name = "textBoxChaPB";
            this.textBoxChaPB.ReadOnly = true;
            this.textBoxChaPB.Size = new System.Drawing.Size(35, 20);
            this.textBoxChaPB.TabIndex = 18;
            // 
            // textBoxCon
            // 
            this.textBoxCon.Location = new System.Drawing.Point(150, 102);
            this.textBoxCon.Name = "textBoxCon";
            this.textBoxCon.ReadOnly = true;
            this.textBoxCon.Size = new System.Drawing.Size(35, 20);
            this.textBoxCon.TabIndex = 15;
            // 
            // textBoxStrPB
            // 
            this.textBoxStrPB.Location = new System.Drawing.Point(232, 42);
            this.textBoxStrPB.Name = "textBoxStrPB";
            this.textBoxStrPB.ReadOnly = true;
            this.textBoxStrPB.Size = new System.Drawing.Size(35, 20);
            this.textBoxStrPB.TabIndex = 17;
            // 
            // textBoxWisBonus
            // 
            this.textBoxWisBonus.Location = new System.Drawing.Point(191, 162);
            this.textBoxWisBonus.Name = "textBoxWisBonus";
            this.textBoxWisBonus.ReadOnly = true;
            this.textBoxWisBonus.Size = new System.Drawing.Size(35, 20);
            this.textBoxWisBonus.TabIndex = 20;
            // 
            // textBoxWis
            // 
            this.textBoxWis.Location = new System.Drawing.Point(150, 162);
            this.textBoxWis.Name = "textBoxWis";
            this.textBoxWis.ReadOnly = true;
            this.textBoxWis.Size = new System.Drawing.Size(35, 20);
            this.textBoxWis.TabIndex = 14;
            // 
            // textBoxIntBonus
            // 
            this.textBoxIntBonus.Location = new System.Drawing.Point(191, 132);
            this.textBoxIntBonus.Name = "textBoxIntBonus";
            this.textBoxIntBonus.ReadOnly = true;
            this.textBoxIntBonus.Size = new System.Drawing.Size(35, 20);
            this.textBoxIntBonus.TabIndex = 19;
            // 
            // textBoxInt
            // 
            this.textBoxInt.Location = new System.Drawing.Point(150, 132);
            this.textBoxInt.Name = "textBoxInt";
            this.textBoxInt.ReadOnly = true;
            this.textBoxInt.Size = new System.Drawing.Size(35, 20);
            this.textBoxInt.TabIndex = 13;
            // 
            // textBoxChaBonus
            // 
            this.textBoxChaBonus.Location = new System.Drawing.Point(191, 192);
            this.textBoxChaBonus.Name = "textBoxChaBonus";
            this.textBoxChaBonus.ReadOnly = true;
            this.textBoxChaBonus.Size = new System.Drawing.Size(35, 20);
            this.textBoxChaBonus.TabIndex = 18;
            // 
            // textBoxCha
            // 
            this.textBoxCha.Location = new System.Drawing.Point(150, 192);
            this.textBoxCha.Name = "textBoxCha";
            this.textBoxCha.ReadOnly = true;
            this.textBoxCha.Size = new System.Drawing.Size(35, 20);
            this.textBoxCha.TabIndex = 12;
            // 
            // textBoxStrBonus
            // 
            this.textBoxStrBonus.Location = new System.Drawing.Point(191, 42);
            this.textBoxStrBonus.Name = "textBoxStrBonus";
            this.textBoxStrBonus.ReadOnly = true;
            this.textBoxStrBonus.Size = new System.Drawing.Size(35, 20);
            this.textBoxStrBonus.TabIndex = 17;
            // 
            // textBoxStr
            // 
            this.textBoxStr.Location = new System.Drawing.Point(150, 42);
            this.textBoxStr.Name = "textBoxStr";
            this.textBoxStr.ReadOnly = true;
            this.textBoxStr.Size = new System.Drawing.Size(35, 20);
            this.textBoxStr.TabIndex = 6;
            // 
            // labelInt
            // 
            this.labelInt.AutoSize = true;
            this.labelInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInt.Location = new System.Drawing.Point(3, 132);
            this.labelInt.Name = "labelInt";
            this.labelInt.Size = new System.Drawing.Size(90, 20);
            this.labelInt.TabIndex = 11;
            this.labelInt.Text = "Intelligence";
            // 
            // labelWis
            // 
            this.labelWis.AutoSize = true;
            this.labelWis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWis.Location = new System.Drawing.Point(3, 162);
            this.labelWis.Name = "labelWis";
            this.labelWis.Size = new System.Drawing.Size(66, 20);
            this.labelWis.TabIndex = 10;
            this.labelWis.Text = "Wisdom";
            // 
            // labelCha
            // 
            this.labelCha.AutoSize = true;
            this.labelCha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCha.Location = new System.Drawing.Point(3, 192);
            this.labelCha.Name = "labelCha";
            this.labelCha.Size = new System.Drawing.Size(76, 20);
            this.labelCha.TabIndex = 9;
            this.labelCha.Text = "Charisma";
            // 
            // labelCon
            // 
            this.labelCon.AutoSize = true;
            this.labelCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCon.Location = new System.Drawing.Point(3, 102);
            this.labelCon.Name = "labelCon";
            this.labelCon.Size = new System.Drawing.Size(94, 20);
            this.labelCon.TabIndex = 8;
            this.labelCon.Text = "Constitution";
            // 
            // labelDex
            // 
            this.labelDex.AutoSize = true;
            this.labelDex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDex.Location = new System.Drawing.Point(3, 72);
            this.labelDex.Name = "labelDex";
            this.labelDex.Size = new System.Drawing.Size(71, 20);
            this.labelDex.TabIndex = 7;
            this.labelDex.Text = "Dexterity";
            // 
            // labelStr
            // 
            this.labelStr.AutoSize = true;
            this.labelStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStr.Location = new System.Drawing.Point(3, 42);
            this.labelStr.Name = "labelStr";
            this.labelStr.Size = new System.Drawing.Size(71, 20);
            this.labelStr.TabIndex = 6;
            this.labelStr.Text = "Strength";
            // 
            // labelAttributes
            // 
            this.labelAttributes.AutoSize = true;
            this.labelAttributes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAttributes.Location = new System.Drawing.Point(3, 0);
            this.labelAttributes.Name = "labelAttributes";
            this.labelAttributes.Size = new System.Drawing.Size(78, 20);
            this.labelAttributes.TabIndex = 6;
            this.labelAttributes.Text = "Attributes";
            // 
            // listBoxClasses
            // 
            this.listBoxClasses.FormattingEnabled = true;
            this.listBoxClasses.Location = new System.Drawing.Point(289, 24);
            this.listBoxClasses.Name = "listBoxClasses";
            this.listBoxClasses.Size = new System.Drawing.Size(238, 56);
            this.listBoxClasses.TabIndex = 6;
            // 
            // labelClasses
            // 
            this.labelClasses.AutoSize = true;
            this.labelClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClasses.Location = new System.Drawing.Point(218, 24);
            this.labelClasses.Name = "labelClasses";
            this.labelClasses.Size = new System.Drawing.Size(65, 20);
            this.labelClasses.TabIndex = 7;
            this.labelClasses.Text = "Classes";
            // 
            // buttonAddClass
            // 
            this.buttonAddClass.Location = new System.Drawing.Point(533, 24);
            this.buttonAddClass.Name = "buttonAddClass";
            this.buttonAddClass.Size = new System.Drawing.Size(129, 23);
            this.buttonAddClass.TabIndex = 27;
            this.buttonAddClass.Text = "Add Class Level";
            this.buttonAddClass.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveClassLevel
            // 
            this.buttonRemoveClassLevel.Location = new System.Drawing.Point(533, 53);
            this.buttonRemoveClassLevel.Name = "buttonRemoveClassLevel";
            this.buttonRemoveClassLevel.Size = new System.Drawing.Size(129, 23);
            this.buttonRemoveClassLevel.TabIndex = 28;
            this.buttonRemoveClassLevel.Text = "Remove Class Level";
            this.buttonRemoveClassLevel.UseVisualStyleBackColor = true;
            // 
            // comboBoxRandomizationMethods
            // 
            this.comboBoxRandomizationMethods.FormattingEnabled = true;
            this.comboBoxRandomizationMethods.Items.AddRange(new object[] {
            "Default",
            "Minmax"});
            this.comboBoxRandomizationMethods.Location = new System.Drawing.Point(7, 218);
            this.comboBoxRandomizationMethods.Name = "comboBoxRandomizationMethods";
            this.comboBoxRandomizationMethods.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRandomizationMethods.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 535);
            this.Controls.Add(this.buttonRemoveClassLevel);
            this.Controls.Add(this.buttonAddClass);
            this.Controls.Add(this.labelClasses);
            this.Controls.Add(this.listBoxClasses);
            this.Controls.Add(this.panelAttributes);
            this.Controls.Add(this.comboBoxRace);
            this.Controls.Add(this.labelRace);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelAttributes.ResumeLayout(false);
            this.panelAttributes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label labelRace;
        private System.Windows.Forms.ComboBox comboBoxRace;
        private System.Windows.Forms.Panel panelAttributes;
        private System.Windows.Forms.Button buttonPlusCha;
        private System.Windows.Forms.Button buttonMinusCha;
        private System.Windows.Forms.Button buttonPlusWis;
        private System.Windows.Forms.Button buttonMinusWis;
        private System.Windows.Forms.Button buttonPlusInt;
        private System.Windows.Forms.Button buttonMinusInt;
        private System.Windows.Forms.Button buttonPlusCon;
        private System.Windows.Forms.Button buttonMinusCon;
        private System.Windows.Forms.Button buttonPlusDex;
        private System.Windows.Forms.Button buttonMinusDex;
        private System.Windows.Forms.Button buttonPlusStrength;
        private System.Windows.Forms.Button buttonMinusStrength;
        private System.Windows.Forms.TextBox textBoxDexPB;
        private System.Windows.Forms.TextBox textBoxConPB;
        private System.Windows.Forms.TextBox textBoxDexBonus;
        private System.Windows.Forms.TextBox textBoxWisPB;
        private System.Windows.Forms.TextBox textBoxDex;
        private System.Windows.Forms.TextBox textBoxIntPB;
        private System.Windows.Forms.TextBox textBoxConBonus;
        private System.Windows.Forms.TextBox textBoxChaPB;
        private System.Windows.Forms.TextBox textBoxCon;
        private System.Windows.Forms.TextBox textBoxStrPB;
        private System.Windows.Forms.TextBox textBoxWisBonus;
        private System.Windows.Forms.TextBox textBoxWis;
        private System.Windows.Forms.TextBox textBoxIntBonus;
        private System.Windows.Forms.TextBox textBoxInt;
        private System.Windows.Forms.TextBox textBoxChaBonus;
        private System.Windows.Forms.TextBox textBoxCha;
        private System.Windows.Forms.TextBox textBoxStrBonus;
        private System.Windows.Forms.TextBox textBoxStr;
        private System.Windows.Forms.Label labelInt;
        private System.Windows.Forms.Label labelWis;
        private System.Windows.Forms.Label labelCha;
        private System.Windows.Forms.Label labelCon;
        private System.Windows.Forms.Label labelDex;
        private System.Windows.Forms.Label labelStr;
        private System.Windows.Forms.Label labelAttributes;
        private System.Windows.Forms.ToolStripMenuItem newCharacterToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxPoints;
        private System.Windows.Forms.Button buttonRandomize;
        private System.Windows.Forms.ListBox listBoxClasses;
        private System.Windows.Forms.Label labelClasses;
        private System.Windows.Forms.Button buttonAddClass;
        private System.Windows.Forms.Button buttonRemoveClassLevel;
        private System.Windows.Forms.ComboBox comboBoxRandomizationMethods;
    }
}

