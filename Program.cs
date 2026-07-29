using System;

public class FormatoDistancia
{
	public static void Main()
	{
		//Introducir distancia
		Console.WriteLine("Escribe la distancia :");
		string distancia = Console.ReadLine();
		
		double convertirDistancia = double.Parse(distancia);
		//Procesar distancia, y darle formato

		double numeroPorProcesar = 0.0;

		string numeroProcesado;

		if (numeroPorProcesar < 0)
		{
			numeroProcesado = numeroPorProcesar * 100 + "cm";
		}
		else if(numeroPorProcesar > 1000 )
		{
			numeroProcesado = numeroPorProcesar / 1000 + "km";
		}			
		else 
		{
			numeroProcesado = numeroPorProcesar + "m";
		}
	
		
	}
}

