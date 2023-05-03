using System.Media;
using System.Text;
using System.Windows.Forms;

namespace NoteTakingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static class vari
        {
            public static String fileName = " "; // holds file location
            public static string text = " ";     // holds text
            public static String fileTextName = " ";// holds file name

        }

        private void button1_Click(object sender, EventArgs e) // creates new save
        {

            vari.text = richTextBox1.Text;
            MessageBox.Show(vari.text);

            SaveFileDialog saveFileDialog = new SaveFileDialog(); // creates dialog box to ask user where to save
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.Title = "Save a Text File";
            if (saveFileDialog.ShowDialog() == DialogResult.OK) // if user clicks ok to save text file
            {
                // Get the selected file name and write to the file
                vari.fileName = saveFileDialog.FileName;
                File.WriteAllText(vari.fileName, vari.text);
                label1.Text = vari.fileTextName;
                MessageBox.Show("Text Saved");
                btnsaveit.Visible = true;

            }

        }

        private void BTNclear_Click(object sender, EventArgs e) // clears richedit, file location and resets everything
        {

            DialogResult res = MessageBox.Show("Are you sure you want to clear", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                richTextBox1.Clear();
                label1.Text = string.Empty;
                vari.fileName = string.Empty;
                vari.text = string.Empty;
                btnsaveit.Visible = false;
            }
        }

        private void BTNopen_Click(object sender, EventArgs e)// open a text file 
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.Title = "Open a Text File";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file name and read its contents
                vari.fileName = openFileDialog.FileName;
                vari.text = File.ReadAllText(vari.fileName);
                vari.fileTextName = openFileDialog.SafeFileName;
                richTextBox1.Text = vari.text;
                label1.Text = vari.fileTextName;
                btnsaveit.Visible = true;

            }
        }

        private void btnsaveit_Click(object sender, EventArgs e)// save to current used file
        {
            vari.text = richTextBox1.Text;
            File.WriteAllText(vari.fileName, vari.text);
            label1.Text = vari.fileTextName;
            MessageBox.Show("Text Saved");
        }
    }
}