﻿using System;
using System.Windows.Forms;
using ReaLTaiizor.Enum.Poison;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Controls;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Ionic.Zip;

namespace CouInjector_Auto_Update
{
    public partial class Form1 : PoisonForm
    {
        string AppPath = System.AppDomain.CurrentDomain.BaseDirectory;
        public Form1()
        {
            InitializeComponent();
            BorderStyle = ReaLTaiizor.Enum.Poison.FormBorderStyle.FixedSingle;
            ShadowType = FormShadowType.AeroShadow;

        }

        private async void poisonButton_Click(object sender, EventArgs e)
        {
            poisonButton.Enabled = false;
            await Task.Run(() => {
                poisonLabel.Text = "[^]-Closing CouInjector...";
                foreach (var process in Process.GetProcessesByName("CouInjector"))
                {
                    process.Kill();
                    process.WaitForExit();
                }
                System.Threading.Thread.Sleep(1000);
                aloneProgressBar1.Value = 5;
                System.Threading.Thread.Sleep(1000);
                aloneProgressBar1.Value = 10;
                System.Threading.Thread.Sleep(1000);
                poisonLabel.Text = "[^]-Deleting old version...";
                File.Delete(AppPath + @"\CouInjector.exe");
                System.Threading.Thread.Sleep(1000);
                aloneProgressBar1.Value = 15;
                System.Threading.Thread.Sleep(1000);
                aloneProgressBar1.Value = 20;
                System.Threading.Thread.Sleep(1000);
            });

            poisonLabel.Text = "[^]-Downloading new version...";
            var webclient = new WebClient();
            var uri = new Uri("https://bymynix.de/couinjector/CouInjector.zip");

            webclient.DownloadFileCompleted += webclient_DownloadDataCompleted;
            webclient.DownloadProgressChanged += DownloadProgressChanged;

            webclient.DownloadFileAsync(uri, AppPath + @"\CouInjector.zip");
        }

        private void DownloadProgressChanged(object sender, System.Net.DownloadProgressChangedEventArgs e)
        {
            aloneProgressBar1.Minimum = 20;
            aloneProgressBar1.Value = e.ProgressPercentage;
        }
        private void webclient_DownloadDataCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            PoisonMessageBox.Show(this, "Update successfully downloaded. CouInjector starts automatically after clicking 'Ok'.", "CouInjector: Auto-Updater", MessageBoxButtons.OK, MessageBoxIcon.Question);
            string zipFilePath = "CouInjector.zip";
            string password = "123";
            string extractPath = AppPath;

            ExtractZIP(zipFilePath, extractPath, password);

            File.Delete(AppPath + "CouInjector.zip");

            Process.Start(AppPath + @"\CouInjector.exe");
            Application.Exit();
        }

        static void ExtractZIP(string zipFilePath, string extractPath, string password)
        {
            using (ZipFile zipFile = ZipFile.Read(zipFilePath))
            {
                zipFile.Password = password;

                foreach (ZipEntry entry in zipFile)
                {
                    entry.Extract(extractPath, ExtractExistingFileAction.OverwriteSilently);
                }
            }
        }
    }
}