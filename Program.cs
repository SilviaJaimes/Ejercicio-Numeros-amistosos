Console.Write("\nIngrese el número de inicio del rango: ");
int inicio = Convert.ToInt32(Console.ReadLine());

Console.Write("\nIngrese el número de finalización del rango: ");
int final = Convert.ToInt32(Console.ReadLine());

int suma = 0;
int suma1 = 0;
int sumas = 0;
int suma2 = 0;

Console.WriteLine($"\nEn el rango de {inicio}-{final}\n");

do
{
    for (int i = inicio; i <= final; i++)
    {
        for (int j = inicio; j <= final; j++)
        {
            for (int m = 2; m <= j; m++)
            {
                if(j % m == 0)
                {
                    suma = j/m;
                    suma1 += suma;
                }
            }
            for (int n = 2; n <= i; n++)
            {
                if(i % n == 0)
                {
                    sumas = i/n;
                    suma2 += sumas;
                }
            }

            if (suma1 == i && suma2 == j)
            {
                Console.WriteLine($"{i}, {j} es par amistoso.");
            }

            suma1 = 0;
            suma2 = 0;
        }
    }
} while (false);

