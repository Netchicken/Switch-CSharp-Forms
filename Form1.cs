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
            ];

            lbxDayOfWeek.Items.AddRange(myWeek.ToArray());
        }

        private void lbxDayOfWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDay = lbxDayOfWeek.SelectedItem.ToString();
            Text = selectedDay;

            switch (selectedDay)
            {
                case "Monday":

                    if (!lbxAppointment.Items.Contains("Meeting on Monday"))
                    {
                        lbxAppointment.Items.Add("Meeting on Monday");
                    }
                    break;
                case "Tuesday":
                    if (!lbxAppointment.Items.Contains("Meeting on Tuesday"))
                    {
                        lbxAppointment.Items.Add("Meeting on Tuesday");
                    }
                    break;
                case "Wednesday":
                    if (!lbxAppointment.Items.Contains("Meeting on Wednesday"))
                    {
                        lbxAppointment.Items.Add("Meeting on Wednesday");
                    }
                    break;
                case "Thursday":
                    if (!lbxAppointment.Items.Contains("Meeting on Thursday"))
                    {
                        lbxAppointment.Items.Add("Meeting on Thursday");
                    }
                    break;
                case "Friday":
                    if (!lbxAppointment.Items.Contains("Meeting on Friday"))
                    {
                        lbxAppointment.Items.Add("Meeting on Friday");
                    }
                    break;
                case "Saturday":
                    if (!lbxAppointment.Items.Contains("Meeting on Saturday"))
                    {
                        lbxAppointment.Items.Add("Meeting on Saturday");
                    }
                    break;
                case "Sunday":
                    if (!lbxAppointment.Items.Contains("Meeting on Sunday"))
                    {
                        lbxAppointment.Items.Add("Meeting on Sunday");
                    }
                    break;

            }
        }
    }
}
