namespace PBO_AKHIR
{
    partial class FormAdmin2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin2));
            button7 = new Button();
            button6 = new Button();
            button2 = new Button();
            button5 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.BackgroundImageLayout = ImageLayout.None;
            button7.FlatStyle = FlatStyle.Popup;
            button7.ForeColor = Color.Black;
            button7.Location = new Point(12, 215);
            button7.Name = "button7";
            button7.Size = new Size(265, 54);
            button7.TabIndex = 34;
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.BackgroundImageLayout = ImageLayout.None;
            button6.FlatStyle = FlatStyle.Popup;
            button6.ForeColor = Color.Black;
            button6.Location = new Point(12, 293);
            button6.Name = "button6";
            button6.Size = new Size(265, 54);
            button6.TabIndex = 33;
            button6.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(12, 151);
            button2.Name = "button2";
            button2.Size = new Size(265, 54);
            button2.TabIndex = 32;
            button2.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.BackgroundImageLayout = ImageLayout.None;
            button5.FlatStyle = FlatStyle.Popup;
            button5.ForeColor = Color.Black;
            button5.Location = new Point(404, 125);
            button5.Name = "button5";
            button5.Size = new Size(299, 33);
            button5.TabIndex = 39;
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.FlatStyle = FlatStyle.Popup;
            button4.ForeColor = Color.Black;
            button4.Location = new Point(748, 125);
            button4.Name = "button4";
            button4.Size = new Size(268, 33);
            button4.TabIndex = 38;
            button4.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(405, 342);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1403, 453);
            dataGridView1.TabIndex = 40;
            // 
            // FormAdmin2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1902, 1053);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button2);
            Name = "FormAdmin2";
            Text = "FormAdmin2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button7;
        private Button button6;
        private Button button2;
        private Button button5;
        private Button button4;
        private DataGridView dataGridView1;
    }
}