namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Name = "My name project";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"name " + textBox1.Text + "" + "Year of birth" + textBox2.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1 = null;
            textBox2 = null;
            textBox1.Focus;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}