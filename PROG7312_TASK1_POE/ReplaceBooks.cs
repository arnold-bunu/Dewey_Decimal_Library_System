using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312_TASK1_POE
{
    public partial class ReplaceBooks : Form

    {
        public int subjectNo;
        public int subSubjectNo;
        public string authorInitials;
        public List<String> callNum = new List<String>();
        public List<String> sortedCallNum = new List<String>();
        public Random rand = new Random();
        public String finalDewey;
      


        public ReplaceBooks()
        {
            InitializeComponent();
            star1.Visible = false;
            star2.Visible = false;
            star3.Visible = false;
            star4.Visible = false;
            star5.Visible = false;
            lbxCorrect.Visible = false;
            starCount.Visible = false;
            lblshowScore.Visible = false;
        }

        
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        //*********************************************************DOWN BUTTON METHOD - USED TO MOVE CALL NUMBERS DOWN****************************************************************************************************
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (lbxRanGenCallNum.SelectedIndex == -1)
            {
                MessageBox.Show("No call number has been selected, please select one to move", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // ERROR MESSAGE TO BE SHOWN IF NOTHING IS SELECTED 
            }
            else
            {
                int newIndex = lbxRanGenCallNum.SelectedIndex +1;

                if (newIndex >= lbxRanGenCallNum.Items.Count)
                    return;
                object selectedItem = lbxRanGenCallNum.SelectedItem; 

                lbxRanGenCallNum.Items.Remove(selectedItem);
                lbxRanGenCallNum.Items.Insert(newIndex, selectedItem);
                lbxRanGenCallNum.SetSelected(newIndex, true);
            }
        }
        //*************************************************************************************************************************************************************

        private void lbxRanGenCallNum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //*********************************************************GENERATE CALL NUMBER METHOD - USED TO RANDOMLY GENERATE 10 CALL NUMBERS****************************************************************************************************
        private void generateCallNumber()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var stringChars = new char[3];
            var random = new Random();

            for (int i = 0; i < 10; i++)
            {
                subjectNo = rand.Next(100, 999);   // GENERATES 3 RANDOM DIGITS 
                subSubjectNo = rand.Next(10, 99); // GENERATES 2 RANDOM DIGITS

                for (int k = 0; k < 3; k++)
                {
                    stringChars[k] = chars[random.Next(chars.Length)];  //GENERATES 3 RANDOM LETTERS

                }
                var myRandomUpperCase = new String(stringChars);
                finalDewey = subjectNo + "." + subSubjectNo + "  " + myRandomUpperCase;  // CONCATENATING MY DEWY DECIMAL 
                callNum.Add(finalDewey);        // ADDING CALL NUMBERS TO A LIST
                

            }
        }
        //*********************************************************BUTTON TO GENERATE CALL NUMBERS****************************************************************************************************

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            lbxRanGenCallNum.Items.Clear();
            for (int b = 0; b < 10; b++)
            {
                generateCallNumber();
                
                lbxRanGenCallNum.Items.Add(callNum[b]); // ADDS CALL NUMBERS TO THE LISTBOX
            }
           
            
        }
        //*********************************************************QUICK SORT METHOD USED TO SORT THE LIST****************************************************************************************************
        //
        public void sortCall(List<String> arr, int left, int right) 
        {
            int pivot;   
            if (left < right)
            {
                 pivot = Partition (arr, left, right);

                if (pivot > 1)
                {
                    sortCall(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    sortCall(arr, pivot + 1, right);
                }
            }
        }

        public int Partition(List<String> arr, int start, int end)
        {
            int pivot = end;
            int i = start, j = end;
            string temp;
            while (i < j)
            {
                while (i < end && string.Compare(arr[i], arr[pivot]) < 0)
                    i++;
                while (j > start && string.Compare(arr[j], arr[pivot]) > 0)
                    j--;

                if (i < j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            temp = arr[pivot];
            arr[pivot] = arr[j];
            arr[j] = temp;
            return j;
        }
        //*********************************************************DONE BUTTON METHOD - USED ONCE FINSIHED PLACING ITEMS IN ORDER****************************************************************************************************
        private void btnDone_Click(object sender, EventArgs e)
        {
            try
            {
                lbxCorrect.Visible = true;
                int points = 0;
                btnGenerate.Visible = false;

                sortCall(callNum, 0, 9);   // SORTING THE CALL NUMBERS 
                lbxCorrect.Items.Clear();

                for (int i = 0; i < 10; i++)
                {
                    lbxCorrect.Items.Add(callNum[i]).ToString();  // ADDING THE CORRECT CALL NUMBERS TO A LIST BOX
                }
                for (int j = 0; j < 10; j++)
                {
                    if (lbxRanGenCallNum.Items[j].ToString() == lbxCorrect.Items[j].ToString())   // COMPARES THE TWO LIST BOXES 
                    {
                        points++;
                    }
                    String showScore = "you got " + points + " correct!";
                    lblshowScore.Text = showScore;
                    lblshowScore.Visible = true;
                }
                // THE NEXT NESTED IF OUPUTS USER SCORES AND STARS 
                if (points > 0 && points <= 2)
                {
                    starCount.Visible = true;
                    String oneStar = "You scored 1 out of 5 stars, keep pushing!";
                    star1.Visible = true;
                    starCount.Text = oneStar;
                }
                else if (points > 2 && points <= 4)
                {
                    starCount.Visible = true;
                    String twoStar = "You scored 2 out of 5 stars, keep pushing!";
                    star1.Visible = true;
                    star2.Visible = true;
                    starCount.Text = twoStar;
                }
                else if (points > 4 && points <= 6)
                {
                    starCount.Visible = true;
                    String threeStar = "You scored 3 out of 5 stars, getting there!";
                    star1.Visible = true;
                    star2.Visible = true;
                    star3.Visible = true;
                    starCount.Text = threeStar;
                }
                else if (points > 6 && points <= 8)
                {
                    starCount.Visible = true;
                    String fourStar = "You scored 4 out of 5 stars, almost perfect!";
                    star1.Visible = true;
                    star2.Visible = true;
                    star3.Visible = true;
                    star4.Visible = true;
                    starCount.Text = fourStar;
                }
                else if (points > 8 && points <= 10)
                {
                    starCount.Visible = true;
                    String fiveStar = "You scored 5 out of 5 stars, well done!";
                    star1.Visible = true;
                    star2.Visible = true;
                    star3.Visible = true;
                    star4.Visible = true;
                    star5.Visible = true;
                    starCount.Text = fiveStar;
                }
            }

            catch
            {
                MessageBox.Show("Please generate some call numbers first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // EXCEPTION CATCHING
            }
        }

        //*************************************************************************************************************************************************************
        private void ReplaceBooks_Load(object sender, EventArgs e)
        {


        }
        //*********************************************************UP BUTTON METHOD - USED USED TO MOVE LIST BOXES UP****************************************************************************************************

        private void pbUpbtn_Click(object sender, EventArgs e)
        {
        if (lbxRanGenCallNum.SelectedIndex == -1 )
            {
                MessageBox.Show("No call number has been selected, please select one to move", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // ERROR MESSAGE TO BE SHOWN IF NO CALL NUMBER IS GENERATED
            }
        else
            {
                int newIndex = lbxRanGenCallNum.SelectedIndex - 1;
                
                if (newIndex < 0 )
                    return;
                object selectedItem = lbxRanGenCallNum.SelectedItem;

                lbxRanGenCallNum.Items.Remove(selectedItem);
                lbxRanGenCallNum.Items.Insert(newIndex, selectedItem);
                lbxRanGenCallNum.SetSelected(newIndex, true);
            }
        }
        //*********************************************************TRY AGAIN METHOD - USED TO CLEAR ENTRY AND GENERATE A NEW LIST****************************************************************************************************

        private void btnTryAgain_Click(object sender, EventArgs e)
        {
            this.Refresh();
            lbxRanGenCallNum.Items.Clear();
            lbxCorrect.Items.Clear();
            callNum.Clear();
            star1.Visible = false;
            star2.Visible = false;
            star3.Visible = false;
            star4.Visible = false;
            star5.Visible = false;
            lbxCorrect.Visible = false;
            starCount.Visible = false;
            lblshowScore.Visible = false;
            




            for (int b = 0; b < 10; b++)
            {
                generateCallNumber();
                lbxRanGenCallNum.Items.Add(callNum[b]);
            }
        }
        //*********************************************************RETURN HOME****************************************************************************************************
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LandingPage landingPage = new LandingPage();
            landingPage.Show();
            this.Hide();
        }
    }
    }


