using System;

namespace TeamTreeHouse
{
    public class TreeHouseExceptions : SystemException
    {
        public TreeHouseExceptions()
        {
        }

        public TreeHouseExceptions(string message) : base(message)
        {

        }
    }

    class OutOfBoundsException : TreeHouseExceptions
    {
        public OutOfBoundsException() : base()
        {

        }
        public OutOfBoundsException(string message) : base(message)
        {

        }
    }
}
