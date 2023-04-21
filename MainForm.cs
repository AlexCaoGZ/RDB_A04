/*
* FILE		        : MainForm.cs
* PROJECT	        : PROG2111 - Assignment 04
* PROGRAMMER	    : Yutong Ji & Zijia Cao
* FIRST  VERSION	: 2021/12/07
* DESCRIPTION	    :
* The functions in this file is to create a survey toll with gamified aspects.
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RDB_A04
{
    public partial class MainForm : Form
    {
        //declare for timer
        public delegate void SetControlValue(string value);
        System.Timers.Timer timer = null;
        //declare for handle sql stuff
        SqlConnection sqlConn = null;
        ArrayList questionIndexList = new ArrayList();
        //declare for gameplay
        string playerName = null;
        bool isShowingAnswer = false;
        int questionNo = 0;
        int score = 0;
        int countDown = 0;
        int correctAnswer = 0;

        /*
        *FUNCTION	    : MainForm
        *DESCRIPTION	: the constructor for mainform
        *PARAMETERS	    :
        *	none.
        *RETURNS	    :
        *	nothing.
        */
        public MainForm()
        {
            InitializeComponent();
            groupBox1.Hide();
            groupBox2.Hide();
            sqlConn = new SqlConnection();
        }

        /*
        *FUNCTION	    : start_Btn_Click
        *DESCRIPTION	: the event for start button clicked
        *PARAMETERS	    :
        *	none.
        *RETURNS	    :
        *	nothing.
        */
        private void start_Btn_Click(object sender, EventArgs e)
        {
            if (name_TextBox.Text == "")
            {
                MessageBox.Show("Your name can not be blank.");
            }
            else if(name_TextBox.Text.Length > 254)
            {
                MessageBox.Show("Your really have a name that longer than 254?");
            }
            else
            {
                //show the game box
                groupBox1.Show();
                groupBox2.Hide();

                //lock the name textbox
                name_TextBox.ReadOnly = true;
                next_Btn.Enabled = true;

                //reset the summary label, this is for play again used
                summary_Label.Text = "";

                //randomize the question's order
                Random rd = new Random();
                while (questionIndexList.Count <= 9)
                {
                    int number = rd.Next(0, 10);
                    if (!questionIndexList.Contains(number))
                    {
                        questionIndexList.Add(number);
                    }
                }

                Play();
            }
        }

        /*
        *FUNCTION	    : Play
        *DESCRIPTION	: this function will load the questions form sql, and put it to the labels
        *PARAMETERS	    :
        *	none.
        *RETURNS	    :
        *	nothing.
        */
        void Play()
        {
            //set play name
            playerName = name_TextBox.Text;

            //count down form 20s.
            countDown = 20;
            countDown_Lable.Text = "Count Down: " + countDown;

            //questionNo == 10 means the survey is completed
            if (questionNo != 10)
            {
                questionNo_Lable.Text = "Question " + (questionNo + 1).ToString();

                //create the Query and exectue
                string SELECT = "SELECT * FROM questionTable WHERE questionIndex =" + questionIndexList[questionNo] + ";";
                List<string> questionList = sqlConn.executeCmd(SELECT);

                //load the datas to labels
                question_Lable.Text = questionList[1];
                A_button.Text = questionList[2];
                B_button.Text = questionList[3];
                C_button.Text = questionList[4];
                D_button.Text = questionList[5];

                //the answer will return as ABCD, so convert it to ascii code for marking
                byte[] array = System.Text.Encoding.ASCII.GetBytes(questionList[6]);
                correctAnswer = (int)(array[0]) - 64;
                questionNo++;

                if (isShowingAnswer)
                {
                    countDown_Lable.Text = " ";

                    switch (correctAnswer)
                    {
                        case 1:
                            answer_label.Text = "A";
                            break;
                        case 2:
                            answer_label.Text = "B";
                            break;
                        case 3:
                            answer_label.Text = "C";
                            break;
                        case 4:
                            answer_label.Text = "D";
                            break;
                    }
                }
                else
                {
                    //Timer start
                    SetTimer();
                }
            }
            else
            {
                if (isShowingAnswer)
                {
                    countDown_Lable.Text = "";
                    questionNo_Lable.Text = "Answer review completed.";
                    question_Lable.Text = "";
                    A_button.Text = "";
                    B_button.Text = "";
                    C_button.Text = "";
                    D_button.Text = "";
                    answer_label.Text = "";
                    next_Btn.Enabled = false;
                    isShowingAnswer = false;
                    questionNo = 0;
                }
                else
                {
                    DateTime TimeStamp = DateTime.UtcNow;

                    //create the Query and exectue, this is for insert the player's score to database
                    string INSERT = "INSERT INTO userTable (Name, Score, TimeStamp) VALUES('" + playerName + "','" + score + "','" + TimeStamp + "')";
                    sqlConn.executeCmd(INSERT);

                    //hide the gamebox, and get Leaderboard ready.
                    groupBox1.Hide();
                    SetUpLeaderboard();
                    summary_Label.Text = "Hi, " + playerName + ". Your score is: " + score;

                    //reset those data for play again
                    questionNo = 0;
                    score = 0;
                    countDown = 0;
                    correctAnswer = 0;
                    name_TextBox.ReadOnly = false;

                    //Leaderboard up.
                    groupBox2.Show();
                }
            }
        }

        /*
        *FUNCTION	    : next_Btn_Click
        *DESCRIPTION	: the Next for start button clicked
        *PARAMETERS	    :
        *	none.
        *RETURNS	    :
        *	nothing.
        */
        private void next_Btn_Click(object sender, EventArgs e)
        {
            if (isShowingAnswer)
            {
                Play();
            }
            else
            {
                bool isCorrect = false;
                //stop the timer
                timer.Stop();

                //marking
                if (A_button.Checked && correctAnswer == 1)
                {
                    isCorrect = true;
                }
                else if (B_button.Checked && correctAnswer == 2)
                {
                    isCorrect = true;
                }
                else if (C_button.Checked && correctAnswer == 3)
                {
                    isCorrect = true;
                }
                else if (D_button.Checked && correctAnswer == 4)
                {
                    isCorrect = true;
                }

                if (isCorrect)
                {
                    if (!(countDown <= 0))
                    {
                        score = score + countDown + 1;
                    }
                }

                //reset the buttons
                A_button.Checked = false;
                B_button.Checked = false;
                C_button.Checked = false;
                D_button.Checked = false;

                //next question
                Play();
            }
        }

        /*
        *FUNCTION	    : SetUpLeaderboard
        *DESCRIPTION	: this function will load the Leaderboard from sql database
        *PARAMETERS	    :
        *	none.
        *RETURNS	    :
        *	nothing.
        */
        void SetUpLeaderboard()
        {
            //clean up the listView first
            listView1.Clear();

            //adding columns
            listView1.Columns.Add("No.", 120);
            listView1.Columns.Add("Time", 120);
            listView1.Columns.Add("Name", 120);
            listView1.Columns.Add("Score", 120);
            listView1.View = System.Windows.Forms.View.Details;

            //create the SELECT Query
            string SELECT = "SELECT * FROM userTable ORDER BY score DESC LIMIT 10";
            List<string> LeaderboardList = sqlConn.executeCmd(SELECT);

            //load the datas to rows
            int No = 0;
            for (int i = 0; i < (LeaderboardList.Count/3);i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = (i + 1).ToString();//no.
                //the time in database is UTC time, we need to convert to local time.
                string date = DateTime.Parse(LeaderboardList[No + 2]).ToLocalTime().ToString();
                lvi.SubItems.Add(date);//time
                lvi.SubItems.Add(LeaderboardList[No]);//name
                lvi.SubItems.Add(LeaderboardList[No + 1]);//score
                listView1.Items.Add(lvi);
                No = No + 3;
            }
        }

        /*
        *FUNCTION	    : SetTimer
        *DESCRIPTION	: this function will set the timer
        *PARAMETERS	    :
        *	none.
        *RETURNS	    :
        *	nothing.
        */
        void SetTimer()
        {
            timer = new System.Timers.Timer(1000);
            timer.AutoReset = true;
            timer.Enabled = true;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(counting);
        }

        /*
        *FUNCTION	    : counting
        *DESCRIPTION	: this function will be called every second by timer
        *PARAMETERS	    :
        *	none.
        *RETURNS	    :
        *	nothing.
        */
        void counting(object sender,System.Timers.ElapsedEventArgs e)
        {
            countDown--;
            this.Invoke(new SetControlValue(setCountLable), countDown.ToString());
        }

        /*
        *FUNCTION	    : setCountLable
        *DESCRIPTION	: this function will be called every second by counting
        *PARAMETERS	    :
        *	none.
        *RETURNS	    :
        *	nothing.
        */
        void setCountLable(string newValue)
        {
            //set the countLable
            countDown_Lable.Text = "Count Down: " + newValue;
            //if countdown reach 0, go next question
            if (countDown == 0)
            {
                next_Btn_Click(null, null);
            }
        }

        private void showAnswer_Btn_Click(object sender, EventArgs e)
        {
            groupBox2.Hide();
            groupBox1.Show();
            isShowingAnswer = true;
            
            Play();
        }
    }
}
