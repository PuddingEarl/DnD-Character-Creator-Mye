﻿namespace DnD_Character_Creator_Mye.SecondaryForms
{
    partial class AddClassForm
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
            this.listBoxClasses = new System.Windows.Forms.ListBox();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxAttribute = new System.Windows.Forms.ComboBox();
            this.comboBoxOptionalFeature = new System.Windows.Forms.ComboBox();
            this.richTextBoxFeatureDescription = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // listBoxClasses
            // 
            this.listBoxClasses.FormattingEnabled = true;
            this.listBoxClasses.Location = new System.Drawing.Point(12, 12);
            this.listBoxClasses.Name = "listBoxClasses";
            this.listBoxClasses.Size = new System.Drawing.Size(431, 134);
            this.listBoxClasses.TabIndex = 0;
            this.listBoxClasses.SelectedIndexChanged += new System.EventHandler(this.listBoxClasses_SelectedIndexChanged);
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(12, 152);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(260, 123);
            this.richTextBoxDescription.TabIndex = 1;
            this.richTextBoxDescription.Text = "";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 281);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add Level";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(368, 281);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxAttribute
            // 
            this.comboBoxAttribute.FormattingEnabled = true;
            this.comboBoxAttribute.Location = new System.Drawing.Point(279, 153);
            this.comboBoxAttribute.Name = "comboBoxAttribute";
            this.comboBoxAttribute.Size = new System.Drawing.Size(164, 21);
            this.comboBoxAttribute.TabIndex = 4;
            this.comboBoxAttribute.SelectedIndexChanged += new System.EventHandler(this.comboBoxAttribute_SelectedIndexChanged);
            // 
            // comboBoxOptionalFeature
            // 
            this.comboBoxOptionalFeature.FormattingEnabled = true;
            this.comboBoxOptionalFeature.Location = new System.Drawing.Point(278, 180);
            this.comboBoxOptionalFeature.Name = "comboBoxOptionalFeature";
            this.comboBoxOptionalFeature.Size = new System.Drawing.Size(164, 21);
            this.comboBoxOptionalFeature.TabIndex = 5;
            this.comboBoxOptionalFeature.SelectedIndexChanged += new System.EventHandler(this.comboBoxOptionalFeature_SelectedIndexChanged);
            // 
            // richTextBoxFeatureDescription
            // 
            this.richTextBoxFeatureDescription.Location = new System.Drawing.Point(278, 207);
            this.richTextBoxFeatureDescription.Name = "richTextBoxFeatureDescription";
            this.richTextBoxFeatureDescription.Size = new System.Drawing.Size(165, 68);
            this.richTextBoxFeatureDescription.TabIndex = 6;
            this.richTextBoxFeatureDescription.Text = "";
            this.richTextBoxFeatureDescription.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // AddClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 316);
            this.Controls.Add(this.richTextBoxFeatureDescription);
            this.Controls.Add(this.comboBoxOptionalFeature);
            this.Controls.Add(this.comboBoxAttribute);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.listBoxClasses);
            this.Name = "AddClassForm";
            this.Text = "AddClassForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxClasses;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxAttribute;
        private System.Windows.Forms.ComboBox comboBoxOptionalFeature;
        private System.Windows.Forms.RichTextBox richTextBoxFeatureDescription;
    }
}