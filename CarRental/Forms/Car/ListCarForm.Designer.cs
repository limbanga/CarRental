namespace CarRental.Forms.Car
{
    partial class ListCarForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListCarForm));
            carEntityBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            AddCarButton = new Button();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            carTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            brandDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Remove = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)carEntityBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // carEntityBindingSource
            // 
            carEntityBindingSource.DataSource = typeof(Entities.CarEntity);
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameCodeDataGridViewTextBoxColumn, carTypeDataGridViewTextBoxColumn, brandDataGridViewTextBoxColumn, Remove });
            dataGridView1.DataSource = carEntityBindingSource;
            dataGridView1.Location = new Point(23, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(754, 342);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // AddCarButton
            // 
            AddCarButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddCarButton.Location = new Point(683, 23);
            AddCarButton.Name = "AddCarButton";
            AddCarButton.Size = new Size(94, 29);
            AddCarButton.TabIndex = 1;
            AddCarButton.Text = "Add";
            AddCarButton.UseVisualStyleBackColor = true;
            AddCarButton.Click += AddCarButton_Click;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.FillWeight = 98.26203F;
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameCodeDataGridViewTextBoxColumn
            // 
            nameCodeDataGridViewTextBoxColumn.DataPropertyName = "NameCode";
            nameCodeDataGridViewTextBoxColumn.FillWeight = 98.26203F;
            nameCodeDataGridViewTextBoxColumn.HeaderText = "NameCode";
            nameCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameCodeDataGridViewTextBoxColumn.Name = "nameCodeDataGridViewTextBoxColumn";
            // 
            // carTypeDataGridViewTextBoxColumn
            // 
            carTypeDataGridViewTextBoxColumn.DataPropertyName = "CarType";
            carTypeDataGridViewTextBoxColumn.FillWeight = 98.26203F;
            carTypeDataGridViewTextBoxColumn.HeaderText = "CarType";
            carTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            carTypeDataGridViewTextBoxColumn.Name = "carTypeDataGridViewTextBoxColumn";
            // 
            // brandDataGridViewTextBoxColumn
            // 
            brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            brandDataGridViewTextBoxColumn.FillWeight = 98.26203F;
            brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            brandDataGridViewTextBoxColumn.MinimumWidth = 6;
            brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            // 
            // Remove
            // 
            Remove.FillWeight = 106.951874F;
            Remove.HeaderText = "Remove";
            Remove.Image = (Image)resources.GetObject("Remove.Image");
            Remove.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Remove.MinimumWidth = 6;
            Remove.Name = "Remove";
            // 
            // ListCarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddCarButton);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListCarForm";
            Padding = new Padding(20);
            Text = "ListCarForm";
            Load += ListCarForm_Load;
            ((System.ComponentModel.ISupportInitialize)carEntityBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource carEntityBindingSource;
        private DataGridView dataGridView1;
        private Button AddCarButton;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn carTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private DataGridViewImageColumn Remove;
    }
}