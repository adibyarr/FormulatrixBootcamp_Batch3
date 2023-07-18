namespace Enumerator;
using System;
using System.Collections;

public class Enumeratorx : IEnumerable
{
    private string[] _colours;

    public Enumeratorx()
    {
        _colours = new string[] { "Green", "Blue", "Cyan" };
    }

    public IEnumerator GetEnumerator()
    {
        return new ColourEnumerator(_colours);
    }

    // class dalam class
    private class ColourEnumerator : IEnumerator
    {
        private string[] _colours;
        private int _currentIndex;

        public ColourEnumerator(string[] colours)
        {
            this._colours = colours;
            _currentIndex = -1;
        }

        public object Current => _colours[_currentIndex];

        public bool MoveNext()
        {
            _currentIndex++;
            return _currentIndex < _colours.Length;
        }

        public void Reset()
        {
            _currentIndex = -1;
        }
    }
}