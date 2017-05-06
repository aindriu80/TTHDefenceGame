//This source code was generated using Visual Studio Design Patterns add-in
//You can find the source code and binaries at http://VSDesignPatterns.codeplex.com
using System;
using System.Collections.Generic;
using System.Linq;


namespace TeamTreeHouse
{

    /// The 'Client' class. Interaction environment for the products.
    class Client
    {

        private AbstractProductA _AbstractProductA;

        private AbstractProductB _AbstractProductB;



        // Constructor

        public Client(AbstractFactory factory)
        {

            _AbstractProductB = factory.CreateProductB();

            _AbstractProductA = factory.CreateProductA();

        }


        public static void Test()
        {

            // Abstract factory1

            AbstractFactory factory1 = new ConcreteFactory1();

            Client client1 = new Client(factory1);

            client1.Run();



            // Abstract factory2

            AbstractFactory factory2 = new ConcreteFactory2();

            Client client2 = new Client(factory2);

            client2.Run();

        }

        public void Run()
        {

            _AbstractProductB.Interact(_AbstractProductA);

        }

    }


  /// The 'AbstractFactory' abstract class
  abstract class AbstractFactory

  {

    public abstract AbstractProductA CreateProductA();

    public abstract AbstractProductB CreateProductB();

  }

  /// The 'ConcreteFactory1' class
  class ConcreteFactory1 : AbstractFactory

  {

    public override AbstractProductA CreateProductA()

    {

      return new ProductA1();

    }

    public override AbstractProductB CreateProductB()

    {

      return new ProductB1();

    }

  }

  /// The 'ConcreteFactory2' class
  class ConcreteFactory2 : AbstractFactory

  {

    public override AbstractProductA CreateProductA()

    {

      return new ProductA2();

    }

    public override AbstractProductB CreateProductB()

    {

      return new ProductB2();

    }

  }
 
}


