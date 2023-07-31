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
    public partial class ImagePopupForm : Form
    {
        private TimeSpan timerDuration;
        private TimeSpan remainingTime;
        private Timer countdownTimer;
        private string folderPath;
        private Random random = new Random();
        private string[] imageFiles;
        private bool timerElapsed = false;

        public ImagePopupForm(string folderPath, TimeSpan timerDuration)
        {
            InitializeComponent();
            this.folderPath = folderPath;
            this.timerDuration = timerDuration;

            pictureBoxImage.SizeMode = PictureBoxSizeMode.Zoom;

            // Initialize the countdown timer
            countdownTimer = new Timer();
            countdownTimer.Tick += CountdownTimer_Tick;

            // Load image files from the folder once at the start
            imageFiles = Directory.GetFiles(folderPath, "*.jpg");

            // Start the timer
            StartTimer();
        }

        public void UpdateImage(Image image)
        {
            pictureBoxImage.Image = image;
        }

        public void StartTimer()
        {
            remainingTime = timerDuration;
            UpdateTimeLabel(); // Update the time label with the initial time

            countdownTimer.Stop(); // Stop the previous timer, if running
            countdownTimer.Interval = 1000; // 1 second interval
            countdownTimer.Start();
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            // Decrement the remaining time by 1 second
            remainingTime = remainingTime.Subtract(TimeSpan.FromSeconds(1));

            // Update the time label
            UpdateTimeLabel();

            if (remainingTime <= TimeSpan.Zero)
            {
                if (!timerElapsed) // Check the flag to avoid repeated processing
                {
                    timerElapsed = true; // Set the flag to true
                    countdownTimer.Stop();
                    // Show the next image and start a new timer
                    ShowNextImage();
                    StartTimer(); // Start the timer again
                    timerElapsed = false; // Reset the flag to false
                }
            }
        }

        public void UpdateTimeLabel()
        {
            // Display the remaining time in the label
            lblTimer.Text = remainingTime.ToString(@"mm\:ss");
        }

        private void ShowNextImage()
        {
            if (imageFiles.Length > 0)
            {
                string randomImagePath = imageFiles[random.Next(imageFiles.Length)];
                Image image = Image.FromFile(randomImagePath);
                UpdateImage(image);
            }
        }
    }
}
