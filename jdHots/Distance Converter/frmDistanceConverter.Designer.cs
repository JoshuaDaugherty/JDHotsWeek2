namespace Distance_Converter
{
    partial class frmDistanceConverter
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
            this.lblDistanceInInches = new System.Windows.Forms.Label();
            this.txtDistanceInInches = new System.Windows.Forms.TextBox();
            this.btnConvertToYards = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDistanceInInches
            // 
            this.lblDistanceInInches.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistanceInInches.Location = new System.Drawing.Point(176, 65);
            this.lblDistanceInInches.Name = "lblDistanceInInches";
            this.lblDistanceInInches.Size = new System.Drawing.Size(266, 36);
            this.lblDistanceInInches.TabIndex = 0;
            this.lblDistanceInInches.Text = "Distance In Inches";
            this.lblDistanceInInches.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDistanceInInches
            // 
            this.txtDistanceInInches.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistanceInInches.Location = new System.Drawing.Point(180, 104);
            this.txtDistanceInInches.Name = "txtDistanceInInches";
            this.txtDistanceInInches.Size = new System.Drawing.Size(262, 40);
            this.txtDistanceInInches.TabIndex = 1;
            this.txtDistanceInInches.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDistanceInInches.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDistanceInInches_KeyPress);
            // 
            // btnConvertToYards
            // 
            this.btnConvertToYards.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertToYards.Location = new System.Drawing.Point(180, 147);
            this.btnConvertToYards.Name = "btnConvertToYards";
            this.btnConvertToYards.Size = new System.Drawing.Size(262, 69);
            this.btnConvertToYards.TabIndex = 2;
            this.btnConvertToYards.Text = "Convert to Yards";
            this.btnConvertToYards.UseVisualStyleBackColor = true;
            this.btnConvertToYards.Click += new System.EventHandler(this.btnConvertToYards_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(455, 147);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 69);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(455, 79);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(141, 65);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(176, 240);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(324, 51);
            this.lblResult.TabIndex = 5;
            // 
            // frmDistanceConverter
            // 
            this.AcceptButton = this.btnConvertToYards;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConvertToYards);
            this.Controls.Add(this.txtDistanceInInches);
            this.Controls.Add(this.lblDistanceInInches);
            this.Name = "frmDistanceConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distance Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDistanceInInches;
        private System.Windows.Forms.TextBox txtDistanceInInches;
        private System.Windows.Forms.Button btnConvertToYards;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblResult;
    }
}

