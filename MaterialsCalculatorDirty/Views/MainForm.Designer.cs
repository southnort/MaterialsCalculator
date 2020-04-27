namespace MaterialsCalculatorDirty
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
            this.materialsButton = new System.Windows.Forms.Button();
            this.jobsButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialsButton
            // 
            this.materialsButton.Location = new System.Drawing.Point(12, 30);
            this.materialsButton.Name = "materialsButton";
            this.materialsButton.Size = new System.Drawing.Size(100, 50);
            this.materialsButton.TabIndex = 0;
            this.materialsButton.Text = "Виды материалов";
            this.materialsButton.UseVisualStyleBackColor = true;
            // 
            // jobsButton
            // 
            this.jobsButton.Location = new System.Drawing.Point(12, 86);
            this.jobsButton.Name = "jobsButton";
            this.jobsButton.Size = new System.Drawing.Size(100, 50);
            this.jobsButton.TabIndex = 1;
            this.jobsButton.Text = "Виды работ";
            this.jobsButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(118, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(670, 355);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(736, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Проекты";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Новый проект";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(673, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 47);
            this.button2.TabIndex = 5;
            this.button2.Text = "Удалить проект";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.jobsButton);
            this.Controls.Add(this.materialsButton);
            this.Name = "Form1";
            this.Text = "Главное окно";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button materialsButton;
        private System.Windows.Forms.Button jobsButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

