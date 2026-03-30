namespace DI1000_Example
{
    partial class frmDi10001k
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
            label3 = new Label();
            btnStart = new Button();
            btnStop = new Button();
            btnOpenPort = new Button();
            btnClosePort = new Button();
            cmbPort = new ComboBox();
            txtWeight = new TextBox();
            lblMessage = new Label();
            label4 = new Label();
            cmdTare = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 21);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 0;
            label1.Text = "Select Port";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 64);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(125, 21);
            label3.TabIndex = 2;
            label3.Text = "Select Baud Rate";
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Lime;
            btnStart.Location = new Point(38, 228);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(138, 41);
            btnStart.TabIndex = 7;
            btnStart.Text = "Start Reading";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.FromArgb(255, 192, 192);
            btnStop.Location = new Point(38, 290);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(138, 41);
            btnStop.TabIndex = 8;
            btnStop.Text = "Stop Reading";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // btnOpenPort
            // 
            btnOpenPort.BackColor = SystemColors.Control;
            btnOpenPort.Location = new Point(38, 121);
            btnOpenPort.Name = "btnOpenPort";
            btnOpenPort.Size = new Size(138, 41);
            btnOpenPort.TabIndex = 9;
            btnOpenPort.Text = "Open Port";
            btnOpenPort.UseVisualStyleBackColor = false;
            btnOpenPort.Click += btnOpenPort_Click;
            // 
            // btnClosePort
            // 
            btnClosePort.BackColor = SystemColors.Control;
            btnClosePort.Location = new Point(38, 352);
            btnClosePort.Name = "btnClosePort";
            btnClosePort.Size = new Size(138, 41);
            btnClosePort.TabIndex = 10;
            btnClosePort.Text = "Close Port";
            btnClosePort.UseVisualStyleBackColor = false;
            btnClosePort.Click += btnClosePort_Click;
            // 
            // cmbPort
            // 
            cmbPort.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPort.FormattingEnabled = true;
            cmbPort.Location = new Point(177, 18);
            cmbPort.Name = "cmbPort";
            cmbPort.Size = new Size(121, 29);
            cmbPort.TabIndex = 11;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(193, 235);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(133, 29);
            txtWeight.TabIndex = 13;
            txtWeight.TextAlign = HorizontalAlignment.Right;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.ForeColor = Color.Firebrick;
            lblMessage.Location = new Point(194, 131);
            lblMessage.Margin = new Padding(4, 0, 4, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(19, 21);
            lblMessage.TabIndex = 15;
            lblMessage.Text = "...";
            lblMessage.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(177, 64);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 21);
            label4.TabIndex = 16;
            label4.Text = "230400";
            // 
            // cmdTare
            // 
            cmdTare.BackColor = SystemColors.Control;
            cmdTare.Location = new Point(354, 228);
            cmdTare.Name = "cmdTare";
            cmdTare.Size = new Size(138, 41);
            cmdTare.TabIndex = 17;
            cmdTare.Text = "Tare/Zero";
            cmdTare.UseVisualStyleBackColor = false;
            cmdTare.Click += cmdTare_Click;
            // 
            // frmDi10001k
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 432);
            Controls.Add(cmdTare);
            Controls.Add(label4);
            Controls.Add(lblMessage);
            Controls.Add(txtWeight);
            Controls.Add(cmbPort);
            Controls.Add(btnClosePort);
            Controls.Add(btnOpenPort);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(label3);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            Name = "frmDi10001k";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DI1000 Example";
            FormClosed += frmDi10001k_FormClosed;
            Load += frmDi10001k_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Button btnStart;
        private Button btnStop;
        private Button btnOpenPort;
        private Button btnClosePort;
        private ComboBox cmbPort;
        private TextBox txtWeight;
        private Label lblMessage;
        private Label label4;
        private Button cmdTare;
    }
}
