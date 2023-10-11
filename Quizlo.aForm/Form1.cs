using Quizlo.Data.Model.DataModel;
using Quizlo.Business.Service.MainService;

namespace Quizlo.aForm
{
    public partial class Form1 : Form
    {
        List<DataModel> listVoca = new List<DataModel>();
        List<DataModel> listCurrent = new List<DataModel>();
        string content = "What does this word mean? ";
        List<Dictionary<string, string>> answer = new List<Dictionary<string, string>>();
        string answerCorrect = "";

        public Form1()
        {
            InitializeComponent();
            listVoca = Form1Sup.GetData();
            setInit(1);
        }

        #region customCode
        void startChallenge()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 5) - 1;

            listCurrent = Form1Sup.RandomData(listVoca); //count = 4
            answerCorrect = listCurrent[randomNumber].Mean.ToString();
            lblContent.Text = content + Environment.NewLine + listCurrent[randomNumber].Word.ToString();

            lblA.Text = listCurrent[0].Mean;
            lblB.Text = listCurrent[1].Mean;
            lblC.Text = listCurrent[2].Mean;
            lblD.Text = listCurrent[3].Mean;
        }
        public void setInit(int flag) // 1: Init, 2: Start
        {
            bool tempBool = false;
            if (flag == 2) tempBool = true;
            btnA.Enabled = tempBool;
            btnB.Enabled = tempBool;
            btnC.Enabled = tempBool;
            btnD.Enabled = tempBool;

            lblA.Text = "";
            lblB.Text = "";
            lblC.Text = "";
            lblD.Text = "";
            lblContent.Text = "";
            lblResult.Text = "";
        }
        public void checkAnswer(Label lblChoose)
        {
            if (answerCorrect.Equals(lblChoose.Text))
                lblResult.Text = "Correct!";
            else
                lblResult.Text = "Incorrect!";
        }
        #endregion

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text.Equals("Start"))
            {
                setInit(2);
                startChallenge();
                btnStart.Text = "End";
                return;
            }
            if (btnStart.Text.Equals("End"))
            {
                setInit(1);
                btnStart.Text = "Start";
                return;
            }
        }
        private void btnA_Click(object sender, EventArgs e)
        {
            checkAnswer(lblA);
            startChallenge();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            checkAnswer(lblB);
            startChallenge();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            checkAnswer(lblC);
            startChallenge();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            checkAnswer(lblD);
            startChallenge();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Test: " + e.KeyCode.ToString());
        }

        private void btnStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Test: " + e.KeyChar.ToString());

        }

        private void btnKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                    checkAnswer(lblA);
                    startChallenge();
                    break;
                case '2':
                    checkAnswer(lblB);
                    startChallenge();
                    break;
                case '3':
                    checkAnswer(lblC);
                    startChallenge();
                    break;
                case '4':
                    checkAnswer(lblD);
                    startChallenge();
                    break;
                default:

                    break;
            }
        }
        private void btnKey_Click(object sender, EventArgs e)
        {
            btnA.Text = "1";
            btnB.Text = "2";
            btnC.Text = "3";
            btnD.Text = "4";
        }

        private void btnKey_Leave(object sender, EventArgs e)
        {
            btnA.Text = "A";
            btnB.Text = "B";
            btnC.Text = "C";
            btnD.Text = "D";
        }
    }
}