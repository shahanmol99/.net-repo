using System;
using System.Collections.Generic;
using System.Text;

namespace EmpSalaryApp.Model
{
    class Element
    {
        private String _tagName;
        private String _content;
        private int _depth;
        private List<Element> _children;

        public Element(string tagName, string content)
        {
            _tagName = tagName;
            _content = content;
            _children = new List<Element>();
            _depth = 0;
        }

        public void addChildren(Element element)
        {
            element.Depth = element.Depth + 1;
            _children.Add(element);
        }
        public String renderHtmlString()
        {
            StringBuilder htmlString = new StringBuilder(100);
            htmlString.Append("<" + _tagName);
            htmlString.Append(">");
            htmlString.Append(_content);
            //string.append("\n");

            foreach(Element e in _children)
            {
                htmlString.Append("\n");
                for (int i=0;i < e.Depth; i++)
                {
                    htmlString.Append("   ");
                }
                htmlString.Append(e.renderHtmlString());
            }

            for (int i = 0; i < _depth; i++)
            {
                htmlString.Append("   ");
            }
            htmlString.Append("</" + _tagName + ">");
            htmlString.Append("\n");

            return htmlString.ToString();

        }

        private int Depth
        {
            get
            {
                return _depth;
            }
            set
            {
                _depth = value;
            }
        }
    }
}
