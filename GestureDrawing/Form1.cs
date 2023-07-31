using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestureDrawing
{
    public partial class Form1 : Form
    {
        // Private field to store the "imagePopupForm" instance
        private ImagePopupForm popupForm;

        public Form1()
        {
            InitializeComponent();
        }

        // Method that displays the number of elements inside the selected folder
        private void UpdateElementCount()
        {
            string folderPath = txtFolderPath.Text;
            int elementCount = Directory.GetFileSystemEntries(folderPath).Length;
            txtElementCount.Text = elementCount.ToString();
        }

        // Folder Selection Button that executes the UpdateElementCount Method
        private void button1_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderDialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    txtFolderPath.Text = folderDialog.SelectedPath;
                    UpdateElementCount();
                }
            }
        }

        // Set the timer duration based on the selected radio button
        private TimeSpan GetSelectedTimerDuration()
        {
            if (button5.Checked)
            {
                return TimeSpan.FromSeconds(30);
            }
            else if (button6.Checked)
            {
                return TimeSpan.FromSeconds(45);
            }
            else if (button7.Checked)
            {
                return TimeSpan.FromSeconds(60);
            }
            else if (button8.Checked)
            {
                return TimeSpan.FromSeconds(120);
            }
            else if (button9.Checked)
            {
                return TimeSpan.FromSeconds(300);
            }
            else if (button10.Checked)
            {
                return TimeSpan.FromSeconds(600);
            }
            else
            {
                // Default to 30 seconds if no radio button is selected
                return TimeSpan.FromSeconds(30);
            }
        }

        // Start Button that executes the Image Popups and handles the timer
        private void button11_Click(object sender, EventArgs e)
        {
            // Get the selected folder path from txtFolderPath
            string folderPath = txtFolderPath.Text;

            // Get the selected timer duration
            TimeSpan timerDuration = GetSelectedTimerDuration();

            // Load a random image from the selected folder
            string[] imageFiles = Directory.GetFiles(folderPath, "*.jpg"); // Assuming JPG images
            if (imageFiles.Length > 0)
            {
                Random random = new Random();
                string randomImagePath = imageFiles[random.Next(imageFiles.Length)];
                Image image = Image.FromFile(randomImagePath);

                // Hide the main form
                this.Hide();

                // Show the image in the existing popup form
                if (popupForm == null || popupForm.IsDisposed)
                {
                    popupForm = new ImagePopupForm(folderPath, timerDuration);
                    popupForm.FormClosed += PopupForm_FormClosed;
                }

                popupForm.UpdateImage(image);
                popupForm.Show();
            }
        }

        // When the popup form is closed, show the main form again
        private void PopupForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
