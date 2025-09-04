namespace MonitoringSystem101
{
    partial class AuditActivitiesForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuditActivitiesForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AuditPanel = new System.Windows.Forms.Panel();
            this.AuditDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.AuditDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditActivitiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timelineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manipulationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginappDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginappDataSet2 = new MonitoringSystem101.LoginappDataSet2();
            this.manipulationTableAdapter = new MonitoringSystem101.LoginappDataSet2TableAdapters.ManipulationTableAdapter();
            this.AuditPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuditDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manipulationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginappDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginappDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // AuditPanel
            // 
            this.AuditPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AuditPanel.BackgroundImage")));
            this.AuditPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AuditPanel.Controls.Add(this.AuditDateTimePicker);
            this.AuditPanel.Controls.Add(this.AuditDataGrid);
            this.AuditPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuditPanel.Location = new System.Drawing.Point(0, 0);
            this.AuditPanel.Name = "AuditPanel";
            this.AuditPanel.Size = new System.Drawing.Size(871, 494);
            this.AuditPanel.TabIndex = 0;
            // 
            // AuditDateTimePicker
            // 
            this.AuditDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuditDateTimePicker.Animated = true;
            this.AuditDateTimePicker.AutoRoundedCorners = true;
            this.AuditDateTimePicker.BackColor = System.Drawing.Color.Transparent;
            this.AuditDateTimePicker.Checked = true;
            this.AuditDateTimePicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AuditDateTimePicker.FocusedColor = System.Drawing.Color.IndianRed;
            this.AuditDateTimePicker.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.AuditDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AuditDateTimePicker.IndicateFocus = true;
            this.AuditDateTimePicker.Location = new System.Drawing.Point(689, 8);
            this.AuditDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.AuditDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.AuditDateTimePicker.Name = "AuditDateTimePicker";
            this.AuditDateTimePicker.Size = new System.Drawing.Size(140, 36);
            this.AuditDateTimePicker.TabIndex = 1;
            this.AuditDateTimePicker.UseTransparentBackground = true;
            this.AuditDateTimePicker.Value = new System.DateTime(2025, 9, 2, 15, 59, 56, 478);
            this.AuditDateTimePicker.ValueChanged += new System.EventHandler(this.AuditDateTimePicker_ValueChanged);
            // 
            // AuditDataGrid
            // 
            this.AuditDataGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.AuditDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AuditDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AuditDataGrid.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AuditDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AuditDataGrid.ColumnHeadersHeight = 35;
            this.AuditDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn,
            this.auditActivitiesDataGridViewTextBoxColumn,
            this.timelineDataGridViewTextBoxColumn});
            this.AuditDataGrid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AuditDataGrid.DataSource = this.manipulationBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AuditDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.AuditDataGrid.GridColor = System.Drawing.Color.DimGray;
            this.AuditDataGrid.Location = new System.Drawing.Point(40, 50);
            this.AuditDataGrid.Name = "AuditDataGrid";
            this.AuditDataGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AuditDataGrid.RowHeadersVisible = false;
            this.AuditDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AuditDataGrid.Size = new System.Drawing.Size(789, 375);
            this.AuditDataGrid.TabIndex = 0;
            this.AuditDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.AuditDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AuditDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AuditDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AuditDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AuditDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.AuditDataGrid.ThemeStyle.GridColor = System.Drawing.Color.DimGray;
            this.AuditDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AuditDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AuditDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuditDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AuditDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AuditDataGrid.ThemeStyle.HeaderStyle.Height = 35;
            this.AuditDataGrid.ThemeStyle.ReadOnly = false;
            this.AuditDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AuditDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AuditDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuditDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AuditDataGrid.ThemeStyle.RowsStyle.Height = 22;
            this.AuditDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AuditDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No_";
            this.noDataGridViewTextBoxColumn.HeaderText = "No_";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            // 
            // auditActivitiesDataGridViewTextBoxColumn
            // 
            this.auditActivitiesDataGridViewTextBoxColumn.DataPropertyName = "Audit Activities";
            this.auditActivitiesDataGridViewTextBoxColumn.HeaderText = "Audit Activities";
            this.auditActivitiesDataGridViewTextBoxColumn.Name = "auditActivitiesDataGridViewTextBoxColumn";
            // 
            // timelineDataGridViewTextBoxColumn
            // 
            this.timelineDataGridViewTextBoxColumn.DataPropertyName = "Timeline";
            this.timelineDataGridViewTextBoxColumn.HeaderText = "Timeline";
            this.timelineDataGridViewTextBoxColumn.Name = "timelineDataGridViewTextBoxColumn";
            // 
            // manipulationBindingSource
            // 
            this.manipulationBindingSource.DataMember = "Manipulation";
            this.manipulationBindingSource.DataSource = this.loginappDataSet2BindingSource;
            // 
            // loginappDataSet2BindingSource
            // 
            this.loginappDataSet2BindingSource.DataSource = this.loginappDataSet2;
            this.loginappDataSet2BindingSource.Position = 0;
            // 
            // loginappDataSet2
            // 
            this.loginappDataSet2.DataSetName = "LoginappDataSet2";
            this.loginappDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // manipulationTableAdapter
            // 
            this.manipulationTableAdapter.ClearBeforeFill = true;
            // 
            // AuditActivitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(871, 494);
            this.Controls.Add(this.AuditPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AuditActivitiesForm";
            this.Text = "Audit_Activities";
            this.Load += new System.EventHandler(this.Audit_Activities_Load);
            this.AuditPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AuditDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manipulationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginappDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginappDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AuditPanel;
        private Guna.UI2.WinForms.Guna2DataGridView AuditDataGrid;
        private Guna.UI2.WinForms.Guna2DateTimePicker AuditDateTimePicker;
        private System.Windows.Forms.BindingSource loginappDataSet2BindingSource;
        private LoginappDataSet2 loginappDataSet2;
        private System.Windows.Forms.BindingSource manipulationBindingSource;
        private LoginappDataSet2TableAdapters.ManipulationTableAdapter manipulationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditActivitiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timelineDataGridViewTextBoxColumn;
    }
}