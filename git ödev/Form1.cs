namespace git_ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> Liste_AdSoyad = new List<string>();
        List<string> Liste_CalisanID = new List<string>();
        List<string> Liste_Yemek = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Liste_AdSoyad.Add(textBox1.Text);
            Liste_CalisanID.Add(textBox2.Text);
            Liste_Yemek.Add(textBox3.Text);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            MessageBox.Show("Başarıyla Gönderildi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 0; i < Liste_AdSoyad.Count; i++)
            {
                string deger = Liste_AdSoyad[i] + " " + Liste_CalisanID[i] + " " + Liste_Yemek[i];
                listBox1.Items.Add(deger);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Liste_AdSoyad.Clear();
            Liste_CalisanID.Clear();
            Liste_Yemek.Clear();
            listBox1.Items.Clear();
        }
    }
}