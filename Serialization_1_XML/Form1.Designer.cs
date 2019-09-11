namespace Serialization_1_XML
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
            this.btnXMLseri = new System.Windows.Forms.Button();
            this.btnXMLDeseri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnXMLseri
            // 
            this.btnXMLseri.Location = new System.Drawing.Point(13, 13);
            this.btnXMLseri.Name = "btnXMLseri";
            this.btnXMLseri.Size = new System.Drawing.Size(390, 54);
            this.btnXMLseri.TabIndex = 0;
            this.btnXMLseri.Text = "XML Serialization";
            this.btnXMLseri.UseVisualStyleBackColor = true;
            // 
            // btnXMLDeseri
            // 
            this.btnXMLDeseri.Location = new System.Drawing.Point(12, 91);
            this.btnXMLDeseri.Name = "btnXMLDeseri";
            this.btnXMLDeseri.Size = new System.Drawing.Size(390, 54);
            this.btnXMLDeseri.TabIndex = 0;
            this.btnXMLDeseri.Text = "XML DeSerialization";
            this.btnXMLDeseri.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 450);
            this.Controls.Add(this.btnXMLDeseri);
            this.Controls.Add(this.btnXMLseri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXMLseri;
        private System.Windows.Forms.Button btnXMLDeseri;
    }
}

