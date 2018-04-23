namespace MeasureString
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
        protected override void Dispose ( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose ( );
            }
            base.Dispose ( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( )
        {
            this.components = new System.ComponentModel.Container();
            this.btn_MeasureString1 = new System.Windows.Forms.Button();
            this.printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.btn_MeasureString2 = new System.Windows.Forms.Button();
            this.btn_MeasureString3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_MeasureString1
            // 
            this.btn_MeasureString1.Location = new System.Drawing.Point(91, 45);
            this.btn_MeasureString1.Name = "btn_MeasureString1";
            this.btn_MeasureString1.Size = new System.Drawing.Size(117, 33);
            this.btn_MeasureString1.TabIndex = 0;
            this.btn_MeasureString1.Text = "MeasureString1";
            this.btn_MeasureString1.UseVisualStyleBackColor = true;
            this.btn_MeasureString1.Click += new System.EventHandler(this.btn_MeasureString1_Click);
            // 
            // btn_MeasureString2
            // 
            this.btn_MeasureString2.Location = new System.Drawing.Point(91, 101);
            this.btn_MeasureString2.Name = "btn_MeasureString2";
            this.btn_MeasureString2.Size = new System.Drawing.Size(117, 33);
            this.btn_MeasureString2.TabIndex = 1;
            this.btn_MeasureString2.Text = "MeasureString2";
            this.btn_MeasureString2.UseVisualStyleBackColor = true;
            this.btn_MeasureString2.Click += new System.EventHandler(this.btn_MeasureString2_Click);
            // 
            // btn_MeasureString3
            // 
            this.btn_MeasureString3.Location = new System.Drawing.Point(91, 156);
            this.btn_MeasureString3.Name = "btn_MeasureString3";
            this.btn_MeasureString3.Size = new System.Drawing.Size(117, 33);
            this.btn_MeasureString3.TabIndex = 2;
            this.btn_MeasureString3.Text = "MeasureString3";
            this.btn_MeasureString3.UseVisualStyleBackColor = true;
            this.btn_MeasureString3.Click += new System.EventHandler(this.btn_MeasureString3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.btn_MeasureString3);
            this.Controls.Add(this.btn_MeasureString2);
            this.Controls.Add(this.btn_MeasureString1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_MeasureString1;
        private DevExpress.XtraPrinting.PrintingSystem printingSystem1;
        private System.Windows.Forms.Button btn_MeasureString2;
        private System.Windows.Forms.Button btn_MeasureString3;
    }
}

