﻿using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace WebPlex.CControls
{
    public partial class ctrlSplashScreen : UserControl
    {
        public ctrlSplashScreen()
        {
            InitializeComponent();
        }

        private void timerCount_Tick(object sender, System.EventArgs e)
        {
            lblLoadingStuckRestart.Visible = true;
        }

        private void lblLoadingStuckRestart_Click(object sender, System.EventArgs e)
        {
            if (Directory.Exists(Main.pathData)) { Directory.Delete(Main.pathData, true); } Application.Restart();
        }
    }
}