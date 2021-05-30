
namespace lab3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelHotelName = new System.Windows.Forms.Label();
            this.labelRoomsNumber = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.listHotel = new System.Windows.Forms.ListBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(226, 381);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 32);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(359, 381);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 32);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(158, 82);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(35, 20);
            this.labelCity.TabIndex = 3;
            this.labelCity.Text = "City";
            this.labelCity.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelHotelName
            // 
            this.labelHotelName.AutoSize = true;
            this.labelHotelName.Location = new System.Drawing.Point(158, 122);
            this.labelHotelName.Name = "labelHotelName";
            this.labelHotelName.Size = new System.Drawing.Size(89, 20);
            this.labelHotelName.TabIndex = 3;
            this.labelHotelName.Text = "HotelName";
            this.labelHotelName.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelRoomsNumber
            // 
            this.labelRoomsNumber.AutoSize = true;
            this.labelRoomsNumber.Location = new System.Drawing.Point(158, 161);
            this.labelRoomsNumber.Name = "labelRoomsNumber";
            this.labelRoomsNumber.Size = new System.Drawing.Size(138, 20);
            this.labelRoomsNumber.TabIndex = 3;
            this.labelRoomsNumber.Text = "Number of Rooms";
            this.labelRoomsNumber.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(158, 200);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(56, 20);
            this.labelRating.TabIndex = 3;
            this.labelRating.Text = "Rating";
            this.labelRating.Click += new System.EventHandler(this.label2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 33);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // listHotel
            // 
            this.listHotel.FormattingEnabled = true;
            this.listHotel.ItemHeight = 20;
            this.listHotel.Location = new System.Drawing.Point(358, 78);
            this.listHotel.Name = "listHotel";
            this.listHotel.Size = new System.Drawing.Size(215, 164);
            this.listHotel.TabIndex = 5;
            this.listHotel.SelectedIndexChanged += new System.EventHandler(this.listHotel_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listHotel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.labelRoomsNumber);
            this.Controls.Add(this.labelHotelName);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAdd);
            this.Name = "Form1";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelHotelName;
        private System.Windows.Forms.Label labelRoomsNumber;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ListBox listHotel;
    }
}

