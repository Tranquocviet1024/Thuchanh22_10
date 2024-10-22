namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            String Ten = txtTen.Text;
            String Matkhau = txtMatkhau.Text;
            if (Ten == "admin" && Matkhau == "1234")
            {
                MessageBox.Show("??ng nh?p thành công");
            }
            else
            {
                MessageBox.Show("??ng nh?p th?t b?i");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
