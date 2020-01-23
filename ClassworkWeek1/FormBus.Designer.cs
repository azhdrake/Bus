namespace ClassworkWeek1
{
  partial class FormBus
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
      this.CalcButt = new System.Windows.Forms.Button();
      this.BusTripNumber = new System.Windows.Forms.TextBox();
      this.TotalBox = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.fuckThisShitImOut = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // CalcButt
      // 
      this.CalcButt.BackColor = System.Drawing.SystemColors.GrayText;
      this.CalcButt.Location = new System.Drawing.Point(388, 326);
      this.CalcButt.Name = "CalcButt";
      this.CalcButt.Size = new System.Drawing.Size(180, 43);
      this.CalcButt.TabIndex = 0;
      this.CalcButt.Text = "Yes Touchy";
      this.CalcButt.UseVisualStyleBackColor = false;
      this.CalcButt.Click += new System.EventHandler(this.calcButt_Click);
      // 
      // BusTripNumber
      // 
      this.BusTripNumber.Location = new System.Drawing.Point(388, 88);
      this.BusTripNumber.Name = "BusTripNumber";
      this.BusTripNumber.Size = new System.Drawing.Size(180, 31);
      this.BusTripNumber.TabIndex = 1;
      this.BusTripNumber.TextChanged += new System.EventHandler(this.BusTripNumber_TextChanged);
      // 
      // TotalBox
      // 
      this.TotalBox.Location = new System.Drawing.Point(388, 206);
      this.TotalBox.Name = "TotalBox";
      this.TotalBox.ReadOnly = true;
      this.TotalBox.Size = new System.Drawing.Size(180, 31);
      this.TotalBox.TabIndex = 2;
      this.TotalBox.TextChanged += new System.EventHandler(this.TotalBox_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(94, 93);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(208, 25);
      this.label1.TabIndex = 3;
      this.label1.Text = "Number of Bus Trips";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(99, 211);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(122, 25);
      this.label2.TabIndex = 4;
      this.label2.Text = "Total Spent";
      // 
      // fuckThisShitImOut
      // 
      this.fuckThisShitImOut.BackColor = System.Drawing.SystemColors.GrayText;
      this.fuckThisShitImOut.Location = new System.Drawing.Point(99, 326);
      this.fuckThisShitImOut.Name = "fuckThisShitImOut";
      this.fuckThisShitImOut.Size = new System.Drawing.Size(162, 42);
      this.fuckThisShitImOut.TabIndex = 5;
      this.fuckThisShitImOut.Text = "I\'m Out!";
      this.fuckThisShitImOut.UseVisualStyleBackColor = false;
      this.fuckThisShitImOut.Click += new System.EventHandler(this.fuckThisShitImOut_Click);
      // 
      // FormBus
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(700, 450);
      this.Controls.Add(this.fuckThisShitImOut);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.TotalBox);
      this.Controls.Add(this.BusTripNumber);
      this.Controls.Add(this.CalcButt);
      this.ForeColor = System.Drawing.Color.Lime;
      this.Name = "FormBus";
      this.Text = "Bus Cost";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button CalcButt;
    private System.Windows.Forms.TextBox BusTripNumber;
    private System.Windows.Forms.TextBox TotalBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button fuckThisShitImOut;
  }
}

