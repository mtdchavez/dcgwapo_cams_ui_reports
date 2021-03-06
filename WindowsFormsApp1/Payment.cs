﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Payment : Form
    {
        public Dashadmin ref_dashadmin { get; set; }
        public MySqlConnection conn;
        public ServiceDetail reftrans { get; set; }
       
        public Payment()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dcgwaps;Uid=root;Pwd=root;SslMode=none;");
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            {
               /* BranchPrint br = new BranchPrint();
                br.ref_dashadmin = this;
                br.Show();
                this.Hide();*/
            }
            try
            {
                if (payamtTxt.Text == String.Empty)
                {
                    MessageBox.Show("Enter payment amount");
                }
                else
                {
                    if (MessageBox.Show("Are you sure will undergo the payment?", "Confirm ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        conn.Open();

                        String query1 = "INSERT INTO payment (client_transaction_id, total_amount, pay_amount, payment_date) VALUES (" + int.Parse(tIDlabel.Text) + ", " + double.Parse(amtLabel.Text) + ", " + double.Parse(payamtTxt.Text) + ", NOW())";
                        String query2 = "UPDATE client_transaction SET status = 'Paid' WHERE id = " + int.Parse(tIDlabel.Text) + "";
                        //String query3 = "INSERT INTO branch_sale VALUES ("
                        MySqlCommand comm1 = new MySqlCommand(query1, conn);
                        MySqlCommand comm2 = new MySqlCommand(query2, conn);
                        comm1.ExecuteNonQuery();
                        comm2.ExecuteNonQuery();

                        conn.Close();
                        
                    }
                    MessageBox.Show("Payment has been successful", "Updated Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClientTransaction trans = new ClientTransaction();
                    trans.ref_pay = this;
                    trans.Show();
                    this.Hide();

                }
                

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }


        }

        private void Payment_Load(object sender, EventArgs e)
        {
            tIDlabel.Text = String.Concat(ServiceDetail.selected_trans_id);
            amtLabel.Text = String.Concat(ServiceDetail.selected_amt);
        }

        private void Payment_FormClosing(object sender, FormClosingEventArgs e)
        {
            reftrans.Show();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void payamtTxt_TextChanged(object sender, EventArgs e)
        {
            if (payamtTxt.Text == "")
            {
                changetxt.Text = "0";
            }
            else
            {
                decimal change = decimal.Parse(payamtTxt.Text.ToString()) - decimal.Parse(amtLabel.Text.ToString());
                changetxt.Text = change.ToString("#,0.00");
            }
        }
    }
}
