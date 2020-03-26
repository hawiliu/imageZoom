using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imageZoom
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            int Width = 0;
            int Height = 0;

            string type = cb_Type.Text;
            ImageFormat format = type.Equals("jpg") ? ImageFormat.Jpeg : ImageFormat.Png;

            if (int.TryParse(tb_Width.Text, out Width) && int.TryParse(tb_Height.Text, out Height))
            {
                try
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        foreach (var file in openFileDialog.FileNames)
                        {
                            string filename = Path.GetFileNameWithoutExtension(file);
                            string filepath = Path.GetDirectoryName(file) + @"\resize";
                            if (!Directory.Exists(filepath))
                                Directory.CreateDirectory(filepath);

                            Image original = Image.FromFile(file);

                            Image output = (Image)(new Bitmap(original, new Size(Convert.ToInt32(tb_Width.Text), Convert.ToInt32(tb_Height.Text))));
                            output.Save(filepath + @"\" + filename + "." + type, format);
                            output.Dispose();
                            original.Dispose();
                        }

                        MessageBox.Show("Finish.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
                MessageBox.Show("Width & Height must be a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
