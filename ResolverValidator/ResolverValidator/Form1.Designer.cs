namespace ResolverValidator
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
            this.GetRiskLevel = new System.Windows.Forms.Button();
            this.datagridtable = new System.Windows.Forms.DataGridView();
            this.validIndicator = new System.Windows.Forms.TextBox();
            this.DisplayCurenUserDomain = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridtable)).BeginInit();
            this.SuspendLayout();
            // 
            // GetRiskLevel
            // 
            this.GetRiskLevel.Location = new System.Drawing.Point(30, 35);
            this.GetRiskLevel.Name = "GetRiskLevel";
            this.GetRiskLevel.Size = new System.Drawing.Size(75, 23);
            this.GetRiskLevel.TabIndex = 0;
            this.GetRiskLevel.Text = "Get RL table";
            this.GetRiskLevel.UseVisualStyleBackColor = true;
            this.GetRiskLevel.Click += new System.EventHandler(this.GetRiskLevel_Click);
            // 
            // datagridtable
            // 
            this.datagridtable.AllowUserToOrderColumns = true;
            this.datagridtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridtable.Location = new System.Drawing.Point(255, 35);
            this.datagridtable.Name = "datagridtable";
            this.datagridtable.RowTemplate.Height = 24;
            this.datagridtable.Size = new System.Drawing.Size(734, 290);
            this.datagridtable.TabIndex = 1;
            // 
            // validIndicator
            // 
            this.validIndicator.Location = new System.Drawing.Point(30, 150);
            this.validIndicator.Multiline = true;
            this.validIndicator.Name = "validIndicator";
            this.validIndicator.Size = new System.Drawing.Size(200, 69);
            this.validIndicator.TabIndex = 2;
            // 
            // DisplayCurenUserDomain
            // 
            this.DisplayCurenUserDomain.Location = new System.Drawing.Point(30, 90);
            this.DisplayCurenUserDomain.Name = "DisplayCurenUserDomain";
            this.DisplayCurenUserDomain.Size = new System.Drawing.Size(200, 22);
            this.DisplayCurenUserDomain.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 410);
            this.Controls.Add(this.DisplayCurenUserDomain);
            this.Controls.Add(this.validIndicator);
            this.Controls.Add(this.datagridtable);
            this.Controls.Add(this.GetRiskLevel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.datagridtable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetRiskLevel;
        private System.Windows.Forms.DataGridView datagridtable;
        private System.Windows.Forms.TextBox validIndicator;
        private System.Windows.Forms.TextBox DisplayCurenUserDomain;
    }
}

