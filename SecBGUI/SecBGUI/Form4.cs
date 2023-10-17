using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecBGUI
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private List<int> numbers;
        private void button1_Click(object sender, EventArgs e)
        {
            //display a random number from 1 to 100

            // Create a Random object
            Random random = new Random();

            // Generate a random number between 1 and 100
            int randomNumber = random.Next(1, 101);
            // MessageBox.Show("Random Number: " + randomNumber.ToString());
            ArrayList myNumbers = new ArrayList();
            const int MAX = 100;
            for (int i = 0; i < MAX; i++)
            {
                myNumbers.Add(random.Next(1, 10));
            }
            Console.WriteLine(myNumbers.Count);

            string filePath = @"C:\Users\anoj1\source\repos\data.txt";

            // Write the data to the specified file path
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (int number in myNumbers)
                {
                    writer.WriteLine(number);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Specify the absolute file path
                string filePath = @"C:\Users\anoj1\source\repos\data.txt";

                if (File.Exists(filePath))
                {
                    // Read all numbers from the file
                    List<int> numbers = new List<int>();
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (int.TryParse(line, out int number))
                            {
                                numbers.Add(number);
                            }
                        }
                    }

                    // Display the numbers
                    if (numbers.Count > 0)
                    {
                        string numbersText = string.Join(", ", numbers);
                        MessageBox.Show("Numbers from the file: " + numbersText);
                    }
                    else
                    {
                        MessageBox.Show("No valid numbers found in the file.");
                    }
                }
                else
                {
                    MessageBox.Show("The file does not exist at the specified path.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Specify the absolute file path
                string filePath = @"C:\Users\anoj1\source\repos\data.txt";

                if (File.Exists(filePath))
                {
                    // Read all numbers from the file
                    List<int> numbers = new List<int>();
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (int.TryParse(line, out int number))
                            {
                                numbers.Add(number);
                            }
                        }
                    }

                    // Calculate the average of the numbers
                    double average = 0.0;

                    if (numbers.Count > 0)
                    {
                        int sum = numbers.Sum();
                        average = (double)sum / numbers.Count;
                        MessageBox.Show("Average of the numbers: " + average.ToString("F2"));
                    }
                    else
                    {
                        MessageBox.Show("No valid numbers found in the file.");
                    }
                }
                else
                {
                    MessageBox.Show("The file does not exist at the specified path.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // Specify the absolute file path
                string filePath = @"C:\Users\anoj1\source\repos\data.txt";

                if (File.Exists(filePath))
                {
                    // Read all numbers from the file
                    List<int> numbers = new List<int>();
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (int.TryParse(line, out int number))
                            {
                                numbers.Add(number);
                            }
                        }
                    }

                    if (numbers.Count > 0)
                    {
                        // Arrange the numbers in ascending order
                        numbers.Sort();

                        // Display the sorted numbers (you can choose how to display them)
                        string sortedNumbersText = string.Join(", ", numbers);
                        MessageBox.Show("Numbers in ascending order: " + sortedNumbersText);
                    }
                    else
                    {
                        MessageBox.Show("No valid numbers found in the file.");
                    }
                }
                else
                {
                    MessageBox.Show("The file does not exist at the specified path.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                // Specify the absolute file path
                string filePath = @"C:\Users\anoj1\source\repos\data.txt";

                if (File.Exists(filePath))
                {
                    // Read all numbers from the file
                    List<int> numbers = new List<int>();
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (int.TryParse(line, out int number))
                            {
                                numbers.Add(number);
                            }
                        }
                    }

                    if (numbers.Count > 0)
                    {
                        // Arrange the numbers in descending order
                        numbers.Sort();
                        numbers.Reverse();

                        // Display the sorted numbers (you can choose how to display them)
                        string sortedNumbersText = string.Join(", ", numbers);
                        MessageBox.Show("Numbers in descending order: " + sortedNumbersText);
                    }
                    else
                    {
                        MessageBox.Show("No valid numbers found in the file.");
                    }
                }
                else
                {
                    MessageBox.Show("The file does not exist at the specified path.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Specify the absolute file path
                string filePath = @"C:\Users\anoj1\source\repos\data.txt";

                if (File.Exists(filePath))
                {
                    // Read all numbers from the file
                    List<int> numbers = new List<int>();
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (int.TryParse(line, out int number))
                            {
                                numbers.Add(number);
                            }
                        }
                    }

                    if (numbers.Count > 0)
                    {
                        // Get the number from the TextBox
                        if (int.TryParse(textBox1.Text, out int numberToCheck))
                        {
                            // Check if the number exists in the list
                            bool numberExists = numbers.Contains(numberToCheck);

                            if (numberExists)
                            {
                                MessageBox.Show($"{numberToCheck} exists in the file.");
                            }
                            else
                            {
                                MessageBox.Show($"{numberToCheck} does not exist in the file.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid number in the TextBox.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No valid numbers found in the file.");
                    }
                }
                else
                {
                    MessageBox.Show("The file does not exist at the specified path.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

