namespace LoginPage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Username, Password;
            Username = textBox1.Text;
            Password = textBox2.Text;
            if((Username == "souliya@gmail.com") && (Password == "123456"))
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
                
                
            }
            else { MessageBox.Show("ຂໍ້ມູນບໍ່ຖືກຕ້ອງ");

            }
        }
    }
}