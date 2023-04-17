/*
 * Created by SharpDevelop.
 * User: Rodrigo
 * Date: 17/4/2023
 * Time: 17:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ClasePersona
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Persona Alumno= new Persona("Rodrigo","Diaz Lopez",44420254, 1800, 8);
			Alumno.Imprimir();
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}