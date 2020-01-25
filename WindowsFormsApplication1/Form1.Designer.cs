namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.horizontalStepsLenght = new System.Windows.Forms.Label();
            this.xValue = new System.Windows.Forms.TextBox();
            this.xCountValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yCountValue = new System.Windows.Forms.TextBox();
            this.yValue = new System.Windows.Forms.TextBox();
            this.zValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.zCountValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.generateNC = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.angleValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dwellBeforeShootValue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.exposureTimeVaule = new System.Windows.Forms.TextBox();
            this.succefullBuild = new System.Windows.Forms.Label();
            this.fileNameValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openProgramWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // horizontalStepsLenght
            // 
            this.horizontalStepsLenght.AutoSize = true;
            this.horizontalStepsLenght.Location = new System.Drawing.Point(38, 27);
            this.horizontalStepsLenght.Name = "horizontalStepsLenght";
            this.horizontalStepsLenght.Size = new System.Drawing.Size(139, 17);
            this.horizontalStepsLenght.TabIndex = 1;
            this.horizontalStepsLenght.Text = "Horizontal step (mm)";
            // 
            // xValue
            // 
            this.xValue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.xValue.Location = new System.Drawing.Point(41, 59);
            this.xValue.Name = "xValue";
            this.xValue.Size = new System.Drawing.Size(100, 22);
            this.xValue.TabIndex = 2;
            this.toolTip2.SetToolTip(this.xValue, "Enter how much the camera will be moved horizontaly before taking a picture");
            // 
            // xCountValue
            // 
            this.xCountValue.Location = new System.Drawing.Point(253, 59);
            this.xCountValue.Name = "xCountValue";
            this.xCountValue.Size = new System.Drawing.Size(100, 22);
            this.xCountValue.TabIndex = 3;
            this.toolTip2.SetToolTip(this.xCountValue, "Enter the number of photographs to be taken in horizontal direction");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of horizontal steps";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vertical step (mm)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Number of vertical steps";
            // 
            // yCountValue
            // 
            this.yCountValue.Location = new System.Drawing.Point(253, 149);
            this.yCountValue.Name = "yCountValue";
            this.yCountValue.Size = new System.Drawing.Size(100, 22);
            this.yCountValue.TabIndex = 6;
            this.toolTip2.SetToolTip(this.yCountValue, "Enter the number of photographs to be taken in vertical direction");
            // 
            // yValue
            // 
            this.yValue.Location = new System.Drawing.Point(41, 149);
            this.yValue.Name = "yValue";
            this.yValue.Size = new System.Drawing.Size(100, 22);
            this.yValue.TabIndex = 8;
            this.toolTip2.SetToolTip(this.yValue, "Enter how much the camera will be moved verticaly before taking a picture");
            // 
            // zValue
            // 
            this.zValue.Location = new System.Drawing.Point(41, 246);
            this.zValue.Name = "zValue";
            this.zValue.Size = new System.Drawing.Size(100, 22);
            this.zValue.TabIndex = 12;
            this.toolTip2.SetToolTip(this.zValue, "Enter how much the camera will be moved in depth before taking a picture");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Number of depth steps";
            // 
            // zCountValue
            // 
            this.zCountValue.Location = new System.Drawing.Point(253, 246);
            this.zCountValue.Name = "zCountValue";
            this.zCountValue.Size = new System.Drawing.Size(100, 22);
            this.zCountValue.TabIndex = 10;
            this.toolTip2.SetToolTip(this.zCountValue, "Enter the number of photographs to be taken in depth");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Depth step (mm)";
            // 
            // generateNC
            // 
            this.generateNC.Location = new System.Drawing.Point(41, 479);
            this.generateNC.Name = "generateNC";
            this.generateNC.Size = new System.Drawing.Size(136, 23);
            this.generateNC.TabIndex = 13;
            this.generateNC.Text = "Generate NC File";
            this.generateNC.UseVisualStyleBackColor = true;
            this.generateNC.Click += new System.EventHandler(this.generateNC_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(253, 479);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 14;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // angleValue
            // 
            this.angleValue.Location = new System.Drawing.Point(41, 335);
            this.angleValue.Name = "angleValue";
            this.angleValue.Size = new System.Drawing.Size(100, 22);
            this.angleValue.TabIndex = 18;
            this.toolTip2.SetToolTip(this.angleValue, "Enter the angle of the camera related to the horizontal plane");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Dwell before shoot (sec)";
            // 
            // dwellBeforeShootValue
            // 
            this.dwellBeforeShootValue.Location = new System.Drawing.Point(253, 335);
            this.dwellBeforeShootValue.Name = "dwellBeforeShootValue";
            this.dwellBeforeShootValue.Size = new System.Drawing.Size(100, 22);
            this.dwellBeforeShootValue.TabIndex = 16;
            this.toolTip2.SetToolTip(this.dwellBeforeShootValue, "Enter time for the machime to wait before taking a picture, to reduce blurry pict" +
        "ures");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Angle (degᵒ)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Exposure time (sec)";
            // 
            // exposureTimeVaule
            // 
            this.exposureTimeVaule.Location = new System.Drawing.Point(41, 418);
            this.exposureTimeVaule.Name = "exposureTimeVaule";
            this.exposureTimeVaule.Size = new System.Drawing.Size(100, 22);
            this.exposureTimeVaule.TabIndex = 19;
            this.toolTip2.SetToolTip(this.exposureTimeVaule, "Exposure time must be in whole seconds");
            // 
            // succefullBuild
            // 
            this.succefullBuild.AutoSize = true;
            this.succefullBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.succefullBuild.Location = new System.Drawing.Point(250, 418);
            this.succefullBuild.Name = "succefullBuild";
            this.succefullBuild.Size = new System.Drawing.Size(0, 24);
            this.succefullBuild.TabIndex = 21;
            // 
            // fileNameValue
            // 
            this.fileNameValue.Location = new System.Drawing.Point(254, 418);
            this.fileNameValue.Name = "fileNameValue";
            this.fileNameValue.Size = new System.Drawing.Size(100, 22);
            this.fileNameValue.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "File name";
            // 
            // toolTip2
            // 
            this.toolTip2.AutoPopDelay = 10000;
            this.toolTip2.InitialDelay = 200;
            this.toolTip2.ReshowDelay = 100;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "AutomaticFotoControlNCGenerator";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openProgramWindowToolStripMenuItem,
            this.closeProgramToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(239, 56);
            // 
            // openProgramWindowToolStripMenuItem
            // 
            this.openProgramWindowToolStripMenuItem.Name = "openProgramWindowToolStripMenuItem";
            this.openProgramWindowToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.openProgramWindowToolStripMenuItem.Text = "Open program window";
            this.openProgramWindowToolStripMenuItem.Click += new System.EventHandler(this.openProgramWindowToolStripMenuItem_Click);
            // 
            // closeProgramToolStripMenuItem
            // 
            this.closeProgramToolStripMenuItem.Name = "closeProgramToolStripMenuItem";
            this.closeProgramToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.closeProgramToolStripMenuItem.Text = "Close program";
            this.closeProgramToolStripMenuItem.Click += new System.EventHandler(this.closeProgramToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 552);
            this.Controls.Add(this.succefullBuild);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.exposureTimeVaule);
            this.Controls.Add(this.angleValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileNameValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dwellBeforeShootValue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.generateNC);
            this.Controls.Add(this.zValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.zCountValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.yValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yCountValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.xCountValue);
            this.Controls.Add(this.xValue);
            this.Controls.Add(this.horizontalStepsLenght);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Automatic photo control NC Generator";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label horizontalStepsLenght;
        private System.Windows.Forms.TextBox xValue;
        private System.Windows.Forms.TextBox xCountValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yCountValue;
        private System.Windows.Forms.TextBox yValue;
        private System.Windows.Forms.TextBox zValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox zCountValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button generateNC;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox angleValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dwellBeforeShootValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox exposureTimeVaule;
        private System.Windows.Forms.Label succefullBuild;
        private System.Windows.Forms.TextBox fileNameValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openProgramWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeProgramToolStripMenuItem;
    }
}