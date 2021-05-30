
namespace lab3
{
    partial class addHotelDialog
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
            this.textCity = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.textHotelName = new System.Windows.Forms.TextBox();
            this.textRoomsNumber = new System.Windows.Forms.TextBox();
            this.textRating = new System.Windows.Forms.TextBox();
            this.labelHotelName = new System.Windows.Forms.Label();
            this.labelRoomsNumber = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(297, 37);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(176, 26);
            this.textCity.TabIndex = 0;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(96, 43);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(35, 20);
            this.labelCity.TabIndex = 1;
            this.labelCity.Text = "City";
            // 
            // textHotelName
            // 
            this.textHotelName.Location = new System.Drawing.Point(297, 89);
            this.textHotelName.Name = "textHotelName";
            this.textHotelName.Size = new System.Drawing.Size(176, 26);
            this.textHotelName.TabIndex = 0;
            this.textHotelName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textRoomsNumber
            // 
            this.textRoomsNumber.Location = new System.Drawing.Point(297, 143);
            this.textRoomsNumber.Name = "textRoomsNumber";
            this.textRoomsNumber.Size = new System.Drawing.Size(176, 26);
            this.textRoomsNumber.TabIndex = 0;
            // 
            // textRating
            // 
            this.textRating.Location = new System.Drawing.Point(297, 195);
            this.textRating.Name = "textRating";
            this.textRating.Size = new System.Drawing.Size(176, 26);
            this.textRating.TabIndex = 0;
            // 
            // labelHotelName
            // 
            this.labelHotelName.AutoSize = true;
            this.labelHotelName.Location = new System.Drawing.Point(96, 95);
            this.labelHotelName.Name = "labelHotelName";
            this.labelHotelName.Size = new System.Drawing.Size(93, 20);
            this.labelHotelName.TabIndex = 1;
            this.labelHotelName.Text = "Hotel Name";
            // 
            // labelRoomsNumber
            // 
            this.labelRoomsNumber.AutoSize = true;
            this.labelRoomsNumber.Location = new System.Drawing.Point(96, 149);
            this.labelRoomsNumber.Name = "labelRoomsNumber";
            this.labelRoomsNumber.Size = new System.Drawing.Size(60, 20);
            this.labelRoomsNumber.TabIndex = 1;
            this.labelRoomsNumber.Text = "Rooms";
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(96, 201);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(56, 20);
            this.labelRating.TabIndex = 1;
            this.labelRating.Text = "Rating";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(80, 304);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 34);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(297, 304);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 33);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // addHotelDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.labelHotelName);
            this.Controls.Add(this.labelRoomsNumber);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.textRating);
            this.Controls.Add(this.textHotelName);
            this.Controls.Add(this.textRoomsNumber);
            this.Controls.Add(this.textCity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addHotelDialog";
            this.Text = "addHotelDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textHotelName;
        private System.Windows.Forms.TextBox textRoomsNumber;
        private System.Windows.Forms.TextBox textRating;
        private System.Windows.Forms.Label labelHotelName;
        private System.Windows.Forms.Label labelRoomsNumber;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}