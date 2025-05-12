using System.Collections;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ComputingNumbers
{
    public partial class numberManipulationForm : Form
    {
        public numberManipulationForm()
        {
            InitializeComponent();
        }

        private void numberManipulationForm_Load(object sender, EventArgs e)
        {

        }

        //Number List
        List<int> numberList = new List<int>();
        const int maxNum = 10;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            numberList.Clear();

            string input = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(input))
            {
                string[] parts = input.Split(',');
                List<string> validEntries = new List<string>();

                foreach (string part in parts)
                {
                    string trimmed = part.Trim();
                    if (!string.IsNullOrEmpty(trimmed))
                    {
                        validEntries.Add(trimmed);
                    }
                }

                //allow only 10  digits
                if (validEntries.Count > maxNum)
                {
                    validEntries = validEntries.Take(maxNum).ToList();

                    string newText = string.Join(", ", validEntries);

                    textBox1.TextChanged -= textBox1_TextChanged;
                    textBox1.Text = newText;
                    textBox1.SelectionStart = textBox1.Text.Length;
                    textBox1.TextChanged += textBox1_TextChanged;
                }

                foreach (string entry in validEntries)
                {
                    if (int.TryParse(entry, out int number))
                    {
                        numberList.Add(number);
                    }
                }
            }

            foreach (int j in numberList)
            {
                Console.WriteLine(j);
            }

            //for (int i = 0; i < 10; i++)
            //{
            //    numberList.Add(i);
            //}

            //foreach (int j in numberList)
            //{
            //    Console.WriteLine(j);
            //}

        }



        //handling number only
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            else
            {
                string currentText = textBox1.Text;
                if (e.KeyChar == ',' && (currentText.Length == 0 || currentText.EndsWith(",")))
                {
                    e.Handled = true;
                }
            }
        }

        //Clear Both all text and Radio selection
        private void clearButton_Click(object sender, System.EventArgs e)
        {
            textBox1.Clear();
            listOddNumbersRadio.Checked = false;
            sumRadio.Checked = false;
            countDuplicateRadio.Checked = false;
        }

        //Listing only odd numbers
        private void listOddNumbersRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (listOddNumbersRadio.Checked)
            {
                var input = textBox1.Text.Split(',');
                var odd = input
                    .Select(x => x.Trim())
                    .Where(x => int.TryParse(x, out int n) && n % 2 != 0);
                textBox1.Text = string.Join(", ", odd);
            }
        }

        //Selecting Duplicate Numbers
        private void countDuplicateRadio_CheckedChanged(object sender, EventArgs e)
        {
            var nums = textBox1.Text.Split(',')
                        .Select(x => x.Trim())
                        .Where(x => int.TryParse(x, out _))
                        .GroupBy(x => x)
                        .Where(g => g.Count() > 1)
                        .SelectMany(g => g);

            textBox1.Text = string.Join(", ", nums);
        }

        private void computeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || (!sumRadio.Checked && !listOddNumbersRadio.Checked && !countDuplicateRadio.Checked))
            {
                MessageBox.Show("Please Enter Numbers and select any function.","Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var input = textBox1.Text.Split(',')
                .Select(x => x.Trim())
                .Where(x => int.TryParse(x, out _))
                .ToList();

            //computing with the selection
            if (sumRadio.Checked)
            {
                var sum = input.Sum(x => int.Parse(x));
                MessageBox.Show($"The sum is: {sum}", "Sum Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (listOddNumbersRadio.Checked)
            {
                var oddNumbers = input
                    .Where(x => int.Parse(x) % 2 != 0); 

                var sumOdd = oddNumbers.Sum(x => int.Parse(x));

                textBox1.Text = string.Join(", ", oddNumbers);
                MessageBox.Show($"The sum of odd numbers is: {sumOdd}", "Odd Numbers Sum", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (countDuplicateRadio.Checked)
            {
                var duplicates = input
                    .GroupBy(x => x)  
                    .Where(g => g.Count() > 1) 
                    .SelectMany(g => g);  

                var sumDuplicate = duplicates.Sum(x => int.Parse(x));

                textBox1.Text = string.Join(", ", duplicates);
                MessageBox.Show($"The sum of duplicate numbers is: {sumDuplicate}", "Duplicate Numbers Sum", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
