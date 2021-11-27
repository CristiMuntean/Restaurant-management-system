namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Login = new System.Windows.Forms.TabPage();
            this.Caps = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Login_butotn = new System.Windows.Forms.Button();
            this.Main_menu = new System.Windows.Forms.TabPage();
            this.IncasariTot = new System.Windows.Forms.Label();
            this.comenzi123 = new System.Windows.Forms.Label();
            this.Masa10 = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.Masa5 = new System.Windows.Forms.Button();
            this.Masa15 = new System.Windows.Forms.Button();
            this.Masa14 = new System.Windows.Forms.Button();
            this.Masa9 = new System.Windows.Forms.Button();
            this.Masa4 = new System.Windows.Forms.Button();
            this.Masa13 = new System.Windows.Forms.Button();
            this.Masa8 = new System.Windows.Forms.Button();
            this.Masa3 = new System.Windows.Forms.Button();
            this.Masa12 = new System.Windows.Forms.Button();
            this.Masa7 = new System.Windows.Forms.Button();
            this.Masa2 = new System.Windows.Forms.Button();
            this.Masa11 = new System.Windows.Forms.Button();
            this.Masa6 = new System.Windows.Forms.Button();
            this.Masa1 = new System.Windows.Forms.Button();
            this.Chelner = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Total = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Inapoi = new System.Windows.Forms.Button();
            this.Bon = new System.Windows.Forms.Button();
            this.comanda = new System.Windows.Forms.Label();
            this.Adauga = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Nr_prod = new System.Windows.Forms.ComboBox();
            this.Produse = new System.Windows.Forms.ComboBox();
            this.Categorie = new System.Windows.Forms.ComboBox();
            this.baza_atestatDataSet = new WindowsFormsApp1.baza_atestatDataSet();
            this.cHELNERIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHELNERITableAdapter = new WindowsFormsApp1.baza_atestatDataSetTableAdapters.CHELNERITableAdapter();
            this.cLIENTIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTITableAdapter = new WindowsFormsApp1.baza_atestatDataSetTableAdapters.CLIENTITableAdapter();
            this.cOMENZIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMENZITableAdapter = new WindowsFormsApp1.baza_atestatDataSetTableAdapters.COMENZITableAdapter();
            this.pRODUSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUSETableAdapter = new WindowsFormsApp1.baza_atestatDataSetTableAdapters.PRODUSETableAdapter();
            this.tabControl1.SuspendLayout();
            this.Login.SuspendLayout();
            this.Main_menu.SuspendLayout();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_atestatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHELNERIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMENZIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUSEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Login);
            this.tabControl1.Controls.Add(this.Main_menu);
            this.tabControl1.Controls.Add(this.Menu);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Turquoise;
            this.Login.Controls.Add(this.Caps);
            this.Login.Controls.Add(this.Error);
            this.Login.Controls.Add(this.Password);
            this.Login.Controls.Add(this.Username);
            this.Login.Controls.Add(this.Login_butotn);
            this.Login.Location = new System.Drawing.Point(4, 22);
            this.Login.Name = "Login";
            this.Login.Padding = new System.Windows.Forms.Padding(3);
            this.Login.Size = new System.Drawing.Size(792, 424);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            // 
            // Caps
            // 
            this.Caps.AutoSize = true;
            this.Caps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Caps.Location = new System.Drawing.Point(233, 201);
            this.Caps.Name = "Caps";
            this.Caps.Size = new System.Drawing.Size(0, 20);
            this.Caps.TabIndex = 5;
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error.Location = new System.Drawing.Point(153, 125);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(0, 20);
            this.Error.TabIndex = 4;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Password.Location = new System.Drawing.Point(237, 224);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(298, 26);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            this.Password.Enter += new System.EventHandler(this.Password_Enter);
            this.Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_KeyDown);
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Username.Location = new System.Drawing.Point(237, 162);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(298, 26);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username";
            this.Username.Enter += new System.EventHandler(this.Username_Enter);
            this.Username.Leave += new System.EventHandler(this.Username_Leave);
            // 
            // Login_butotn
            // 
            this.Login_butotn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_butotn.Location = new System.Drawing.Point(270, 280);
            this.Login_butotn.Name = "Login_butotn";
            this.Login_butotn.Size = new System.Drawing.Size(235, 55);
            this.Login_butotn.TabIndex = 0;
            this.Login_butotn.Text = "Login";
            this.Login_butotn.UseVisualStyleBackColor = true;
            this.Login_butotn.Click += new System.EventHandler(this.Login_butotn_Click);
            // 
            // Main_menu
            // 
            this.Main_menu.BackColor = System.Drawing.Color.Turquoise;
            this.Main_menu.Controls.Add(this.IncasariTot);
            this.Main_menu.Controls.Add(this.comenzi123);
            this.Main_menu.Controls.Add(this.Masa10);
            this.Main_menu.Controls.Add(this.Logout);
            this.Main_menu.Controls.Add(this.Masa5);
            this.Main_menu.Controls.Add(this.Masa15);
            this.Main_menu.Controls.Add(this.Masa14);
            this.Main_menu.Controls.Add(this.Masa9);
            this.Main_menu.Controls.Add(this.Masa4);
            this.Main_menu.Controls.Add(this.Masa13);
            this.Main_menu.Controls.Add(this.Masa8);
            this.Main_menu.Controls.Add(this.Masa3);
            this.Main_menu.Controls.Add(this.Masa12);
            this.Main_menu.Controls.Add(this.Masa7);
            this.Main_menu.Controls.Add(this.Masa2);
            this.Main_menu.Controls.Add(this.Masa11);
            this.Main_menu.Controls.Add(this.Masa6);
            this.Main_menu.Controls.Add(this.Masa1);
            this.Main_menu.Controls.Add(this.Chelner);
            this.Main_menu.Location = new System.Drawing.Point(4, 22);
            this.Main_menu.Name = "Main_menu";
            this.Main_menu.Padding = new System.Windows.Forms.Padding(3);
            this.Main_menu.Size = new System.Drawing.Size(792, 424);
            this.Main_menu.TabIndex = 1;
            this.Main_menu.Text = "Main menu";
            // 
            // IncasariTot
            // 
            this.IncasariTot.AutoSize = true;
            this.IncasariTot.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncasariTot.Location = new System.Drawing.Point(40, 373);
            this.IncasariTot.Name = "IncasariTot";
            this.IncasariTot.Size = new System.Drawing.Size(139, 27);
            this.IncasariTot.TabIndex = 5;
            this.IncasariTot.Text = "Incasari totale: 0 lei";
            // 
            // comenzi123
            // 
            this.comenzi123.AutoSize = true;
            this.comenzi123.Font = new System.Drawing.Font("Dubai", 12F);
            this.comenzi123.Location = new System.Drawing.Point(358, 21);
            this.comenzi123.Name = "comenzi123";
            this.comenzi123.Size = new System.Drawing.Size(0, 27);
            this.comenzi123.TabIndex = 4;
            // 
            // Masa10
            // 
            this.Masa10.BackColor = System.Drawing.Color.LawnGreen;
            this.Masa10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Masa10.Location = new System.Drawing.Point(570, 165);
            this.Masa10.Name = "Masa10";
            this.Masa10.Size = new System.Drawing.Size(88, 70);
            this.Masa10.TabIndex = 3;
            this.Masa10.Text = "10";
            this.Masa10.UseVisualStyleBackColor = false;
            this.Masa10.Click += new System.EventHandler(this.Masa10_Click);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(631, 373);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(133, 38);
            this.Logout.TabIndex = 2;
            this.Logout.Text = "LOG OUT";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Masa5
            // 
            this.Masa5.BackColor = System.Drawing.Color.LawnGreen;
            this.Masa5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Masa5.Location = new System.Drawing.Point(570, 65);
            this.Masa5.Name = "Masa5";
            this.Masa5.Size = new System.Drawing.Size(88, 70);
            this.Masa5.TabIndex = 1;
            this.Masa5.Text = "5";
            this.Masa5.UseVisualStyleBackColor = false;
            this.Masa5.Click += new System.EventHandler(this.Masa5_Click);
            // 
            // Masa15
            // 
            this.Masa15.BackColor = System.Drawing.Color.LawnGreen;
            this.Masa15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Masa15.Location = new System.Drawing.Point(570, 263);
            this.Masa15.Name = "Masa15";
            this.Masa15.Size = new System.Drawing.Size(88, 70);
            this.Masa15.TabIndex = 1;
            this.Masa15.Text = "15";
            this.Masa15.UseVisualStyleBackColor = false;
            this.Masa15.Click += new System.EventHandler(this.Masa15_Click);
            // 
            // Masa14
            // 
            this.Masa14.BackColor = System.Drawing.Color.LawnGreen;
            this.Masa14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Masa14.Location = new System.Drawing.Point(438, 263);
            this.Masa14.Name = "Masa14";
            this.Masa14.Size = new System.Drawing.Size(88, 70);
            this.Masa14.TabIndex = 1;
            this.Masa14.Text = "14";
            this.Masa14.UseVisualStyleBackColor = false;
            this.Masa14.Click += new System.EventHandler(this.Masa14_Click);
            // 
            // Masa9
            // 
            this.Masa9.BackColor = System.Drawing.Color.LawnGreen;
            this.Masa9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Masa9.Location = new System.Drawing.Point(438, 165);
            this.Masa9.Name = "Masa9";
            this.Masa9.Size = new System.Drawing.Size(88, 70);
            this.Masa9.TabIndex = 1;
            this.Masa9.Text = "9";
            this.Masa9.UseVisualStyleBackColor = false;
            this.Masa9.Click += new System.EventHandler(this.Masa9_Click);
            // 
            // Masa4
            // 
            this.Masa4.BackColor = System.Drawing.Color.LawnGreen;
            this.Masa4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Masa4.Location = new System.Drawing.Point(438, 65);
            this.Masa4.Name = "Masa4";
            this.Masa4.Size = new System.Drawing.Size(88, 70);
            this.Masa4.TabIndex = 1;
            this.Masa4.Text = "4";
            this.Masa4.UseVisualStyleBackColor = false;
            this.Masa4.Click += new System.EventHandler(this.Masa4_Click);
            // 
            // Masa13
            // 
            this.Masa13.BackColor = System.Drawing.Color.LawnGreen;
            this.Masa13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Masa13.Location = new System.Drawing.Point(306, 263);
            this.Masa13.Name = "Masa13";
            this.Masa13.Size = new System.Drawing.Size(88, 70);
            this.Masa13.TabIndex = 1;
            this.Masa13.Text = "11";
            this.Masa13.UseVisualStyleBackColor = false;
            this.Masa13.Click += new System.EventHandler(this.Masa13_Click);
            // 
            // Masa8
            // 
            this.Masa8.BackColor = System.Drawing.Color.LawnGreen;
            this.Masa8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Masa8.Location = new System.Drawing.Point(306, 165);
            this.Masa8.Name = "Masa8";
            this.Masa8.Size = new System.Drawing.Size(88, 70);
            this.Masa8.TabIndex = 1;
            this.Masa8.Text = "8";
            this.Masa8.UseVisualStyleBackColor = false;
            this.Masa8.Click += new System.EventHandler(this.Masa8_Click);
            // 
            // Masa3
            // 
            this.Masa3.BackColor = System.Drawing.Color.LawnGreen;
            this.Masa3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Masa3.Location = new System.Drawing.Point(306, 65);
            this.Masa3.Name = "Masa3";
            this.Masa3.Size = new System.Drawing.Size(88, 70);
            this.Masa3.TabIndex = 1;
            this.Masa3.Text = "3";
            this.Masa3.UseVisualStyleBackColor = false;
            this.Masa3.Click += new System.EventHandler(this.Masa3_Click);
            // 
            // Masa12
            // 
            this.Masa12.BackColor = System.Drawing.Color.LawnGreen;
            this.Masa12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Masa12.Location = new System.Drawing.Point(174, 263);
            this.Masa12.Name = "Masa12";
            this.Masa12.Size = new System.Drawing.Size(88, 70);
            this.Masa12.TabIndex = 1;
            this.Masa12.Text = "12";
            this.Masa12.UseVisualStyleBackColor = false;
            this.Masa12.Click += new System.EventHandler(this.Masa12_Click);
            // 
            // Masa7
            // 
            this.Masa7.BackColor = System.Drawing.Color.LawnGreen;
            this.Masa7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Masa7.Location = new System.Drawing.Point(174, 165);
            this.Masa7.Name = "Masa7";
            this.Masa7.Size = new System.Drawing.Size(88, 70);
            this.Masa7.TabIndex = 1;
            this.Masa7.Text = "7";
            this.Masa7.UseVisualStyleBackColor = false;
            this.Masa7.Click += new System.EventHandler(this.Masa7_Click);
            // 
            // Masa2
            // 
            this.Masa2.BackColor = System.Drawing.Color.LawnGreen;
            this.Masa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Masa2.Location = new System.Drawing.Point(174, 65);
            this.Masa2.Name = "Masa2";
            this.Masa2.Size = new System.Drawing.Size(88, 70);
            this.Masa2.TabIndex = 1;
            this.Masa2.Text = "2";
            this.Masa2.UseVisualStyleBackColor = false;
            this.Masa2.Click += new System.EventHandler(this.Masa2_Click);
            // 
            // Masa11
            // 
            this.Masa11.BackColor = System.Drawing.Color.LawnGreen;
            this.Masa11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Masa11.Location = new System.Drawing.Point(42, 263);
            this.Masa11.Name = "Masa11";
            this.Masa11.Size = new System.Drawing.Size(88, 70);
            this.Masa11.TabIndex = 1;
            this.Masa11.Text = "11";
            this.Masa11.UseVisualStyleBackColor = false;
            this.Masa11.Click += new System.EventHandler(this.Masa11_Click);
            // 
            // Masa6
            // 
            this.Masa6.BackColor = System.Drawing.Color.LawnGreen;
            this.Masa6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Masa6.Location = new System.Drawing.Point(42, 165);
            this.Masa6.Name = "Masa6";
            this.Masa6.Size = new System.Drawing.Size(88, 70);
            this.Masa6.TabIndex = 1;
            this.Masa6.Text = "6";
            this.Masa6.UseVisualStyleBackColor = false;
            this.Masa6.Click += new System.EventHandler(this.Masa6_Click);
            // 
            // Masa1
            // 
            this.Masa1.BackColor = System.Drawing.Color.LawnGreen;
            this.Masa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Masa1.Location = new System.Drawing.Point(42, 65);
            this.Masa1.Name = "Masa1";
            this.Masa1.Size = new System.Drawing.Size(88, 70);
            this.Masa1.TabIndex = 1;
            this.Masa1.Text = "1";
            this.Masa1.UseVisualStyleBackColor = false;
            this.Masa1.Click += new System.EventHandler(this.Masa1_Click);
            // 
            // Chelner
            // 
            this.Chelner.AutoSize = true;
            this.Chelner.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chelner.Location = new System.Drawing.Point(38, 21);
            this.Chelner.Name = "Chelner";
            this.Chelner.Size = new System.Drawing.Size(114, 27);
            this.Chelner.TabIndex = 0;
            this.Chelner.Text = "Chelner curent: ";
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.Turquoise;
            this.Menu.Controls.Add(this.dataGridView1);
            this.Menu.Controls.Add(this.Total);
            this.Menu.Controls.Add(this.label4);
            this.Menu.Controls.Add(this.Inapoi);
            this.Menu.Controls.Add(this.Bon);
            this.Menu.Controls.Add(this.comanda);
            this.Menu.Controls.Add(this.Adauga);
            this.Menu.Controls.Add(this.label3);
            this.Menu.Controls.Add(this.label2);
            this.Menu.Controls.Add(this.label1);
            this.Menu.Controls.Add(this.Nr_prod);
            this.Menu.Controls.Add(this.Produse);
            this.Menu.Controls.Add(this.Categorie);
            this.Menu.Location = new System.Drawing.Point(4, 22);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(3);
            this.Menu.Size = new System.Drawing.Size(792, 424);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "Menu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Turquoise;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(418, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(340, 315);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Total
            // 
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(643, 383);
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Size = new System.Drawing.Size(115, 26);
            this.Total.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(481, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Totalul de plata este:";
            // 
            // Inapoi
            // 
            this.Inapoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inapoi.Location = new System.Drawing.Point(52, 18);
            this.Inapoi.Name = "Inapoi";
            this.Inapoi.Size = new System.Drawing.Size(344, 51);
            this.Inapoi.TabIndex = 7;
            this.Inapoi.Text = "Inapoi la mese";
            this.Inapoi.UseVisualStyleBackColor = true;
            this.Inapoi.Click += new System.EventHandler(this.Inapoi_Click);
            // 
            // Bon
            // 
            this.Bon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bon.Location = new System.Drawing.Point(316, 376);
            this.Bon.Name = "Bon";
            this.Bon.Size = new System.Drawing.Size(159, 43);
            this.Bon.TabIndex = 6;
            this.Bon.Text = "Listeaza bon si elibereaza masa";
            this.Bon.UseVisualStyleBackColor = true;
            this.Bon.Click += new System.EventHandler(this.Bon_Click);
            // 
            // comanda
            // 
            this.comanda.AutoSize = true;
            this.comanda.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comanda.Location = new System.Drawing.Point(482, 12);
            this.comanda.Name = "comanda";
            this.comanda.Size = new System.Drawing.Size(146, 27);
            this.comanda.TabIndex = 5;
            this.comanda.Text = "Comanda de la masa ";
            // 
            // Adauga
            // 
            this.Adauga.Font = new System.Drawing.Font("Dubai", 12F);
            this.Adauga.Location = new System.Drawing.Point(52, 320);
            this.Adauga.Name = "Adauga";
            this.Adauga.Size = new System.Drawing.Size(111, 41);
            this.Adauga.TabIndex = 3;
            this.Adauga.Text = "Adauga";
            this.Adauga.UseVisualStyleBackColor = true;
            this.Adauga.Click += new System.EventHandler(this.Adauga_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 12F);
            this.label3.Location = new System.Drawing.Point(47, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alegeti numarul de produse:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 12F);
            this.label2.Location = new System.Drawing.Point(50, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alegeti produsul pe care doriti sa il adaugati:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alegeti categoria din care vreti sa adaugati produsul:";
            // 
            // Nr_prod
            // 
            this.Nr_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nr_prod.FormattingEnabled = true;
            this.Nr_prod.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.Nr_prod.Location = new System.Drawing.Point(246, 244);
            this.Nr_prod.Name = "Nr_prod";
            this.Nr_prod.Size = new System.Drawing.Size(58, 33);
            this.Nr_prod.TabIndex = 0;
            // 
            // Produse
            // 
            this.Produse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Produse.FormattingEnabled = true;
            this.Produse.Location = new System.Drawing.Point(53, 199);
            this.Produse.Name = "Produse";
            this.Produse.Size = new System.Drawing.Size(229, 26);
            this.Produse.TabIndex = 0;
            // 
            // Categorie
            // 
            this.Categorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categorie.FormattingEnabled = true;
            this.Categorie.Location = new System.Drawing.Point(53, 126);
            this.Categorie.Name = "Categorie";
            this.Categorie.Size = new System.Drawing.Size(229, 26);
            this.Categorie.TabIndex = 0;
            this.Categorie.SelectedIndexChanged += new System.EventHandler(this.Categorie_SelectedIndexChanged);
            // 
            // baza_atestatDataSet
            // 
            this.baza_atestatDataSet.DataSetName = "baza_atestatDataSet";
            this.baza_atestatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cHELNERIBindingSource
            // 
            this.cHELNERIBindingSource.DataMember = "CHELNERI";
            this.cHELNERIBindingSource.DataSource = this.baza_atestatDataSet;
            // 
            // cHELNERITableAdapter
            // 
            this.cHELNERITableAdapter.ClearBeforeFill = true;
            // 
            // cLIENTIBindingSource
            // 
            this.cLIENTIBindingSource.DataMember = "CLIENTI";
            this.cLIENTIBindingSource.DataSource = this.baza_atestatDataSet;
            // 
            // cLIENTITableAdapter
            // 
            this.cLIENTITableAdapter.ClearBeforeFill = true;
            // 
            // cOMENZIBindingSource
            // 
            this.cOMENZIBindingSource.DataMember = "COMENZI";
            this.cOMENZIBindingSource.DataSource = this.baza_atestatDataSet;
            // 
            // cOMENZITableAdapter
            // 
            this.cOMENZITableAdapter.ClearBeforeFill = true;
            // 
            // pRODUSEBindingSource
            // 
            this.pRODUSEBindingSource.DataMember = "PRODUSE";
            this.pRODUSEBindingSource.DataSource = this.baza_atestatDataSet;
            // 
            // pRODUSETableAdapter
            // 
            this.pRODUSETableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            this.Main_menu.ResumeLayout(false);
            this.Main_menu.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_atestatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHELNERIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMENZIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUSEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private baza_atestatDataSet baza_atestatDataSet;
        private System.Windows.Forms.BindingSource cHELNERIBindingSource;
        private baza_atestatDataSetTableAdapters.CHELNERITableAdapter cHELNERITableAdapter;
        private System.Windows.Forms.BindingSource cLIENTIBindingSource;
        private baza_atestatDataSetTableAdapters.CLIENTITableAdapter cLIENTITableAdapter;
        private System.Windows.Forms.BindingSource cOMENZIBindingSource;
        private baza_atestatDataSetTableAdapters.COMENZITableAdapter cOMENZITableAdapter;
        private System.Windows.Forms.BindingSource pRODUSEBindingSource;
        private baza_atestatDataSetTableAdapters.PRODUSETableAdapter pRODUSETableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Button Login_butotn;
        private System.Windows.Forms.TabPage Main_menu;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.Label Chelner;
        private System.Windows.Forms.Button Masa1;
        private System.Windows.Forms.Button Masa4;
        private System.Windows.Forms.Button Masa3;
        private System.Windows.Forms.Button Masa2;
        private System.Windows.Forms.Button Masa5;
        private System.Windows.Forms.Button Masa14;
        private System.Windows.Forms.Button Masa9;
        private System.Windows.Forms.Button Masa13;
        private System.Windows.Forms.Button Masa8;
        private System.Windows.Forms.Button Masa12;
        private System.Windows.Forms.Button Masa7;
        private System.Windows.Forms.Button Masa11;
        private System.Windows.Forms.Button Masa6;
        private System.Windows.Forms.Button Masa15;
        private System.Windows.Forms.TabPage Menu;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.ComboBox Produse;
        private System.Windows.Forms.ComboBox Categorie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Adauga;
        private System.Windows.Forms.Label comanda;
        private System.Windows.Forms.Button Bon;
        private System.Windows.Forms.Button Inapoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Nr_prod;
        private System.Windows.Forms.Button Masa10;
        private System.Windows.Forms.Label Caps;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label comenzi123;
        private System.Windows.Forms.Label IncasariTot;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

