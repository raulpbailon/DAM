/*--------------------------------------------------------------------------------------
 * PROGRAMA:    Ejercicio 1, Examen Programación
 * AUTOR: 		Raúl Prieto Bailón
 * FUNCION: 	Lee de teclado N caracteres e imprime por pantalla el numero de vocales 
 * introducidas y el numero total de caracteres.
 * FECHA 		21/11/2016	Versión 0.1
 * COMENTARIOS: --------
 * ---------------------------------------------------------------------------------*/
using System;

namespace Eje_1
{
	class Ejercicio1
	{
		static void Main(string[] args)
		{
			// Declaro las variables
			char caracter = ' ';
			int a = 0;
			int e = 0;
			int i= 0;
			int o = 0;
			int u = 0;
			int contador = 0;
			//Intro del programa
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.ForegroundColor = ConsoleColor.White;
			Console.Clear();
			try{
				Console.Write("Introduce caracteres, '*' para finalizar.\n\tIntroduce un caracter: ");
				caracter = char.Parse(Console.ReadLine());
				while (caracter!='*')
				{
					contador++;
					caracter = char.ToLower (caracter); // Evitamos diferencia entre mayuscula y minuscula pasando todas las letras a minusculas.
					if (caracter=='a') a++;
					else if(caracter=='e') e++;
					else if(caracter=='i') i++;
					else if(caracter=='o') o++;
					else if(caracter=='u') u++;

					Console.Write("\tIntroduce otro caracter: ");
					caracter = char.Parse(Console.ReadLine());
				}
				//Imprimir resultado
				Imprimir(a,e,i,o,u,contador);
			}
			catch
			{
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.WriteLine("\n\tERROR: introduccion incorrecta. Reinicie el programa.");
			} 
			
			Console.ReadLine(); //Evitamos que el programa finalice automáticamente
		}

	#region Métodos del programa
		static void Imprimir(int a, int e, int i, int o, int u, int cont)
		{
			//a
			Console.Write("\na[{0}] -> ",a);
			for (int j = 0; j < a; j++)
			{
				Console.Write("#");
			}
			
			Console.Write("\ne[{0}] -> ",e);
			for (int j = 0; j < e; j++)
			{
				Console.Write("#");
			}

			Console.Write("\ni[{0}] -> ",i);
			for (int j = 0; j < i; j++)
			{
				Console.Write("#");
			}
			Console.Write("\no[{0}] -> ",o);
			for (int j = 0; j < o; j++)
			{
				Console.Write("#");
			}

			Console.Write("\nu[{0}] -> ",u);
			for (int j = 0; j < u; j++)
			{
				Console.Write("#");
			}
			
			Console.WriteLine("\n\nEl total de caracteres es: {0}", cont);
		}
		
	#endregion
	}
}
