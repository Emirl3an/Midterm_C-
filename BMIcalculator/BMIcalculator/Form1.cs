namespace BMIcalculator
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {//Exit Button
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {//Reset Button
            txtHeight.Text = "";
            txtWeight.Text = "";
            txtResult.Text = "";

            radKg.Checked = false;
            radLb.Checked = false;

        }
        private void btnCalculate_Click_1(object sender, EventArgs e)
        {//Calculate Button
            double weight = Convert.ToDouble(txtWeight.Text);
            double height = Convert.ToDouble(txtHeight.Text);
            double result = 0.0;
            string result2 = "";


            if (radKg.Checked)
            {
                result = weight / (height * height);
            }
            else
                if (radLb.Checked)
            {
                weight = weight / 2.205;
                result = weight / (height * height);
            }

            if (result < 18.5)
            {
                result2 = "You are underweight";
            }
            else
            if (result < 25)
            {
                result2 = "You have normal weight";
            }
            else
            if (result < 30)
            {
                result2 = "You are overweight";
            }
            else 
            if (result >= 30)
            {
                result2 = "You are obese";
            }


            txtResult.Text = "Your Body Mass Index is: " + result.ToString("#.#") + "\r\n" + result2;




        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}