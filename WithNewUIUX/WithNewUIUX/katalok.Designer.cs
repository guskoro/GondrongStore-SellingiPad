namespace WithNewUIUX
{
    partial class katalok
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
            System.Windows.Forms.Label nama_katalogLabel;
            System.Windows.Forms.Label harga_katalogLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(katalok));
            this.gondrongStoreDataSet = new WithNewUIUX.GondrongStoreDataSet();
            this.katalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.katalogTableAdapter = new WithNewUIUX.GondrongStoreDataSetTableAdapters.katalogTableAdapter();
            this.tableAdapterManager = new WithNewUIUX.GondrongStoreDataSetTableAdapters.TableAdapterManager();
            this.katalogDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_katalogTextBox = new System.Windows.Forms.TextBox();
            this.harga_katalogTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            nama_katalogLabel = new System.Windows.Forms.Label();
            harga_katalogLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gondrongStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.katalogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.katalogDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // nama_katalogLabel
            // 
            nama_katalogLabel.AutoSize = true;
            nama_katalogLabel.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nama_katalogLabel.Location = new System.Drawing.Point(16, 360);
            nama_katalogLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nama_katalogLabel.Name = "nama_katalogLabel";
            nama_katalogLabel.Size = new System.Drawing.Size(124, 22);
            nama_katalogLabel.TabIndex = 2;
            nama_katalogLabel.Text = "Nama Katalog :";
            // 
            // harga_katalogLabel
            // 
            harga_katalogLabel.AutoSize = true;
            harga_katalogLabel.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            harga_katalogLabel.Location = new System.Drawing.Point(414, 361);
            harga_katalogLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            harga_katalogLabel.Name = "harga_katalogLabel";
            harga_katalogLabel.Size = new System.Drawing.Size(124, 22);
            harga_katalogLabel.TabIndex = 4;
            harga_katalogLabel.Text = "Harga Katalog :";
            // 
            // gondrongStoreDataSet
            // 
            this.gondrongStoreDataSet.DataSetName = "GondrongStoreDataSet";
            this.gondrongStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // katalogBindingSource
            // 
            this.katalogBindingSource.DataMember = "katalog";
            this.katalogBindingSource.DataSource = this.gondrongStoreDataSet;
            // 
            // katalogTableAdapter
            // 
            this.katalogTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.katalogTableAdapter = this.katalogTableAdapter;
            this.tableAdapterManager.modalTableAdapter = null;
            this.tableAdapterManager.pembelianTableAdapter = null;
            this.tableAdapterManager.penjualanTableAdapter = null;
            this.tableAdapterManager.stokTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WithNewUIUX.GondrongStoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // katalogDataGridView
            // 
            this.katalogDataGridView.AutoGenerateColumns = false;
            this.katalogDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.katalogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.katalogDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.katalogDataGridView.DataSource = this.katalogBindingSource;
            this.katalogDataGridView.Location = new System.Drawing.Point(13, 407);
            this.katalogDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.katalogDataGridView.Name = "katalogDataGridView";
            this.katalogDataGridView.RowTemplate.Height = 24;
            this.katalogDataGridView.Size = new System.Drawing.Size(891, 213);
            this.katalogDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_katalog";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_katalog";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nama_katalog";
            this.dataGridViewTextBoxColumn2.HeaderText = "nama_katalog";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "harga_katalog";
            this.dataGridViewTextBoxColumn3.HeaderText = "harga_katalog";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // nama_katalogTextBox
            // 
            this.nama_katalogTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.katalogBindingSource, "nama_katalog", true));
            this.nama_katalogTextBox.Location = new System.Drawing.Point(147, 356);
            this.nama_katalogTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nama_katalogTextBox.Name = "nama_katalogTextBox";
            this.nama_katalogTextBox.Size = new System.Drawing.Size(246, 28);
            this.nama_katalogTextBox.TabIndex = 3;
            // 
            // harga_katalogTextBox
            // 
            this.harga_katalogTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.katalogBindingSource, "harga_katalog", true));
            this.harga_katalogTextBox.Location = new System.Drawing.Point(545, 357);
            this.harga_katalogTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.harga_katalogTextBox.Name = "harga_katalogTextBox";
            this.harga_katalogTextBox.Size = new System.Drawing.Size(225, 28);
            this.harga_katalogTextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(789, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 33);
            this.button1.TabIndex = 25;
            this.button1.Text = "Tambahkan";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(543, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(610, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tambah Katalog untuk ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(612, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "iPad yang Anda Inginkan Segera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(653, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 41);
            this.label3.TabIndex = 29;
            this.label3.Text = "Terwujud !";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(574, 202);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(331, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // katalok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 633);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(nama_katalogLabel);
            this.Controls.Add(this.nama_katalogTextBox);
            this.Controls.Add(harga_katalogLabel);
            this.Controls.Add(this.harga_katalogTextBox);
            this.Controls.Add(this.katalogDataGridView);
            this.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "katalok";
            this.Text = "katalok";
            this.Load += new System.EventHandler(this.katalok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gondrongStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.katalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.katalogDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GondrongStoreDataSet gondrongStoreDataSet;
        private System.Windows.Forms.BindingSource katalogBindingSource;
        private GondrongStoreDataSetTableAdapters.katalogTableAdapter katalogTableAdapter;
        private GondrongStoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView katalogDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox nama_katalogTextBox;
        private System.Windows.Forms.TextBox harga_katalogTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}