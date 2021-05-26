using System;

namespace figuras
{
    abstract class figuras
    {
        private float ccirculo;
        private float ccuadrado;
        private float crectangulo;
        private float ctriangulo;
        private float celipse;

        public float Ccirculo
        {
            get { return this.ccirculo; }
            set { this.ccirculo = value; }
        }
        public float Ccuadrado
        {
            get { return this.ccuadrado; }
            set { this.ccuadrado = value; }
        }
        public float Crectangulo
        {
            get { return this.crectangulo; }
            set { this.crectangulo = value; }
        }
        public float Ctriangulo
        {
            get { return this.ctriangulo; }
            set { this.ctriangulo = value; }
        }
        public float Celipse
        {
            get { return this.celipse; }
            set { this.celipse = value; }
        }
        abstract class circulo
        {
            private double diametro;
            private double radio;
            public double Diametro
            {
                get { return this.diametro; }
                set { this.diametro = value; }
            }
            public double Radio
            {
                get { return this.radio; }
                set { this.radio = value; }
            }
            public double Area()
            {
                double resultado = 3.14 / Math.Pow(radio, 2);
                return resultado;
            }
            public double Perimetro()
            {
                double resultado = 3.14 * diametro;
                return resultado;
            }
        }

        abstract class cuadrado
        {
            private double longitudlado;
            public double Longitudlado
            {
                get { return this.longitudlado; }
                set { this.longitudlado = value; }
            }
            public double Area()
            {
                double resultado = longitudlado * longitudlado;
                return resultado;
            }
            public double Perimetro()
            {
                double resultado = 4 * longitudlado;
                return resultado;
            }
        }

        abstract class rectangulo
        {
            private double b;
            private double altura;
            public double B
            {
                get { return this.b; }
                set { this.b = value; }
            }
            public double Altura
            {
                get { return this.altura; }
                set { this.altura = value; }
            }
            public double Area()
            {
                double resultado = b * altura;
                return resultado;
            }
            public double Perimetro()
            {
                double resultado = 2 * (b + altura);
                return resultado;
            }
        }

        abstract class triangulo
        {
            private double longitudlado;
            private double longitudiferente;
            private double b;
            private double altura;
            private string tipo;
            public double Longitudlado
            {
                get { return this.longitudlado; }
                set { this.longitudlado = value; }
            }
            public double Longitudiferente
            {
                get { return this.longitudiferente; }
                set { this.longitudiferente = value; }
            }
            public double B
            {
                get { return this.b; }
                set { this.b = value; }
            }
            public double Altura
            {
                get { return this.altura; }
                set { this.altura = value; }
            }
            public string Tipo
            {
                get { return this.tipo; }
                set { this.tipo = value; }
            }
            public double Area()
            {
                double resultado = b * altura / 2;
                return resultado;
            }
            public double Perimetro()
            {
                if (tipo == "perpendicular")
                {
                    double resultado = 3 * longitudlado;
                    return resultado;
                }
                else
                {
                    double resultado = longitudiferente * 2 + longitudiferente;
                    return resultado;
                }
            }

            abstract class elipse
            {
                private double pi;
                private double altura;
                private double b;
                public double Pi
                {
                    get { return this.pi; }
                    set { this.pi = value; }
                }
                public double Altura
                {
                    get { return this.altura; }
                    set { this.altura = value; }
                }
                public double B
                {
                    get { return this.b; }
                    set { this.b = value; }
                }
                public double Area()
                {
                    double resultado = altura * b * 3.14;
                    return resultado;
                }
                public double Perimetro()
                {
                    double h = Math.Pow(altura - b / altura + b, 2);
                    double resultado = 3.14 * (altura + b) * (1 + 3 * h / 10 + Math.Sqrt(4 - 3 * h));
                    return resultado;
                }
            }
        }
    }
}