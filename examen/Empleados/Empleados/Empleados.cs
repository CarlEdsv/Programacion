using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    class Empleados
    {
        private int id;
        private string nombre;
        private string dui;
        private string codigo;
        private double salario;
        private double afp;
        private double isss;
        private double descuento;
        private double sliquido;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Dui
        {
            get { return dui; }
            set { dui = value; }
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public double Afp
        {
            get { return afp; }
            set { afp = value; }
        }

        public double Isss
        {
            get { return isss; }
            set { isss = value; }
        }

        public double Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }

        public double Sliquido
        {
            get { return sliquido; }
            set { sliquido = value; }
        }
        public double AFP(double Salario)

        {
            double CalcAFP = Salario * 0.075;
            return CalcAFP;
        }

        public double ISSS(double Salario)

        {
            double Calisss = Salario * 0.03;
            return Calisss;
        }

        public double DESCUENTO(double ISSS, double AFP)

        {
            double CalcDescuento = ISSS + AFP;
            return CalcDescuento;
        }
        public double SLIQUIDO(double SALARIO, double DESCUENTO)

        {
            double CalcSliquido = SALARIO - DESCUENTO;
            return CalcSliquido;
        }
    }
}
