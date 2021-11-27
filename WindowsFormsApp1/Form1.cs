using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        string User = "", Pass = "";
        
        int[] mese= { 0 };
        int selectedTable,ID_chelner,KeyCom=0,plata=0,incasariTotale=0;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\atestat info\WindowsFormsApp1\WindowsFormsApp1\baza_atestat.mdf;Integrated Security=True;Connect Timeout=30");
        
        DataTable grid = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {  
            
            baza_atestatDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'baza_atestatDataSet.PRODUSE' table. You can move, or remove it, as needed.
            this.pRODUSETableAdapter.Fill(this.baza_atestatDataSet.PRODUSE);
            // TODO: This line of code loads data into the 'baza_atestatDataSet.COMENZI' table. You can move, or remove it, as needed.
            this.cOMENZITableAdapter.Fill(this.baza_atestatDataSet.COMENZI);
            // TODO: This line of code loads data into the 'baza_atestatDataSet.CLIENTI' table. You can move, or remove it, as needed.
            this.cLIENTITableAdapter.Fill(this.baza_atestatDataSet.CLIENTI);
            // TODO: This line of code loads data into the 'baza_atestatDataSet.CHELNERI' table. You can move, or remove it, as needed.
            this.cHELNERITableAdapter.Fill(this.baza_atestatDataSet.CHELNERI);
            tabControl1.SelectedTab = Login;
            mese = new int[17];
            dataGridView1.ReadOnly = true;
            tabControl1.Appearance = TabAppearance.FlatButtons;
           tabControl1.ItemSize = new Size(0, 1);
           tabControl1.SizeMode = TabSizeMode.Fixed;
            pRODUSETableAdapter.Categorii(baza_atestatDataSet.PRODUSE);
            DataTable tabel = baza_atestatDataSet.PRODUSE;
            for(int i=0;i<tabel.Rows.Count;i++)
            {
                Categorie.Items.Add(tabel.Rows[i]["categorie"]);
            }
            for(int i=1;i<=15;i++)
            {
                cOMENZITableAdapter.comanda_per_masa(baza_atestatDataSet.COMENZI, i);
                DataTable dt = baza_atestatDataSet.COMENZI;
                if(dt.Rows.Count>0)
                {
                    mese[i] = 1;
                    if (i == 1) Masa1.BackColor = Color.Red;
                    if (i == 2) Masa2.BackColor = Color.Red;
                    if (i == 3) Masa3.BackColor = Color.Red;
                    if (i == 4) Masa4.BackColor = Color.Red;
                    if (i == 5) Masa5.BackColor = Color.Red;
                    if (i == 6) Masa6.BackColor = Color.Red;
                    if (i == 7) Masa7.BackColor = Color.Red;
                    if (i == 8) Masa8.BackColor = Color.Red;
                    if (i == 9) Masa9.BackColor = Color.Red;
                    if (i == 10) Masa10.BackColor = Color.Red;
                    if (i == 11) Masa11.BackColor = Color.Red;
                    if (i == 12) Masa12.BackColor = Color.Red;
                    if (i == 13) Masa13.BackColor = Color.Red;
                    if (i == 14) Masa14.BackColor = Color.Red;
                    if (i == 15) Masa15.BackColor = Color.Red;
                }
            }
            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "DeleteBut";
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            this.dataGridView1.Columns.Add(deleteButton);

        }
        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT  COMENZI.cantitate_prod AS Cantitate, COMENZI.nume_prod AS Nume, PRODUSE.pret_prod * COMENZI.cantitate_prod AS Pret, COMENZI.id_comanda,COMENZI.nr FROM COMENZI INNER JOIN PRODUSE ON COMENZI.nume_prod = PRODUSE.denumire_produs where id_comanda='" + selectedTable + "' ";
            cmd.ExecuteNonQuery();
            grid.Clear();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(grid);
            dataGridView1.DataSource = grid;
            con.Close();
            dataGridView1.Columns[0].Width = 75;
            dataGridView1.Columns[1].Width = 75;
            dataGridView1.AllowUserToAddRows = false;
            
        }
        
        private void CapsOnOff()
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                Caps.ForeColor = Color.PaleVioletRed;
                Caps.Text = "The caps lock is On";
            }
            else Caps.Text = "";
        }
        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            CapsOnOff();
        }

        private void Login_butotn_Click(object sender, EventArgs e)
        {
            bool ok = false;
            int ch=0;
            cHELNERITableAdapter.LOGIN(baza_atestatDataSet.CHELNERI);
            DataTable dt = baza_atestatDataSet.CHELNERI;
            string user = Username.Text, pass = Password.Text;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string user1 = dt.Rows[i]["username"].ToString(),user2="",pass1=dt.Rows[i]["password"].ToString(),pass2="";
                int j = 0;
                while ((user1[j] >= 'A' && user1[j] <= 'Z') || (user1[j] >= 'a' && user1[j] <= 'z') || (user1[j] >= '0' && user1[j] <= '9'))
                {
                    user2 = user2 + user1[j];
                    j++;
                }
                j = 0;
                while ((pass1[j] >= 'A' && pass1[j] <= 'Z') || (pass1[j] >= 'a' && pass1[j] <= 'z') || (pass1[j] >= '0' && pass1[j] <= '9'))
                {
                    pass2 = pass2 + pass1[j];
                    j++;
                }
                if (user.Equals(user2) == true && pass.Equals(pass2) == true)
                {
                    ok = true;
                    ch = i;
                }
            }
            if (ok == true)
            {
                tabControl1.SelectedTab = Main_menu;
                User = User + user;
                Pass = Pass + pass;
                string chel = dt.Rows[ch]["prenume"].ToString();
                Chelner.Text +=chel;
                Username.Text = "Username";
                Username.ForeColor = Color.Silver;
                Password.Text = "Password";
                Password.ForeColor = Color.Silver;
               
                cHELNERITableAdapter.ID_Chel(baza_atestatDataSet.CHELNERI, User, Pass);
                DataTable ID = baza_atestatDataSet.CHELNERI;
                if (ID.Rows.Count > 0)
                    ID_chelner = (int)ID.Rows[ID.Rows.Count - 1]["id_chelner"];

                cOMENZITableAdapter.Comenzi_nr_total(baza_atestatDataSet.COMENZI);
                DataTable comenzi = baza_atestatDataSet.COMENZI;
                if (comenzi.Rows.Count > 0)
                    KeyCom = Convert.ToInt32(comenzi.Rows[0]["MAX"]);
                cHELNERITableAdapter.Fill(baza_atestatDataSet.CHELNERI);
                DataTable nr_com = baza_atestatDataSet.CHELNERI;
                comenzi123.Text= "Numar comenzi:" + nr_com.Rows[ID_chelner - 1]["nr_comenzi"];
            }
            else Error.Text = "Username-ul sau parola nu sunt corecte. Va rugam incercati din nou.";
            
        }
        private void Password_Enter(object sender, EventArgs e)
        {
            if(Password.Text.Equals("Password"))
            {
                Password.Text = "";
                Password.ForeColor = Color.Black;
                Password.PasswordChar = '•';
            }
        }
        private void Username_Enter(object sender, EventArgs e)
        {
            if(Username.Text.Equals("Username"))
            {
                Username.Text = "";
                Username.ForeColor = Color.Black;
            }
        }
        private void Username_Leave(object sender, EventArgs e)
        {
            if (Username.Text == "")
            {
                Username.Text = "Username";
                Username.ForeColor = Color.Silver;
            }
        }
        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text == "")
            {
                Password.Text = "Password";
                Password.ForeColor = Color.Silver;
                Password.PasswordChar = '\0';
            }
        }
        private void Logout_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Login;
            Chelner.Text = "Chelner curent: ";
            ID_chelner = 0;
            Error.Text = "";
            User = "";
            Pass = "";
        }
        private void Masa1_Click(object sender, EventArgs e)
        {
            this.cOMENZITableAdapter.Update(baza_atestatDataSet.COMENZI);
            this.cOMENZITableAdapter.Fill(this.baza_atestatDataSet.COMENZI);
            tabControl1.SelectedTab = Menu;
            mese[1] = 1;
            Masa1.BackColor = Color.Red;
            selectedTable = 1;
            comanda.Text = "Comanda de la masa 1 este:";
            cOMENZITableAdapter.comanda_per_masa(baza_atestatDataSet.COMENZI, selectedTable);
            DataTable dt = baza_atestatDataSet.COMENZI;
            plata = 0;
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                plata += Convert.ToInt32(dt.Rows[i]["Pret"]);
            }
            Total.Text = plata.ToString() + " lei";
            disp_data();
        }

        private void Masa2_Click(object sender, EventArgs e)
        {
            this.cOMENZITableAdapter.Update(baza_atestatDataSet.COMENZI);
            this.cOMENZITableAdapter.Fill(this.baza_atestatDataSet.COMENZI);
            tabControl1.SelectedTab = Menu;
            mese[2] = 1;
            Masa2.BackColor = Color.Red;
            selectedTable = 2;
            comanda.Text = "Comanda de la masa 2 este:";
            cOMENZITableAdapter.comanda_per_masa(baza_atestatDataSet.COMENZI, selectedTable);
            DataTable dt = baza_atestatDataSet.COMENZI;
            plata = 0;
            disp_data();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                plata += Convert.ToInt32(dt.Rows[i]["Pret"]);
            }
            Total.Text = plata.ToString() + " lei";
        }

        private void Masa3_Click(object sender, EventArgs e)
        {
            this.cOMENZITableAdapter.Update(baza_atestatDataSet.COMENZI);
            this.cOMENZITableAdapter.Fill(this.baza_atestatDataSet.COMENZI);
            tabControl1.SelectedTab = Menu;
            mese[3] = 1;
            Masa3.BackColor = Color.Red;
            selectedTable = 3;
            comanda.Text = "Comanda de la masa 3 este:";
            cOMENZITableAdapter.comanda_per_masa(baza_atestatDataSet.COMENZI, selectedTable);
            DataTable dt = baza_atestatDataSet.COMENZI;
            plata = 0;
            disp_data();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                plata += Convert.ToInt32(dt.Rows[i]["Pret"]);
            }
            Total.Text = plata.ToString() + " lei";
        }

        private void Masa4_Click(object sender, EventArgs e)
        {
            this.cOMENZITableAdapter.Update(baza_atestatDataSet.COMENZI);
            this.cOMENZITableAdapter.Fill(this.baza_atestatDataSet.COMENZI);
            tabControl1.SelectedTab = Menu;
            mese[4] = 1;
            Masa4.BackColor = Color.Red;
            selectedTable = 4;
            comanda.Text = "Comanda de la masa 4 este:";
            cOMENZITableAdapter.comanda_per_masa(baza_atestatDataSet.COMENZI, selectedTable);
            DataTable dt = baza_atestatDataSet.COMENZI;
            plata = 0;
            disp_data();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                plata += Convert.ToInt32(dt.Rows[i]["Pret"]);
            }
            Total.Text = plata.ToString() + " lei";
        }

        private void Masa5_Click(object sender, EventArgs e)
        {
            this.cOMENZITableAdapter.Update(baza_atestatDataSet.COMENZI);
            this.cOMENZITableAdapter.Fill(this.baza_atestatDataSet.COMENZI);
            tabControl1.SelectedTab = Menu;
            mese[5] = 1;
            Masa5.BackColor = Color.Red;
            selectedTable = 5;
            comanda.Text = "Comanda de la masa 5 este:";
            cOMENZITableAdapter.comanda_per_masa(baza_atestatDataSet.COMENZI, selectedTable);
            DataTable dt = baza_atestatDataSet.COMENZI;
            plata = 0;
            disp_data();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                plata += Convert.ToInt32(dt.Rows[i]["Pret"]);
            }
            Total.Text = plata.ToString() + " lei";
        }

        private void Masa6_Click(object sender, EventArgs e)
        {
            this.cOMENZITableAdapter.Update(baza_atestatDataSet.COMENZI);
            this.cOMENZITableAdapter.Fill(this.baza_atestatDataSet.COMENZI);
            tabControl1.SelectedTab = Menu;
            mese[6] = 1;
            Masa6.BackColor = Color.Red;
            selectedTable = 6;
            comanda.Text = "Comanda de la masa 6 este:";
            cOMENZITableAdapter.comanda_per_masa(baza_atestatDataSet.COMENZI, selectedTable);
            DataTable dt = baza_atestatDataSet.COMENZI;
            plata = 0;
            disp_data();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                plata += Convert.ToInt32(dt.Rows[i]["Pret"]);
            }
            Total.Text = plata.ToString() + " lei";
        }

        private void Masa7_Click(object sender, EventArgs e)
        {
            this.cOMENZITableAdapter.Update(baza_atestatDataSet.COMENZI);
            this.cOMENZITableAdapter.Fill(this.baza_atestatDataSet.COMENZI);
            tabControl1.SelectedTab = Menu;
            mese[7] = 1;
            Masa7.BackColor = Color.Red;
            selectedTable = 7;
            comanda.Text = "Comanda de la masa 7 este:";
            cOMENZITableAdapter.comanda_per_masa(baza_atestatDataSet.COMENZI, selectedTable);
            DataTable dt = baza_atestatDataSet.COMENZI;
            plata = 0;
            disp_data();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                plata += Convert.ToInt32(dt.Rows[i]["Pret"]);
            }
            Total.Text = plata.ToString() + " lei";
        }

        private void Masa8_Click(object sender, EventArgs e)
        {
            this.cOMENZITableAdapter.Update(baza_atestatDataSet.COMENZI);
            this.cOMENZITableAdapter.Fill(this.baza_atestatDataSet.COMENZI);
            tabControl1.SelectedTab = Menu;
            mese[8] = 1;
            Masa8.BackColor = Color.Red;
            selectedTable = 8;
            comanda.Text = "Comanda de la masa 8 este:";
            cOMENZITableAdapter.comanda_per_masa(baza_atestatDataSet.COMENZI, selectedTable);
            DataTable dt = baza_atestatDataSet.COMENZI;
            plata = 0;
            disp_data();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                plata += Convert.ToInt32(dt.Rows[i]["Pret"]);
            }
            Total.Text = plata.ToString() + " lei";
        }

        private void Masa9_Click(object sender, EventArgs e)
        {
            this.cOMENZITableAdapter.Update(baza_atestatDataSet.COMENZI);
            this.cOMENZITableAdapter.Fill(this.baza_atestatDataSet.COMENZI);
            tabControl1.SelectedTab = Menu;
            mese[9] = 1;
            Masa9.BackColor = Color.Red;
            selectedTable = 9;
            comanda.Text = "Comanda de la masa 9 este:";
            cOMENZITableAdapter.comanda_per_masa(baza_atestatDataSet.COMENZI, selectedTable);
            DataTable dt = baza_atestatDataSet.COMENZI;
            plata = 0;
            disp_data();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                plata += Convert.ToInt32(dt.Rows[i]["Pret"]);
            }
            Total.Text = plata.ToString() + " lei";
        }

        private void Masa10_Click(object sender, EventArgs e)
        {
            this.cOMENZITableAdapter.Update(baza_atestatDataSet.COMENZI);
            this.cOMENZITableAdapter.Fill(this.baza_atestatDataSet.COMENZI);
            tabControl1.SelectedTab = Menu;
            mese[10] = 1;
            Masa10.BackColor = Color.Red;
            selectedTable = 10;
            comanda.Text = "Comanda de la masa 10 este:";
            cOMENZITableAdapter.comanda_per_masa(baza_atestatDataSet.COMENZI, selectedTable);
            DataTable dt = baza_atestatDataSet.COMENZI;
            plata = 0;
            disp_data();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                plata += Convert.ToInt32(dt.Rows[i]["Pret"]);
            }
            Total.Text = plata.ToString() + " lei";
        }

        private void Masa11_Click(object sender, EventArgs e)
        {
            this.cOMENZITableAdapter.Update(baza_atestatDataSet.COMENZI);
            this.cOMENZITableAdapter.Fill(this.baza_atestatDataSet.COMENZI);
            tabControl1.SelectedTab = Menu;
            mese[11] = 1;
            Masa11.BackColor = Color.Red;
            selectedTable = 11;
            comanda.Text = "Comanda de la masa 11 este:";
            cOMENZITableAdapter.comanda_per_masa(baza_atestatDataSet.COMENZI, selectedTable);
            DataTable dt = baza_atestatDataSet.COMENZI;
            plata = 0;
            disp_data();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                plata += Convert.ToInt32(dt.Rows[i]["Pret"]);
            }
            Total.Text = plata.ToString() + " lei";
        }

        private void Masa12_Click(object sender, EventArgs e)
        {
            this.cOMENZITableAdapter.Update(baza_atestatDataSet.COMENZI);
            this.cOMENZITableAdapter.Fill(this.baza_atestatDataSet.COMENZI);
            tabControl1.SelectedTab = Menu;
            mese[12] = 1;
            Masa12.BackColor = Color.Red;
            selectedTable = 12;
            comanda.Text = "Comanda de la masa 12 este:";
            cOMENZITableAdapter.comanda_per_masa(baza_atestatDataSet.COMENZI, selectedTable);
            DataTable dt = baza_atestatDataSet.COMENZI;
            plata = 0;
            disp_data();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                plata += Convert.ToInt32(dt.Rows[i]["Pret"]);
            }
            Total.Text = plata.ToString() + " lei";
        }

        private void Masa13_Click(object sender, EventArgs e)
        {
            this.cOMENZITableAdapter.Update(baza_atestatDataSet.COMENZI);
            this.cOMENZITableAdapter.Fill(this.baza_atestatDataSet.COMENZI);
            tabControl1.SelectedTab = Menu;
            mese[13] = 1;
            Masa13.BackColor = Color.Red;
            selectedTable = 13;
            comanda.Text = "Comanda de la masa 13 este:";
            cOMENZITableAdapter.comanda_per_masa(baza_atestatDataSet.COMENZI, selectedTable);
            DataTable dt = baza_atestatDataSet.COMENZI;
            plata = 0;
            disp_data();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                plata += Convert.ToInt32(dt.Rows[i]["Pret"]);
            }
            Total.Text = plata.ToString() + " lei";
        }

        private void Masa14_Click(object sender, EventArgs e)
        {
            this.cOMENZITableAdapter.Update(baza_atestatDataSet.COMENZI);
            this.cOMENZITableAdapter.Fill(this.baza_atestatDataSet.COMENZI);
            tabControl1.SelectedTab = Menu;
            mese[14] = 1;
            Masa14.BackColor = Color.Red;
            selectedTable = 14;
            comanda.Text = "Comanda de la masa 14 este:";
            cOMENZITableAdapter.comanda_per_masa(baza_atestatDataSet.COMENZI, selectedTable);
            DataTable dt = baza_atestatDataSet.COMENZI;
            plata = 0;
            disp_data();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                plata += Convert.ToInt32(dt.Rows[i]["Pret"]);
            }
            Total.Text = plata.ToString() + " lei";
        }

        

        private void Masa15_Click(object sender, EventArgs e)
        {
            this.cOMENZITableAdapter.Update(baza_atestatDataSet.COMENZI);
            this.cOMENZITableAdapter.Fill(this.baza_atestatDataSet.COMENZI);
            tabControl1.SelectedTab = Menu;
            mese[15] = 1;
            Masa15.BackColor = Color.Red;
            selectedTable = 15;
            comanda.Text = "Comanda de la masa 15 este:";
            cOMENZITableAdapter.comanda_per_masa(baza_atestatDataSet.COMENZI, selectedTable);
            DataTable dt = baza_atestatDataSet.COMENZI;
            plata = 0;
            disp_data();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                plata += Convert.ToInt32(dt.Rows[i]["Pret"]);
            }
            Total.Text = plata.ToString()+" lei";
        }
        private void Categorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            Produse.Items.Clear();
            Categorie.Text = "";
            Produse.Text = "";
            pRODUSETableAdapter.Produse(baza_atestatDataSet.PRODUSE, Categorie.SelectedItem.ToString());
            DataTable dt = baza_atestatDataSet.PRODUSE;
            for (int i = 0; i < dt.Rows.Count; i++)
                Produse.Items.Add(dt.Rows[i]["denumire_produs"]);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==0)
            {
                int number = Convert.ToInt32(grid.Rows[e.RowIndex]["nr"]);
                int price = Convert.ToInt32(grid.Rows[e.RowIndex]["Pret"]);
                plata = plata - price;
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from COMENZI where nr='" + number + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                grid.Rows.RemoveAt(e.RowIndex);
                this.cOMENZITableAdapter.Update(baza_atestatDataSet.COMENZI);
                this.cOMENZITableAdapter.Fill(this.baza_atestatDataSet.COMENZI);
                Total.Text = plata.ToString() + " lei";
            }
        }

        

        private void Bon_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Main_menu;
            mese[selectedTable] = 0;
            if (selectedTable == 1) Masa1.BackColor = Color.LawnGreen;
            if (selectedTable == 2) Masa2.BackColor = Color.LawnGreen;
            if (selectedTable == 3) Masa3.BackColor = Color.LawnGreen;
            if (selectedTable == 4) Masa4.BackColor = Color.LawnGreen;
            if (selectedTable == 5) Masa5.BackColor = Color.LawnGreen;
            if (selectedTable == 6) Masa6.BackColor = Color.LawnGreen;
            if (selectedTable == 7) Masa7.BackColor = Color.LawnGreen;
            if (selectedTable == 8) Masa8.BackColor = Color.LawnGreen;
            if (selectedTable == 9) Masa9.BackColor = Color.LawnGreen;
            if (selectedTable == 10) Masa10.BackColor = Color.LawnGreen;
            if (selectedTable == 11) Masa11.BackColor = Color.LawnGreen;
            if (selectedTable == 12) Masa12.BackColor = Color.LawnGreen;
            if (selectedTable == 13) Masa13.BackColor = Color.LawnGreen;
            if (selectedTable == 14) Masa14.BackColor = Color.LawnGreen;
            if (selectedTable == 15) Masa15.BackColor = Color.LawnGreen;

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update COMENZI set id_comanda='" + selectedTable + "'*100 where id_comanda='" + selectedTable + "' ";
            cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "update CHELNERI set nr_comenzi=nr_comenzi+1 where id_chelner='" + ID_chelner + "'";
            cmd1.ExecuteNonQuery();
            con.Close();
            this.cOMENZITableAdapter.Update(baza_atestatDataSet.COMENZI);
            this.cOMENZITableAdapter.Fill(this.baza_atestatDataSet.COMENZI);
            
            this.cHELNERITableAdapter.Update(baza_atestatDataSet.CHELNERI);
            this.cHELNERITableAdapter.Fill(this.baza_atestatDataSet.CHELNERI);
            cHELNERITableAdapter.Fill(baza_atestatDataSet.CHELNERI);
            DataTable dt = baza_atestatDataSet.CHELNERI;
            comenzi123.Text = "Numar comenzi: " + dt.Rows[ID_chelner - 1]["nr_comenzi"];
            grid.Clear();
            Total.Text = "0 lei";
            incasariTotale += plata;
            IncasariTot.Text = "Incasari totale:" + incasariTotale + " lei";
        }

        private void Inapoi_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Main_menu;
            cOMENZITableAdapter.Fill(baza_atestatDataSet.COMENZI);
            DataTable dt = baza_atestatDataSet.COMENZI;
            bool ok = true;
            for(int i=0;i<grid.Rows.Count;i++)
            {
                if (Convert.ToInt32(grid.Rows[i]["id_comanda"]) == selectedTable) ok = false;
            }
            if(ok==true)
            {
                mese[selectedTable] = 0;
                if (selectedTable == 1) Masa1.BackColor = Color.LawnGreen;
                if (selectedTable == 2) Masa2.BackColor = Color.LawnGreen;
                if (selectedTable == 3) Masa3.BackColor = Color.LawnGreen;
                if (selectedTable == 4) Masa4.BackColor = Color.LawnGreen;
                if (selectedTable == 5) Masa5.BackColor = Color.LawnGreen;
                if (selectedTable == 6) Masa6.BackColor = Color.LawnGreen;
                if (selectedTable == 7) Masa7.BackColor = Color.LawnGreen;
                if (selectedTable == 8) Masa8.BackColor = Color.LawnGreen;
                if (selectedTable == 9) Masa9.BackColor = Color.LawnGreen;
                if (selectedTable == 10) Masa10.BackColor = Color.LawnGreen;
                if (selectedTable == 11) Masa11.BackColor = Color.LawnGreen;
                if (selectedTable == 12) Masa12.BackColor = Color.LawnGreen;
                if (selectedTable == 13) Masa13.BackColor = Color.LawnGreen;
                if (selectedTable == 14) Masa14.BackColor = Color.LawnGreen;
                if (selectedTable == 15) Masa15.BackColor = Color.LawnGreen;
            }
            grid.Clear();
            this.cHELNERITableAdapter.Update(baza_atestatDataSet.CHELNERI);
            this.cHELNERITableAdapter.Fill(this.baza_atestatDataSet.CHELNERI);
            DataTable dti = baza_atestatDataSet.CHELNERI;
            comenzi123.Text = "Numar comenzi: " + dti.Rows[ID_chelner - 1]["nr_comenzi"];
        }

        private void Adauga_Click(object sender, EventArgs e)
        {
            if (Produse.Text != "" && Nr_prod.Text != "")
            {
                KeyCom++;
                con.Open();                                                                                                  ///De aici incepe inserarea unei linii noi in tabel
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into COMENZI (id_comanda, nume_prod, cantitate_prod, id_chelner, tip_comanda, nr) values (@id_comanda,@nume_prod,@cantitate_prod,@id_chelner,@tip_comanda,@nr)";
                cmd.Parameters.AddWithValue("@id_comanda", selectedTable);
                cmd.Parameters.AddWithValue("@nume_prod", Produse.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@cantitate_prod", int.Parse(Nr_prod.SelectedItem.ToString()));
                cmd.Parameters.AddWithValue("@id_chelner", ID_chelner);
                cmd.Parameters.AddWithValue("@tip_comanda", "Aici");
                cmd.Parameters.AddWithValue("@nr", KeyCom);
                cmd.ExecuteNonQuery();
                this.cOMENZITableAdapter.Update(baza_atestatDataSet.COMENZI);
                this.cOMENZITableAdapter.Fill(this.baza_atestatDataSet.COMENZI);
                con.Close();                                                                                                ///Aici se termina inserarea
                disp_data();

                Categorie.Text = "";
                Produse.Items.Clear();
                Produse.Text = "";
                Nr_prod.Text = "";
                cOMENZITableAdapter.comanda_per_masa(baza_atestatDataSet.COMENZI, selectedTable);
                DataTable dt = baza_atestatDataSet.COMENZI;
                plata = 0;
                for (int i = 0; i < grid.Rows.Count; i++)
                {
                    plata += Convert.ToInt32(grid.Rows[i]["Pret"]);
                }
                Total.Text = plata.ToString() + " lei";
            }
        }
       

    }
}
