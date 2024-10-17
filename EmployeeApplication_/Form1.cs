namespace EmployeeApplication_
{
    public partial class frmComputeSalary : Form
    {
        Parttime Employee;
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public interface IEmployee
        {
            string fname { get; set; }
            string lname { get; set; }
            string dept { get; set; }
            string title { get; set; }
            double basicsal { get; set; }

            void compute(int hoursworked, double rateper);
        }

        public class Parttime : IEmployee
        {
            public string fname { get; set; }
            public string lname { get; set; }
            public string dept { get; set; }
            public string title { get; set; }
            public double basicsal { get; set; }

            public Parttime(string fn, string ln, string dt, string tj)
            {
                fname = fn;
                lname = ln;
                dept = dt;
                title = tj;
                basicsal = 0.0;
            }

            public void compute(int hoursworked, double rateper)
            {
                basicsal = hoursworked * rateper;
            }

            public double getSalary()
            {
                return basicsal;
            }
        }

        private void txt_firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void butt_compute_Click(object sender, EventArgs e)
        {
            string firstname = txt_firstname.Text;
            string lastname = txt_lastname.Text;
            string department = txt_department.Text;
            string jtitle = txt_jobtitle.Text;
            double rph = double.Parse(txt_rateperhour.Text);
            int thw = int.Parse(txt_totalhoursworked.Text);

            Employee = new Parttime(firstname, lastname, department, jtitle);

            Employee.compute(thw, rph);

            lbl_firstname.Text = Employee.fname;
            lbl_lastname.Text = Employee.lname;
            lbl_basicsalary.Text = Employee.getSalary().ToString();

        }
    }
}