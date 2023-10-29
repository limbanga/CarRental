namespace CarRental.Forms.Statistic
{
    partial class StatisticForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticForm));
            cartesianChart = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            label1 = new Label();
            totalCarLabel = new Label();
            configPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)configPictureBox).BeginInit();
            SuspendLayout();
            // 
            // cartesianChart
            // 
            cartesianChart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cartesianChart.Location = new Point(23, 108);
            cartesianChart.Name = "cartesianChart";
            cartesianChart.Size = new Size(831, 361);
            cartesianChart.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(278, 20);
            label1.Name = "label1";
            label1.Size = new Size(325, 41);
            label1.TabIndex = 1;
            label1.Text = "Number of car by type";
            // 
            // totalCarLabel
            // 
            totalCarLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            totalCarLabel.AutoSize = true;
            totalCarLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            totalCarLabel.Location = new Point(731, 64);
            totalCarLabel.Name = "totalCarLabel";
            totalCarLabel.Size = new Size(123, 28);
            totalCarLabel.TabIndex = 2;
            totalCarLabel.Text = "Total car : 10";
            // 
            // configPictureBox
            // 
            configPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            configPictureBox.Image = (Image)resources.GetObject("configPictureBox.Image");
            configPictureBox.Location = new Point(818, 23);
            configPictureBox.Name = "configPictureBox";
            configPictureBox.Size = new Size(36, 31);
            configPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            configPictureBox.TabIndex = 3;
            configPictureBox.TabStop = false;
            configPictureBox.Click += configPictureBox_Click;
            // 
            // StatisticForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 492);
            Controls.Add(configPictureBox);
            Controls.Add(totalCarLabel);
            Controls.Add(label1);
            Controls.Add(cartesianChart);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StatisticForm";
            Padding = new Padding(20);
            Text = "StatisticForm";
            Load += StatisticForm_Load;
            ((System.ComponentModel.ISupportInitialize)configPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart;
        private Label label1;
        private Label totalCarLabel;
        private PictureBox configPictureBox;
    }
}