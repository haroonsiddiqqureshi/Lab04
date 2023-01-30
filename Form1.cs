namespace LAB04
{
    public partial class Form1 : Form
    {
        private Classroom classroom;
        public Form1()
        {
            InitializeComponent();
            classroom = new Classroom();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.tbName.Text;
            int year = int.Parse(this.tbBirthYear.Text);
            double grade = double.Parse(this.tbGrade.Text);

            Person persons = new Person(name, year, grade);
            this.classroom.AddPerson(persons);

            labelPersonList.Text = this.classroom.ShowPerson();
            totalAge.Text = this.classroom.ShowAllAge().ToString();
            this.classroom.SetGrade();
            this.labelGradeMax.Text = this.classroom.ShowMaxGrade().ToString();
            this.labelGradeMin.Text = this.classroom.ShowMinGrade().ToString();
            this.labelNameMaxGrade.Text = this.classroom.ShowNameMaxGrade();
            this.labelNameMinGrade.Text = this.classroom.ShowNameMinGrade();
            this.labelGradeAvg.Text = this.classroom.ShowAvgnGrade();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbGrade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}