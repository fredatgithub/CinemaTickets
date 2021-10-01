using System;
using System.Windows.Forms;

namespace WindowsFormsAppCinemaTickets
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private void CalculateButton_Click(object sender, EventArgs e)
    {
      int TotalAdults = 0;
      int TotalStudents = 0;
      int TotalChildren = 0;
      int TotalTicketsSold = 0;
      decimal TotalReceipts = 0;
      const decimal ADULT_TICKET_PRICE = 20;
      const decimal STUDENT_TICKET_PRICE = 15;
      const decimal CHILD_TICKET_PRICE = 10;

      try
      {
        int.TryParse(AdultTextBox.Text, out TotalAdults);
      }
      catch (Exception)
      {
        MessageBox.Show("Please enter numerical data for number of adults",
              "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      try
      {
        int.TryParse(StudentTextBox.Text, out TotalStudents);
      }
      catch (Exception)
      {
        MessageBox.Show("Please enter numerical data for number of students",
            "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      try
      {
        int.TryParse(ChildTextBox.Text, out TotalChildren);
      }
      catch (Exception)
      {
        MessageBox.Show("Please enter numerical data for number of children",
            "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      try
      {
        TotalTicketsSold = TotalAdults + TotalStudents + TotalChildren;
        TotalReceipts = (TotalAdults * ADULT_TICKET_PRICE) + (TotalStudents * STUDENT_TICKET_PRICE) + (TotalChildren * CHILD_TICKET_PRICE);
        CashierNameOutputLabel.Text = "Cashier's name: " + CashierNameTextBox.Text;
        CashierTotalTicketsSoldOutputLabel.Text = "Cashier Total Tickets Sold: " + (TotalAdults + TotalStudents + TotalChildren).ToString("n");
        CashierTotalReceiptsOutputLabel.Text = "Cashier Total Receipts: " + TotalReceipts.ToString("c");

      }
      catch
      {
        MessageBox.Show("Please enter a decimal value in the spaces provided",
           "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
      const decimal ADULT_TICKET_PRICE = 20;
      const decimal STUDENT_TICKET_PRICE = 15;
      const decimal CHILD_TICKET_PRICE = 10;

      labelPriceAdult.Text = ADULT_TICKET_PRICE.ToString();
      labelPriceStudent.Text = STUDENT_TICKET_PRICE.ToString();
      labelPriceChild.Text = CHILD_TICKET_PRICE.ToString();
    }
  }
}
