namespace DesignPatterns
{
    public class HtmlBuilder
    {
        private readonly string _rootName;

        public HtmlBuilder(string rootName)
        {
            _rootName = rootName;
            _root.Name = rootName;
        }

        // not fluent
        public void AddChild(string childName, string childText)
        {
            var e = new HtmlElement(childName, childText);
            _root.Elements.Add(e);
        }

        // fluent
        public HtmlBuilder AddChildFluent(string childName, string childText)
        {
            var e = new HtmlElement(childName, childText);
            _root.Elements.Add(e);
            return this;
        }

        public override string ToString()
        {
            return _root.ToString();
        }

        public void Clear()
        {
            _root = new HtmlElement { Name = _rootName };
        }

        HtmlElement _root = new();
    }
}