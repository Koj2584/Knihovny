using RetezUtil;

namespace Knihovny2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = Retezec.Smaz(textBox1.Text);
            } catch { }
            try
            {
                Minus x = new Minus(textBox2.Text);
                Minus y = new Minus(textBox3.Text);
                label2.Text = x - y;
            } catch (Exception ex) { }
        }
    }
}