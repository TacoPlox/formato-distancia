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

		// double numeroPorProcesar = 0.0;

		string numeroProcesado;

		if (convertirDistancia < 0.0)
		{
			numeroProcesado = convertirDistancia * 100 + "cm";
		}
		else if(convertirDistancia > 1000 )
		{
			numeroProcesado = convertirDistancia / 1000 + "km";
		}			
		else 
		{
			numeroProcesado = convertirDistancia + "m";
		}
	
		
	}
}

