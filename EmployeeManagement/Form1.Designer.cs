namespace EmployeeManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage_editEmployees = new System.Windows.Forms.TabPage();
            this.materialButton_changeCompanyName = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox_companyName = new MaterialSkin.Controls.MaterialTextBox2();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_employees = new System.Windows.Forms.DataGridView();
            this.materialButton_addEmployee = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox_employeeAddress = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBox_employeePhone = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBox_employeeSurname = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBox_employeeName = new MaterialSkin.Controls.MaterialTextBox2();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl_projectInfo = new System.Windows.Forms.TabControl();
            this.tabPage_projectInfo = new System.Windows.Forms.TabPage();
            this.dataGridView_projects = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView_tasksForProject = new System.Windows.Forms.DataGridView();
            this.label_projectName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.materialButton_addProject = new MaterialSkin.Controls.MaterialButton();
            this.dateTimePicker_projectEnd = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker_projectStart = new System.Windows.Forms.DateTimePicker();
            this.materialTextBox_projectName = new MaterialSkin.Controls.MaterialTextBox2();
            this.label3 = new System.Windows.Forms.Label();
            this.tab_createTasks = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.numericUpDown_estimatedTime = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridView_allTasks = new System.Windows.Forms.DataGridView();
            this.dataGridView_taskTimesForTask = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.materialButton_addTask = new MaterialSkin.Controls.MaterialButton();
            this.materialMultiLineTextBox_taskDescription = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialTextBox_taskName = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialComboBox_projectName = new MaterialSkin.Controls.MaterialComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage_assignEmployees = new System.Windows.Forms.TabPage();
            this.materialButton_assignEmployee = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox_taskTimeToSpend = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialComboBox_employee = new MaterialSkin.Controls.MaterialComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.materialComboBox_taskName = new MaterialSkin.Controls.MaterialComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage_save = new System.Windows.Forms.TabPage();
            this.materialButton_saveData = new MaterialSkin.Controls.MaterialButton();
            this.label17 = new System.Windows.Forms.Label();
            this.tabPage_editEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employees)).BeginInit();
            this.tabControl_projectInfo.SuspendLayout();
            this.tabPage_projectInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_projects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tasksForProject)).BeginInit();
            this.tab_createTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_estimatedTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_allTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_taskTimesForTask)).BeginInit();
            this.tabPage_assignEmployees.SuspendLayout();
            this.tabPage_save.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage_editEmployees
            // 
            this.tabPage_editEmployees.Controls.Add(this.materialButton_changeCompanyName);
            this.tabPage_editEmployees.Controls.Add(this.materialTextBox_companyName);
            this.tabPage_editEmployees.Controls.Add(this.label4);
            this.tabPage_editEmployees.Controls.Add(this.label2);
            this.tabPage_editEmployees.Controls.Add(this.dataGridView_employees);
            this.tabPage_editEmployees.Controls.Add(this.materialButton_addEmployee);
            this.tabPage_editEmployees.Controls.Add(this.materialTextBox_employeeAddress);
            this.tabPage_editEmployees.Controls.Add(this.materialTextBox_employeePhone);
            this.tabPage_editEmployees.Controls.Add(this.materialTextBox_employeeSurname);
            this.tabPage_editEmployees.Controls.Add(this.materialTextBox_employeeName);
            this.tabPage_editEmployees.Controls.Add(this.label1);
            this.tabPage_editEmployees.Location = new System.Drawing.Point(4, 24);
            this.tabPage_editEmployees.Name = "tabPage_editEmployees";
            this.tabPage_editEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_editEmployees.Size = new System.Drawing.Size(786, 740);
            this.tabPage_editEmployees.TabIndex = 1;
            this.tabPage_editEmployees.Text = "Edit Employees";
            this.tabPage_editEmployees.UseVisualStyleBackColor = true;
            // 
            // materialButton_changeCompanyName
            // 
            this.materialButton_changeCompanyName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_changeCompanyName.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton_changeCompanyName.Depth = 0;
            this.materialButton_changeCompanyName.HighEmphasis = true;
            this.materialButton_changeCompanyName.Icon = null;
            this.materialButton_changeCompanyName.Location = new System.Drawing.Point(6, 131);
            this.materialButton_changeCompanyName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_changeCompanyName.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_changeCompanyName.Name = "materialButton_changeCompanyName";
            this.materialButton_changeCompanyName.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton_changeCompanyName.Size = new System.Drawing.Size(80, 36);
            this.materialButton_changeCompanyName.TabIndex = 10;
            this.materialButton_changeCompanyName.Text = "Change";
            this.materialButton_changeCompanyName.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_changeCompanyName.UseAccentColor = false;
            this.materialButton_changeCompanyName.UseVisualStyleBackColor = true;
            this.materialButton_changeCompanyName.Click += new System.EventHandler(this.materialButton_changeCompanyName_Click);
            // 
            // materialTextBox_companyName
            // 
            this.materialTextBox_companyName.AnimateReadOnly = false;
            this.materialTextBox_companyName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox_companyName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox_companyName.Depth = 0;
            this.materialTextBox_companyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox_companyName.HideSelection = true;
            this.materialTextBox_companyName.LeadingIcon = null;
            this.materialTextBox_companyName.Location = new System.Drawing.Point(6, 60);
            this.materialTextBox_companyName.MaxLength = 32767;
            this.materialTextBox_companyName.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_companyName.Name = "materialTextBox_companyName";
            this.materialTextBox_companyName.PasswordChar = '\0';
            this.materialTextBox_companyName.PrefixSuffixText = null;
            this.materialTextBox_companyName.ReadOnly = false;
            this.materialTextBox_companyName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox_companyName.SelectedText = "";
            this.materialTextBox_companyName.SelectionLength = 0;
            this.materialTextBox_companyName.SelectionStart = 0;
            this.materialTextBox_companyName.ShortcutsEnabled = true;
            this.materialTextBox_companyName.Size = new System.Drawing.Size(250, 48);
            this.materialTextBox_companyName.TabIndex = 9;
            this.materialTextBox_companyName.TabStop = false;
            this.materialTextBox_companyName.Text = "Company Name";
            this.materialTextBox_companyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox_companyName.TrailingIcon = null;
            this.materialTextBox_companyName.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Change Company Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "All Company Employees";
            // 
            // dataGridView_employees
            // 
            this.dataGridView_employees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_employees.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_employees.Location = new System.Drawing.Point(3, 484);
            this.dataGridView_employees.Name = "dataGridView_employees";
            this.dataGridView_employees.RowTemplate.Height = 25;
            this.dataGridView_employees.Size = new System.Drawing.Size(780, 253);
            this.dataGridView_employees.TabIndex = 6;
            // 
            // materialButton_addEmployee
            // 
            this.materialButton_addEmployee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_addEmployee.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton_addEmployee.Depth = 0;
            this.materialButton_addEmployee.HighEmphasis = true;
            this.materialButton_addEmployee.Icon = null;
            this.materialButton_addEmployee.Location = new System.Drawing.Point(7, 369);
            this.materialButton_addEmployee.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_addEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_addEmployee.Name = "materialButton_addEmployee";
            this.materialButton_addEmployee.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton_addEmployee.Size = new System.Drawing.Size(129, 36);
            this.materialButton_addEmployee.TabIndex = 5;
            this.materialButton_addEmployee.Text = "Add Employee";
            this.materialButton_addEmployee.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_addEmployee.UseAccentColor = false;
            this.materialButton_addEmployee.UseVisualStyleBackColor = true;
            this.materialButton_addEmployee.Click += new System.EventHandler(this.materialButton_addEmployee_Click);
            // 
            // materialTextBox_employeeAddress
            // 
            this.materialTextBox_employeeAddress.AnimateReadOnly = false;
            this.materialTextBox_employeeAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox_employeeAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox_employeeAddress.Depth = 0;
            this.materialTextBox_employeeAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox_employeeAddress.HideSelection = true;
            this.materialTextBox_employeeAddress.LeadingIcon = null;
            this.materialTextBox_employeeAddress.Location = new System.Drawing.Point(321, 299);
            this.materialTextBox_employeeAddress.MaxLength = 32767;
            this.materialTextBox_employeeAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_employeeAddress.Name = "materialTextBox_employeeAddress";
            this.materialTextBox_employeeAddress.PasswordChar = '\0';
            this.materialTextBox_employeeAddress.PrefixSuffixText = null;
            this.materialTextBox_employeeAddress.ReadOnly = false;
            this.materialTextBox_employeeAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox_employeeAddress.SelectedText = "";
            this.materialTextBox_employeeAddress.SelectionLength = 0;
            this.materialTextBox_employeeAddress.SelectionStart = 0;
            this.materialTextBox_employeeAddress.ShortcutsEnabled = true;
            this.materialTextBox_employeeAddress.Size = new System.Drawing.Size(250, 48);
            this.materialTextBox_employeeAddress.TabIndex = 4;
            this.materialTextBox_employeeAddress.TabStop = false;
            this.materialTextBox_employeeAddress.Text = "Address";
            this.materialTextBox_employeeAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox_employeeAddress.TrailingIcon = null;
            this.materialTextBox_employeeAddress.UseSystemPasswordChar = false;
            // 
            // materialTextBox_employeePhone
            // 
            this.materialTextBox_employeePhone.AnimateReadOnly = false;
            this.materialTextBox_employeePhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox_employeePhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox_employeePhone.Depth = 0;
            this.materialTextBox_employeePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox_employeePhone.HideSelection = true;
            this.materialTextBox_employeePhone.LeadingIcon = null;
            this.materialTextBox_employeePhone.Location = new System.Drawing.Point(321, 235);
            this.materialTextBox_employeePhone.MaxLength = 32767;
            this.materialTextBox_employeePhone.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_employeePhone.Name = "materialTextBox_employeePhone";
            this.materialTextBox_employeePhone.PasswordChar = '\0';
            this.materialTextBox_employeePhone.PrefixSuffixText = null;
            this.materialTextBox_employeePhone.ReadOnly = false;
            this.materialTextBox_employeePhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox_employeePhone.SelectedText = "";
            this.materialTextBox_employeePhone.SelectionLength = 0;
            this.materialTextBox_employeePhone.SelectionStart = 0;
            this.materialTextBox_employeePhone.ShortcutsEnabled = true;
            this.materialTextBox_employeePhone.Size = new System.Drawing.Size(250, 48);
            this.materialTextBox_employeePhone.TabIndex = 3;
            this.materialTextBox_employeePhone.TabStop = false;
            this.materialTextBox_employeePhone.Text = "Phone Number";
            this.materialTextBox_employeePhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox_employeePhone.TrailingIcon = null;
            this.materialTextBox_employeePhone.UseSystemPasswordChar = false;
            // 
            // materialTextBox_employeeSurname
            // 
            this.materialTextBox_employeeSurname.AnimateReadOnly = false;
            this.materialTextBox_employeeSurname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox_employeeSurname.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox_employeeSurname.Depth = 0;
            this.materialTextBox_employeeSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox_employeeSurname.HideSelection = true;
            this.materialTextBox_employeeSurname.LeadingIcon = null;
            this.materialTextBox_employeeSurname.Location = new System.Drawing.Point(6, 299);
            this.materialTextBox_employeeSurname.MaxLength = 32767;
            this.materialTextBox_employeeSurname.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_employeeSurname.Name = "materialTextBox_employeeSurname";
            this.materialTextBox_employeeSurname.PasswordChar = '\0';
            this.materialTextBox_employeeSurname.PrefixSuffixText = null;
            this.materialTextBox_employeeSurname.ReadOnly = false;
            this.materialTextBox_employeeSurname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox_employeeSurname.SelectedText = "";
            this.materialTextBox_employeeSurname.SelectionLength = 0;
            this.materialTextBox_employeeSurname.SelectionStart = 0;
            this.materialTextBox_employeeSurname.ShortcutsEnabled = true;
            this.materialTextBox_employeeSurname.Size = new System.Drawing.Size(250, 48);
            this.materialTextBox_employeeSurname.TabIndex = 2;
            this.materialTextBox_employeeSurname.TabStop = false;
            this.materialTextBox_employeeSurname.Text = "Surname";
            this.materialTextBox_employeeSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox_employeeSurname.TrailingIcon = null;
            this.materialTextBox_employeeSurname.UseSystemPasswordChar = false;
            // 
            // materialTextBox_employeeName
            // 
            this.materialTextBox_employeeName.AnimateReadOnly = false;
            this.materialTextBox_employeeName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox_employeeName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox_employeeName.Depth = 0;
            this.materialTextBox_employeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox_employeeName.HideSelection = true;
            this.materialTextBox_employeeName.LeadingIcon = null;
            this.materialTextBox_employeeName.Location = new System.Drawing.Point(6, 235);
            this.materialTextBox_employeeName.MaxLength = 32767;
            this.materialTextBox_employeeName.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_employeeName.Name = "materialTextBox_employeeName";
            this.materialTextBox_employeeName.PasswordChar = '\0';
            this.materialTextBox_employeeName.PrefixSuffixText = null;
            this.materialTextBox_employeeName.ReadOnly = false;
            this.materialTextBox_employeeName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox_employeeName.SelectedText = "";
            this.materialTextBox_employeeName.SelectionLength = 0;
            this.materialTextBox_employeeName.SelectionStart = 0;
            this.materialTextBox_employeeName.ShortcutsEnabled = true;
            this.materialTextBox_employeeName.Size = new System.Drawing.Size(250, 48);
            this.materialTextBox_employeeName.TabIndex = 1;
            this.materialTextBox_employeeName.TabStop = false;
            this.materialTextBox_employeeName.Text = "Name";
            this.materialTextBox_employeeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox_employeeName.TrailingIcon = null;
            this.materialTextBox_employeeName.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add A New Employee";
            // 
            // tabControl_projectInfo
            // 
            this.tabControl_projectInfo.Controls.Add(this.tabPage_editEmployees);
            this.tabControl_projectInfo.Controls.Add(this.tabPage_projectInfo);
            this.tabControl_projectInfo.Controls.Add(this.tab_createTasks);
            this.tabControl_projectInfo.Controls.Add(this.tabPage_assignEmployees);
            this.tabControl_projectInfo.Controls.Add(this.tabPage_save);
            this.tabControl_projectInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_projectInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl_projectInfo.Location = new System.Drawing.Point(3, 64);
            this.tabControl_projectInfo.Name = "tabControl_projectInfo";
            this.tabControl_projectInfo.SelectedIndex = 0;
            this.tabControl_projectInfo.Size = new System.Drawing.Size(794, 768);
            this.tabControl_projectInfo.TabIndex = 0;
            // 
            // tabPage_projectInfo
            // 
            this.tabPage_projectInfo.Controls.Add(this.dataGridView_projects);
            this.tabPage_projectInfo.Controls.Add(this.label9);
            this.tabPage_projectInfo.Controls.Add(this.dataGridView_tasksForProject);
            this.tabPage_projectInfo.Controls.Add(this.label_projectName);
            this.tabPage_projectInfo.Controls.Add(this.label8);
            this.tabPage_projectInfo.Controls.Add(this.materialButton_addProject);
            this.tabPage_projectInfo.Controls.Add(this.dateTimePicker_projectEnd);
            this.tabPage_projectInfo.Controls.Add(this.label6);
            this.tabPage_projectInfo.Controls.Add(this.label5);
            this.tabPage_projectInfo.Controls.Add(this.dateTimePicker_projectStart);
            this.tabPage_projectInfo.Controls.Add(this.materialTextBox_projectName);
            this.tabPage_projectInfo.Controls.Add(this.label3);
            this.tabPage_projectInfo.Location = new System.Drawing.Point(4, 24);
            this.tabPage_projectInfo.Name = "tabPage_projectInfo";
            this.tabPage_projectInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_projectInfo.Size = new System.Drawing.Size(786, 740);
            this.tabPage_projectInfo.TabIndex = 2;
            this.tabPage_projectInfo.Text = "Project Information";
            this.tabPage_projectInfo.UseVisualStyleBackColor = true;
            // 
            // dataGridView_projects
            // 
            this.dataGridView_projects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_projects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_projects.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_projects.Location = new System.Drawing.Point(3, 565);
            this.dataGridView_projects.Name = "dataGridView_projects";
            this.dataGridView_projects.RowTemplate.Height = 25;
            this.dataGridView_projects.Size = new System.Drawing.Size(780, 172);
            this.dataGridView_projects.TabIndex = 11;
            this.dataGridView_projects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_projects_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 522);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "All Projects";
            // 
            // dataGridView_tasksForProject
            // 
            this.dataGridView_tasksForProject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_tasksForProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tasksForProject.Location = new System.Drawing.Point(6, 381);
            this.dataGridView_tasksForProject.Name = "dataGridView_tasksForProject";
            this.dataGridView_tasksForProject.RowTemplate.Height = 25;
            this.dataGridView_tasksForProject.Size = new System.Drawing.Size(774, 119);
            this.dataGridView_tasksForProject.TabIndex = 9;
            // 
            // label_projectName
            // 
            this.label_projectName.AutoSize = true;
            this.label_projectName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_projectName.Location = new System.Drawing.Point(170, 337);
            this.label_projectName.Name = "label_projectName";
            this.label_projectName.Size = new System.Drawing.Size(0, 25);
            this.label_projectName.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tasks For Project";
            // 
            // materialButton_addProject
            // 
            this.materialButton_addProject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_addProject.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton_addProject.Depth = 0;
            this.materialButton_addProject.HighEmphasis = true;
            this.materialButton_addProject.Icon = null;
            this.materialButton_addProject.Location = new System.Drawing.Point(7, 264);
            this.materialButton_addProject.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_addProject.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_addProject.Name = "materialButton_addProject";
            this.materialButton_addProject.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton_addProject.Size = new System.Drawing.Size(118, 36);
            this.materialButton_addProject.TabIndex = 6;
            this.materialButton_addProject.Text = "Add Project";
            this.materialButton_addProject.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_addProject.UseAccentColor = false;
            this.materialButton_addProject.UseVisualStyleBackColor = true;
            this.materialButton_addProject.Click += new System.EventHandler(this.materialButton_addProject_Click);
            // 
            // dateTimePicker_projectEnd
            // 
            this.dateTimePicker_projectEnd.Location = new System.Drawing.Point(3, 214);
            this.dateTimePicker_projectEnd.Name = "dateTimePicker_projectEnd";
            this.dateTimePicker_projectEnd.Size = new System.Drawing.Size(250, 23);
            this.dateTimePicker_projectEnd.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Project End";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Project Start";
            // 
            // dateTimePicker_projectStart
            // 
            this.dateTimePicker_projectStart.Location = new System.Drawing.Point(3, 149);
            this.dateTimePicker_projectStart.Name = "dateTimePicker_projectStart";
            this.dateTimePicker_projectStart.Size = new System.Drawing.Size(250, 23);
            this.dateTimePicker_projectStart.TabIndex = 2;
            // 
            // materialTextBox_projectName
            // 
            this.materialTextBox_projectName.AnimateReadOnly = false;
            this.materialTextBox_projectName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox_projectName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox_projectName.Depth = 0;
            this.materialTextBox_projectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox_projectName.HideSelection = true;
            this.materialTextBox_projectName.LeadingIcon = null;
            this.materialTextBox_projectName.Location = new System.Drawing.Point(6, 58);
            this.materialTextBox_projectName.MaxLength = 32767;
            this.materialTextBox_projectName.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_projectName.Name = "materialTextBox_projectName";
            this.materialTextBox_projectName.PasswordChar = '\0';
            this.materialTextBox_projectName.PrefixSuffixText = null;
            this.materialTextBox_projectName.ReadOnly = false;
            this.materialTextBox_projectName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox_projectName.SelectedText = "";
            this.materialTextBox_projectName.SelectionLength = 0;
            this.materialTextBox_projectName.SelectionStart = 0;
            this.materialTextBox_projectName.ShortcutsEnabled = true;
            this.materialTextBox_projectName.Size = new System.Drawing.Size(250, 48);
            this.materialTextBox_projectName.TabIndex = 1;
            this.materialTextBox_projectName.TabStop = false;
            this.materialTextBox_projectName.Text = "Project Name";
            this.materialTextBox_projectName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox_projectName.TrailingIcon = null;
            this.materialTextBox_projectName.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Create A New Project";
            // 
            // tab_createTasks
            // 
            this.tab_createTasks.Controls.Add(this.label16);
            this.tab_createTasks.Controls.Add(this.numericUpDown_estimatedTime);
            this.tab_createTasks.Controls.Add(this.label15);
            this.tab_createTasks.Controls.Add(this.dataGridView_allTasks);
            this.tab_createTasks.Controls.Add(this.dataGridView_taskTimesForTask);
            this.tab_createTasks.Controls.Add(this.label14);
            this.tab_createTasks.Controls.Add(this.label10);
            this.tab_createTasks.Controls.Add(this.materialButton_addTask);
            this.tab_createTasks.Controls.Add(this.materialMultiLineTextBox_taskDescription);
            this.tab_createTasks.Controls.Add(this.materialTextBox_taskName);
            this.tab_createTasks.Controls.Add(this.materialComboBox_projectName);
            this.tab_createTasks.Controls.Add(this.label7);
            this.tab_createTasks.Location = new System.Drawing.Point(4, 24);
            this.tab_createTasks.Name = "tab_createTasks";
            this.tab_createTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tab_createTasks.Size = new System.Drawing.Size(786, 740);
            this.tab_createTasks.TabIndex = 3;
            this.tab_createTasks.Text = "Create Tasks";
            this.tab_createTasks.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(318, 59);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(195, 21);
            this.label16.TabIndex = 13;
            this.label16.Text = "Estimated Task Time (days)";
            // 
            // numericUpDown_estimatedTime
            // 
            this.numericUpDown_estimatedTime.Location = new System.Drawing.Point(318, 83);
            this.numericUpDown_estimatedTime.Name = "numericUpDown_estimatedTime";
            this.numericUpDown_estimatedTime.Size = new System.Drawing.Size(250, 23);
            this.numericUpDown_estimatedTime.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(6, 593);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 25);
            this.label15.TabIndex = 10;
            this.label15.Text = "All Tasks";
            // 
            // dataGridView_allTasks
            // 
            this.dataGridView_allTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_allTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_allTasks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_allTasks.Location = new System.Drawing.Point(3, 636);
            this.dataGridView_allTasks.Name = "dataGridView_allTasks";
            this.dataGridView_allTasks.RowTemplate.Height = 25;
            this.dataGridView_allTasks.Size = new System.Drawing.Size(780, 101);
            this.dataGridView_allTasks.TabIndex = 9;
            this.dataGridView_allTasks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_allTasks_CellClick);
            // 
            // dataGridView_taskTimesForTask
            // 
            this.dataGridView_taskTimesForTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_taskTimesForTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_taskTimesForTask.Location = new System.Drawing.Point(6, 466);
            this.dataGridView_taskTimesForTask.Name = "dataGridView_taskTimesForTask";
            this.dataGridView_taskTimesForTask.RowTemplate.Height = 25;
            this.dataGridView_taskTimesForTask.Size = new System.Drawing.Size(774, 99);
            this.dataGridView_taskTimesForTask.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(6, 421);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(173, 25);
            this.label14.TabIndex = 7;
            this.label14.Text = "Task Times For Task";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(6, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 21);
            this.label10.TabIndex = 6;
            this.label10.Text = "Project Name";
            // 
            // materialButton_addTask
            // 
            this.materialButton_addTask.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_addTask.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton_addTask.Depth = 0;
            this.materialButton_addTask.HighEmphasis = true;
            this.materialButton_addTask.Icon = null;
            this.materialButton_addTask.Location = new System.Drawing.Point(6, 352);
            this.materialButton_addTask.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_addTask.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_addTask.Name = "materialButton_addTask";
            this.materialButton_addTask.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton_addTask.Size = new System.Drawing.Size(91, 36);
            this.materialButton_addTask.TabIndex = 4;
            this.materialButton_addTask.Text = "Add Task";
            this.materialButton_addTask.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_addTask.UseAccentColor = false;
            this.materialButton_addTask.UseVisualStyleBackColor = true;
            this.materialButton_addTask.Click += new System.EventHandler(this.materialButton_addTask_Click);
            // 
            // materialMultiLineTextBox_taskDescription
            // 
            this.materialMultiLineTextBox_taskDescription.AnimateReadOnly = false;
            this.materialMultiLineTextBox_taskDescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMultiLineTextBox_taskDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialMultiLineTextBox_taskDescription.Depth = 0;
            this.materialMultiLineTextBox_taskDescription.HideSelection = true;
            this.materialMultiLineTextBox_taskDescription.Location = new System.Drawing.Point(2, 214);
            this.materialMultiLineTextBox_taskDescription.MaxLength = 32767;
            this.materialMultiLineTextBox_taskDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMultiLineTextBox_taskDescription.Name = "materialMultiLineTextBox_taskDescription";
            this.materialMultiLineTextBox_taskDescription.PasswordChar = '\0';
            this.materialMultiLineTextBox_taskDescription.ReadOnly = false;
            this.materialMultiLineTextBox_taskDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.materialMultiLineTextBox_taskDescription.SelectedText = "";
            this.materialMultiLineTextBox_taskDescription.SelectionLength = 0;
            this.materialMultiLineTextBox_taskDescription.SelectionStart = 0;
            this.materialMultiLineTextBox_taskDescription.ShortcutsEnabled = true;
            this.materialMultiLineTextBox_taskDescription.Size = new System.Drawing.Size(250, 115);
            this.materialMultiLineTextBox_taskDescription.TabIndex = 3;
            this.materialMultiLineTextBox_taskDescription.TabStop = false;
            this.materialMultiLineTextBox_taskDescription.Text = "Task Description";
            this.materialMultiLineTextBox_taskDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMultiLineTextBox_taskDescription.UseSystemPasswordChar = false;
            // 
            // materialTextBox_taskName
            // 
            this.materialTextBox_taskName.AnimateReadOnly = false;
            this.materialTextBox_taskName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox_taskName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox_taskName.Depth = 0;
            this.materialTextBox_taskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox_taskName.HideSelection = true;
            this.materialTextBox_taskName.LeadingIcon = null;
            this.materialTextBox_taskName.Location = new System.Drawing.Point(2, 148);
            this.materialTextBox_taskName.MaxLength = 32767;
            this.materialTextBox_taskName.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_taskName.Name = "materialTextBox_taskName";
            this.materialTextBox_taskName.PasswordChar = '\0';
            this.materialTextBox_taskName.PrefixSuffixText = null;
            this.materialTextBox_taskName.ReadOnly = false;
            this.materialTextBox_taskName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox_taskName.SelectedText = "";
            this.materialTextBox_taskName.SelectionLength = 0;
            this.materialTextBox_taskName.SelectionStart = 0;
            this.materialTextBox_taskName.ShortcutsEnabled = true;
            this.materialTextBox_taskName.Size = new System.Drawing.Size(250, 48);
            this.materialTextBox_taskName.TabIndex = 2;
            this.materialTextBox_taskName.TabStop = false;
            this.materialTextBox_taskName.Text = "Task Name";
            this.materialTextBox_taskName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox_taskName.TrailingIcon = null;
            this.materialTextBox_taskName.UseSystemPasswordChar = false;
            // 
            // materialComboBox_projectName
            // 
            this.materialComboBox_projectName.AutoResize = false;
            this.materialComboBox_projectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox_projectName.Depth = 0;
            this.materialComboBox_projectName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox_projectName.DropDownHeight = 174;
            this.materialComboBox_projectName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox_projectName.DropDownWidth = 121;
            this.materialComboBox_projectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox_projectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox_projectName.FormattingEnabled = true;
            this.materialComboBox_projectName.IntegralHeight = false;
            this.materialComboBox_projectName.ItemHeight = 43;
            this.materialComboBox_projectName.Location = new System.Drawing.Point(2, 80);
            this.materialComboBox_projectName.MaxDropDownItems = 4;
            this.materialComboBox_projectName.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox_projectName.Name = "materialComboBox_projectName";
            this.materialComboBox_projectName.Size = new System.Drawing.Size(250, 49);
            this.materialComboBox_projectName.StartIndex = 0;
            this.materialComboBox_projectName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Create A Task";
            // 
            // tabPage_assignEmployees
            // 
            this.tabPage_assignEmployees.Controls.Add(this.materialButton_assignEmployee);
            this.tabPage_assignEmployees.Controls.Add(this.materialTextBox_taskTimeToSpend);
            this.tabPage_assignEmployees.Controls.Add(this.materialComboBox_employee);
            this.tabPage_assignEmployees.Controls.Add(this.label13);
            this.tabPage_assignEmployees.Controls.Add(this.label12);
            this.tabPage_assignEmployees.Controls.Add(this.materialComboBox_taskName);
            this.tabPage_assignEmployees.Controls.Add(this.label11);
            this.tabPage_assignEmployees.Location = new System.Drawing.Point(4, 24);
            this.tabPage_assignEmployees.Name = "tabPage_assignEmployees";
            this.tabPage_assignEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_assignEmployees.Size = new System.Drawing.Size(786, 740);
            this.tabPage_assignEmployees.TabIndex = 4;
            this.tabPage_assignEmployees.Text = "Assign Employees To Tasks";
            this.tabPage_assignEmployees.UseVisualStyleBackColor = true;
            // 
            // materialButton_assignEmployee
            // 
            this.materialButton_assignEmployee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_assignEmployee.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton_assignEmployee.Depth = 0;
            this.materialButton_assignEmployee.HighEmphasis = true;
            this.materialButton_assignEmployee.Icon = null;
            this.materialButton_assignEmployee.Location = new System.Drawing.Point(7, 308);
            this.materialButton_assignEmployee.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_assignEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_assignEmployee.Name = "materialButton_assignEmployee";
            this.materialButton_assignEmployee.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton_assignEmployee.Size = new System.Drawing.Size(152, 36);
            this.materialButton_assignEmployee.TabIndex = 6;
            this.materialButton_assignEmployee.Text = "Assign Employee";
            this.materialButton_assignEmployee.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_assignEmployee.UseAccentColor = false;
            this.materialButton_assignEmployee.UseVisualStyleBackColor = true;
            this.materialButton_assignEmployee.Click += new System.EventHandler(this.materialButton_assignEmployee_Click);
            // 
            // materialTextBox_taskTimeToSpend
            // 
            this.materialTextBox_taskTimeToSpend.AnimateReadOnly = false;
            this.materialTextBox_taskTimeToSpend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox_taskTimeToSpend.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox_taskTimeToSpend.Depth = 0;
            this.materialTextBox_taskTimeToSpend.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox_taskTimeToSpend.HideSelection = true;
            this.materialTextBox_taskTimeToSpend.LeadingIcon = null;
            this.materialTextBox_taskTimeToSpend.Location = new System.Drawing.Point(3, 240);
            this.materialTextBox_taskTimeToSpend.MaxLength = 32767;
            this.materialTextBox_taskTimeToSpend.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_taskTimeToSpend.Name = "materialTextBox_taskTimeToSpend";
            this.materialTextBox_taskTimeToSpend.PasswordChar = '\0';
            this.materialTextBox_taskTimeToSpend.PrefixSuffixText = null;
            this.materialTextBox_taskTimeToSpend.ReadOnly = false;
            this.materialTextBox_taskTimeToSpend.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox_taskTimeToSpend.SelectedText = "";
            this.materialTextBox_taskTimeToSpend.SelectionLength = 0;
            this.materialTextBox_taskTimeToSpend.SelectionStart = 0;
            this.materialTextBox_taskTimeToSpend.ShortcutsEnabled = true;
            this.materialTextBox_taskTimeToSpend.Size = new System.Drawing.Size(250, 48);
            this.materialTextBox_taskTimeToSpend.TabIndex = 5;
            this.materialTextBox_taskTimeToSpend.TabStop = false;
            this.materialTextBox_taskTimeToSpend.Text = "Timespan (__:__) dd:hh";
            this.materialTextBox_taskTimeToSpend.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox_taskTimeToSpend.TrailingIcon = null;
            this.materialTextBox_taskTimeToSpend.UseSystemPasswordChar = false;
            // 
            // materialComboBox_employee
            // 
            this.materialComboBox_employee.AutoResize = false;
            this.materialComboBox_employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox_employee.Depth = 0;
            this.materialComboBox_employee.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox_employee.DropDownHeight = 174;
            this.materialComboBox_employee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox_employee.DropDownWidth = 121;
            this.materialComboBox_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox_employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox_employee.FormattingEnabled = true;
            this.materialComboBox_employee.IntegralHeight = false;
            this.materialComboBox_employee.ItemHeight = 43;
            this.materialComboBox_employee.Location = new System.Drawing.Point(3, 173);
            this.materialComboBox_employee.MaxDropDownItems = 4;
            this.materialComboBox_employee.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox_employee.Name = "materialComboBox_employee";
            this.materialComboBox_employee.Size = new System.Drawing.Size(250, 49);
            this.materialComboBox_employee.StartIndex = 0;
            this.materialComboBox_employee.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(6, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 21);
            this.label13.TabIndex = 3;
            this.label13.Text = "Employee";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(6, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 21);
            this.label12.TabIndex = 2;
            this.label12.Text = "Task";
            // 
            // materialComboBox_taskName
            // 
            this.materialComboBox_taskName.AutoResize = false;
            this.materialComboBox_taskName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox_taskName.Depth = 0;
            this.materialComboBox_taskName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox_taskName.DropDownHeight = 174;
            this.materialComboBox_taskName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox_taskName.DropDownWidth = 121;
            this.materialComboBox_taskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox_taskName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox_taskName.FormattingEnabled = true;
            this.materialComboBox_taskName.IntegralHeight = false;
            this.materialComboBox_taskName.ItemHeight = 43;
            this.materialComboBox_taskName.Location = new System.Drawing.Point(3, 82);
            this.materialComboBox_taskName.MaxDropDownItems = 4;
            this.materialComboBox_taskName.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox_taskName.Name = "materialComboBox_taskName";
            this.materialComboBox_taskName.Size = new System.Drawing.Size(250, 49);
            this.materialComboBox_taskName.StartIndex = 0;
            this.materialComboBox_taskName.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(6, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Assign An Employee";
            // 
            // tabPage_save
            // 
            this.tabPage_save.Controls.Add(this.materialButton_saveData);
            this.tabPage_save.Controls.Add(this.label17);
            this.tabPage_save.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage_save.Location = new System.Drawing.Point(4, 24);
            this.tabPage_save.Name = "tabPage_save";
            this.tabPage_save.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_save.Size = new System.Drawing.Size(786, 740);
            this.tabPage_save.TabIndex = 5;
            this.tabPage_save.Text = "Save Changes";
            this.tabPage_save.UseVisualStyleBackColor = true;
            // 
            // materialButton_saveData
            // 
            this.materialButton_saveData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_saveData.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton_saveData.Depth = 0;
            this.materialButton_saveData.HighEmphasis = true;
            this.materialButton_saveData.Icon = null;
            this.materialButton_saveData.Location = new System.Drawing.Point(7, 29);
            this.materialButton_saveData.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_saveData.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_saveData.Name = "materialButton_saveData";
            this.materialButton_saveData.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton_saveData.Size = new System.Drawing.Size(99, 36);
            this.materialButton_saveData.TabIndex = 1;
            this.materialButton_saveData.Text = "Save Data";
            this.materialButton_saveData.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_saveData.UseAccentColor = false;
            this.materialButton_saveData.UseVisualStyleBackColor = true;
            this.materialButton_saveData.Click += new System.EventHandler(this.materialButton_saveData_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 86);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(220, 15);
            this.label17.TabIndex = 0;
            this.label17.Text = "Note: Data gets saved in an XML format.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 835);
            this.Controls.Add(this.tabControl_projectInfo);
            this.DrawerShowIconsWhenHidden = true;
            this.Name = "Form1";
            this.Text = "Employee Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabPage_editEmployees.ResumeLayout(false);
            this.tabPage_editEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employees)).EndInit();
            this.tabControl_projectInfo.ResumeLayout(false);
            this.tabPage_projectInfo.ResumeLayout(false);
            this.tabPage_projectInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_projects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tasksForProject)).EndInit();
            this.tab_createTasks.ResumeLayout(false);
            this.tab_createTasks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_estimatedTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_allTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_taskTimesForTask)).EndInit();
            this.tabPage_assignEmployees.ResumeLayout(false);
            this.tabPage_assignEmployees.PerformLayout();
            this.tabPage_save.ResumeLayout(false);
            this.tabPage_save.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage_editEmployees;
        private MaterialSkin.Controls.MaterialButton materialButton_changeCompanyName;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox_companyName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_employees;
        private MaterialSkin.Controls.MaterialButton materialButton_addEmployee;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox_employeeAddress;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox_employeePhone;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox_employeeSurname;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox_employeeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl_projectInfo;
        private System.Windows.Forms.TabPage tabPage_projectInfo;
        private System.Windows.Forms.DateTimePicker dateTimePicker_projectStart;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox_projectName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_projectEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialButton materialButton_addProject;
        private System.Windows.Forms.TabPage tab_createTasks;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox_projectName;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox_taskName;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 materialMultiLineTextBox_taskDescription;
        private System.Windows.Forms.DataGridView dataGridView_projects;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView_tasksForProject;
        private System.Windows.Forms.Label label_projectName;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialButton materialButton_addTask;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage_assignEmployees;
        private System.Windows.Forms.Label label11;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox_employee;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox_taskName;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox_taskTimeToSpend;
        private MaterialSkin.Controls.MaterialButton materialButton_assignEmployee;
        private System.Windows.Forms.DataGridView dataGridView_taskTimesForTask;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView_allTasks;
        private System.Windows.Forms.NumericUpDown numericUpDown_estimatedTime;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabPage_save;
        private MaterialSkin.Controls.MaterialButton materialButton_saveData;
        private System.Windows.Forms.Label label17;
    }
}
