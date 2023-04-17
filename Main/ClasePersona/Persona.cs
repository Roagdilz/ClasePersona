/*
 * Created by SharpDevelop.
 * User: Rodrigo
 * Date: 17/4/2023
 * Time: 18:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ClasePersona
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona
	{
		string nombre;
		string apellido;
		long dni;
		int legajo;
		int nota;
		
		//Constructores
		public Persona()
		{
		}
		public Persona(string nombre, string apellido, long dni, int legajo, int nota){
			this.nombre = nombre;
			this.apellido = apellido;
			this.dni = dni;
			this.legajo = legajo;
			this.nota = nota;
			Console.WriteLine("Bienvenido {0}",this.nombre);
			Console.ReadKey();
		}
		
		///Metodos..
		
		public void Imprimir(){
			Console.WriteLine("Welcome {0}, legajo: {1}. Nota: {2}",this.nombre,this.legajo,this.nota);
			Console.ReadKey();
		}
		
		///Propiedades
		public string Nombre{
			get{
				return this.nombre;
			}
			set{
				this.nombre=value;
			}
		}
		public string Apellido{
			get{
				return this.apellido;
			}
			set{
				this.apellido = value;
			}
		}
		public long Dni{
			get{
				return this.dni;
			}
			set{
				this.dni = value;
			}
		}
		public int Legajo{
			get{
				return this.legajo;
			}
			set{
				this.legajo = value;
			}
		}
		public int Nota{
			get {
				return this.nota;
			}
			set{
				this.nota = value;
			}
		}
	}
}
