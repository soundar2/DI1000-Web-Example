namespace DI1000_Example
{
    partial class frmSelectModel
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
            groupBox1 = new GroupBox();
            btnOpenDi1000 = new Button();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btnOpenDi10001k = new Button();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnOpenDi1000);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(30, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(324, 183);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "DI-100U, DI-1000U, DI-1000UHS";
            // 
            // btnOpenDi1000
            // 
            btnOpenDi1000.Location = new Point(54, 122);
            btnOpenDi1000.Name = "btnOpenDi1000";
            btnOpenDi1000.Size = new Size(226, 46);
            btnOpenDi1000.TabIndex = 3;
            btnOpenDi1000.Text = "Open";
            btnOpenDi1000.UseVisualStyleBackColor = true;
            btnOpenDi1000.Click += btnOpenDi1000_Click;
            // 
            // label2
            // 
            label2.Location = new Point(12, 36);
            label2.Name = "label2";
            label2.Size = new Size(250, 83);
            label2.TabIndex = 2;
            label2.Text = "Read weight values either one at a time or in streaming mode upto 500 readings/sec";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnOpenDi10001k);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(30, 225);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(324, 183);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "DI-1000UHS-1K";
            // 
            // btnOpenDi10001k
            // 
            btnOpenDi10001k.Location = new Point(54, 123);
            btnOpenDi10001k.Name = "btnOpenDi10001k";
            btnOpenDi10001k.Size = new Size(226, 46);
            btnOpenDi10001k.TabIndex = 3;
            btnOpenDi10001k.Text = "Open";
            btnOpenDi10001k.UseVisualStyleBackColor = true;
            btnOpenDi10001k.Click += btnOpenDi10001k_click;
            // 
            // label3
            // 
            label3.Location = new Point(13, 36);
            label3.Name = "label3";
            label3.Size = new Size(239, 84);
            label3.TabIndex = 2;
            label3.Text = "Read weight values in streaming mode upto 500 readings/sec";
            // 
            // frmSelectModel
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 424);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            Name = "frmSelectModel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Select Interface Model";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnOpenDi1000;
        private Label label2;
        private GroupBox groupBox2;
        private Button btnOpenDi10001k;
        private Label label3;
    }
}