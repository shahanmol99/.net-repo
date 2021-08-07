using System;
using System.Collections.Generic;
using System.Text;

namespace RectEncapApp.Model
{
    class Rectangle
    {
        int _width;
        int _height;
        BorderStyle _border;

        public Rectangle(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public Rectangle(int width, int height, BorderStyle border)
        {
            _width = width;
            _height = height;
            _border = border;
        }

        public int GetWidth()
        {
            return _width;
        }

        public int GetHeight()
        {
            return _height;
        }

        public BorderStyle GetBorderStyle()
        {
            return _border;
        }

        public int CalculateArea()
        {
            return _width * _height;
        }

        public void SetBorderStyle(BorderStyle border)
        {
            _border = border;
        }


    }

    enum BorderStyle
    {
        SOLID, DOTTED
    };
}
