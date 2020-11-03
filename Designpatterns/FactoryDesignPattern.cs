using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace FactoryDesignPattern
{
		class FactoryDesignPattern
		{
			class MainApp
			{
				static void Main(string[] args)
				{
					// An array of creators
					Creator[] creators = new Creator[2];
					creators[0] = new ConcreteCreatorA();
					creators[1] = new ConcreteCreatorB();
					// Iterate over creators and create products
					foreach (Creator obj in creators)
					{
						Product product = obj.FactoryMethod();
						Console.WriteLine("Created {0}", product.GetType().Name);
					}
					ConcreteCreatorA cc1 = new ConcreteCreatorA();
					cc1.Method1();
					ConcreteCreatorB cc2 = new ConcreteCreatorB();
					cc2.Method2();
					Console.ReadKey();
				}
			}
			abstract class Product { }// The 'Product' abstract class
			class ConcreteProductA : Product { }// A 'ConcreteProduct' class
			class ConcreteProductB : Product { }// A 'ConcreteProduct' class
			abstract class Creator// The 'Creator' abstract class
			{
				public abstract Product FactoryMethod();
			}
			class ConcreteCreatorA : Creator//A Concrete class
			{
				public override Product FactoryMethod()
				{
					return new ConcreteProductA();
				}
				public void Method1()
				{
					Console.WriteLine("This is ConcreteCreatorA class");
				}
			}
			class ConcreteCreatorB : Creator
			{
				public override Product FactoryMethod()
				{
					return new ConcreteProductB();
				}
				public void Method2()
				{
					Console.WriteLine("This is ConcreteCreatorB class");
				}
			}
		}
	}

