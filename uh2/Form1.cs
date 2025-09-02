namespace uh2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Isi ComboBox
            comboMood.Items.AddRange(new string[] { "Happy", "Sad", "Angry", "Excited", "Tired" });

            // Set default pilihan biar tidak null
            comboMood.SelectedIndex = 0;

            // Tampilkan tanggal hari ini
            lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string mood = comboMood.SelectedItem?.ToString();
            string date = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            if (!string.IsNullOrEmpty(mood))
            {
                listMoods.Items.Add($"{date} - {mood}");
            }
            else
            {
                MessageBox.Show("Pilih mood terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboMood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }
    }
}
