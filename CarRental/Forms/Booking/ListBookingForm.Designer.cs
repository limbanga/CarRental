﻿namespace CarRental.Forms.Booking
{
    partial class ListBookingForm
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
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CarName = new DataGridViewTextBoxColumn();
            rentAtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            returnAtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            realReturnAtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookingNoteEntityBindingSource = new BindingSource(components);
            addBookingButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookingNoteEntityBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, userNameDataGridViewTextBoxColumn, CarName, rentAtDataGridViewTextBoxColumn, returnAtDataGridViewTextBoxColumn, realReturnAtDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bookingNoteEntityBindingSource;
            dataGridView1.Location = new Point(23, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(884, 404);
            dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CarName
            // 
            CarName.DataPropertyName = "CarName";
            CarName.HeaderText = "CarName";
            CarName.MinimumWidth = 6;
            CarName.Name = "CarName";
            CarName.ReadOnly = true;
            // 
            // rentAtDataGridViewTextBoxColumn
            // 
            rentAtDataGridViewTextBoxColumn.DataPropertyName = "RentAt";
            rentAtDataGridViewTextBoxColumn.HeaderText = "RentAt";
            rentAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            rentAtDataGridViewTextBoxColumn.Name = "rentAtDataGridViewTextBoxColumn";
            // 
            // returnAtDataGridViewTextBoxColumn
            // 
            returnAtDataGridViewTextBoxColumn.DataPropertyName = "ReturnAt";
            returnAtDataGridViewTextBoxColumn.HeaderText = "ReturnAt";
            returnAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            returnAtDataGridViewTextBoxColumn.Name = "returnAtDataGridViewTextBoxColumn";
            // 
            // realReturnAtDataGridViewTextBoxColumn
            // 
            realReturnAtDataGridViewTextBoxColumn.DataPropertyName = "RealReturnAt";
            realReturnAtDataGridViewTextBoxColumn.HeaderText = "RealReturnAt";
            realReturnAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            realReturnAtDataGridViewTextBoxColumn.Name = "realReturnAtDataGridViewTextBoxColumn";
            // 
            // bookingNoteEntityBindingSource
            // 
            bookingNoteEntityBindingSource.DataSource = typeof(Entities.BookingNoteEntity);
            // 
            // addBookingButton
            // 
            addBookingButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addBookingButton.Location = new Point(813, 23);
            addBookingButton.Name = "addBookingButton";
            addBookingButton.Size = new Size(94, 29);
            addBookingButton.TabIndex = 1;
            addBookingButton.Text = "Add";
            addBookingButton.UseVisualStyleBackColor = true;
            addBookingButton.Click += addBookingButton_Click;
            // 
            // ListBookingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 517);
            Controls.Add(addBookingButton);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListBookingForm";
            Padding = new Padding(20);
            Text = "ListBookingForm";
            Load += ListBookingForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookingNoteEntityBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button addBookingButton;
        private BindingSource bookingNoteEntityBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn CarName;
        private DataGridViewTextBoxColumn rentAtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn returnAtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn realReturnAtDataGridViewTextBoxColumn;
    }
}