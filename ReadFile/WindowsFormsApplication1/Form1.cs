using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                if (openFileDialog1.FileName == "")
                {
                    return;
                }
                else
                {
                    try
                    {
                        //StreamReader sr = new StreamReader(openFileDialog1.FileName);
                        FileInfo file = new FileInfo(openFileDialog1.FileName);
                        FileStream fs = file.OpenRead();
                        var size = file.Length;
                        progressBar1.Maximum = (int) size;
                        var step = 10;
                        byte[] buf = new byte[10];
                        while (fs.Read(buf, 0, buf.Length) > 0)
                        {
                            progressBar1.Increment(step);

                        }
                        fs.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Sorry",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
 

                }
            }
        }
    }

