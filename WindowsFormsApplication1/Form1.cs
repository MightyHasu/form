using System;
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

        private void clear_Click(object sender, EventArgs e)
        {
            xCountValue.Clear();
            yCountValue.Clear();
            zCountValue.Clear();
            angleValue.Clear();
            dwellBeforeShootValue.Clear();
            xValue.Clear();
            yValue.Clear();
            zValue.Clear();
            exposureTimeVaule.Clear();
            fileNameValue.Clear();
        }

        private void generateNC_Click(object sender, EventArgs e)
        {

            string head = "G90 G70 \r\nG54\r\nG0 X0 Y0\r\nG0 Z0\r\n";

            int dwellTime = new int();
            int x = new int();
            int xCount = new int();
            int y = new int();
            int yCount = new int();
            int z = new int();
            int zCount = new int();
            int angle = new int();
            int exposureTime = new int();
            
            try
            {
                dwellTime = int.Parse(dwellBeforeShootValue.Text);
            }
            catch (Exception)
            {
                dwellBeforeShootValue.ForeColor = System.Drawing.Color.Red;
                dwellBeforeShootValue.Text = "Invalid - " + dwellBeforeShootValue.Text;
                return;               
            }

            try
            {
                x = int.Parse(xValue.Text);
            }
            catch(Exception)

            {
                xValue.ForeColor = System.Drawing.Color.Red;
                xValue.Text = "Invalid - " + xValue.Text;
                return;
            }

            try
            {
                xCount = int.Parse(xCountValue.Text);
            }
            catch (Exception)
            {
                xCountValue.ForeColor = System.Drawing.Color.Red;
                xCountValue.Text = "Invalid - " + xCountValue.Text;
                return;
            }

            try
            {
                y = int.Parse(yValue.Text);
            }
            catch (Exception)
            {
                yValue.ForeColor = System.Drawing.Color.Red;
                yValue.Text = "Invalid - " + yValue.Text;
                return;
            }

            try
            {
                yCount = int.Parse(yCountValue.Text);
            }
            catch (Exception)
            {
                yCountValue.ForeColor = System.Drawing.Color.Red;
                yCountValue.Text = "Invalid - " + yCountValue.Text;
                return;
            }

            try
            {
                z = int.Parse(zValue.Text);
            }
            catch (Exception)
            {
                zValue.ForeColor = System.Drawing.Color.Red;
                zValue.Text = "Invalid - " + zValue.Text;
                return;
            }

            try
            {
                zCount = int.Parse(zCountValue.Text);
            }
            catch (Exception)
            {
                zCountValue.ForeColor = System.Drawing.Color.Red;
                zCountValue.Text = "Invalid - " + zCountValue.Text;
                return;
            }

            try
            {
                angle = int.Parse(angleValue.Text);
            }
            catch (Exception)
            {
                angleValue.ForeColor = System.Drawing.Color.Red;
                angleValue.Text = "Invalid - " + angleValue.Text;
                return;
            }

            try
            {
                exposureTime = int.Parse(exposureTimeVaule.Text);
            }
            catch (Exception)
            {
                exposureTimeVaule.ForeColor = System.Drawing.Color.Red;
                exposureTimeVaule.Text = "Invalid - " + exposureTimeVaule.Text;
                return;

            }            

            System.Text.StringBuilder ncFile = new System.Text.StringBuilder();            

            ncFile.Append(head);

            int zTemp = 0;
            for (int i = 0; i < zCount; i++)
            {
                int yTemp = 0;
                for (int j = 0; j < yCount; j++)
                {
                    int xTemp = 0;
                    for (int k = 0; k < xCount; k++)
                    {
                        double yMove = Math.Round(((yTemp * Math.Cos(angle)) + (zTemp * Math.Sin(angle))), 3);
                        double zMove = Math.Round(((yTemp * Math.Sin(angle)) - (zTemp * Math.Cos(angle))), 3);
                        ncFile.Append("G0 X" + xTemp + " Y" + yMove + " Z" + zMove + "\r\n");
                        ncFile.Append("G04 X" + dwellTime + "\r\n");
                        ncFile.Append("M8\r\n");
                        ncFile.Append("G04 X1\r\n");
                        ncFile.Append("M9\r\n");
                        ncFile.Append("G04 X" + exposureTime + "\r\n");
                        xTemp += x;
                    }

                    yTemp += y;
                }
                zTemp += z;
            }

            ncFile.Append("M30\r\n");            

            if (fileNameValue.Text == "")
            {
                fileNameValue.Text = "NewNCFile";
            } 

            FileWriterMighty.WriteFile(ncFile.ToString(), (fileNameValue.Text));            

            MessageBox.Show("NC file generated!");
            

        }

        private void openProgramWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void closeProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            this.Activate();
        }
    }
}

   

class FileWriterMighty
{
    public static void WriteFile(string lines, string fileName)
    {       
        System.Text.StringBuilder path = new System.Text.StringBuilder();
        path.Append(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)+"\\");        
        System.IO.File.WriteAllText(@path+fileName+".NC", lines);

        //if (true)
        //{
        //    
        //}
        //Form f = new WindowsFormsApplication1.Form2(); // This is bad
        //f.Show();

    }
}



        
    