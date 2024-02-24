int contador = 0;
int numero = 2;
 Console.WriteLine("Los primeros 5 números pares son:");
while (contador < 5)
 {
      Console.WriteLine(numero);
      numero += 2; 
      contador++;
        }

Console.ReadLine();



int suma = 0;

for (int i = 1; i <= 10; i++)
{
    suma += i; 
}

Console.WriteLine($"La suma de los primeros 10 números naturales es: {suma}");



int suma = 0;
int numero;

Console.WriteLine("Ingresa números enteros positivos. Escribe un número negativo para finalizar.");

do
{
    Console.Write("Número: ");
    numero = Convert.ToInt32(Console.ReadLine());

    if (numero >= 0)
    {
        suma += numero;
    }
} while (numero >= 0);

Console.WriteLine($"La suma de los números ingresados es: {suma}");


