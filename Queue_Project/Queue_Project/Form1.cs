using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue_Project
{


    
    public partial class frm_Main : Form
    {
        
        private Double st;//service time
        private Double at;//arriving time
        private Double ar_M;//arriving rate M
        private Double sr_M;//arriving rate M
        private int capcity;
        private int NOS;//number of servers in M     private double n_t;
        private double T_i;
      
        M_M_1 m_m_1;
        M_M_C m_m_c;

        D_D d_d;
       
        bool is_infinite ; //system capacity
        int num_of_initial_cst = 7;
        public frm_Main()
        {
            InitializeComponent();

        }

        private void btn_Calc_wq(object sender, EventArgs e)
        {
            ep.Clear();
            bool isallValid = true;
            if (n_txt.Text.Trim() == "")
            {
                ep.SetError(n_txt, "enter n");
                isallValid = false;
            }
            if (M_txt.Text.Trim() == "" && M_initial_panel.Visible == true)
            {
                ep.SetError(M_txt, "enter M");
                isallValid = false;
            }

            if (isallValid)
            {
                int n = int.Parse(n_txt.Text);
          
                if (M_initial_panel.Visible)
                {
                    d_d.setNumber_of_initial_customers(int.Parse(M_txt.Text));
                }
                
                wq_txt.Text = d_d.calc_w_q(n).ToString();
            }
        }
        private void btn_Calc_noft(object sender, EventArgs e)
        {
            ep.Clear();
            bool isallValid = true;
            if (time_txt.Text.Trim() == "")
            {
                ep.SetError(time_txt, "enter t");
                isallValid = false;
            }
            if (M_txt.Text.Trim() == ""&&M_initial_panel.Visible==true)
            {
                ep.SetError(M_txt, "enter t");
                isallValid = false;
            }

            if(isallValid)
            {
              
                if (M_initial_panel.Visible)
                {
                    d_d.setNumber_of_initial_customers (int.Parse(M_txt.Text));
                }

                
               
                n_of_t_txt.Text = d_d.calc_n_t(int.Parse(time_txt.Text)).ToString();
                show_Graph();

            }
        }
        
        private void acceptNumOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') )
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void btn_Go_Click(object sender, EventArgs e)
        {
            ep.Clear();
            bool isAllValid = true;
            if (at_txt.Text.Trim() == "")
            {
                ep.SetError(at_txt, "enter arrining time");
                isAllValid = false;
            }
            if (st_txt.Text.Trim() == "")
            {
                ep.SetError(st_txt, "enter servinging time");
                isAllValid = false;
            }
            if (SystemCapcity_txt.Text.Trim() == "" & !infinite_cb.Checked)
            {
                ep.SetError(SystemCapcity_txt, "enter system capcity");
                isAllValid = false;
            }
            if (isAllValid)
            {
                at = Double.Parse(at_txt.Text);
                st = Double.Parse(st_txt.Text);
                is_infinite = infinite_cb.Checked;
                if (!is_infinite)
                    capcity = int.Parse(SystemCapcity_txt.Text);

                    D_output_Panel.Visible = true;

                if (st > at)
                {
                    M_initial_panel.Visible = false;         //   case1:   1/μ > 1/λ
                    if (is_infinite)
                    {  // if system capacity is infinite (K not found)   D/D/1
                      ti_panel.Visible = false;
                        d_d = new D_D(st, at);
                    }
                    else
                    {  // if system capacity is finite (K found)    D/D/1/k-1
                        ti_panel.Visible = true;
                        d_d = new D_D(st, at, capcity);
                        
                    }
                }
                else if (st < at)
                { // case2:   1/μ < 1/λ   // D/D/1/k-1 or D/D/1 the same     //system capacity ignored but initial customers: M is required
                    M_initial_panel.Visible = true;
                   ti_panel.Visible = false;
                    d_d = new D_D(st, at, capcity, num_of_initial_cst);

                }
               
                else if (st == at)
                {
                    M_initial_panel.Visible = true;
                    d_d = new D_D(st, at);
                } 
                d_d.run_system();
                T_i = d_d.getT_i();
                ti_txt.Text = T_i.ToString();

                D_output_Panel.Location = D_Panel.Location;
              
                D_Panel.Visible = false;
            }
                           
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            foreach(Control c in Main_Panel.Controls)
            {
                c.Visible = false;
            }
            a_v_pattern.Visible = true;
            pattern_lbl.Visible = true;
         }

        private void a_v_pattern_SelectedIndexChanged(object sender, EventArgs e)
        {

            M_panel.Location = D_Panel.Location;
            if (a_v_pattern.SelectedIndex == 0)
            {
                D_Panel.Visible = true;
                M_panel.Visible = false;
            }
            if(a_v_pattern.SelectedIndex == 1)
            {
                D_Panel.Visible = false;
                M_panel.Visible = true;

            }

        }

        private void Go_back(object sender, EventArgs e)
        { 
           
          //  btn_back.Text = "back";

          
            D_output_Panel.Visible = false;
            M_output_panel.Visible = false;

            if (a_v_pattern.SelectedIndex == 0)
            {
                D_Panel.Visible = true;
                M_panel.Visible = false;
            }
            if (a_v_pattern.SelectedIndex == 1)
            {
                D_Panel.Visible = false;
                M_panel.Visible = true;

            }
        }

        private void infinite_cb_CheckedChanged(object sender, EventArgs e)
        {
            
                SystemCapcity_txt.Enabled = !infinite_cb.Checked;
            
        }

        private void calc_pn_btn_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (n_pn_txt.Text.Trim() == "")
            {
                ep.SetError(n_txt, "enter n");
            }
            else
            {
                if(NOS==1)
               p_n_txt.Text= String.Format("{0:0.00}", m_m_1.calc_pn(int.Parse(n_pn_txt.Text)));
             
                else
                    p_n_txt.Text = String.Format("{0:0.00}", m_m_c.calc_pn(int.Parse(n_pn_txt.Text)));
            }
         
        }

        private void key_enter_cilck(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==13 && D_Panel.Visible)
            btn_Go_Click(sender, e);
            if (e.KeyValue == 13 && M_panel.Visible)
                Go_M_btn_Click(sender, e);
        }
       
        private void Go_M_btn_Click(object sender, EventArgs e)
        {
            ci_panel.Visible = false;
            p_n_panel.Visible = false;
            ep.Clear();
            bool isAllValid = true;
            if (ar_M_txt.Text.Trim() == "")
            {
                ep.SetError(ar_M_txt, "enter arrining rate");
                isAllValid = false;
            }
            if (sr_M_txt.Text.Trim() == "")
            {
                ep.SetError(sr_M_txt, "enter servinging rate");
                isAllValid = false;
            }
            if (syc_M_txt.Text.Trim() == "" & !syc_M_isinfinite.Checked)
            {
                ep.SetError(syc_M_txt, "enter system capcity");
                isAllValid = false;
            }
            if (NOS_M_txt.Text.Trim() == "" )
            {
                ep.SetError(NOS_M_txt, "enter number of servers");
                isAllValid = false;
            }
            if (isAllValid)
            {
                ar_M = Double.Parse(ar_M_txt.Text);
                sr_M = Double.Parse(sr_M_txt.Text);
                NOS = int.Parse(NOS_M_txt.Text);
                is_infinite = syc_M_isinfinite.Checked;
                if (!is_infinite)
                    capcity = int.Parse(syc_M_txt.Text);
                
                M_output_panel.Location = M_panel.Location;
                M_output_panel.Visible = true;
                M_panel.Visible = false;

                if (NOS == 1)
                {

                    if (is_infinite)
                    {  // if system capacity is infinite (K not found) M/M/1
                        m_m_1 = new M_M_1();
                        m_m_1.setArrival_rate(ar_M);
                        m_m_1.setService_rate(sr_M);
                        m_m_1.run_system();


                        L_txt.Text = String.Format("{0:0.0 }", m_m_1.getL());
                        lq_txt.Text = String.Format("{0:0.00}", m_m_1.getL_q());
                        p0_txt.Text = String.Format("{0:0.00}", m_m_1.getPo());
                        w_txt.Text = String.Format("{0:0.00}", m_m_1.getW());
                        w_q_txt.Text = String.Format("{0:0.00}", m_m_1.getW_q());
                        p_n_panel.Visible = true;
                    }
                    else
                    { // if system capacity is finite (K found) M/M/1/K
                        m_m_1 = new M_M_1();
                        m_m_1.setArrival_rate(ar_M);
                        m_m_1.setService_rate(sr_M);
                        m_m_1.setK(capcity + 1);
                        m_m_1.run_system();

                        L_txt.Text = String.Format("{0:0.00}", m_m_1.getL());
                        lq_txt.Text = String.Format("{0:0.00}",m_m_1.getL_q());
                        p0_txt.Text = String.Format("{0:0.00}", m_m_1.getPo());
                        w_txt.Text = String.Format("{0:0.00}", m_m_1.getW());
                        w_q_txt.Text = String.Format("{0:0.00}", m_m_1.getW_q());
                        p_n_panel.Visible = true;
                    }

                }
                else if (NOS > 1)
                {
                    ci_panel.Visible = true;
                    if (is_infinite)
                    {  // if system capacity is infinite (K not found) M/M/C
                        m_m_c = new M_M_C();
                        m_m_c.setArrival_rate(ar_M);
                        m_m_c.setService_rate(sr_M);
                        m_m_c.setNum_of_parellel_servers(NOS);
                        m_m_c.run_system();

                        L_txt.Text= String.Format("{0:0.00}", m_m_c.getL());
                        lq_txt.Text = String.Format("{0:0.00}", m_m_c.getL_q());
                        p0_txt.Text = String.Format("{0:0.00}", m_m_c.getPo());
                        w_txt.Text = String.Format("{0:0.00}", m_m_c.getW());
                        w_q_txt.Text = String.Format("{0:0.00}", m_m_c.getW_q());
                        ci_txt.Text = String.Format("{0:0.00}", m_m_c.calc_ci());

                        p_n_panel.Visible = true;
                    }
                    else
                    {  // if system capacity is finite (K found)  M/M/C/K
                        m_m_c = new M_M_C();

                        m_m_c.setArrival_rate(ar_M);
                        m_m_c.setService_rate(sr_M);
                        m_m_c.setNum_of_parellel_servers(NOS);
                        m_m_c.setK(capcity);
                        m_m_c.run_system();

                        L_txt.Text = String.Format("{0:0.00}", m_m_c.getL());
                        lq_txt.Text = String.Format("{0:0.00}", m_m_c.getL_q());
                        p0_txt.Text = String.Format("{0:0.00}", m_m_c.getPo());
                        w_txt.Text = String.Format("{0:0.00}", m_m_c.getW());
                       
                        w_q_txt.Text = String.Format("{0:0.00}",m_m_c.getW_q());
                        ci_txt.Text = String.Format("{0:0.00}", m_m_c.calc_ci());
                        p_n_panel.Visible = true;

                    }


                }
                }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        private void show_Graph() {
            chart1.Series["Series1"].Points.Clear();
          
            chart1.Visible = true;
            for (int i = 0; i< 10; i++) {
                chart1.Series["Series1"].Points.AddXY(i,d_d.calc_n_t(i));
            }
       }
    }

}
