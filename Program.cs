using System;

public class FormatoDistancia
{
	public static void Main()
	{
		//Procesar distancia, y darle formato 
		double numeroPorProcesar = 1.0;
		if (numeroPorProcesar < 0)
		{
			Console.WriteLine("Su distancia seria " + (numeroPorProcesar * 100) + "Centimetros");
		}
		else if (numeroPorProcesar == 0)
		{
			Console.WriteLine("No hay distancia para procesar");
		}

		else if(numeroPorProcesar < 1000 )
		{
			Console.WriteLine("Su distancia seria " + (numeroPorProcesar / 1000) + "Kilometros");
		}			
		else 
		{
			Console.WriteLine("Su distancia seria " + numeroPorProcesar + "Metros");
		}
	}

}

