namespace W0702WFLotto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnGeneration(object sender, EventArgs e)
        {
            Random r = new Random();
            int[] num = new int[6];

            for (int i = 0; i < 6; i++)
            {
                //num[i] = r.Next(1,46);
                int n = 0;
                do { 
                    n = r.Next(1, 46);
                }while(num.Contains(n));
                num[i] = n;
            }

            num1.Text = $"{num[0]}";
            num2.Text = $"{num[1]}";
            num3.Text = $"{num[2]}";
            num4.Text = $"{num[3]}";
            num5.Text = $"{num[4]}";
            num6.Text = $"{num[5]}";
        }
    }
}