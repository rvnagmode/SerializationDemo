namespace SerializationDemo
{
    partial class Form1
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
            this.btnBinaryWrite = new System.Windows.Forms.Button();
            this.btnBinaryRead = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnXmlRead = new System.Windows.Forms.Button();
            this.btnXmlWrite = new System.Windows.Forms.Button();
            this.btnSOAPRead = new System.Windows.Forms.Button();
            this.btnSOAPWrite = new System.Windows.Forms.Button();
            this.btnJsonRead = new System.Windows.Forms.Button();
            this.btnJsonWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBinaryWrite
            // 
            this.btnBinaryWrite.Location = new System.Drawing.Point(377, 23);
            this.btnBinaryWrite.Name = "btnBinaryWrite";
            this.btnBinaryWrite.Size = new System.Drawing.Size(134, 54);
            this.btnBinaryWrite.TabIndex = 0;
            this.btnBinaryWrite.Text = "Binary Write";
            this.btnBinaryWrite.UseVisualStyleBackColor = true;
            // 
            // btnBinaryRead
            // 
            this.btnBinaryRead.Location = new System.Drawing.Point(553, 23);
            this.btnBinaryRead.Name = "btnBinaryRead";
            this.btnBinaryRead.Size = new System.Drawing.Size(134, 54);
            this.btnBinaryRead.TabIndex = 1;
            this.btnBinaryRead.Text = "Binary Read";
            this.btnBinaryRead.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(108, 41);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(225, 20);
            this.txtId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dept Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Location";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(108, 98);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(225, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(108, 156);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(225, 20);
            this.txtLocation.TabIndex = 7;
            this.txtLocation.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnXmlRead
            // 
            this.btnXmlRead.Location = new System.Drawing.Point(553, 113);
            this.btnXmlRead.Name = "btnXmlRead";
            this.btnXmlRead.Size = new System.Drawing.Size(134, 54);
            this.btnXmlRead.TabIndex = 9;
            this.btnXmlRead.Text = "Xml Read";
            this.btnXmlRead.UseVisualStyleBackColor = true;
            this.btnXmlRead.Click += new System.EventHandler(this.btnXmlRead_Click);
            // 
            // btnXmlWrite
            // 
            this.btnXmlWrite.Location = new System.Drawing.Point(377, 113);
            this.btnXmlWrite.Name = "btnXmlWrite";
            this.btnXmlWrite.Size = new System.Drawing.Size(134, 54);
            this.btnXmlWrite.TabIndex = 8;
            this.btnXmlWrite.Text = "Xml Write";
            this.btnXmlWrite.UseVisualStyleBackColor = true;
            this.btnXmlWrite.Click += new System.EventHandler(this.btnXmlWrite_Click);
            // 
            // btnSOAPRead
            // 
            this.btnSOAPRead.Location = new System.Drawing.Point(553, 206);
            this.btnSOAPRead.Name = "btnSOAPRead";
            this.btnSOAPRead.Size = new System.Drawing.Size(134, 54);
            this.btnSOAPRead.TabIndex = 11;
            this.btnSOAPRead.Text = "SOAP Read";
            this.btnSOAPRead.UseVisualStyleBackColor = true;
            // 
            // btnSOAPWrite
            // 
            this.btnSOAPWrite.Location = new System.Drawing.Point(377, 206);
            this.btnSOAPWrite.Name = "btnSOAPWrite";
            this.btnSOAPWrite.Size = new System.Drawing.Size(134, 54);
            this.btnSOAPWrite.TabIndex = 10;
            this.btnSOAPWrite.Text = "SOAP Write";
            this.btnSOAPWrite.UseVisualStyleBackColor = true;
            // 
            // btnJsonRead
            // 
            this.btnJsonRead.Location = new System.Drawing.Point(553, 293);
            this.btnJsonRead.Name = "btnJsonRead";
            this.btnJsonRead.Size = new System.Drawing.Size(134, 54);
            this.btnJsonRead.TabIndex = 13;
            this.btnJsonRead.Text = "Json Read";
            this.btnJsonRead.UseVisualStyleBackColor = true;
            this.btnJsonRead.Click += new System.EventHandler(this.btnJsonRead_Click);
            // 
            // btnJsonWrite
            // 
            this.btnJsonWrite.Location = new System.Drawing.Point(377, 293);
            this.btnJsonWrite.Name = "btnJsonWrite";
            this.btnJsonWrite.Size = new System.Drawing.Size(134, 54);
            this.btnJsonWrite.TabIndex = 12;
            this.btnJsonWrite.Text = "Json Write";
            this.btnJsonWrite.UseVisualStyleBackColor = true;
            this.btnJsonWrite.Click += new System.EventHandler(this.btnJsonWrite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJsonRead);
            this.Controls.Add(this.btnJsonWrite);
            this.Controls.Add(this.btnSOAPRead);
            this.Controls.Add(this.btnSOAPWrite);
            this.Controls.Add(this.btnXmlRead);
            this.Controls.Add(this.btnXmlWrite);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnBinaryRead);
            this.Controls.Add(this.btnBinaryWrite);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBinaryWrite;
        private System.Windows.Forms.Button btnBinaryRead;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnXmlRead;
        private System.Windows.Forms.Button btnXmlWrite;
        private System.Windows.Forms.Button btnSOAPRead;
        private System.Windows.Forms.Button btnSOAPWrite;
        private System.Windows.Forms.Button btnJsonRead;
        private System.Windows.Forms.Button btnJsonWrite;
    }
}

