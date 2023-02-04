
namespace LR11
{
    partial class MainForm
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
            this.addDataButton = new System.Windows.Forms.Button();
            this.searchDataButton = new System.Windows.Forms.Button();
            this.mainDataGroupBox = new System.Windows.Forms.GroupBox();
            this.houseTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.birthTextBox = new System.Windows.Forms.TextBox();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.fioTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addDataGroupBox = new System.Windows.Forms.GroupBox();
            this.flatTextBox = new System.Windows.Forms.TextBox();
            this.squareTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.searchResultListBox = new System.Windows.Forms.ListBox();
            this.actionButton = new System.Windows.Forms.Button();
            this.revertButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.generalButtonsGroupBox = new System.Windows.Forms.GroupBox();
            this.mainDataGroupBox.SuspendLayout();
            this.addDataGroupBox.SuspendLayout();
            this.generalButtonsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addDataButton
            // 
            this.addDataButton.Location = new System.Drawing.Point(12, 12);
            this.addDataButton.Name = "addDataButton";
            this.addDataButton.Size = new System.Drawing.Size(140, 29);
            this.addDataButton.TabIndex = 0;
            this.addDataButton.Text = "Ввод данных";
            this.addDataButton.UseVisualStyleBackColor = true;
            // 
            // searchDataButton
            // 
            this.searchDataButton.Location = new System.Drawing.Point(175, 12);
            this.searchDataButton.Name = "searchDataButton";
            this.searchDataButton.Size = new System.Drawing.Size(140, 29);
            this.searchDataButton.TabIndex = 1;
            this.searchDataButton.Text = "Поиск данных";
            this.searchDataButton.UseVisualStyleBackColor = true;
            // 
            // mainDataGroupBox
            // 
            this.mainDataGroupBox.Controls.Add(this.houseTextBox);
            this.mainDataGroupBox.Controls.Add(this.streetTextBox);
            this.mainDataGroupBox.Controls.Add(this.birthTextBox);
            this.mainDataGroupBox.Controls.Add(this.femaleRadioButton);
            this.mainDataGroupBox.Controls.Add(this.maleRadioButton);
            this.mainDataGroupBox.Controls.Add(this.fioTextBox);
            this.mainDataGroupBox.Controls.Add(this.label1);
            this.mainDataGroupBox.Controls.Add(this.label2);
            this.mainDataGroupBox.Controls.Add(this.label3);
            this.mainDataGroupBox.Controls.Add(this.label4);
            this.mainDataGroupBox.Controls.Add(this.label5);
            this.mainDataGroupBox.Location = new System.Drawing.Point(12, 57);
            this.mainDataGroupBox.Name = "mainDataGroupBox";
            this.mainDataGroupBox.Size = new System.Drawing.Size(303, 227);
            this.mainDataGroupBox.TabIndex = 2;
            this.mainDataGroupBox.TabStop = false;
            this.mainDataGroupBox.Text = "Основные данные";
            // 
            // houseTextBox
            // 
            this.houseTextBox.Location = new System.Drawing.Point(74, 187);
            this.houseTextBox.Name = "houseTextBox";
            this.houseTextBox.Size = new System.Drawing.Size(214, 22);
            this.houseTextBox.TabIndex = 13;
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(74, 147);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(214, 22);
            this.streetTextBox.TabIndex = 12;
            // 
            // birthTextBox
            // 
            this.birthTextBox.Location = new System.Drawing.Point(129, 107);
            this.birthTextBox.Name = "birthTextBox";
            this.birthTextBox.Size = new System.Drawing.Size(159, 22);
            this.birthTextBox.TabIndex = 11;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(195, 68);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(62, 21);
            this.femaleRadioButton.TabIndex = 10;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Жен.";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(98, 68);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(60, 21);
            this.maleRadioButton.TabIndex = 9;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Муж.";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // fioTextBox
            // 
            this.fioTextBox.Location = new System.Drawing.Point(74, 27);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(214, 22);
            this.fioTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пол";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата рождения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Улица";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Дом";
            // 
            // addDataGroupBox
            // 
            this.addDataGroupBox.Controls.Add(this.flatTextBox);
            this.addDataGroupBox.Controls.Add(this.squareTextBox);
            this.addDataGroupBox.Controls.Add(this.label7);
            this.addDataGroupBox.Controls.Add(this.label6);
            this.addDataGroupBox.Location = new System.Drawing.Point(12, 300);
            this.addDataGroupBox.Name = "addDataGroupBox";
            this.addDataGroupBox.Size = new System.Drawing.Size(303, 104);
            this.addDataGroupBox.TabIndex = 3;
            this.addDataGroupBox.TabStop = false;
            this.addDataGroupBox.Text = "Дополнительные данные";
            // 
            // flatTextBox
            // 
            this.flatTextBox.Location = new System.Drawing.Point(98, 27);
            this.flatTextBox.Name = "flatTextBox";
            this.flatTextBox.Size = new System.Drawing.Size(190, 22);
            this.flatTextBox.TabIndex = 4;
            // 
            // squareTextBox
            // 
            this.squareTextBox.Location = new System.Drawing.Point(141, 67);
            this.squareTextBox.Name = "squareTextBox";
            this.squareTextBox.Size = new System.Drawing.Size(147, 22);
            this.squareTextBox.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Общая площадь";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Квартира";
            // 
            // searchResultListBox
            // 
            this.searchResultListBox.FormattingEnabled = true;
            this.searchResultListBox.ItemHeight = 16;
            this.searchResultListBox.Location = new System.Drawing.Point(338, 12);
            this.searchResultListBox.Name = "searchResultListBox";
            this.searchResultListBox.Size = new System.Drawing.Size(450, 388);
            this.searchResultListBox.TabIndex = 4;
            // 
            // actionButton
            // 
            this.actionButton.Location = new System.Drawing.Point(11, 21);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(140, 29);
            this.actionButton.TabIndex = 5;
            this.actionButton.Text = "button";
            this.actionButton.UseVisualStyleBackColor = true;
            // 
            // revertButton
            // 
            this.revertButton.Location = new System.Drawing.Point(163, 21);
            this.revertButton.Name = "revertButton";
            this.revertButton.Size = new System.Drawing.Size(140, 29);
            this.revertButton.TabIndex = 6;
            this.revertButton.Text = "Отменить";
            this.revertButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(325, 21);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(450, 29);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // generalButtonsGroupBox
            // 
            this.generalButtonsGroupBox.Controls.Add(this.revertButton);
            this.generalButtonsGroupBox.Controls.Add(this.actionButton);
            this.generalButtonsGroupBox.Controls.Add(this.closeButton);
            this.generalButtonsGroupBox.Location = new System.Drawing.Point(12, 410);
            this.generalButtonsGroupBox.Name = "generalButtonsGroupBox";
            this.generalButtonsGroupBox.Size = new System.Drawing.Size(781, 62);
            this.generalButtonsGroupBox.TabIndex = 8;
            this.generalButtonsGroupBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.generalButtonsGroupBox);
            this.Controls.Add(this.searchResultListBox);
            this.Controls.Add(this.addDataGroupBox);
            this.Controls.Add(this.mainDataGroupBox);
            this.Controls.Add(this.searchDataButton);
            this.Controls.Add(this.addDataButton);
            this.Name = "MainForm";
            this.mainDataGroupBox.ResumeLayout(false);
            this.mainDataGroupBox.PerformLayout();
            this.addDataGroupBox.ResumeLayout(false);
            this.addDataGroupBox.PerformLayout();
            this.generalButtonsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addDataButton;
        private System.Windows.Forms.Button searchDataButton;
        private System.Windows.Forms.GroupBox mainDataGroupBox;
        private System.Windows.Forms.TextBox houseTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox birthTextBox;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.TextBox fioTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox addDataGroupBox;
        private System.Windows.Forms.TextBox squareTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox flatTextBox;
        private System.Windows.Forms.ListBox searchResultListBox;
        private System.Windows.Forms.Button actionButton;
        private System.Windows.Forms.Button revertButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.GroupBox generalButtonsGroupBox;
    }
}

