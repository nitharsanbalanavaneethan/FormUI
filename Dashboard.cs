namespace FormUI
{
    public partial class Dashboard : Form
    {
        List<Person> people = new List<Person>();
        public Dashboard()
        {
            InitializeComponent();

            updateBinding();



        }
        private void updateBinding()
        {

            PeopleFoundListBox.DataSource = people;
            PeopleFoundListBox.DisplayMember = "FullInfo";

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            people =  db.GetPeople(NameText.Text);

            updateBinding();

        }

        private void InsertRecord_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.InsertPersion(FirstNameText.Text, LastNameText.Text, EmailAddressText.Text, PhoneNumberText.Text);

            FirstNameText.Text = "";
            LastNameText.Text = "";
            EmailAddressText.Text = "";
            PhoneNumberText.Text = "";

        }
    }
}