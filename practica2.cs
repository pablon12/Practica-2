/*
 * Creado por SharpDevelop.
 * Usuario: Pablo
 * Fecha: 28/02/2014
 * Hora: 11:18 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica_1
{
	class Program
	{
		
		
		
		public static void Main(string[] args)
		{	
			double resultado;	
			
			Console.WriteLine("Dame el primer precio");
			double pro1=double.Parse(Console.ReadLine());
			
			Console.WriteLine("Dame el segundo precio");
			double pro2=double.Parse(Console.ReadLine());
			
			Console.WriteLine("Dame el tercer precio");
			double pro3=double.Parse(Console.ReadLine());
			
			pro1= (pro1 * .16) + pro1;
			
			Console.WriteLine("el precio del producto 1 ="+ pro1);
			
			pro2=(pro2 * .16) + pro2;
			
			Console.WriteLine("el precio mas iva del producto 2 ="+ pro2);
			
			pro3=(pro3 *.16) + pro3;
			
			Console.WriteLine("el precio mas iva del producto 3 =" + pro3);
			
			resultado= pro1+pro2+pro3;
			Console.WriteLine("el total de los articulos es =" + resultado);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}