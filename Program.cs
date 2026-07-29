using System;

public class FormatoDistancia
{
	public static void Main()
	{
		//Procesar distancia, y darle formato 
		double numeroPorProcesar = 0.0;
		string numeroProcesado;
		
		if (numeroPorProcesar < 0)
		{
			numeroProcesado = numeroPorProcesar * 100 + "cm";
		}
		else if(numeroPorProcesar > 1000 )
		{
			numeroProcesado = numeroPorProcesar / 1000 + "Km";
		}			
		else 
		{
			numeroProcesado = numeroPorProcesar + "M";
		}
	}
}

