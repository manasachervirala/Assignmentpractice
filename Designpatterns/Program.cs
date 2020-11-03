using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	class Program
	{

		static void Main(string[] args)
		{
		}
	}

}
public class Mysingleton
{
	private static Mysingleton instance = new Mysingleton();
	private Mysingleton() { }
	public static Mysingleton Instance
	{
		get { return instance; }
	}
}
