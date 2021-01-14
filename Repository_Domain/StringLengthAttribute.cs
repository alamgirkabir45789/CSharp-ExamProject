using System;

namespace Repository_Domain
{
    internal class StringLengthAttribute : Attribute
    {
        private int v;

        public StringLengthAttribute(int v)
        {
            this.v = v;
        }
    }
}