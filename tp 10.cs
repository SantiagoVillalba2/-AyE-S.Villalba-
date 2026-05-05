// ejercicio 1
Console.WriteLine("Ingrese un número de dos cifras");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 9)
{
    int unidades = num % 10;
    int decenas = num / 10;
    Console.WriteLine($"unidades: {unidades}");
    Console.WriteLine($"decenas: {decenas}");
}
else
{
    Console.WriteLine("No es un número de dos cifras");
}
// ejercicio 2
Console.WriteLine("Ingrese un número de 3 cifras");
int numero = Convert.ToInt32(Console.ReadLine());
if (numero > 99 || numero < 1000)
{
    int medio = numero / 10;
    int final = medio % 10;
    Console.WriteLine($"Cifra central: {final}");
}

// ejercicio 3
Console.WriteLine("Ingrese un precio");
int numerin = Convert.ToInt32(Console.ReadLine());
double porcentaje = numerin * 0.18;
double descuento = numerin - porcentaje;
Console.WriteLine($"Precio con descuento: {descuento}");

// ejercicio 4
Console.WriteLine("Ingrese un número de dos cifras");
int numerito = Convert.ToInt32(Console.ReadLine());
if (numerito > 9 && numerito < 100)
{
    int decenass = numerito / 10;
    int unidadess = numerito % 10;
    int resultado1 = unidadess * 10;
    int resultado2 = resultado1 + decenass;
    Console.WriteLine($"número dado vuelta: {resultado2}");
}
else
{
    Console.WriteLine("No es un número de dos cifras");
}

// ejercicio 5
Console.WriteLine("Ingrese una fecha como un número de 6 dígitos");
int fecha = Convert.ToInt32(Console.ReadLine());
int resultadoo1 = fecha / 100;
int resultadoo2 = resultadoo1 % 100;
Console.WriteLine($"El número de mes es: {resultadoo2}");

// ejercicio 6
Console.WriteLine("Ingrese la longitud de los lados (medida en cm)");
int numerooo = Convert.ToInt32(Console.ReadLine());
int perimetro = numerooo * 4;
int superficie = numerooo * numerooo;
Console.WriteLine($"el perimetro del cuadrado es de: {perimetro}");
Console.WriteLine($"el área del cuadrado es de: {superficie}cm²");

// ejercicio 7
Console.WriteLine("Ingresá el valor de trabajo por hora y seguido de eso, ingresá las horas trabajadas");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int resultado = num1 * num2;
Console.WriteLine($"El sueldo basado en el valor por hora y cantidad de horas trabajadas es de: {resultado}");

// ejercicio 8
Console.WriteLine("Ingrese la temperatura (medida en Fahrenheit)");
int numm = Convert.ToInt32(Console.ReadLine());
double resultadooo1 = numm - 32;
double resultadooo2 = numm / 1.8;
Console.WriteLine($"La conversión de grados Fahrenheit a grados Celsius es de: {resultadooo2}°C");

// ejercicio 9
Console.WriteLine("Ingrese la hora, seguido de minutos y segundos del instante 1");
int nummm1 = Convert.ToInt32(Console.ReadLine());
int nummm2 = Convert.ToInt32(Console.ReadLine());
int nummm3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese la hora, seguido de minutos y segundos del instante 2");
int nummm4 = Convert.ToInt32(Console.ReadLine());
int nummm5 = Convert.ToInt32(Console.ReadLine());
int nummm6 = Convert.ToInt32(Console.ReadLine());
int resultadoooo1 = (nummm1 * 3600) + (nummm2 * 60) + nummm3;
int resultado22 = (nummm4 * 3600) + (nummm5 * 60) + nummm6;
int diferencia = resultadoooo1 - resultado22;
Console.WriteLine($"La diferencia de segundos en los dos instantes es de: {diferencia} segundos");

// ejercicio 10
Console.WriteLine("Ingrese un número entero de 3 dígitos");
int tresdigitos = Convert.ToInt32(Console.ReadLine());
if (tresdigitos > 99 && tresdigitos < 1000)
{
    int unidadesss = tresdigitos % 10;
    int decenasss = tresdigitos / 10;
    int decenasss2 = decenasss % 10;
    int centenasss = tresdigitos / 100;
    Console.WriteLine($"unidades: {unidadesss}");
    Console.WriteLine($"decenas: {decenasss2}");
    Console.WriteLine($"centenas: {centenasss}");
}
else
{
    Console.WriteLine("No es un número de tres dígitos");
}