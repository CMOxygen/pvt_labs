
namespace lab2
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.labelAddSurname = new System.Windows.Forms.Label();
            this.labelAddName = new System.Windows.Forms.Label();
            this.labelAddRank = new System.Windows.Forms.Label();
            this.boxSurname = new System.Windows.Forms.TextBox();
            this.boxName = new System.Windows.Forms.TextBox();
            this.boxRank = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelAddNumber = new System.Windows.Forms.Label();
            this.boxNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelAddSurname
            // 
            this.labelAddSurname.AutoSize = true;
            this.labelAddSurname.Location = new System.Drawing.Point(65, 99);
            this.labelAddSurname.Name = "labelAddSurname";
            this.labelAddSurname.Size = new System.Drawing.Size(81, 20);
            this.labelAddSurname.TabIndex = 0;
            this.labelAddSurname.Text = "Фамилия";
            // 
            // labelAddName
            // 
            this.labelAddName.AutoSize = true;
            this.labelAddName.Location = new System.Drawing.Point(65, 134);
            this.labelAddName.Name = "labelAddName";
            this.labelAddName.Size = new System.Drawing.Size(40, 20);
            this.labelAddName.TabIndex = 0;
            this.labelAddName.Text = "Имя";
            // 
            // labelAddRank
            // 
            this.labelAddRank.AutoSize = true;
            this.labelAddRank.Location = new System.Drawing.Point(65, 172);
            this.labelAddRank.Name = "labelAddRank";
            this.labelAddRank.Size = new System.Drawing.Size(95, 20);
            this.labelAddRank.TabIndex = 0;
            this.labelAddRank.Text = "Должность";
            // 
            // boxSurname
            // 
            this.boxSurname.Location = new System.Drawing.Point(279, 99);
            this.boxSurname.Name = "boxSurname";
            this.boxSurname.Size = new System.Drawing.Size(100, 26);
            this.boxSurname.TabIndex = 1;
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(279, 134);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(100, 26);
            this.boxName.TabIndex = 1;
            // 
            // boxRank
            // 
            this.boxRank.Location = new System.Drawing.Point(279, 169);
            this.boxRank.Name = "boxRank";
            this.boxRank.Size = new System.Drawing.Size(100, 26);
            this.boxRank.TabIndex = 1;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(109, 326);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 37);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "Ok";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(269, 326);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 37);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelAddNumber
            // 
            this.labelAddNumber.AutoSize = true;
            this.labelAddNumber.Location = new System.Drawing.Point(65, 207);
            this.labelAddNumber.Name = "labelAddNumber";
            this.labelAddNumber.Size = new System.Drawing.Size(59, 20);
            this.labelAddNumber.TabIndex = 0;
            this.labelAddNumber.Text = "Номер";
            // 
            // boxNumber
            // 
            this.boxNumber.Location = new System.Drawing.Point(279, 204);
            this.boxNumber.Name = "boxNumber";
            this.boxNumber.Size = new System.Drawing.Size(100, 26);
            this.boxNumber.TabIndex = 1;
            // 
            // addHotelDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.boxNumber);
            this.Controls.Add(this.boxRank);
            this.Controls.Add(this.boxName);
            this.Controls.Add(this.boxSurname);
            this.Controls.Add(this.labelAddNumber);
            this.Controls.Add(this.labelAddRank);
            this.Controls.Add(this.labelAddName);
            this.Controls.Add(this.labelAddSurname);
            this.Name = "addHotelDialog";
            this.Text = "addHotelDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label labelAddSurname;
        private System.Windows.Forms.Label labelAddName;
        private System.Windows.Forms.Label labelAddRank;
        private System.Windows.Forms.TextBox boxSurname;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.TextBox boxRank;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelAddNumber;
        private System.Windows.Forms.TextBox boxNumber;
    }
}