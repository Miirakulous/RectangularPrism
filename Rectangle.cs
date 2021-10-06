namespace RectangularPrism
{
    class Rectangle
    {
        private int length;
        private int width;
        private int height;
        public Rectangle()
        {
            this.length = 1;
            this.width = 1;
            this.height = 1;
        }
        public Rectangle(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            this.width = width;
        }

        public int GetLength()
        {
            return this.length;
        }
        public int GetHeight()
        {
            return this.height;
        }
        public int GetWidth()
        {
            return this.width;
        }
        public int SetLength(int length)
        {
            this.length = length;
            return this.length;
        }
        public int SetWidth(int width)
        {
            this.width = width;
            return this.width;
        }
        public int SetHeight(int height)
        {
            this.height = height;
            return this.height;
        }
        public int GetVolume()
        {
            return this.length * this.width * this.height;
        }
    }

}
