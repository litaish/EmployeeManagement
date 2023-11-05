using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace EmployeeManagement
{
    public partial class Form1 : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public bool wasSaveClicked = false;
        public Company company;
        public BindingList<Project> projects;
        public BindingList<Task> tasks;
        public Form1()
        {
            InitializeComponent();

            projects = Deserialize<BindingList<Project>>("data.txt"); // On init deserialized to projects BindingList

            //this.dataGridView.Columns["Wheel"].Tag = "WheelName"; // Use this with override string toString() to display cell as object property

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Amber700, MaterialSkin.TextShade.WHITE);

            if (projects == null)
            {
                company = new Company();
                company.Name = "My Company";

                company.Employees = new BindingList<Employee>();

                tasks = new BindingList<Task>();
            }
            else
            {
                company = projects[0].Company;

                company.Employees = projects[0].Company.Employees;

                tasks = new BindingList<Task>();

                foreach (var proj in projects)
                {
                    foreach (var task in proj.Tasks)
                    {
                        tasks.Add(task);
                    }
                }
            }

            var sourceTasks = new BindingSource(tasks, null);
            dataGridView_projects.DataSource = sourceTasks;
            dataGridView_allTasks.DataSource = sourceTasks;
            materialComboBox_taskName.DataSource = sourceTasks;

            var sourceProjects = new BindingSource(projects, null);
            dataGridView_projects.DataSource = sourceProjects;
            materialComboBox_projectName.DataSource = sourceProjects;

            var sourceEmployees = new BindingSource(company.Employees, null);  // Company Employees list gets binded to datagridview
            dataGridView_employees.DataSource = sourceEmployees;
            materialComboBox_employee.DataSource = sourceEmployees;
        }

        private void materialButton_addEmployee_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Name = materialTextBox_employeeName.Text;
            emp.Surname = materialTextBox_employeeSurname.Text;
            emp.Phone = materialTextBox_employeePhone.Text;
            emp.Address = materialTextBox_employeeAddress.Text;

            company.Employees.Add(emp);
        }

        private void materialButton_changeCompanyName_Click(object sender, EventArgs e)
        {
            company.Name = materialTextBox_companyName.Text;
        }

        private void materialButton_addProject_Click(object sender, EventArgs e)
        {
            Project proj = new Project();
            proj.Name = materialTextBox_projectName.Text;
            proj.Start = dateTimePicker_projectStart.Value;
            proj.End = dateTimePicker_projectEnd.Value;
            proj.Company = company;
            projects.Add(proj);
        }

        private void dataGridView_projects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Project selectedProject = (Project)dataGridView_projects.Rows[dataGridView_projects.CurrentCell.RowIndex].DataBoundItem;

            if (selectedProject == null) return;

            if (selectedProject.Tasks != null)
            {
                var sourceTasks = new BindingSource(selectedProject.Tasks, null);
                dataGridView_tasksForProject.DataSource = sourceTasks;
            } else
            {
                dataGridView_tasksForProject.DataSource = null;
            }
        }

        private void materialButton_addTask_Click(object sender, EventArgs e)
        {
            Project selectedProject = (Project)materialComboBox_projectName.SelectedItem;

            Task task = new Task();
            task.Name = materialTextBox_taskName.Text;
            task.Description = materialMultiLineTextBox_taskDescription.Text;
            task.EstimatedTime = (int)numericUpDown_estimatedTime.Value;

            if (selectedProject.Tasks == null)
            {
                selectedProject.Tasks = new BindingList<Task>(); // Initialize a new task list for each project
            }
            tasks.Add(task); // Add task to all tasks to display it in All Tasks dgv
            selectedProject.Tasks.Add(task);
        }

        private void materialButton_assignEmployee_Click(object sender, EventArgs e)
        {
            Task selectedTask = (Task)materialComboBox_taskName.SelectedItem;

            TaskTime taskTime = new TaskTime();
            taskTime.Employee = (Employee)materialComboBox_employee.SelectedItem;

            try // Checking if tasktime format is correct
            {
                taskTime.Time = TimeSpan.Parse(materialTextBox_taskTimeToSpend.Text); // Parse __:__ format text into TimeSpan object


                if (selectedTask.TaskTimes == null)
                {
                    selectedTask.TaskTimes = new BindingList<TaskTime>();
                }

                selectedTask.TaskTimes.Add(taskTime);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid format for timespan - __:__");
            }
            
        }

        private void dataGridView_allTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Task selectedTask = (Task)dataGridView_allTasks.Rows[dataGridView_allTasks.CurrentCell.RowIndex].DataBoundItem;

            if (selectedTask == null) return;

            if (selectedTask.TaskTimes != null)
            {
                var sourceTaskTimes = new BindingSource(selectedTask.TaskTimes, null);
                dataGridView_taskTimesForTask.DataSource = sourceTaskTimes;
            }
            else
            {
                dataGridView_taskTimesForTask.DataSource = null;
            }
        }

        private void materialButton_saveData_Click(object sender, EventArgs e)
        {
            wasSaveClicked = true;
            Serialize<BindingList<Project>>("data.txt", projects);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (wasSaveClicked == true) return; // Check if the save button was already clicked, then leave

            if (e.CloseReason == CloseReason.UserClosing || e.CloseReason == CloseReason.WindowsShutDown)
            {
                DialogResult dialogResult = MessageBox.Show("Would you like to save your changes?", "Save?", MessageBoxButtons.YesNo); // Prompt user to save his data

                if (dialogResult == DialogResult.Yes)
                {
                    Serialize<BindingList<Project>>("data.txt", projects);
                } 
                else if (dialogResult == DialogResult.No) {
                    Application.Exit();
                }
            }
        }
        public static void Serialize<T>(string file, object root) // Add generic type as parameter
        {
            Stream stm = new FileStream(file, FileMode.Create);
            XmlSerializer fmt = new XmlSerializer(typeof(T));
            fmt.Serialize(stm, root);
            stm.Flush();
            stm.Close();
        }
        public static T Deserialize<T>(string file) // Add generic type as parameter
        {
            Stream stm = new FileStream(file, FileMode.Open);
            XmlSerializer fmt = new XmlSerializer(typeof(T));
            T obj = (T)fmt.Deserialize(stm);
            stm.Close();
            return obj;
        }
    }
}
