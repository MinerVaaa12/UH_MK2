namespace uh2
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
            label1 = new Label();
            comboMood = new ComboBox();
            btnSave = new Button();
            listMoods = new ListBox();
            lblDate = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat Black", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(243, 184);
            label1.Name = "label1";
            label1.Size = new Size(240, 46);
            label1.TabIndex = 0;
            label1.Text = "PILIH MOOD";
            label1.Click += label1_Click;
            // 
            // comboMood
            // 
            comboMood.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboMood.FormattingEnabled = true;
            comboMood.Location = new Point(173, 257);
            comboMood.Name = "comboMood";
            comboMood.Size = new Size(368, 29);
            comboMood.TabIndex = 1;
            comboMood.SelectedIndexChanged += comboMood_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Montserrat", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(273, 312);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(169, 43);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // listMoods
            // 
            listMoods.FormattingEnabled = true;
            listMoods.Location = new Point(756, 201);
            listMoods.Name = "listMoods";
            listMoods.Size = new Size(315, 104);
            listMoods.TabIndex = 3;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(759, 170);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(50, 20);
            lblDate.TabIndex = 4;
            lblDate.Text = "label2";
            lblDate.Click += lblDate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 703);
            Controls.Add(lblDate);
            Controls.Add(listMoods);
            Controls.Add(btnSave);
            Controls.Add(comboMood);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboMood;
        private Button btnSave;
        private ListBox listMoods;
        private Label lblDate;
    }
}
