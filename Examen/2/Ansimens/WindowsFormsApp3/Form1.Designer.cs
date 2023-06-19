namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.demEkz_Ansimov_435DataSet = new WindowsFormsApp3.DemEkz_Ansimov_435DataSet();
            this.activnostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activnostTableAdapter = new WindowsFormsApp3.DemEkz_Ansimov_435DataSetTableAdapters.ActivnostTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namemeropriyatiyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activnostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demEkz_Ansimov_435DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activnostBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.namemeropriyatiyaDataGridViewTextBoxColumn,
            this.dataStartDataGridViewTextBoxColumn,
            this.activnostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.activnostBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(187, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 203);
            this.dataGridView1.TabIndex = 0;
            // 
            // demEkz_Ansimov_435DataSet
            // 
            this.demEkz_Ansimov_435DataSet.DataSetName = "DemEkz_Ansimov_435DataSet";
            this.demEkz_Ansimov_435DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // activnostBindingSource
            // 
            this.activnostBindingSource.DataMember = "Activnost";
            this.activnostBindingSource.DataSource = this.demEkz_Ansimov_435DataSet;
            // 
            // activnostTableAdapter
            // 
            this.activnostTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(310, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Авторизация";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "№";
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // namemeropriyatiyaDataGridViewTextBoxColumn
            // 
            this.namemeropriyatiyaDataGridViewTextBoxColumn.DataPropertyName = "Namemeropriyatiya";
            this.namemeropriyatiyaDataGridViewTextBoxColumn.HeaderText = "Namemeropriyatiya";
            this.namemeropriyatiyaDataGridViewTextBoxColumn.Name = "namemeropriyatiyaDataGridViewTextBoxColumn";
            // 
            // dataStartDataGridViewTextBoxColumn
            // 
            this.dataStartDataGridViewTextBoxColumn.DataPropertyName = "DataStart";
            this.dataStartDataGridViewTextBoxColumn.HeaderText = "DataStart";
            this.dataStartDataGridViewTextBoxColumn.Name = "dataStartDataGridViewTextBoxColumn";
            // 
            // activnostDataGridViewTextBoxColumn
            // 
            this.activnostDataGridViewTextBoxColumn.DataPropertyName = "activnost";
            this.activnostDataGridViewTextBoxColumn.HeaderText = "activnost";
            this.activnostDataGridViewTextBoxColumn.Name = "activnostDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(304, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Мероприятия";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demEkz_Ansimov_435DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activnostBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DemEkz_Ansimov_435DataSet demEkz_Ansimov_435DataSet;
        private System.Windows.Forms.BindingSource activnostBindingSource;
        private DemEkz_Ansimov_435DataSetTableAdapters.ActivnostTableAdapter activnostTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namemeropriyatiyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activnostDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}

