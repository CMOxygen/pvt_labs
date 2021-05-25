
namespace lab2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.dataSet11 = new lab2.DataSet1();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataSet11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection2 = new System.Data.OleDb.OleDbConnection();
            this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.rankLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.surnameText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.rankText = new System.Windows.Forms.TextBox();
            this.numberText = new System.Windows.Forms.TextBox();
            this.dataSet31 = new lab2.DataSet3();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet31)).BeginInit();
            this.SuspendLayout();
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = resources.GetString("oleDbSelectCommand1.CommandText");
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Database1.mdb;Persis" +
    "t Security Info=True";
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Table", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Код", "Код"),
                        new System.Data.Common.DataColumnMapping("Фамилия", "Фамилия"),
                        new System.Data.Common.DataColumnMapping("Должность", "Должность"),
                        new System.Data.Common.DataColumnMapping("Оружие", "Оружие")})});
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.dataSet11;
            this.listBox1.DisplayMember = "Table.Фамилия";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(390, 404);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "Table.Должность";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dataSet11BindingSource
            // 
            this.dataSet11BindingSource.DataSource = this.dataSet11;
            this.dataSet11BindingSource.Position = 0;
            // 
            // dataSet11BindingSource1
            // 
            this.dataSet11BindingSource1.DataSource = this.dataSet11;
            this.dataSet11BindingSource1.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилия";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(339, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "С";
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(511, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = resources.GetString("oleDbSelectCommand2.CommandText");
            this.oleDbSelectCommand2.Connection = this.oleDbConnection2;
            this.oleDbSelectCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Фамилия", System.Data.OleDb.OleDbType.WChar, 255, "Фамилия")});
            // 
            // oleDbConnection2
            // 
            this.oleDbConnection2.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Database1.mdb;Persis" +
    "t Security Info=True";
            // 
            // oleDbDataAdapter2
            // 
            this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
            this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Table", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Код", "Код"),
                        new System.Data.Common.DataColumnMapping("Фамилия", "Фамилия"),
                        new System.Data.Common.DataColumnMapping("Должность", "Должность"),
                        new System.Data.Common.DataColumnMapping("Оружие", "Оружие")})});
            this.oleDbDataAdapter2.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(this.oleDbDataAdapter2_RowUpdated);
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(468, 54);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(81, 20);
            this.surnameLabel.TabIndex = 4;
            this.surnameLabel.Text = "Фамилия";
            this.surnameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(468, 90);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(40, 20);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Имя";
            this.nameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // rankLabel
            // 
            this.rankLabel.AutoSize = true;
            this.rankLabel.Location = new System.Drawing.Point(468, 122);
            this.rankLabel.Name = "rankLabel";
            this.rankLabel.Size = new System.Drawing.Size(95, 20);
            this.rankLabel.TabIndex = 4;
            this.rankLabel.Text = "Должность";
            this.rankLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(468, 154);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(119, 20);
            this.numberLabel.TabIndex = 4;
            this.numberLabel.Text = "Личный номер";
            this.numberLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // surnameText
            // 
            this.surnameText.Location = new System.Drawing.Point(604, 48);
            this.surnameText.Name = "surnameText";
            this.surnameText.Size = new System.Drawing.Size(168, 26);
            this.surnameText.TabIndex = 5;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(604, 87);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(168, 26);
            this.nameText.TabIndex = 5;
            // 
            // rankText
            // 
            this.rankText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet31, "Table.Должность", true));
            this.rankText.Location = new System.Drawing.Point(604, 122);
            this.rankText.Name = "rankText";
            this.rankText.Size = new System.Drawing.Size(168, 26);
            this.rankText.TabIndex = 5;
            // 
            // numberText
            // 
            this.numberText.Location = new System.Drawing.Point(604, 154);
            this.numberText.Name = "numberText";
            this.numberText.Size = new System.Drawing.Size(168, 26);
            this.numberText.TabIndex = 5;
            // 
            // dataSet31
            // 
            this.dataSet31.DataSetName = "DataSet3";
            this.dataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numberText);
            this.Controls.Add(this.rankText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.surnameText);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.rankLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet31)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource dataSet11BindingSource;
        private System.Windows.Forms.BindingSource dataSet11BindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
        private System.Data.OleDb.OleDbConnection oleDbConnection2;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label rankLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.TextBox surnameText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox rankText;
        private System.Windows.Forms.TextBox numberText;
        private DataSet3 dataSet31;
    }
}

