using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement
{
    class Cafe
    {

        //Default Constructor
        public Cafe()
        {
            newNesc = 0.0; newHotCh = 0.0; newTee = 0.0; newCoff = 0.0; newWas = 0.0; newCapp = 0.0; newRed = 0.0; newIceTee = 0.0;
            newZin = 0.0; newFaj = 0.0; newHot = 0.0; newFri = 0.0; newExtra = 0.0; newCho = 0.0; newcheeseCak = 0.0; newNp = 0.0;

        }

        //Set Method
        public Cafe(double Nesc, double HotCh, double Tee, double Coff, double Was, double Capp, double Red, double IceTee,
                  double Zin, double Faj, double Hot, double Fri, double Extra, double Cho, double cheeseCak, double Np)
        {
            newNesc = Nesc;
            newHotCh = HotCh;
            newTee = Tee;
            newCoff = Coff;
            newWas = Was;
            newCapp = Capp;
            newRed = Red;
            newIceTee = IceTee;

            newZin = Zin;
            newFaj = Faj;
            newHot = Hot;
            newFri = Fri;
            newExtra = Extra;
            newCho = Cho;
            newcheeseCak = cheeseCak;
            newNp = Np;
        }
        //Drinks
        private double newNesc;
        private double newHotCh;
        private double newTee;
        private double newCoff;
        private double newWas;
        private double newCapp;
        private double newRed;
        private double newIceTee;

        //Food
        private double newZin;
        private double newFaj;
        private double newHot;
        private double newFri;
        private double newExtra;
        private double newCho;
        private double newcheeseCak;
        private double newNp;

        //get Method
        public double getNesc() { return newNesc; }
        public double getHotCh() { return newHotCh; }
        public double getTee() { return newTee; }
        public double getCoff() { return newCoff; }
        public double getWas() { return newWas; }
        public double getCapp() { return newCapp; }
        public double getRed() { return newRed; }
        public double getIceTee() { return newIceTee; }
        public double getZin() { return newZin; }
        public double getFaj() { return newFaj; }
        public double getHot() { return newHot; }
        public double getFri() { return newFri; }
        public double getExtra() { return newExtra; }
        public double getCho() { return newCho; }
        public double getCheCake() { return newcheeseCak; }
        public double getNp() { return newNp; }
    }
}
