
using System;
using System.Globalization;


class Calculadora{
    public double results_int = 0.0;

    public double methods_numb(double numero, int method){

        switch (method){
            case 1:
                numero = Math.Pow(numero, 2);
                break;
            case 2:
                numero = Math.Pow(numero, 3);
                break;
            case 3:
                numero = Math.PI * (Math.Pow(numero, 2));
                break;
            case 4:
                numero = Math.Pow(numero, 3);
                break;
            case 5:
                numero = Math.Sqrt(numero);
                break;
            case 6:
                numero = Math.Round(numero);
                break;
            default:
                return numero;
        }
        return numero;
    }

    public double Calcular(Calculadora calculadora, double numero, int operacion, int method){
        numero = methods_numb(numero, method);

        switch (operacion){
            case 1:
                calculadora.results_int += numero;
                break;
            case 2:
                calculadora.results_int -= numero;
                break;
            case 3:
                calculadora.results_int /= numero;
                break;
            case 4:
                calculadora.results_int *= numero;
                break;
        }

        return calculadora.results_int;
    }

    static void Main(string[] args){
        Calculadora calculadora = new Calculadora();
        while (true){
            Console.WriteLine("[+] Introduce el numero a calcular o mantenga presionado CTRL+C para finalizar el proceso");
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            provider.NumberGroupSeparator = ",";
            double numero = Convert.ToDouble(Console.ReadLine(), provider);

            string[] operaciones = {
                "Sumar",
                "Restar",
                "Dividir",
                "Multiplicar"
            };

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n[+] Introduce un numero del 1-4 para elegir la operacion a realizar");
            for(int i = 0; i<operaciones.Length; i++){
                int posicion = i+1;
                Console.WriteLine(posicion.ToString() + " => " + operaciones[i]);
            }

            int operacion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n[+] Introduce una operacion para hacer con el numero antes de agregarlo");

            string[] methods_afc = {
                "Elevar al cuadrado",
                "Elevar al cubo",
                "Encontrar el area del circulo",
                "Encontrar el area del cubo",
                "Encontrar la raiz cuadrada",
                "Redondear",
                "Pasar"
            };

            for(int a = 0; a<methods_afc.Length; a++){
                int posicion = a+1;
                Console.WriteLine(posicion.ToString() + " => " + methods_afc[a]);
            }

            int mthods_afc = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine(calculadora.Calcular(calculadora, numero, operacion, mthods_afc));
        };

    }
    
}