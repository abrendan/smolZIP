using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;

namespace smolZIP
{
    public partial class MainForm : Form
    {
        private const string AppVersion = "1.0.0";

        public MainForm()
        {
            InitializeComponent();
        }

        // Extract ZIP File with progress
        private void ExtractZip(string zipFilePath, string extractPath)
        {
            try
            {
                using (FileStream fs = File.OpenRead(zipFilePath))
                {
                    ZipFile zf = new ZipFile(fs);
                    progressBar.Maximum = (int)zf.Count;
                    progressBar.Value = 0;

                    foreach (ZipEntry entry in zf)
                    {
                        if (!entry.IsFile) continue;

                        string entryFileName = entry.Name;
                        byte[] buffer = new byte[4096];

                        // ZipFile.GetInputStream() returns a raw input stream.
                        using (Stream zipStream = zf.GetInputStream(entry))
                        {
                            string fullZipToPath = Path.Combine(extractPath, entryFileName);
                            string directoryName = Path.GetDirectoryName(fullZipToPath);

                            if (directoryName.Length > 0)
                                Directory.CreateDirectory(directoryName);

                            using (FileStream streamWriter = File.Create(fullZipToPath))
                            {
                                StreamUtils.Copy(zipStream, streamWriter, buffer);
                            }
                        }

                        progressBar.Value++;
                    }
                }
                MessageBox.Show("Extraction complete!", "smolZIP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progressBar.Value = 0;
            }
        }

        // Create ZIP File with progress
        private void CreateZip(string folderPath, string zipFilePath)
        {
            try
            {
                FastZipEvents events = new FastZipEvents();
                events.Progress = new ProgressHandler((source, progress) =>
                {
                    progressBar.Value = progressBar.Value + 1;
                });

                FastZip fastZip = new FastZip(events);
                fastZip.CreateZip(zipFilePath, folderPath, true, null);
                MessageBox.Show("Archiving complete!", "smolZIP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progressBar.Value = 0;
            }
        }

        private void btnExtractZip_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Zip files (*.zip)|*.zip";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                    {
                        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                        {
                            ExtractZip(openFileDialog.FileName, folderBrowserDialog.SelectedPath);
                        }
                    }
                }
            }
        }

        private void btnCreateZip_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Zip files (*.zip)|*.zip";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            CreateZip(folderBrowserDialog.SelectedPath, saveFileDialog.FileName);
                        }
                    }
                }
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}