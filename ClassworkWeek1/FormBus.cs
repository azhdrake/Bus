using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassworkWeek1
{
  public partial class FormBus : Form
  {
    public FormBus()
    {
      InitializeComponent();
    }

    private void calcButt_Click(object sender, EventArgs e)
    {
      double busRate = 2.50;
      int trips = 0;
      if (Int32.TryParse(BusTripNumber.Text, out trips))
      {
        double total = busRate * trips;
        TotalBox.Text = "$" + Convert.ToString(total);
      }
      else
      {
        MessageBox.Show("Please enter an interager", "Error");
      }
    }

    private void TotalBox_TextChanged(object sender, EventArgs e)
    {

    }

    private void BusTripNumber_TextChanged(object sender, EventArgs e)
    {

    }

    private void fuckThisShitImOut_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
