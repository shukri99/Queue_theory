namespace Queue_Project
{
    partial class frm_Main
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.time_txt = new System.Windows.Forms.TextBox();
            this.st_txt = new System.Windows.Forms.TextBox();
            this.at_txt = new System.Windows.Forms.TextBox();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_crs = new System.Windows.Forms.Label();
            this.lbl_at = new System.Windows.Forms.Label();
            this.n_of_t_txt = new System.Windows.Forms.TextBox();
            this.n_of_t_lbl = new System.Windows.Forms.Label();
            this.SystemCapcity_txt = new System.Windows.Forms.TextBox();
            this.SystemCapcity_lbl = new System.Windows.Forms.Label();
            this.ti_txt = new System.Windows.Forms.TextBox();
            this.ti_lbl = new System.Windows.Forms.Label();
            this.CalcTi_btn = new System.Windows.Forms.Button();
            this.n_txt = new System.Windows.Forms.TextBox();
            this.wq_txt = new System.Windows.Forms.TextBox();
            this.n_lbl = new System.Windows.Forms.Label();
            this.wq_lbl = new System.Windows.Forms.Label();
            this.a_v_pattern = new System.Windows.Forms.ComboBox();
            this.pattern_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.D_Panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.infinite_cb = new System.Windows.Forms.CheckBox();
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.D_output_Panel = new System.Windows.Forms.Panel();
            this.ti_panel = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.calc_n_btn = new System.Windows.Forms.Button();
            this.calc_w_byn = new System.Windows.Forms.Button();
            this.M_initial_panel = new System.Windows.Forms.Panel();
            this.M_txt = new System.Windows.Forms.TextBox();
            this.M_lbl = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.M_output_panel = new System.Windows.Forms.Panel();
            this.p_n_panel = new System.Windows.Forms.Panel();
            this.n_pn_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.p_n_txt = new System.Windows.Forms.TextBox();
            this.calc_pn_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.L_txt = new System.Windows.Forms.TextBox();
            this.l_lbl = new System.Windows.Forms.Label();
            this.p0_txt = new System.Windows.Forms.TextBox();
            this.lq_txt = new System.Windows.Forms.TextBox();
            this.lq_lbl = new System.Windows.Forms.Label();
            this.w_q_txt = new System.Windows.Forms.TextBox();
            this.w_txt = new System.Windows.Forms.TextBox();
            this.p0_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.w_lbl = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.M_panel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.syc_M_isinfinite = new System.Windows.Forms.CheckBox();
            this.Go_M_btn = new System.Windows.Forms.Button();
            this.sr_M_txt = new System.Windows.Forms.TextBox();
            this.ar_M_txt = new System.Windows.Forms.TextBox();
            this.NOS_M_txt = new System.Windows.Forms.TextBox();
            this.syc_M_txt = new System.Windows.Forms.TextBox();
            this.sr_M_lbl = new System.Windows.Forms.Label();
            this.NOS_M_lbl = new System.Windows.Forms.Label();
            this.syc_M_lbl = new System.Windows.Forms.Label();
            this.ar_M_lbl = new System.Windows.Forms.Label();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.ci_panel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.ci_txt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.D_Panel.SuspendLayout();
            this.Main_Panel.SuspendLayout();
            this.D_output_Panel.SuspendLayout();
            this.ti_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel3.SuspendLayout();
            this.M_initial_panel.SuspendLayout();
            this.M_output_panel.SuspendLayout();
            this.p_n_panel.SuspendLayout();
            this.panel7.SuspendLayout();
            this.M_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.ci_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // time_txt
            // 
            this.time_txt.BackColor = System.Drawing.Color.White;
            this.time_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.time_txt.Location = new System.Drawing.Point(100, 37);
            this.time_txt.Name = "time_txt";
            this.time_txt.Size = new System.Drawing.Size(100, 36);
            this.time_txt.TabIndex = 0;
            this.time_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.acceptNumOnly);
            // 
            // st_txt
            // 
            this.st_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.st_txt.Location = new System.Drawing.Point(270, 4);
            this.st_txt.Name = "st_txt";
            this.st_txt.Size = new System.Drawing.Size(100, 36);
            this.st_txt.TabIndex = 0;
            this.st_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_enter_cilck);
            this.st_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.acceptNumOnly);
            // 
            // at_txt
            // 
            this.at_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.at_txt.Location = new System.Drawing.Point(270, 85);
            this.at_txt.Name = "at_txt";
            this.at_txt.Size = new System.Drawing.Size(100, 36);
            this.at_txt.TabIndex = 0;
            this.at_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_enter_cilck);
            this.at_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.acceptNumOnly);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(21, 40);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(26, 38);
            this.lbl_time.TabIndex = 1;
            this.lbl_time.Text = "t";
            // 
            // lbl_crs
            // 
            this.lbl_crs.AutoSize = true;
            this.lbl_crs.Location = new System.Drawing.Point(4, 9);
            this.lbl_crs.Name = "lbl_crs";
            this.lbl_crs.Size = new System.Drawing.Size(178, 38);
            this.lbl_crs.TabIndex = 1;
            this.lbl_crs.Text = "Serving Time";
            // 
            // lbl_at
            // 
            this.lbl_at.AutoSize = true;
            this.lbl_at.Location = new System.Drawing.Point(4, 90);
            this.lbl_at.Name = "lbl_at";
            this.lbl_at.Size = new System.Drawing.Size(183, 38);
            this.lbl_at.TabIndex = 1;
            this.lbl_at.Text = "Arriving Time";
            // 
            // n_of_t_txt
            // 
            this.n_of_t_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.n_of_t_txt.Location = new System.Drawing.Point(100, 101);
            this.n_of_t_txt.Name = "n_of_t_txt";
            this.n_of_t_txt.ReadOnly = true;
            this.n_of_t_txt.Size = new System.Drawing.Size(268, 36);
            this.n_of_t_txt.TabIndex = 0;
            // 
            // n_of_t_lbl
            // 
            this.n_of_t_lbl.AutoSize = true;
            this.n_of_t_lbl.Location = new System.Drawing.Point(14, 99);
            this.n_of_t_lbl.Name = "n_of_t_lbl";
            this.n_of_t_lbl.Size = new System.Drawing.Size(58, 38);
            this.n_of_t_lbl.TabIndex = 1;
            this.n_of_t_lbl.Text = "n(t)";
            // 
            // SystemCapcity_txt
            // 
            this.SystemCapcity_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SystemCapcity_txt.Location = new System.Drawing.Point(270, 171);
            this.SystemCapcity_txt.Name = "SystemCapcity_txt";
            this.SystemCapcity_txt.Size = new System.Drawing.Size(100, 36);
            this.SystemCapcity_txt.TabIndex = 0;
            this.SystemCapcity_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_enter_cilck);
            this.SystemCapcity_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.acceptNumOnly);
            // 
            // SystemCapcity_lbl
            // 
            this.SystemCapcity_lbl.AutoSize = true;
            this.SystemCapcity_lbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemCapcity_lbl.Location = new System.Drawing.Point(3, 179);
            this.SystemCapcity_lbl.Name = "SystemCapcity_lbl";
            this.SystemCapcity_lbl.Size = new System.Drawing.Size(176, 32);
            this.SystemCapcity_lbl.TabIndex = 1;
            this.SystemCapcity_lbl.Text = "System Capcity";
            // 
            // ti_txt
            // 
            this.ti_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ti_txt.Location = new System.Drawing.Point(79, 26);
            this.ti_txt.Name = "ti_txt";
            this.ti_txt.ReadOnly = true;
            this.ti_txt.Size = new System.Drawing.Size(268, 36);
            this.ti_txt.TabIndex = 0;
            // 
            // ti_lbl
            // 
            this.ti_lbl.AutoSize = true;
            this.ti_lbl.Location = new System.Drawing.Point(32, 21);
            this.ti_lbl.Name = "ti_lbl";
            this.ti_lbl.Size = new System.Drawing.Size(33, 38);
            this.ti_lbl.TabIndex = 1;
            this.ti_lbl.Text = "ti";
            // 
            // CalcTi_btn
            // 
            this.CalcTi_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.CalcTi_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CalcTi_btn.FlatAppearance.BorderSize = 0;
            this.CalcTi_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CalcTi_btn.ForeColor = System.Drawing.Color.White;
            this.CalcTi_btn.Location = new System.Drawing.Point(11, 230);
            this.CalcTi_btn.Name = "CalcTi_btn";
            this.CalcTi_btn.Size = new System.Drawing.Size(359, 40);
            this.CalcTi_btn.TabIndex = 2;
            this.CalcTi_btn.Text = "Go";
            this.CalcTi_btn.UseVisualStyleBackColor = false;
            this.CalcTi_btn.Click += new System.EventHandler(this.btn_Go_Click);
            this.CalcTi_btn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_enter_cilck);
            // 
            // n_txt
            // 
            this.n_txt.BackColor = System.Drawing.Color.White;
            this.n_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.n_txt.Location = new System.Drawing.Point(100, 151);
            this.n_txt.Name = "n_txt";
            this.n_txt.Size = new System.Drawing.Size(100, 36);
            this.n_txt.TabIndex = 0;
            this.n_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.acceptNumOnly);
            // 
            // wq_txt
            // 
            this.wq_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wq_txt.Location = new System.Drawing.Point(100, 207);
            this.wq_txt.Name = "wq_txt";
            this.wq_txt.ReadOnly = true;
            this.wq_txt.Size = new System.Drawing.Size(268, 36);
            this.wq_txt.TabIndex = 0;
            // 
            // n_lbl
            // 
            this.n_lbl.AutoSize = true;
            this.n_lbl.Location = new System.Drawing.Point(28, 156);
            this.n_lbl.Name = "n_lbl";
            this.n_lbl.Size = new System.Drawing.Size(33, 38);
            this.n_lbl.TabIndex = 1;
            this.n_lbl.Text = "n";
            // 
            // wq_lbl
            // 
            this.wq_lbl.AutoSize = true;
            this.wq_lbl.Location = new System.Drawing.Point(14, 207);
            this.wq_lbl.Name = "wq_lbl";
            this.wq_lbl.Size = new System.Drawing.Size(90, 38);
            this.wq_lbl.TabIndex = 1;
            this.wq_lbl.Text = "Wq(n)";
            // 
            // a_v_pattern
            // 
            this.a_v_pattern.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.a_v_pattern.FormattingEnabled = true;
            this.a_v_pattern.Items.AddRange(new object[] {
            "D",
            "M"});
            this.a_v_pattern.Location = new System.Drawing.Point(311, 15);
            this.a_v_pattern.Name = "a_v_pattern";
            this.a_v_pattern.Size = new System.Drawing.Size(100, 45);
            this.a_v_pattern.TabIndex = 3;
            this.a_v_pattern.SelectedIndexChanged += new System.EventHandler(this.a_v_pattern_SelectedIndexChanged);
            // 
            // pattern_lbl
            // 
            this.pattern_lbl.AutoSize = true;
            this.pattern_lbl.Location = new System.Drawing.Point(45, 18);
            this.pattern_lbl.Name = "pattern_lbl";
            this.pattern_lbl.Size = new System.Drawing.Size(313, 38);
            this.pattern_lbl.TabIndex = 1;
            this.pattern_lbl.Text = "Serving/Arriving Pattern";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 96);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "Queuing Theory";
            // 
            // D_Panel
            // 
            this.D_Panel.Controls.Add(this.panel2);
            this.D_Panel.Controls.Add(this.infinite_cb);
            this.D_Panel.Controls.Add(this.CalcTi_btn);
            this.D_Panel.Controls.Add(this.st_txt);
            this.D_Panel.Controls.Add(this.at_txt);
            this.D_Panel.Controls.Add(this.SystemCapcity_txt);
            this.D_Panel.Controls.Add(this.lbl_crs);
            this.D_Panel.Controls.Add(this.SystemCapcity_lbl);
            this.D_Panel.Controls.Add(this.lbl_at);
            this.D_Panel.Location = new System.Drawing.Point(38, 66);
            this.D_Panel.Name = "D_Panel";
            this.D_Panel.Size = new System.Drawing.Size(397, 291);
            this.D_Panel.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(376, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 273);
            this.panel2.TabIndex = 4;
            // 
            // infinite_cb
            // 
            this.infinite_cb.AutoSize = true;
            this.infinite_cb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.infinite_cb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infinite_cb.Location = new System.Drawing.Point(178, 182);
            this.infinite_cb.Name = "infinite_cb";
            this.infinite_cb.Size = new System.Drawing.Size(86, 32);
            this.infinite_cb.TabIndex = 3;
            this.infinite_cb.Text = "infnite";
            this.infinite_cb.UseVisualStyleBackColor = true;
            this.infinite_cb.CheckedChanged += new System.EventHandler(this.infinite_cb_CheckedChanged);
            // 
            // Main_Panel
            // 
            this.Main_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(34)))), ((int)(((byte)(77)))));
            this.Main_Panel.Controls.Add(this.D_output_Panel);
            this.Main_Panel.Controls.Add(this.M_output_panel);
            this.Main_Panel.Controls.Add(this.a_v_pattern);
            this.Main_Panel.Controls.Add(this.M_panel);
            this.Main_Panel.Controls.Add(this.D_Panel);
            this.Main_Panel.Controls.Add(this.pattern_lbl);
            this.Main_Panel.ForeColor = System.Drawing.Color.White;
            this.Main_Panel.Location = new System.Drawing.Point(-4, 97);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(1012, 909);
            this.Main_Panel.TabIndex = 6;
            // 
            // D_output_Panel
            // 
            this.D_output_Panel.Controls.Add(this.ti_panel);
            this.D_output_Panel.Controls.Add(this.chart1);
            this.D_output_Panel.Controls.Add(this.panel3);
            this.D_output_Panel.Controls.Add(this.M_initial_panel);
            this.D_output_Panel.Controls.Add(this.btn_back);
            this.D_output_Panel.Location = new System.Drawing.Point(673, 668);
            this.D_output_Panel.Name = "D_output_Panel";
            this.D_output_Panel.Size = new System.Drawing.Size(511, 720);
            this.D_output_Panel.TabIndex = 7;
            // 
            // ti_panel
            // 
            this.ti_panel.Controls.Add(this.ti_lbl);
            this.ti_panel.Controls.Add(this.ti_txt);
            this.ti_panel.Location = new System.Drawing.Point(34, 56);
            this.ti_panel.Name = "ti_panel";
            this.ti_panel.Size = new System.Drawing.Size(431, 59);
            this.ti_panel.TabIndex = 3;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Area3DStyle.WallWidth = 10;
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.SharpTriangle;
            chartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.BorderWidth = 5;
            chartArea1.IsSameFontSizeForAllAxes = true;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(22, 394);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BorderColor = System.Drawing.Color.Blue;
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            series1.LabelBorderColor = System.Drawing.Color.Blue;
            series1.LabelBorderWidth = 2;
            series1.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.MarkerColor = System.Drawing.Color.Blue;
            series1.Name = "Series1";
            series1.ShadowColor = System.Drawing.Color.White;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(443, 121);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.time_txt);
            this.panel3.Controls.Add(this.lbl_time);
            this.panel3.Controls.Add(this.n_txt);
            this.panel3.Controls.Add(this.n_of_t_txt);
            this.panel3.Controls.Add(this.calc_n_btn);
            this.panel3.Controls.Add(this.calc_w_byn);
            this.panel3.Controls.Add(this.n_of_t_lbl);
            this.panel3.Controls.Add(this.wq_txt);
            this.panel3.Controls.Add(this.n_lbl);
            this.panel3.Controls.Add(this.wq_lbl);
            this.panel3.Location = new System.Drawing.Point(37, 124);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(459, 264);
            this.panel3.TabIndex = 4;
            // 
            // calc_n_btn
            // 
            this.calc_n_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.calc_n_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.calc_n_btn.FlatAppearance.BorderSize = 0;
            this.calc_n_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calc_n_btn.ForeColor = System.Drawing.Color.White;
            this.calc_n_btn.Location = new System.Drawing.Point(214, 40);
            this.calc_n_btn.Name = "calc_n_btn";
            this.calc_n_btn.Size = new System.Drawing.Size(154, 40);
            this.calc_n_btn.TabIndex = 2;
            this.calc_n_btn.Text = "Calc n(t)";
            this.calc_n_btn.UseVisualStyleBackColor = false;
            this.calc_n_btn.Click += new System.EventHandler(this.btn_Calc_noft);
            // 
            // calc_w_byn
            // 
            this.calc_w_byn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.calc_w_byn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.calc_w_byn.FlatAppearance.BorderSize = 0;
            this.calc_w_byn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calc_w_byn.ForeColor = System.Drawing.Color.White;
            this.calc_w_byn.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.calc_w_byn.Location = new System.Drawing.Point(214, 152);
            this.calc_w_byn.Name = "calc_w_byn";
            this.calc_w_byn.Size = new System.Drawing.Size(154, 40);
            this.calc_w_byn.TabIndex = 2;
            this.calc_w_byn.Text = "Calc wq(n)";
            this.calc_w_byn.UseVisualStyleBackColor = false;
            this.calc_w_byn.Click += new System.EventHandler(this.btn_Calc_wq);
            // 
            // M_initial_panel
            // 
            this.M_initial_panel.Controls.Add(this.M_txt);
            this.M_initial_panel.Controls.Add(this.M_lbl);
            this.M_initial_panel.Location = new System.Drawing.Point(81, 3);
            this.M_initial_panel.Name = "M_initial_panel";
            this.M_initial_panel.Size = new System.Drawing.Size(347, 46);
            this.M_initial_panel.TabIndex = 3;
            // 
            // M_txt
            // 
            this.M_txt.BackColor = System.Drawing.Color.White;
            this.M_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.M_txt.Location = new System.Drawing.Point(100, 3);
            this.M_txt.Name = "M_txt";
            this.M_txt.Size = new System.Drawing.Size(100, 36);
            this.M_txt.TabIndex = 0;
            this.M_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_enter_cilck);
            this.M_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.acceptNumOnly);
            // 
            // M_lbl
            // 
            this.M_lbl.AutoSize = true;
            this.M_lbl.Location = new System.Drawing.Point(3, 6);
            this.M_lbl.Name = "M_lbl";
            this.M_lbl.Size = new System.Drawing.Size(42, 38);
            this.M_lbl.TabIndex = 1;
            this.M_lbl.Text = "M";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.btn_back.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(7, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(68, 40);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.Go_back);
            // 
            // M_output_panel
            // 
            this.M_output_panel.Controls.Add(this.ci_panel);
            this.M_output_panel.Controls.Add(this.p_n_panel);
            this.M_output_panel.Controls.Add(this.panel7);
            this.M_output_panel.Controls.Add(this.button3);
            this.M_output_panel.Location = new System.Drawing.Point(476, 18);
            this.M_output_panel.Name = "M_output_panel";
            this.M_output_panel.Size = new System.Drawing.Size(404, 558);
            this.M_output_panel.TabIndex = 7;
            // 
            // p_n_panel
            // 
            this.p_n_panel.Controls.Add(this.n_pn_txt);
            this.p_n_panel.Controls.Add(this.label3);
            this.p_n_panel.Controls.Add(this.p_n_txt);
            this.p_n_panel.Controls.Add(this.calc_pn_btn);
            this.p_n_panel.Controls.Add(this.label4);
            this.p_n_panel.Location = new System.Drawing.Point(27, 418);
            this.p_n_panel.Name = "p_n_panel";
            this.p_n_panel.Size = new System.Drawing.Size(363, 113);
            this.p_n_panel.TabIndex = 5;
            this.p_n_panel.Visible = false;
            // 
            // n_pn_txt
            // 
            this.n_pn_txt.BackColor = System.Drawing.Color.White;
            this.n_pn_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.n_pn_txt.Location = new System.Drawing.Point(90, 3);
            this.n_pn_txt.Name = "n_pn_txt";
            this.n_pn_txt.Size = new System.Drawing.Size(100, 36);
            this.n_pn_txt.TabIndex = 3;
            this.n_pn_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.acceptNumOnly);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "n";
            // 
            // p_n_txt
            // 
            this.p_n_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p_n_txt.Location = new System.Drawing.Point(90, 67);
            this.p_n_txt.Name = "p_n_txt";
            this.p_n_txt.ReadOnly = true;
            this.p_n_txt.Size = new System.Drawing.Size(268, 36);
            this.p_n_txt.TabIndex = 4;
            // 
            // calc_pn_btn
            // 
            this.calc_pn_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.calc_pn_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.calc_pn_btn.FlatAppearance.BorderSize = 0;
            this.calc_pn_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calc_pn_btn.ForeColor = System.Drawing.Color.White;
            this.calc_pn_btn.Location = new System.Drawing.Point(204, 6);
            this.calc_pn_btn.Name = "calc_pn_btn";
            this.calc_pn_btn.Size = new System.Drawing.Size(154, 40);
            this.calc_pn_btn.TabIndex = 7;
            this.calc_pn_btn.Text = "Calc p(n)";
            this.calc_pn_btn.UseVisualStyleBackColor = false;
            this.calc_pn_btn.Click += new System.EventHandler(this.calc_pn_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 38);
            this.label4.TabIndex = 6;
            this.label4.Text = "p(n)";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.L_txt);
            this.panel7.Controls.Add(this.l_lbl);
            this.panel7.Controls.Add(this.p0_txt);
            this.panel7.Controls.Add(this.lq_txt);
            this.panel7.Controls.Add(this.lq_lbl);
            this.panel7.Controls.Add(this.w_q_txt);
            this.panel7.Controls.Add(this.w_txt);
            this.panel7.Controls.Add(this.p0_lbl);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.w_lbl);
            this.panel7.Location = new System.Drawing.Point(19, 68);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(459, 289);
            this.panel7.TabIndex = 4;
            // 
            // L_txt
            // 
            this.L_txt.BackColor = System.Drawing.Color.White;
            this.L_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.L_txt.Location = new System.Drawing.Point(100, 8);
            this.L_txt.Name = "L_txt";
            this.L_txt.ReadOnly = true;
            this.L_txt.Size = new System.Drawing.Size(268, 36);
            this.L_txt.TabIndex = 0;
            this.L_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.acceptNumOnly);
            // 
            // l_lbl
            // 
            this.l_lbl.AutoSize = true;
            this.l_lbl.Location = new System.Drawing.Point(21, 11);
            this.l_lbl.Name = "l_lbl";
            this.l_lbl.Size = new System.Drawing.Size(30, 38);
            this.l_lbl.TabIndex = 1;
            this.l_lbl.Text = "L";
            // 
            // p0_txt
            // 
            this.p0_txt.BackColor = System.Drawing.Color.White;
            this.p0_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p0_txt.Location = new System.Drawing.Point(100, 122);
            this.p0_txt.Name = "p0_txt";
            this.p0_txt.ReadOnly = true;
            this.p0_txt.Size = new System.Drawing.Size(268, 36);
            this.p0_txt.TabIndex = 0;
            this.p0_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.acceptNumOnly);
            // 
            // lq_txt
            // 
            this.lq_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lq_txt.Location = new System.Drawing.Point(100, 72);
            this.lq_txt.Name = "lq_txt";
            this.lq_txt.ReadOnly = true;
            this.lq_txt.Size = new System.Drawing.Size(268, 36);
            this.lq_txt.TabIndex = 0;
            // 
            // lq_lbl
            // 
            this.lq_lbl.AutoSize = true;
            this.lq_lbl.Location = new System.Drawing.Point(14, 70);
            this.lq_lbl.Name = "lq_lbl";
            this.lq_lbl.Size = new System.Drawing.Size(46, 38);
            this.lq_lbl.TabIndex = 1;
            this.lq_lbl.Text = "Lq";
            // 
            // w_q_txt
            // 
            this.w_q_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.w_q_txt.Location = new System.Drawing.Point(100, 238);
            this.w_q_txt.Name = "w_q_txt";
            this.w_q_txt.ReadOnly = true;
            this.w_q_txt.Size = new System.Drawing.Size(268, 36);
            this.w_q_txt.TabIndex = 0;
            // 
            // w_txt
            // 
            this.w_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.w_txt.Location = new System.Drawing.Point(100, 178);
            this.w_txt.Name = "w_txt";
            this.w_txt.ReadOnly = true;
            this.w_txt.Size = new System.Drawing.Size(268, 36);
            this.w_txt.TabIndex = 0;
            // 
            // p0_lbl
            // 
            this.p0_lbl.AutoSize = true;
            this.p0_lbl.Location = new System.Drawing.Point(14, 125);
            this.p0_lbl.Name = "p0_lbl";
            this.p0_lbl.Size = new System.Drawing.Size(48, 38);
            this.p0_lbl.TabIndex = 1;
            this.p0_lbl.Text = "p0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wq";
            // 
            // w_lbl
            // 
            this.w_lbl.AutoSize = true;
            this.w_lbl.Location = new System.Drawing.Point(14, 178);
            this.w_lbl.Name = "w_lbl";
            this.w_lbl.Size = new System.Drawing.Size(43, 38);
            this.w_lbl.TabIndex = 1;
            this.w_lbl.Text = "W";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(7, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Go_back);
            // 
            // M_panel
            // 
            this.M_panel.Controls.Add(this.panel5);
            this.M_panel.Controls.Add(this.syc_M_isinfinite);
            this.M_panel.Controls.Add(this.Go_M_btn);
            this.M_panel.Controls.Add(this.sr_M_txt);
            this.M_panel.Controls.Add(this.ar_M_txt);
            this.M_panel.Controls.Add(this.NOS_M_txt);
            this.M_panel.Controls.Add(this.syc_M_txt);
            this.M_panel.Controls.Add(this.sr_M_lbl);
            this.M_panel.Controls.Add(this.NOS_M_lbl);
            this.M_panel.Controls.Add(this.syc_M_lbl);
            this.M_panel.Controls.Add(this.ar_M_lbl);
            this.M_panel.Location = new System.Drawing.Point(38, 373);
            this.M_panel.Name = "M_panel";
            this.M_panel.Size = new System.Drawing.Size(397, 371);
            this.M_panel.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(376, 101);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(291, 273);
            this.panel5.TabIndex = 4;
            // 
            // syc_M_isinfinite
            // 
            this.syc_M_isinfinite.AutoSize = true;
            this.syc_M_isinfinite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.syc_M_isinfinite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.syc_M_isinfinite.Location = new System.Drawing.Point(180, 158);
            this.syc_M_isinfinite.Name = "syc_M_isinfinite";
            this.syc_M_isinfinite.Size = new System.Drawing.Size(86, 32);
            this.syc_M_isinfinite.TabIndex = 3;
            this.syc_M_isinfinite.Text = "infnite";
            this.syc_M_isinfinite.UseVisualStyleBackColor = true;
            this.syc_M_isinfinite.CheckedChanged += new System.EventHandler(this.infinite_cb_CheckedChanged);
            // 
            // Go_M_btn
            // 
            this.Go_M_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.Go_M_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Go_M_btn.FlatAppearance.BorderSize = 0;
            this.Go_M_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Go_M_btn.ForeColor = System.Drawing.Color.White;
            this.Go_M_btn.Location = new System.Drawing.Point(9, 283);
            this.Go_M_btn.Name = "Go_M_btn";
            this.Go_M_btn.Size = new System.Drawing.Size(359, 40);
            this.Go_M_btn.TabIndex = 2;
            this.Go_M_btn.Text = "Go";
            this.Go_M_btn.UseVisualStyleBackColor = false;
            this.Go_M_btn.Click += new System.EventHandler(this.Go_M_btn_Click);
            this.Go_M_btn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_enter_cilck);
            // 
            // sr_M_txt
            // 
            this.sr_M_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sr_M_txt.Location = new System.Drawing.Point(270, 4);
            this.sr_M_txt.Name = "sr_M_txt";
            this.sr_M_txt.Size = new System.Drawing.Size(100, 36);
            this.sr_M_txt.TabIndex = 0;
            this.sr_M_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_enter_cilck);
            this.sr_M_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.acceptNumOnly);
            // 
            // ar_M_txt
            // 
            this.ar_M_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ar_M_txt.Location = new System.Drawing.Point(270, 85);
            this.ar_M_txt.Name = "ar_M_txt";
            this.ar_M_txt.Size = new System.Drawing.Size(100, 36);
            this.ar_M_txt.TabIndex = 0;
            this.ar_M_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_enter_cilck);
            this.ar_M_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.acceptNumOnly);
            // 
            // NOS_M_txt
            // 
            this.NOS_M_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NOS_M_txt.Location = new System.Drawing.Point(268, 207);
            this.NOS_M_txt.Name = "NOS_M_txt";
            this.NOS_M_txt.Size = new System.Drawing.Size(100, 36);
            this.NOS_M_txt.TabIndex = 0;
            this.NOS_M_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_enter_cilck);
            this.NOS_M_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.acceptNumOnly);
            // 
            // syc_M_txt
            // 
            this.syc_M_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.syc_M_txt.Location = new System.Drawing.Point(270, 154);
            this.syc_M_txt.Name = "syc_M_txt";
            this.syc_M_txt.Size = new System.Drawing.Size(100, 36);
            this.syc_M_txt.TabIndex = 0;
            this.syc_M_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_enter_cilck);
            this.syc_M_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.acceptNumOnly);
            // 
            // sr_M_lbl
            // 
            this.sr_M_lbl.AutoSize = true;
            this.sr_M_lbl.Location = new System.Drawing.Point(4, 9);
            this.sr_M_lbl.Name = "sr_M_lbl";
            this.sr_M_lbl.Size = new System.Drawing.Size(172, 38);
            this.sr_M_lbl.TabIndex = 1;
            this.sr_M_lbl.Text = "Serving Rate";
            // 
            // NOS_M_lbl
            // 
            this.NOS_M_lbl.AutoSize = true;
            this.NOS_M_lbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOS_M_lbl.Location = new System.Drawing.Point(5, 207);
            this.NOS_M_lbl.Name = "NOS_M_lbl";
            this.NOS_M_lbl.Size = new System.Drawing.Size(216, 32);
            this.NOS_M_lbl.TabIndex = 1;
            this.NOS_M_lbl.Text = "Number of Servers";
            // 
            // syc_M_lbl
            // 
            this.syc_M_lbl.AutoSize = true;
            this.syc_M_lbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.syc_M_lbl.Location = new System.Drawing.Point(5, 155);
            this.syc_M_lbl.Name = "syc_M_lbl";
            this.syc_M_lbl.Size = new System.Drawing.Size(176, 32);
            this.syc_M_lbl.TabIndex = 1;
            this.syc_M_lbl.Text = "System Capcity";
            // 
            // ar_M_lbl
            // 
            this.ar_M_lbl.AutoSize = true;
            this.ar_M_lbl.Location = new System.Drawing.Point(4, 90);
            this.ar_M_lbl.Name = "ar_M_lbl";
            this.ar_M_lbl.Size = new System.Drawing.Size(177, 38);
            this.ar_M_lbl.TabIndex = 1;
            this.ar_M_lbl.Text = "Arriving Rate";
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // ci_panel
            // 
            this.ci_panel.Controls.Add(this.label5);
            this.ci_panel.Controls.Add(this.ci_txt);
            this.ci_panel.Location = new System.Drawing.Point(27, 359);
            this.ci_panel.Name = "ci_panel";
            this.ci_panel.Size = new System.Drawing.Size(377, 53);
            this.ci_panel.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 38);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ci";
            // 
            // ci_txt
            // 
            this.ci_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ci_txt.Location = new System.Drawing.Point(93, 5);
            this.ci_txt.Name = "ci_txt";
            this.ci_txt.ReadOnly = true;
            this.ci_txt.Size = new System.Drawing.Size(268, 36);
            this.ci_txt.TabIndex = 0;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(34)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(462, 673);
            this.Controls.Add(this.Main_Panel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(70)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Queue";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.D_Panel.ResumeLayout(false);
            this.D_Panel.PerformLayout();
            this.Main_Panel.ResumeLayout(false);
            this.Main_Panel.PerformLayout();
            this.D_output_Panel.ResumeLayout(false);
            this.ti_panel.ResumeLayout(false);
            this.ti_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.M_initial_panel.ResumeLayout(false);
            this.M_initial_panel.PerformLayout();
            this.M_output_panel.ResumeLayout(false);
            this.p_n_panel.ResumeLayout(false);
            this.p_n_panel.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.M_panel.ResumeLayout(false);
            this.M_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ci_panel.ResumeLayout(false);
            this.ci_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox time_txt;
        private System.Windows.Forms.TextBox st_txt;
        private System.Windows.Forms.TextBox at_txt;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_crs;
        private System.Windows.Forms.Label lbl_at;
        private System.Windows.Forms.TextBox n_of_t_txt;
        private System.Windows.Forms.Label n_of_t_lbl;
        private System.Windows.Forms.TextBox SystemCapcity_txt;
        private System.Windows.Forms.Label SystemCapcity_lbl;
        private System.Windows.Forms.TextBox ti_txt;
        private System.Windows.Forms.Label ti_lbl;
        private System.Windows.Forms.Button CalcTi_btn;
        private System.Windows.Forms.TextBox n_txt;
        private System.Windows.Forms.TextBox wq_txt;
        private System.Windows.Forms.Label n_lbl;
        private System.Windows.Forms.Label wq_lbl;
        private System.Windows.Forms.ComboBox a_v_pattern;
        private System.Windows.Forms.Label pattern_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel D_Panel;
        private System.Windows.Forms.Panel Main_Panel;
        private System.Windows.Forms.Panel D_output_Panel;
        private System.Windows.Forms.Button calc_n_btn;
        private System.Windows.Forms.Button calc_w_byn;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.CheckBox infinite_cb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel M_initial_panel;
        private System.Windows.Forms.TextBox M_txt;
        private System.Windows.Forms.Label M_lbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel ti_panel;
        private System.Windows.Forms.Panel M_panel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox syc_M_isinfinite;
        private System.Windows.Forms.Button Go_M_btn;
        private System.Windows.Forms.TextBox sr_M_txt;
        private System.Windows.Forms.TextBox ar_M_txt;
        private System.Windows.Forms.TextBox syc_M_txt;
        private System.Windows.Forms.Label sr_M_lbl;
        private System.Windows.Forms.Label syc_M_lbl;
        private System.Windows.Forms.Label ar_M_lbl;
        private System.Windows.Forms.TextBox NOS_M_txt;
        private System.Windows.Forms.Label NOS_M_lbl;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel M_output_panel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox L_txt;
        private System.Windows.Forms.Label l_lbl;
        private System.Windows.Forms.TextBox p0_txt;
        private System.Windows.Forms.TextBox lq_txt;
        private System.Windows.Forms.Label lq_lbl;
        private System.Windows.Forms.TextBox w_q_txt;
        private System.Windows.Forms.TextBox w_txt;
        private System.Windows.Forms.Label p0_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label w_lbl;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel p_n_panel;
        private System.Windows.Forms.TextBox n_pn_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox p_n_txt;
        private System.Windows.Forms.Button calc_pn_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel ci_panel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ci_txt;
    }
}

