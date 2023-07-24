namespace DemoPiggyback
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            button_connect = new Button();
            comboBox_comport = new ComboBox();
            button_disconnect = new Button();
            label1 = new Label();
            label_liveData = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dgvTable = new DataGridView();
            helpProvider1 = new HelpProvider();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTable).BeginInit();
            SuspendLayout();
            // 
            // button_connect
            // 
            button_connect.Location = new Point(323, 246);
            button_connect.Name = "button_connect";
            button_connect.Size = new Size(150, 46);
            button_connect.TabIndex = 0;
            button_connect.Text = "Connect";
            button_connect.UseVisualStyleBackColor = true;
            button_connect.Click += button_connect_Click;
            // 
            // comboBox_comport
            // 
            comboBox_comport.FormattingEnabled = true;
            comboBox_comport.Location = new Point(54, 250);
            comboBox_comport.Name = "comboBox_comport";
            comboBox_comport.Size = new Size(242, 40);
            comboBox_comport.TabIndex = 1;
            // 
            // button_disconnect
            // 
            button_disconnect.Location = new Point(491, 246);
            button_disconnect.Name = "button_disconnect";
            button_disconnect.Size = new Size(150, 46);
            button_disconnect.TabIndex = 2;
            button_disconnect.Text = "Disconnect";
            button_disconnect.UseVisualStyleBackColor = true;
            button_disconnect.Click += button_disconnect_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(710, 243);
            label1.Name = "label1";
            label1.Size = new Size(149, 45);
            label1.TabIndex = 3;
            label1.Text = "Live Data";
            // 
            // label_liveData
            // 
            label_liveData.AutoSize = true;
            label_liveData.Font = new Font("Segoe UI Black", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label_liveData.ForeColor = Color.Red;
            label_liveData.Location = new Point(907, 222);
            label_liveData.Name = "label_liveData";
            label_liveData.Size = new Size(108, 71);
            label_liveData.TabIndex = 4;
            label_liveData.Text = "***";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(0, 192, 0);
            textBox1.Location = new Point(251, 609);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 57);
            textBox1.TabIndex = 5;
            textBox1.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(54, 621);
            label2.Name = "label2";
            label2.Size = new Size(164, 45);
            label2.TabIndex = 6;
            label2.Text = "Tune Data";
            // 
            // button1
            // 
            button1.Location = new Point(491, 609);
            button1.Name = "button1";
            button1.Size = new Size(150, 56);
            button1.TabIndex = 7;
            button1.Text = "Write";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(54, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(587, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // dgvTable
            // 
            dgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTable.Location = new Point(54, 328);
            dgvTable.Name = "dgvTable";
            dgvTable.RowHeadersWidth = 82;
            dgvTable.RowTemplate.Height = 41;
            dgvTable.Size = new Size(1810, 220);
            dgvTable.TabIndex = 9;
            dgvTable.CellFormatting += dgvTable_CellFormatting;
            // 
            // button2
            // 
            button2.Location = new Point(723, 154);
            button2.Name = "button2";
            button2.Size = new Size(8, 8);
            button2.TabIndex = 10;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(1148, 231);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 11;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1933, 728);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dgvTable);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label_liveData);
            Controls.Add(label1);
            Controls.Add(button_disconnect);
            Controls.Add(comboBox_comport);
            Controls.Add(button_connect);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PiggybackDemo-MRONG789";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_connect;
        private ComboBox comboBox_comport;
        private Button button_disconnect;
        private Label label1;
        private Label label_liveData;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dgvTable;
        private HelpProvider helpProvider1;
        private Button button2;
        private Button button3;
    }
}