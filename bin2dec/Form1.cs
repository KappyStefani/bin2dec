namespace bin2dec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTransform_Click_1(object sender, EventArgs e)
        {
            string binario = Convert.ToString(Bin.Text);
            int decimalValor = 0;

            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] == '1')
                {
                    decimalValor += (int)Math.Pow(2, binario.Length - 1 - i);
                }
            }

            Decimal.Text = decimalValor.ToString();
        }
    }
}
