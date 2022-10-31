
namespace WinUI
{
    partial class GasPrices
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
            this.DisplayLB = new System.Windows.Forms.ListBox();
            this.AvgMButton = new System.Windows.Forms.Button();
            this.HiLoPerYButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.AvgYButton = new System.Windows.Forms.Button();
            this.OverFlowLB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // DisplayLB
            // 
            this.DisplayLB.FormattingEnabled = true;
            this.DisplayLB.ItemHeight = 16;
            this.DisplayLB.Location = new System.Drawing.Point(230, 13);
            this.DisplayLB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DisplayLB.Name = "DisplayLB";
            this.DisplayLB.Size = new System.Drawing.Size(279, 356);
            this.DisplayLB.TabIndex = 0;
            // 
            // AvgMButton
            // 
            this.AvgMButton.Location = new System.Drawing.Point(65, 194);
            this.AvgMButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AvgMButton.Name = "AvgMButton";
            this.AvgMButton.Size = new System.Drawing.Size(157, 28);
            this.AvgMButton.TabIndex = 1;
            this.AvgMButton.Text = "Display avg $ per mo";
            this.AvgMButton.UseVisualStyleBackColor = true;
            this.AvgMButton.Click += new System.EventHandler(this.AvgMButton_Click);
            // 
            // HiLoPerYButton
            // 
            this.HiLoPerYButton.Location = new System.Drawing.Point(65, 283);
            this.HiLoPerYButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HiLoPerYButton.Name = "HiLoPerYButton";
            this.HiLoPerYButton.Size = new System.Drawing.Size(157, 48);
            this.HiLoPerYButton.TabIndex = 2;
            this.HiLoPerYButton.Text = "Display highest & lowest $ per year";
            this.HiLoPerYButton.UseVisualStyleBackColor = true;
            this.HiLoPerYButton.Click += new System.EventHandler(this.HiLoPerYButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(65, 386);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(157, 28);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Close Program";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AvgYButton
            // 
            this.AvgYButton.Location = new System.Drawing.Point(65, 103);
            this.AvgYButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AvgYButton.Name = "AvgYButton";
            this.AvgYButton.Size = new System.Drawing.Size(157, 28);
            this.AvgYButton.TabIndex = 4;
            this.AvgYButton.Text = "Display avg $ per yr";
            this.AvgYButton.UseVisualStyleBackColor = true;
            this.AvgYButton.Click += new System.EventHandler(this.AvgYButton_Click);
            // 
            // OverFlowLB
            // 
            this.OverFlowLB.FormattingEnabled = true;
            this.OverFlowLB.ItemHeight = 16;
            this.OverFlowLB.Location = new System.Drawing.Point(516, 13);
            this.OverFlowLB.Name = "OverFlowLB";
            this.OverFlowLB.Size = new System.Drawing.Size(280, 356);
            this.OverFlowLB.TabIndex = 5;
            // 
            // GasPrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 554);
            this.Controls.Add(this.OverFlowLB);
            this.Controls.Add(this.AvgYButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.HiLoPerYButton);
            this.Controls.Add(this.AvgMButton);
            this.Controls.Add(this.DisplayLB);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GasPrices";
            this.Text = "Gas Prices";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox DisplayLB;
        private System.Windows.Forms.Button AvgMButton;
        private System.Windows.Forms.Button HiLoPerYButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button AvgYButton;
        private System.Windows.Forms.ListBox OverFlowLB;
    }
}

