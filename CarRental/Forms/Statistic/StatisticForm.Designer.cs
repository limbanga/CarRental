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
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            label1 = new Label();
            totalCarLabel = new Label();
            SuspendLayout();
            // 
            // cartesianChart1
            // 
            cartesianChart1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cartesianChart1.Location = new Point(23, 97);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(831, 372);
            cartesianChart1.TabIndex = 0;
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
            totalCarLabel.Location = new Point(731, 56);
            totalCarLabel.Name = "totalCarLabel";
            totalCarLabel.Size = new Size(123, 28);
            totalCarLabel.TabIndex = 2;
            totalCarLabel.Text = "Total car : 10";
            // 
            // StatisticForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 492);
            Controls.Add(totalCarLabel);
            Controls.Add(label1);
            Controls.Add(cartesianChart1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StatisticForm";
            Padding = new Padding(20);
            Text = "StatisticForm";
            Load += StatisticForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private Label label1;
        private Label totalCarLabel;
    }
}