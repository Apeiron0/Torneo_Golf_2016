namespace Torneo_Anual_Golf_2016
{
    partial class frm_tiros
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblLocalTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.database_shootoutDataSet = new Torneo_Anual_Golf_2016.Database_shootoutDataSet();
            this.tirosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tirosTableAdapter = new Torneo_Anual_Golf_2016.Database_shootoutDataSetTableAdapters.TirosTableAdapter();
            this.tableAdapterManager = new Torneo_Anual_Golf_2016.Database_shootoutDataSetTableAdapters.TableAdapterManager();
            this.database_shootoutDataSet1 = new Torneo_Anual_Golf_2016.Database_shootoutDataSet();
            this.tirosTableAdapter1 = new Torneo_Anual_Golf_2016.Database_shootoutDataSetTableAdapters.TirosTableAdapter();
            this.tiro_ActualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiro_ActualTableAdapter = new Torneo_Anual_Golf_2016.Database_shootoutDataSetTableAdapters.Tiro_ActualTableAdapter();
            this.tiro_ActualGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database_shootoutDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tirosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_shootoutDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiro_ActualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiro_ActualGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1146, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LblLocalTime, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1140, 106);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // LblLocalTime
            // 
            this.LblLocalTime.AutoSize = true;
            this.LblLocalTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblLocalTime.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLocalTime.Location = new System.Drawing.Point(1029, 53);
            this.LblLocalTime.Name = "LblLocalTime";
            this.LblLocalTime.Size = new System.Drawing.Size(108, 53);
            this.LblLocalTime.TabIndex = 3;
            this.LblLocalTime.Text = "label4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "TEE TIME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(852, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 53);
            this.label3.TabIndex = 2;
            this.label3.Text = "HORA ACTUAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "TORNEO ANUAL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 668);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1146, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // database_shootoutDataSet
            // 
            this.database_shootoutDataSet.DataSetName = "Database_shootoutDataSet";
            this.database_shootoutDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tirosBindingSource
            // 
            this.tirosBindingSource.DataMember = "Tiros";
            this.tirosBindingSource.DataSource = this.database_shootoutDataSet;
            // 
            // tirosTableAdapter
            // 
            this.tirosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.JugadorTableAdapter = null;
            this.tableAdapterManager.TirosTableAdapter = this.tirosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Torneo_Anual_Golf_2016.Database_shootoutDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // database_shootoutDataSet1
            // 
            this.database_shootoutDataSet1.DataSetName = "Database_shootoutDataSet";
            this.database_shootoutDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tirosTableAdapter1
            // 
            this.tirosTableAdapter1.ClearBeforeFill = true;
            // 
            // tiro_ActualBindingSource
            // 
            this.tiro_ActualBindingSource.DataMember = "Tiro_Actual";
            this.tiro_ActualBindingSource.DataSource = this.database_shootoutDataSet;
            // 
            // tiro_ActualTableAdapter
            // 
            this.tiro_ActualTableAdapter.ClearBeforeFill = true;
            // 
            // tiro_ActualGridControl
            // 
            this.tiro_ActualGridControl.DataSource = this.tiro_ActualBindingSource;
            this.tiro_ActualGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tiro_ActualGridControl.Location = new System.Drawing.Point(0, 126);
            this.tiro_ActualGridControl.MainView = this.gridView1;
            this.tiro_ActualGridControl.Name = "tiro_ActualGridControl";
            this.tiro_ActualGridControl.Size = new System.Drawing.Size(1146, 542);
            this.tiro_ActualGridControl.TabIndex = 3;
            this.tiro_ActualGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.tiro_ActualGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // frm_tiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 768);
            this.Controls.Add(this.tiro_ActualGridControl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_tiros";
            this.Text = "frm_tiros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_tiros_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database_shootoutDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tirosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_shootoutDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiro_ActualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiro_ActualGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Database_shootoutDataSet database_shootoutDataSet;
        private System.Windows.Forms.BindingSource tirosBindingSource;
        private Database_shootoutDataSetTableAdapters.TirosTableAdapter tirosTableAdapter;
        private Database_shootoutDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LblLocalTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Database_shootoutDataSet database_shootoutDataSet1;
        private Database_shootoutDataSetTableAdapters.TirosTableAdapter tirosTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource tiro_ActualBindingSource;
        private Database_shootoutDataSetTableAdapters.Tiro_ActualTableAdapter tiro_ActualTableAdapter;
        private DevExpress.XtraGrid.GridControl tiro_ActualGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}