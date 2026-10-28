namespace lab3quizform2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool IsPassing(int score)
        {
            if (score >= 50)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        string GetLetterGrade(int score)
        {
            if (score >= 90 && score <= 100)
            {
                return "A";
            }
            else if (score >= 80)
            {
                return "B";
            }
            else if (score >= 70)
            {
                return "C";
            }
            else if (score >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }

        }

        int CalculateNeededScore(int score)
        {
            return 100 - score;
        }




        private void btnCheckPass_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtScore.Text, out int a))
            {
                string checkpass = IsPassing(a) ? "pass" : "fail";
                lblResult.Text = checkpass;
            }
        }

        private void btnLetterGrade_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtScore.Text, out int a))
            {
                int score = int.Parse(txtScore.Text);

                string grade = GetLetterGrade(score);

                lblResult.Text = grade;
            }
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtScore.Text, out int a))
            {
                int score = int.Parse(txtScore.Text);

                int neededScore = CalculateNeededScore(score);

                lblResult.Text = neededScore.ToString();
            }
            
        }
    }
}
