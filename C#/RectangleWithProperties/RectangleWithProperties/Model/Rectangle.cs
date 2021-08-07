using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleWithProperties.Model
{
    class Rectangle
    {
        int _width;
        int _height;
        BorderStyle _border = BorderStyle.SOLID;

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

        public int Width
        { 
            get
            {
                return _width;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
        }


        public BorderStyle Border
        {
            get
            {
                return _border;
            }
            set
            {
                _border = value;
            }
        }


        public int CalculateArea()
        {
            return _width * _height;
        }



    }

    enum BorderStyle
    {
        SOLID, DOTTED
    };
}
