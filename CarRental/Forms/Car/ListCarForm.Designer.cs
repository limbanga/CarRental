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
            searchTextBox = new TextBox();
            searchButton = new Button();
            nameCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CarName = new DataGridViewTextBoxColumn();
            carTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            FuelType = new DataGridViewTextBoxColumn();
            brandDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            PricePerDay = new DataGridViewTextBoxColumn();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nameCodeDataGridViewTextBoxColumn, CarName, carTypeDataGridViewTextBoxColumn, FuelType, brandDataGridViewTextBoxColumn, PricePerDay, Remove });
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
            // searchTextBox
            // 
            searchTextBox.Location = new Point(23, 25);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(188, 27);
            searchTextBox.TabIndex = 2;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(217, 25);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(78, 29);
            searchButton.TabIndex = 3;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // nameCodeDataGridViewTextBoxColumn
            // 
            nameCodeDataGridViewTextBoxColumn.DataPropertyName = "NameCode";
            nameCodeDataGridViewTextBoxColumn.HeaderText = "NameCode";
            nameCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameCodeDataGridViewTextBoxColumn.Name = "nameCodeDataGridViewTextBoxColumn";
            // 
            // CarName
            // 
            CarName.DataPropertyName = "CarName";
            CarName.HeaderText = "CarName";
            CarName.MinimumWidth = 6;
            CarName.Name = "CarName";
            // 
            // carTypeDataGridViewTextBoxColumn
            // 
            carTypeDataGridViewTextBoxColumn.DataPropertyName = "CarType";
            carTypeDataGridViewTextBoxColumn.HeaderText = "CarType";
            carTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            carTypeDataGridViewTextBoxColumn.Name = "carTypeDataGridViewTextBoxColumn";
            // 
            // FuelType
            // 
            FuelType.DataPropertyName = "FuelType";
            FuelType.HeaderText = "FuelType";
            FuelType.MinimumWidth = 6;
            FuelType.Name = "FuelType";
            // 
            // brandDataGridViewTextBoxColumn
            // 
            brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            brandDataGridViewTextBoxColumn.MinimumWidth = 6;
            brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            // 
            // PricePerDay
            // 
            PricePerDay.DataPropertyName = "PricePerDay";
            PricePerDay.HeaderText = "PricePerDay ($)";
            PricePerDay.MinimumWidth = 6;
            PricePerDay.Name = "PricePerDay";
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
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
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
            PerformLayout();
        }

        #endregion

        private BindingSource carEntityBindingSource;
        private DataGridView dataGridView1;
        private Button AddCarButton;
        private TextBox searchTextBox;
        private Button searchButton;
        private DataGridViewTextBoxColumn nameCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn CarName;
        private DataGridViewTextBoxColumn carTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn FuelType;
        private DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn PricePerDay;
        private DataGridViewImageColumn Remove;
    }
}