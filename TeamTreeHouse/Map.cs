﻿namespace TeamTreeHouse
{
    public class Map
    {
        public readonly int Width;
        public readonly int Height;

        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public bool onMap(Point point)
        {
            bool inBounds = point.X >= 0 && point.X < Width &&
                            point.Y >= 0 && point.Y < Height;

            return inBounds;
        }


    }
}