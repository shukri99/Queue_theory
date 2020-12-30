using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Project
{
    class M_M_1 : M_M
    {
        public M_M_1() : base()
        {

        }


        private void calc_p()
        {
            base.setP(base.getArrival_rate() / base.getService_rate());
        }
        public double calc_pn(int n)
        {
            if (base.getK() == -1)
            {
                return calc_pn_infinity(n);
            }
            else
            {
                return calc_pn_k(n);

            }
        }

        private void calc_po_infinity()
        {
            this.calc_p();
            base.setPo(1 - base.getP());
        }

        double calc_pn_infinity(int n)
        {
            return (Math.Pow(base.getP(), n) * (1 - base.getP()));
        }

        private void calc_Lq_infinity()
        {
            base.setL_q(base.getArrival_rate() * base.getW_q());
        }

        private void calc_l_infinity()
        {

            base.setL(base.getArrival_rate() * base.getW());
        }

        private void calc_wq_infinity()
        {
            base.setW_q((base.getArrival_rate()) / (base.getService_rate() * (base.getService_rate() - base.getArrival_rate())));
        }

        private void calc_w_infinity()
        {
            base.setW(1 / (base.getService_rate() - base.getArrival_rate()));
        }

        private void calc_po_k()
        {
            this.calc_p();
            if (base.getP() == 1)
            {
                setPo(1 / (base.getK() + 1));
            }
            else
            {
                base.setPo((1 - base.getP()) / (1 - Math.Pow(base.getP(), base.getK() + 1)));
            }
        }

        double calc_pn_k(int n)
        {
            if (base.getP() == 1)
            {
                return base.getPo();
            }
            else
            {
                return (Math.Pow(base.getP(), n) * base.getPo());
            }
        }

        private void calc_Lq_k()
        {
            base.setL_q(base.getL() - base.getP() * (1 - calc_pn_k(base.getK())));

        }

        private void calc_l_k()
        {
            if (base.getP() == 1)
            {
                base.setL(base.getK() / 2);
            }
            else
            {
                base.setL(base.getP() * ((1 - (Math.Pow(base.getP(), base.getK()) * (base.getK() + 1)) + (base.getK() * Math.Pow(base.getP(), base.getK() + 1))) / ((1 - base.getP()) * (1 - Math.Pow(base.getP(), base.getK() + 1)))));
            }
        }

        private void calc_wq_k()
        {
            base.setW_q((base.getW() * base.getService_rate() - 1) / base.getService_rate());
        }

        private void calc_w_k()
        {

            base.setW(getL() / base.getLamda_dash());
        }

        private void calc_lamda_dash()
        {
            base.setLamda_dash(base.getArrival_rate() * (1 - this.calc_pn_k(getK())));
        }


        override public void run_system()
        {
            base.run_system();
            this.calc_p();
            if (base.getK() == -1)
            {
                this.calc_po_infinity();
                this.calc_w_infinity();
                this.calc_wq_infinity();
                this.calc_l_infinity();
                this.calc_Lq_infinity();




            }
            else
            {

                this.calc_po_k();
                this.calc_l_k();
                this.calc_Lq_k();
                this.calc_lamda_dash();
                this.calc_w_k();
                this.calc_wq_k();

            }
        }
    }
}
