﻿namespace Shapes
{
    class Rectangle : Shape
    {
        public decimal Width
        {
            get { return this.width; }
            set
            {
                if (value < 0)
                {
                    throw new System.ArgumentException("Value must be positive number!");
                }

                this.width = value;
            }
        }

        public decimal Height
        {
            get { return this.height; }
            set
            {
                if (value < 0)
                {
                    throw new System.ArgumentException("Value must be positive number!");
                }

                this.height = value;
            }
        }

        public Rectangle()
            : this(0, 0)
        {
        }

        public Rectangle(decimal width, decimal height)
        {
            this.width = width;
            this.height = height;
        }

        public override decimal CalculateSurface()
        {
            return this.width * this.height;
        }
    }
}