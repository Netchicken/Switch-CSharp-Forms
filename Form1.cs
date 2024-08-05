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
        }
    }
}
