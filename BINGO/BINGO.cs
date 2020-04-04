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

namespace BINGO
{
    public partial class BINGO : Form
    {
        private Control[] bingoNumbers;
        private bool[] generatedNumbers;
        private Control[,] bingoCells;
        private bool[,] clicked;
        private int[,] cellClickedCounter;
        private bool[] selectedRows = new bool[5];


        public BINGO()
        {
            InitializeComponent();
        }
        public void setSelectedRows()
        {
            for (int i = 0; i < selectedRows.Length; ++i)
            {
                if (i == 0 && b1.BackColor == Color.Green || b2.BackColor == Color.Green || b3.BackColor == Color.Green ||
                              b4.BackColor == Color.Green || b5.BackColor == Color.Green)
                {
                    selectedRows[0] = true;
                }
                if (i == 1 && b6.BackColor == Color.Green || b7.BackColor == Color.Green || b8.BackColor == Color.Green ||
                              b9.BackColor == Color.Green || b10.BackColor == Color.Green)
                {
                    selectedRows[1] = true;
                }
                if (i == 2 && b11.BackColor == Color.Green || b12.BackColor == Color.Green ||
                                  b14.BackColor == Color.Green || b15.BackColor == Color.Green)
                {
                    selectedRows[2] = true;
                }
                if (i == 3 && b16.BackColor == Color.Green || b17.BackColor == Color.Green || b18.BackColor == Color.Green ||
                                  b19.BackColor == Color.Green || b20.BackColor == Color.Green)
                {
                    selectedRows[3] = true;
                }
                if (i == 4 && b22.BackColor == Color.Green || b23.BackColor == Color.Green || b24.BackColor == Color.Green ||
                                  b25.BackColor == Color.Green || b21.BackColor == Color.Green)
                {
                    selectedRows[4] = true;
                }
            }
        }
        private void patternEnable()
        {
            string b;
            Control c;

            for (int i = 1; i <= 25; ++i)
            {
                b = "b" + i;
                c = this.Controls.Find(b, true)[0];
                c.Enabled = true;
            }
        }

        private void patternDisable()
        {
            string query;
            SqlCommand command;
            SqlDataReader reader;

            string b;
            Control c;

            try
            {
                connection.DB();
                query = "Select * from WinningPattern";
                command = new SqlCommand(query, connection.conn);
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    for (int i = 1; i <= 25; ++i)
                    {
                        b = "b" + i;
                        c = this.Controls.Find(b, true)[0];
                        c.Enabled = false;
                    }
                    //btnGenerate.Enabled = true;
                }
                else
                {
                    patternEnable();
                }
                connection.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
        private void BtnGenerate_Click(object sender, EventArgs e)
        {

            //Save pattern
            string query = "Select * from WinningPattern where Patterns > 0";

            try
            {
                connection.DB();
                SqlCommand command = new SqlCommand(query, connection.conn);
                SqlDataReader reader = command.ExecuteReader();

                if (!reader.Read())
                {
                   savePattern();
                }

                connection.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            patternDisable();
            setSelectedRows();


            int num = NumberGenerator.GenerateRandomNumber(selectedRows);
            char letter = NumberGenerator.GetCharEquivalent();
            if(num != -1)
            {
                bingoNumbers[num - 1].BackColor = Color.Red;
                lblLetter.Text = "" + letter;
                
                lblNumber.Text = "" + num;

                try
                {
                    connection.DB();
                    String a = "Insert into Generated_Numbers values(" + lblNumber.Text +")";
                    SqlCommand command = new SqlCommand(a, connection.conn);
                    command.ExecuteNonQuery();
                    connection.conn.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                lblLetter.Text = "";
                lblNumber.Text = "";
            }

        }
        
        public void BINGO_Load(object sender, EventArgs e)
        {

            patternDisable();

            bingoNumbers = new Control[75];
            generatedNumbers = new bool[75];
            bingoCells = new Control[5, 5];
            clicked = new bool[5, 5];
            cellClickedCounter = new int[5, 5];
            string a = "";
            string controlName;
            int counter = 1;
            lblLetter.Text = "";
            lblNumber.Text = "";

            string control = ""; // added
            string query = "";
            for (int i=0; i<75; ++i)
            {
                controlName = "label" + (i + 1);
                bingoNumbers[i] = this.Controls.Find(controlName,true)[0];
                bingoNumbers[i].Text = "" + (i + 1);
                bingoNumbers[i].BackColor = NumberGenerator.GeneratedNumbers()[i]? Color.Red : Color.DarkViolet;
                a += bingoNumbers[i].Name + "\n";
            }

            for(int i=0; i<5; ++i)
            {
                for(int ii=0; ii<5; ++ii)
                {
                    bingoCells[i, ii] = Controls.Find("b" + counter, true)[0];
                    if (counter == 13)
                    {
                        ++counter;
                        continue;
                    }
                    else
                    {
                        bingoCells[i, ii].BackColor = clicked[i, ii] ? Color.Green : Color.White;
                    }

                    ++counter;
                }
            }
            retrievePattern();

            //added
            try
            {
                Control c;
                connection.DB();
                query = "Select * From Generated_Numbers";
                SqlCommand command = new SqlCommand(query, connection.conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    reader.GetValue(0);
                    for (int i = 0; i < 75; i++)
                    {
                        if (i == Int32.Parse(reader.GetValue(0).ToString()))
                        {
                            control = "label" + reader.GetValue(0).ToString();
                            c = this.Controls.Find(control, true)[0];
                            c.BackColor = Color.Red;
                            
                        }
                    }
                }
                connection.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void recolor()
        {
            for(int i = 0; i<5; ++i)
            {
                for(int j = 0; j<5; j++)
                {
                    if (i == 2 && j == 2)
                    {
                        bingoCells[j, i].BackColor = Color.Green;
                    }
                    else
                    {
                        bingoCells[j, i].BackColor = Color.White;

                    }
                }
            }
        }
  
        private void FillWinningPatternCells()
        { 
            for (int i = 0; i < 5; ++i)
            {
                for (int ii = 0; ii < 5; ++ii)
                {
                    if (BingoPattern.Patterns[BingoPattern.SelectedPattern].GetPattern()[ii, i])
                    {
                        bingoCells[ii, i].BackColor = Color.Green;
                    }
                    else
                        bingoCells[ii, i].BackColor = Color.White;

                }
            }
        }

        private void savePattern()
        {
            SqlCommand command;
            string query = "";//added
            string B = "b";
            int count = 0;

            for (int i = 0; i < 5; ++i)
            {
                for (int j = 0; j < 5; j++)
                {
                    count++;

                    if (bingoCells[i,j].BackColor.Equals(Color.Green))
                    {
                        try
                        {
                            connection.DB();
                            query = "Insert into WinningPattern values(" + count + ")";

                            command = new SqlCommand(query, connection.conn);
                            command.ExecuteNonQuery();
                            connection.conn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }
        private void retrievePattern()
        {
            try
            {
                
                String control;
                Control c;
                connection.DB();
                String query = "Select * From WinningPattern";
                SqlCommand command = new SqlCommand(query, connection.conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    reader.GetValue(0);
                    for (int i = 0; i < 26; i++)
                    {
                        if (i == Int32.Parse(reader.GetValue(0).ToString()))
                        {
                            control = "b" + reader.GetValue(0).ToString();
                            c = this.Controls.Find(control, true)[0];
                            c.BackColor = Color.Green;
                        }
                    
                    }

                }
                connection.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deletePattern()
        {
            SqlCommand command;
            string query;

            try
            {
                connection.DB();
                query = "Delete From WinningPattern";
                command = new SqlCommand(query, connection.conn);
                command.ExecuteNonQuery();
                connection.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void PanelLogo_Click(object sender, EventArgs e)
        {
            new PatternMaker(this).ShowDialog();
        }

        public void Reset(object sender, EventArgs e)
        {
            BingoPattern.SelectedPattern++;
            BingoPattern.SelectedPattern %= BingoPattern.Patterns.Length;
            NumberGenerator.ResetGeneratedNumbers();
            BINGO_Load(sender, e);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            selectedRows = new bool[5];

            DialogResult res = MessageBox.Show("You are about to declare a winner.", "Warning", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if(res == DialogResult.OK)
            {
                Round.SavePreviousRound(clicked, NumberGenerator.GeneratedNumbers());
                new WeHaveAWinner(this).ShowDialog();

                patternEnable();
                deletePattern();
                recolor();

                try
                {
                    connection.DB();

                    String x = "DELETE FROM Generated_Numbers";
                    SqlCommand command = new SqlCommand(x, connection.conn);
                    command.ExecuteNonQuery();
                    connection.conn.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                String controlName;
                String a = "";

                for (int i = 0; i < 75; ++i)
                {
                    controlName = "label" + (i + 1);
                    bingoNumbers[i] = this.Controls.Find(controlName, true)[0];
                    bingoNumbers[i].Text = "" + (i + 1);
                    bingoNumbers[i].BackColor = Color.DarkViolet;
                    a += bingoNumbers[i].Name + "\n";
                }
            }
            
        }

        private void B25_Click(object sender, EventArgs e)
        {
            ClickACell(4, 4);
        }

        private void B24_Click(object sender, EventArgs e)
        {
            ClickACell(4, 3);
        }

        private void B23_Click(object sender, EventArgs e)
        {
            ClickACell(4, 2);
        }

        private void B22_Click(object sender, EventArgs e)
        {
            ClickACell(4, 1);
        }

        private void B21_Click(object sender, EventArgs e)
        {
            ClickACell(4, 0);
        }

        private void B20_Click(object sender, EventArgs e)
        {
            ClickACell(3, 4);
        }

        private void B19_Click(object sender, EventArgs e)
        {
            ClickACell(3, 3);
        }

        private void B18_Click(object sender, EventArgs e)
        {
            ClickACell(3, 2);
        }

        private void B17_Click(object sender, EventArgs e)
        {
            ClickACell(3, 1);
        }

        private void B16_Click(object sender, EventArgs e)
        {
            ClickACell(3, 0);
        }
        

        private void B15_Click(object sender, EventArgs e)
        {
            ClickACell(2, 4);
        }

        private void B14_Click(object sender, EventArgs e)
        {
            ClickACell(2, 3);
        }

        private void B12_Click(object sender, EventArgs e)
        {
            ClickACell(2, 1);
        }

        private void B11_Click(object sender, EventArgs e)
        {
            ClickACell(2, 0);
        }

        private void B10_Click(object sender, EventArgs e)
        {
            ClickACell(1, 4);
        }

        private void B9_Click(object sender, EventArgs e)
        {
            ClickACell(1, 3);
        }

        private void B8_Click(object sender, EventArgs e)
        {
            ClickACell(1, 2);
        }

        private void B7_Click(object sender, EventArgs e)
        {
            ClickACell(1, 1);
        }

        private void B6_Click(object sender, EventArgs e)
        {
            ClickACell(1, 0);
        }

        private void B5_Click(object sender, EventArgs e)
        {
            ClickACell(0, 4);
        }

        private void B4_Click(object sender, EventArgs e)
        {
            ClickACell(0, 3);
        }

        private void B3_Click(object sender, EventArgs e)
        {
            ClickACell(0, 2);
        }

        private void B2_Click(object sender, EventArgs e)
        {
            ClickACell(0, 1);
        }

        private void B1_Click(object sender, EventArgs e)
        {
            ClickACell(0, 0);
        }

        private void ClickACell(int i, int ii)
        {
            clicked[i, ii] = !clicked[i, ii];
            bingoCells[i, ii].BackColor = clicked[i, ii] ? Color.Green : Color.White;

     
        }
        private void SetCellClickedCount(int i, int ii)
        {
            cellClickedCounter[i, ii] += clicked[i, ii] ? 1 : -1;
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            Round a = Round.GetPreviousRound();
            clicked = a.ClickedCells;
            NumberGenerator.SetGeneratedNumbers(a.GeneratedNumbers);
            BINGO_Load(sender, e);
        }


    }
}
