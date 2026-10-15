namespace tp_24
{
    using System.IO;
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto = "archivo.txt";



            using (StreamWriter escritor = new StreamWriter(texto))
            {
                escritor.WriteLine("ejercicio 1");
                escritor.WriteLine("Ingrese un número de dos cifras");
                int num = 97;
                if (num > 9)
                {
                    int unidades = num % 10;
                    int decenas = num / 10;
                    escritor.WriteLine($"unidades: {unidades}");
                    escritor.WriteLine($"decenas: {decenas}");
                }
                else
                {
                    escritor.WriteLine("No es un número de dos cifras");
                }

                escritor.WriteLine("");
                escritor.WriteLine("ejercicio 2");
                escritor.WriteLine("Ingrese un número de 3 cifras");
                int numero = 876;
                if (numero > 99 || numero < 1000)
                {
                    int medio = numero / 10;
                    int final = medio % 10;
                    escritor.WriteLine($"Cifra central: {final}");
                }

                escritor.WriteLine("");
                escritor.WriteLine("ejercicio 3");
                escritor.WriteLine("Ingrese un precio");
                int numerin = 56;
                double porcentaje = numerin * 0.18;
                double descuento = numerin - porcentaje;
                escritor.WriteLine($"Precio con descuento: {descuento}");

                escritor.WriteLine("");
                escritor.WriteLine("ejercicio 4");
                escritor.WriteLine("Ingrese un número de dos cifras");
                int numerito = 90;
                if (numerito > 9 && numerito < 100)
                {
                    int decenass = numerito / 10;
                    int unidadess = numerito % 10;
                    int resultado1 = unidadess * 10;
                    int resultado2 = resultado1 + decenass;
                    escritor.WriteLine($"número dado vuelta: {resultado2}");
                }
                else
                {
                    escritor.WriteLine("No es un número de dos cifras");
                }

                escritor.WriteLine("");
                escritor.WriteLine("ejercicio 5");
                escritor.WriteLine("Ingrese una fecha como un número de 6 dígitos");
                int fecha = 09122001;
                int resultadoo1 = fecha / 100;
                int resultadoo2 = resultadoo1 % 100;
                escritor.WriteLine($"El número de mes es: {resultadoo2}");

                escritor.WriteLine("");
                escritor.WriteLine("ejercicio 6");
                escritor.WriteLine("Ingrese la longitud de los lados (medida en cm)");
                int numerooo = 56;
                int perimetro = numerooo * 4;
                int superficie = numerooo * numerooo;
                escritor.WriteLine($"el perimetro del cuadrado es de: {perimetro}");
                escritor.WriteLine($"el área del cuadrado es de: {superficie}cm²");

                escritor.WriteLine("");
                escritor.WriteLine("ejercicio 7");
                escritor.WriteLine("Ingresá el valor de trabajo por hora y seguido de eso, ingresá las horas trabajadas");
                int num1 = 56;
                int num2 = 7;
                int resultado = num1 * num2;
                escritor.WriteLine($"El sueldo basado en el valor por hora y cantidad de horas trabajadas es de: {resultado}");

                escritor.WriteLine("");
                escritor.WriteLine("ejercicio 8");
                escritor.WriteLine("Ingrese la temperatura (medida en Fahrenheit)");
                int numm = 456;
                double resultadooo1 = numm - 32;
                double resultadooo2 = numm / 1.8;
                escritor.WriteLine($"La conversión de grados Fahrenheit a grados Celsius es de: {resultadooo2}°C");

                escritor.WriteLine("");
                escritor.WriteLine("ejercicio 9");
                escritor.WriteLine("Ingrese la hora, seguido de minutos y segundos del instante 1");
                int nummm1 = 2;
                int nummm2 = 45;
                int nummm3 = 32;
                escritor.WriteLine("Ingrese la hora, seguido de minutos y segundos del instante 2");
                int nummm4 = 21;
                int nummm5 = 34;
                int nummm6 = 30;
                int resultadoooo1 = (nummm1 * 3600) + (nummm2 * 60) + nummm3;
                int resultado22 = (nummm4 * 3600) + (nummm5 * 60) + nummm6;
                int diferencia = resultadoooo1 - resultado22;
                escritor.WriteLine($"La diferencia de segundos en los dos instantes es de: {diferencia} segundos");

                escritor.WriteLine("");
                escritor.WriteLine("ejercicio 10");
                escritor.WriteLine("Ingreseonv un número entero de 3 dígitos");
                int tresdigitos = 234;
                if (tresdigitos > 99 && tresdigitos < 1000)
                {
                    int unidadesss = tresdigitos % 10;
                    int decenasss = tresdigitos / 10;
                    int decenasss2 = decenasss % 10;
                    int centenasss = tresdigitos / 100;
                    escritor.WriteLine($"unidades: {unidadesss}");
                    escritor.WriteLine($"decenas: {decenasss2}");
                    escritor.WriteLine($"centenas: {centenasss}");
                }
                else
                {
                    Console.WriteLine("No es un número de tres dígitos");
                }


            }
            using (StreamReader lector = new StreamReader(texto))
            {
                string todoelarchivo = lector.ReadToEnd();

                Console.WriteLine(todoelarchivo);
            }
        }
    }
}
