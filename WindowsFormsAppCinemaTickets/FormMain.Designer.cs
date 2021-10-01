
namespace WindowsFormsAppCinemaTickets
{
  partial class FormMain
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      this.AdultTextBox = new System.Windows.Forms.TextBox();
      this.labelAdult = new System.Windows.Forms.Label();
      this.labelStudent = new System.Windows.Forms.Label();
      this.StudentTextBox = new System.Windows.Forms.TextBox();
      this.labelChild = new System.Windows.Forms.Label();
      this.ChildTextBox = new System.Windows.Forms.TextBox();
      this.CalculateButton = new System.Windows.Forms.Button();
      this.CashierNameOutputLabel = new System.Windows.Forms.Label();
      this.CashierNameTextBox = new System.Windows.Forms.TextBox();
      this.CashierTotalTicketsSoldOutputLabel = new System.Windows.Forms.Label();
      this.CashierTotalReceiptsOutputLabel = new System.Windows.Forms.Label();
      this.labelCashierNameInput = new System.Windows.Forms.Label();
      this.labelPrices = new System.Windows.Forms.Label();
      this.labelPriceAdult = new System.Windows.Forms.Label();
      this.labelPriceStudent = new System.Windows.Forms.Label();
      this.labelPriceChild = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // AdultTextBox
      // 
      this.AdultTextBox.Location = new System.Drawing.Point(144, 71);
      this.AdultTextBox.Name = "AdultTextBox";
      this.AdultTextBox.Size = new System.Drawing.Size(100, 20);
      this.AdultTextBox.TabIndex = 0;
      this.AdultTextBox.Text = "0";
      // 
      // labelAdult
      // 
      this.labelAdult.AutoSize = true;
      this.labelAdult.Location = new System.Drawing.Point(31, 77);
      this.labelAdult.Name = "labelAdult";
      this.labelAdult.Size = new System.Drawing.Size(34, 13);
      this.labelAdult.TabIndex = 1;
      this.labelAdult.Text = "Adult:";
      // 
      // labelStudent
      // 
      this.labelStudent.AutoSize = true;
      this.labelStudent.Location = new System.Drawing.Point(31, 117);
      this.labelStudent.Name = "labelStudent";
      this.labelStudent.Size = new System.Drawing.Size(47, 13);
      this.labelStudent.TabIndex = 3;
      this.labelStudent.Text = "Student:";
      // 
      // StudentTextBox
      // 
      this.StudentTextBox.Location = new System.Drawing.Point(144, 111);
      this.StudentTextBox.Name = "StudentTextBox";
      this.StudentTextBox.Size = new System.Drawing.Size(100, 20);
      this.StudentTextBox.TabIndex = 2;
      this.StudentTextBox.Text = "0";
      // 
      // labelChild
      // 
      this.labelChild.AutoSize = true;
      this.labelChild.Location = new System.Drawing.Point(31, 156);
      this.labelChild.Name = "labelChild";
      this.labelChild.Size = new System.Drawing.Size(32, 13);
      this.labelChild.TabIndex = 5;
      this.labelChild.Text = "child:";
      // 
      // ChildTextBox
      // 
      this.ChildTextBox.Location = new System.Drawing.Point(144, 150);
      this.ChildTextBox.Name = "ChildTextBox";
      this.ChildTextBox.Size = new System.Drawing.Size(100, 20);
      this.ChildTextBox.TabIndex = 4;
      this.ChildTextBox.Text = "0";
      // 
      // CalculateButton
      // 
      this.CalculateButton.Location = new System.Drawing.Point(34, 212);
      this.CalculateButton.Name = "CalculateButton";
      this.CalculateButton.Size = new System.Drawing.Size(75, 23);
      this.CalculateButton.TabIndex = 6;
      this.CalculateButton.Text = "Calculate";
      this.CalculateButton.UseVisualStyleBackColor = true;
      this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
      // 
      // CashierNameOutputLabel
      // 
      this.CashierNameOutputLabel.AutoSize = true;
      this.CashierNameOutputLabel.Location = new System.Drawing.Point(31, 314);
      this.CashierNameOutputLabel.Name = "CashierNameOutputLabel";
      this.CashierNameOutputLabel.Size = new System.Drawing.Size(86, 13);
      this.CashierNameOutputLabel.TabIndex = 8;
      this.CashierNameOutputLabel.Text = "Cashier\'s Name: ";
      // 
      // CashierNameTextBox
      // 
      this.CashierNameTextBox.Location = new System.Drawing.Point(144, 260);
      this.CashierNameTextBox.Name = "CashierNameTextBox";
      this.CashierNameTextBox.Size = new System.Drawing.Size(158, 20);
      this.CashierNameTextBox.TabIndex = 7;
      this.CashierNameTextBox.Text = "Enter the name of the cashier";
      // 
      // CashierTotalTicketsSoldOutputLabel
      // 
      this.CashierTotalTicketsSoldOutputLabel.AutoSize = true;
      this.CashierTotalTicketsSoldOutputLabel.Location = new System.Drawing.Point(31, 347);
      this.CashierTotalTicketsSoldOutputLabel.Name = "CashierTotalTicketsSoldOutputLabel";
      this.CashierTotalTicketsSoldOutputLabel.Size = new System.Drawing.Size(137, 13);
      this.CashierTotalTicketsSoldOutputLabel.TabIndex = 9;
      this.CashierTotalTicketsSoldOutputLabel.Text = "Cashier Total Tickets Sold: ";
      // 
      // CashierTotalReceiptsOutputLabel
      // 
      this.CashierTotalReceiptsOutputLabel.AutoSize = true;
      this.CashierTotalReceiptsOutputLabel.Location = new System.Drawing.Point(31, 377);
      this.CashierTotalReceiptsOutputLabel.Name = "CashierTotalReceiptsOutputLabel";
      this.CashierTotalReceiptsOutputLabel.Size = new System.Drawing.Size(120, 13);
      this.CashierTotalReceiptsOutputLabel.TabIndex = 10;
      this.CashierTotalReceiptsOutputLabel.Text = "Cashier Total Receipts: ";
      // 
      // labelCashierNameInput
      // 
      this.labelCashierNameInput.AutoSize = true;
      this.labelCashierNameInput.Location = new System.Drawing.Point(31, 267);
      this.labelCashierNameInput.Name = "labelCashierNameInput";
      this.labelCashierNameInput.Size = new System.Drawing.Size(86, 13);
      this.labelCashierNameInput.TabIndex = 11;
      this.labelCashierNameInput.Text = "Cashier\'s Name: ";
      // 
      // labelPrices
      // 
      this.labelPrices.AutoSize = true;
      this.labelPrices.Location = new System.Drawing.Point(268, 45);
      this.labelPrices.Name = "labelPrices";
      this.labelPrices.Size = new System.Drawing.Size(36, 13);
      this.labelPrices.TabIndex = 12;
      this.labelPrices.Text = "Prices";
      // 
      // labelPriceAdult
      // 
      this.labelPriceAdult.AutoSize = true;
      this.labelPriceAdult.Location = new System.Drawing.Point(268, 74);
      this.labelPriceAdult.Name = "labelPriceAdult";
      this.labelPriceAdult.Size = new System.Drawing.Size(31, 13);
      this.labelPriceAdult.TabIndex = 13;
      this.labelPriceAdult.Text = "Price";
      // 
      // labelPriceStudent
      // 
      this.labelPriceStudent.AutoSize = true;
      this.labelPriceStudent.Location = new System.Drawing.Point(266, 117);
      this.labelPriceStudent.Name = "labelPriceStudent";
      this.labelPriceStudent.Size = new System.Drawing.Size(31, 13);
      this.labelPriceStudent.TabIndex = 14;
      this.labelPriceStudent.Text = "Price";
      // 
      // labelPriceChild
      // 
      this.labelPriceChild.AutoSize = true;
      this.labelPriceChild.Location = new System.Drawing.Point(266, 156);
      this.labelPriceChild.Name = "labelPriceChild";
      this.labelPriceChild.Size = new System.Drawing.Size(31, 13);
      this.labelPriceChild.TabIndex = 15;
      this.labelPriceChild.Text = "Price";
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(459, 419);
      this.Controls.Add(this.labelPriceChild);
      this.Controls.Add(this.labelPriceStudent);
      this.Controls.Add(this.labelPriceAdult);
      this.Controls.Add(this.labelPrices);
      this.Controls.Add(this.labelCashierNameInput);
      this.Controls.Add(this.CashierTotalReceiptsOutputLabel);
      this.Controls.Add(this.CashierTotalTicketsSoldOutputLabel);
      this.Controls.Add(this.CashierNameOutputLabel);
      this.Controls.Add(this.CashierNameTextBox);
      this.Controls.Add(this.CalculateButton);
      this.Controls.Add(this.labelChild);
      this.Controls.Add(this.ChildTextBox);
      this.Controls.Add(this.labelStudent);
      this.Controls.Add(this.StudentTextBox);
      this.Controls.Add(this.labelAdult);
      this.Controls.Add(this.AdultTextBox);
      this.Name = "FormMain";
      this.Text = "Cinema tickets";
      this.Load += new System.EventHandler(this.FormMain_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox AdultTextBox;
    private System.Windows.Forms.Label labelAdult;
    private System.Windows.Forms.Label labelStudent;
    private System.Windows.Forms.TextBox StudentTextBox;
    private System.Windows.Forms.Label labelChild;
    private System.Windows.Forms.TextBox ChildTextBox;
    private System.Windows.Forms.Button CalculateButton;
    private System.Windows.Forms.Label CashierNameOutputLabel;
    private System.Windows.Forms.TextBox CashierNameTextBox;
    private System.Windows.Forms.Label CashierTotalTicketsSoldOutputLabel;
    private System.Windows.Forms.Label CashierTotalReceiptsOutputLabel;
    private System.Windows.Forms.Label labelCashierNameInput;
    private System.Windows.Forms.Label labelPrices;
    private System.Windows.Forms.Label labelPriceAdult;
    private System.Windows.Forms.Label labelPriceStudent;
    private System.Windows.Forms.Label labelPriceChild;
  }
}

