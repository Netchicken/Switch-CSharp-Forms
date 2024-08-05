namespace Switch_CSharp_Forms
{
    public partial class Form1 : Form
    {
        string selectedDay = "";
        List<string> myWeek = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnLoadDOW_Click(object sender, EventArgs e)
        {
            myWeek =
            [
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
                "Any Day",
            ];

            lbxDayOfWeek.Items.AddRange(myWeek.ToArray());
        }

        private void lbxDayOfWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDay = lbxDayOfWeek.SelectedItem.ToString();
            Text = selectedDay;
            //is the apointment already made on that day?
            //do the items in lbxappointment contain "Meeting on " + selectedDay?
            bool isNotInListBox = !lbxAppointment.Items.Contains("Meeting on " + selectedDay);



            switch (selectedDay)
            {
                case "Any Day":
                case "Monday":
                    if (isNotInListBox || selectedDay == "Any Day")
                    {
                        lbxAppointment.Items.Add("Meeting on Monday");
                    }
                    break;
                case "Tuesday":
                    if (isNotInListBox)
                    {
                        lbxAppointment.Items.Add("Meeting on Tuesday");
                    }
                    break;
                case "Wednesday":
                    if (isNotInListBox)
                    {
                        lbxAppointment.Items.Add("Meeting on Wednesday");
                    }
                    break;
                case "Thursday":
                    if (isNotInListBox)
                    {
                        lbxAppointment.Items.Add("Meeting on Thursday");
                    }
                    break;
                case "Friday":
                    if (isNotInListBox)
                    {
                        lbxAppointment.Items.Add("Meeting on Friday");
                    }
                    break;
                case "Saturday":

                case "Sunday":
                    if (!lbxAppointment.Items.Contains("No Weekend booking"))
                    {
                        lbxAppointment.Items.Add("No Weekend booking");
                    }
                    break;
            }
            //switch (selectedDay)
            //{
            //    case "Any Day":
            //    case "Monday":
            //        lbxAppointment.Items.Add("Meeting on Monday");
            //        break;
            //    case "Tuesday":
            //        lbxAppointment.Items.Add("Meeting on Tuesday");
            //        break;
            //    case "Wednesday":
            //        lbxAppointment.Items.Add("Meeting on Wednesday");
            //        break;
            //    case "Thursday":
            //        lbxAppointment.Items.Add("Meeting on Thursday");
            //        break;
            //    case "Friday":
            //        lbxAppointment.Items.Add("Meeting on Friday");
            //        break;
            //    case "Saturday":
            //    case "Sunday":
            //        lbxAppointment.Items.Add("No Weekend booking");
            //        break;
            //}

        }

        private void btnStringOp_Click(object sender, EventArgs e)
        {
            string name1 = "john";
            string name2 = "john";

            string charName1 = "";
            int countName1 = 0;
            string charName2 = "";
            int countName2 = 0;

            foreach (char c in name1)
            {
                countName1 += c;
                charName1 += (int)c + " ";
            }
            foreach (char c in name2)
            {
                countName2 += c;
                charName2 += (int)c + " ";
            }


            if (string.Compare(name1, name2) < 0)
            {
                lbxStringOp.Items.Add("string.Compare(name1, name2) < 0");

            }
            else if (string.Compare(name1, name2) == 0)
            {
                lbxStringOp.Items.Add("string.Compare(name1, name2) = 0");
            }
            else if (string.Compare(name1, name2) > 0)
            {
                lbxStringOp.Items.Add("string.Compare(name1, name2) > 0");

            }
            lbxStringOp.Items.Add(name1 + " " + charName1 + " name1 total " + countName1);
            lbxStringOp.Items.Add(name1 + " " + charName2 + " name2 total " + countName2);



        }
    }
}
