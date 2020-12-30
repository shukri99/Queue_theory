using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Project
{
    class M_M_C:M_M
    {

        private int num_of_parellel_servers = 0;  // c:number of parellel servers

        public double getNum_of_parellel_servers()
        {
            return num_of_parellel_servers;
        }

        public void setNum_of_parellel_servers(int num_of_parellel_servers)
        {
            this.num_of_parellel_servers = num_of_parellel_servers;
        }

        private void calc_r()
        {
            setR(base.getArrival_rate() / base.getService_rate());
        }

        private void calc_p()
        {
            setP(base.getR() / num_of_parellel_servers);
        }

        private void calc_po_infinity()
        {
            double first_term_result = 0;
            if (base.getP() < 1)
            {



                for (int i = 0; i <= num_of_parellel_servers - 1; i++)
                {

                    first_term_result += (Math.Pow(base.getR(), i) / factorial(i));

                }

                setPo(1 / (first_term_result
                        + ((num_of_parellel_servers * Math.Pow(base.getR(), num_of_parellel_servers))
                        / factorial(num_of_parellel_servers) * (num_of_parellel_servers - base.getR()))));
            }
            else if (base.getP() >= 1)
            {

                for (int i = 0; i <= num_of_parellel_servers - 1; i++)
                {

                    first_term_result += (1 / factorial(i))
                            * (Math.Pow(base.getR(), i));

                }
                setPo(1 / (first_term_result +
                        ((((1 / factorial(num_of_parellel_servers))
                                * (Math.Pow(base.getR(), num_of_parellel_servers)))
                                * ((num_of_parellel_servers * base.getService_rate())
                                        / (num_of_parellel_servers * base.getService_rate() - base.getArrival_rate()))))));



            }
            else
            {
                setPo(-1);
            }
        }

        private double calc_pn_infinity(int n)
        {
            if (n >= 0 && n < num_of_parellel_servers)
            {

                return (Math.Pow(base.getR(), n) / factorial(n)) * base.getPo();

            }
            else if (n >= num_of_parellel_servers)
            {

                return ((Math.Pow(base.getR(), n)
                        / ((Math.Pow(num_of_parellel_servers, n - num_of_parellel_servers)
                        * factorial(num_of_parellel_servers))) * base.getPo()));

            }
            else
            {
                return -1;// error
            }
        }

        private void calc_Lq_infinity()
        {
            setL_q(((Math.Pow(base.getR(), num_of_parellel_servers + 1) / num_of_parellel_servers)
                            / (factorial(num_of_parellel_servers)
                            * Math.Pow((1 - (base.getR() / num_of_parellel_servers)), 2))) * base.getPo());
        }

        private void calc_l_infinity()
        {
            setL((base.getL_q() + base.getR()));
        }

        private void calc_wq_infinity()
        {
            setW_q(base.getL_q() / base.getArrival_rate());
        }

        private void calc_w_infinity()
        {
            setW(base.getW_q() + base.getService_time());
        }

        private void calc_po_k()
        {
            double first_term_result = 0;
            for (int i = 0; i <= num_of_parellel_servers - 1; i++)
            {
                first_term_result += ((Math.Pow(base.getR(), i)) / (factorial(i)));
            }
            if (base.getP() == 1)
            {
                setPo(1 / (first_term_result
                        + ((Math.Pow(base.getR(), num_of_parellel_servers)
                        / factorial(num_of_parellel_servers))
                        * (base.getK() - num_of_parellel_servers + 1))));
            }
            else
            {
                setPo(1 / (first_term_result
                        + (Math.Pow(base.getR(), num_of_parellel_servers) / factorial(num_of_parellel_servers))
                        * ((1 - Math.Pow(base.getP(), base.getK() - num_of_parellel_servers + 1)) / (1 - base.getP()))));
            }
        }

        private double calc_pn_k(int n)
        {
            if (0 <= n && n < num_of_parellel_servers)
            {

                return ((Math.Pow(base.getR(), n) / factorial(n)) * base.getPo());

            }
            else if (num_of_parellel_servers <= n && n <= base.getK())
            {

                return ((Math.Pow(base.getR(), n)
                        / (Math.Pow(num_of_parellel_servers, n - num_of_parellel_servers)
                        * factorial(num_of_parellel_servers))) * base.getPo());

            }
            else
            {
                return -1;// error
            }
        }

        private void calc_Lq_k()
        {

            setL_q(((base.getP() * Math.Pow(base.getR(), num_of_parellel_servers) * base.getPo())
                            / (factorial(num_of_parellel_servers) * Math.Pow(1 - base.getP(), 2)))
                            * (1 - Math.Pow(base.getP(), base.getK() - num_of_parellel_servers + 1)
                            - ((1 - base.getP()) * (base.getK() - num_of_parellel_servers + 1) * Math.Pow(base.getP(), base.getK() - num_of_parellel_servers))));
        }

        private void calc_l_k()
        {
            int last_term_result = 0;

            for (int i = 0; i <= num_of_parellel_servers - 1; i++)
            {
                last_term_result += (int)((num_of_parellel_servers - i) * (Math.Pow(base.getR(), i) / factorial(i)));
            }


            setL(base.getL_q() + num_of_parellel_servers - base.getPo() * last_term_result);
        }

        private void calc_wq_k()
        {
            setW_q(base.getL_q() / base.getLamda_dash());
        }

        private void calc_w_k()
        {
            setW(base.getL() / base.getLamda_dash());
        }

        private void calc_lamda_dash()
        {
            setLamda_dash(base.getArrival_rate() * (1 - this.calc_pn_k(base.getK())));
        }

        public double calc_pn(int n)
        {
            if (base.getK() == -1)
            {
                return this.calc_pn_infinity(n);

            }
            else
            {
                return this.calc_pn_k(n);

            }
        }
        public double calc_ci()
        {
            Console.WriteLine(num_of_parellel_servers+"\n");
            Console.WriteLine(getR()+"\n");
            return (((double) num_of_parellel_servers - getR()));
        }
        override public void run_system()
        {
            base.run_system();
            this.calc_p();
            this.calc_r();
            this.calc_p();
            if (base.getK() == -1)
            {
                this.calc_po_infinity();
                this.calc_Lq_infinity();
                this.calc_l_infinity();
                this.calc_wq_infinity();
                this.calc_w_infinity();

            }
            else
            {
                this.calc_po_k();
                this.calc_Lq_k();
                this.calc_l_k();
                this.calc_lamda_dash();
                this.calc_wq_k();
                this.calc_w_k();

            }
        }
    }
}
