namespace Switch_CSharp_Forms
{
    public partial class Form1 : Form
    {
        string selectedDay = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRunSwitch_Click(object sender, EventArgs e)
        {



        }

        private void btnLoadDOW_Click(object sender, EventArgs e)
        {
            List<string> myWeek = new List<string>();
            myWeek.Add("Monday");
            myWeek.Add("Tuesday");
            myWeek.Add("Wednesday");
            myWeek.Add("Thursday");
            myWeek.Add("Friday");
            myWeek.Add("Saturday");
            myWeek.Add("Sunday");

            lbxDayOfWeek.Items.AddRange(myWeek.ToArray());
        }

        private void lbxDayOfWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDay = lbxDayOfWeek.SelectedItem.ToString();
            Text = selectedDay;

            switch (selectedDay)
            {
                case "Monday":

                    if (!lbxAppointment.Items.Contains("Monday"))
                    {
                        lbxAppointment.Items.Add("Meeting on Monday");
                    }

                    break;
                case "Tuesday":
                    if (!lbxAppointment.Items.Contains("Tuesday"))
                    {
                        lbxAppointment.Items.Add("Meeting on Tuesday");
                    }
                    break;
                case "Wednesday":
                    if (!lbxAppointment.Items.Contains("Wednesday"))
                    {
                        lbxAppointment.Items.Add("Meeting on Wednesday");
                    }
                    break;
                case "Thursday":
                    if (!lbxAppointment.Items.Contains("Thursday"))
                    {
                        lbxAppointment.Items.Add("Meeting on Thursday");
                    }
                    break;
                case "Friday":
                    if (!lbxAppointment.Items.Contains("Friday"))
                    {
                        lbxAppointment.Items.Add("Meeting on Friday");
                    }
                    break;
                case "Saturday":
                    if (!lbxAppointment.Items.Contains("Saturday"))
                    {
                        lbxAppointment.Items.Add("Meeting on Saturday");
                    }
                    break;
                case "Sunday":
                    if (!lbxAppointment.Items.Contains("Sunday"))
                    {
                        lbxAppointment.Items.Add("Meeting on Sunday");
                    }
                    break;

            }





        }
    }
}
