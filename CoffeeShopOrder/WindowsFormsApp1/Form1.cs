/*Name: Zain & Henry
* Description: A coffee shop simulator 
* Input: enter the size and amount of coffee you want
* Output: costs for all  the coffee
*/
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double total = 0;//declare total cost variable
        int small = 0, medium = 0, large = 0;//declare all sizes variable
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //initiate all boxes to disabled
            smallCheck.Checked = false;
            mediumCheck.Checked = false;
            largeCheck.Checked = false;
            addToOrder.Enabled = false;
            completeOrder.Enabled = false;
            total = 0;//initiate total cost to 0
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();//close program
        }

        private void addToOrder_Click(object sender, EventArgs e)
        {
            if (smallCheck.Checked == true ||
                mediumCheck.Checked == true ||
                largeCheck.Checked == true)
            //if any one radio box is checked
            {
                if (smallCheck.Checked == true)
                {//if small size radio is checked
                    small += Convert.ToInt32(amountBox.Text);
                    //cost for small size coffee is added
                    total += 1.75 * small;
                    //total cost for the coffee is added
                }
                else if (mediumCheck.Checked == true)
                {//if medium size radio is Checked
                    medium += Convert.ToInt32(amountBox.Text);
                    //cost for medium size coffee is added
                    total += 1.90 * medium;
                    //total cost for the coffee is updated
                }
                else if (largeCheck.Checked == true)
                {//if large size radio is checked
                    large += Convert.ToInt32(amountBox.Text);
                    //cost for large size coffe is added
                    total += 2.00 * large;
                    //total cost for the coffee is updated
                }
                //reset every radio box to disabled
                smallCheck.Checked = false;
                mediumCheck.Checked = false;
                largeCheck.Checked = false;
                addToOrder.Enabled = false;
                //reset the text to nothing
                amountBox.Text = "";
                //enable the completeOrder buttom
                completeOrder.Enabled = true;
            }
            else
                MessageBox.Show("Please check a size!", "Error");
            //output error msg when no size is chosen
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (amountBox.Text == "")//if users entered nothing
            {
                //reset buttoms/disable
                addToOrder.Enabled = false;
                completeOrder.Enabled = false;
            }
            try
            {
                price.Text = "";//reset the price 
                int amount = Convert.ToInt32(amountBox.Text);
                if (amount != 0)//if there are amount added
                    addToOrder.Enabled = true;//enable addToOrder buttom
            }
            catch { }
        }

        private void completeOrder_Click(object sender, EventArgs e)
        {
            //output the costs 
            price.Text = $"Small: {small}\nMedium: {medium}\nLarge: {large}\nTotal: ${total}";
            //reset everything to 0
            small = 0;
            medium = 0;
            large = 0;
            total = 0;
            //reset completeOrder buttom
            completeOrder.Enabled = false;
        }
    }
}