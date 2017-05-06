//This source code was generated using Visual Studio Design Patterns add-in
//You can find the source code and binaries at http://VSDesignPatterns.codeplex.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamTreeHouse
{

    /// The 'AbstractProductA' abstract class
    abstract class AbstractProductA
    {

    }

    /// The 'AbstractProductB' abstract class
    abstract class AbstractProductB
    {

        public abstract void Interact(AbstractProductA a);

    }

    /// The 'ProductA1' class
    class ProductA1 : AbstractProductA
    {

    }


    /// The 'ProductB1' class
    class ProductB1 : AbstractProductB
    {

        public override void Interact(AbstractProductA a)
        {

            Console.WriteLine(this.GetType().Name +

              " interacts with " + a.GetType().Name);

        }

    }


    /// The 'ProductA2' class
    class ProductA2 : AbstractProductA
    {

    }


    /// The 'ProductB2' class
    class ProductB2 : AbstractProductB
    {

        public override void Interact(AbstractProductA a)
        {

            Console.WriteLine(this.GetType().Name +

              " interacts with " + a.GetType().Name);

        }

    }
 
}
