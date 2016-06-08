using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
/*
Pierwszy to konstruktor domyślny nie przyjmujący
żadnych argumentów. Tworzy on nowy prostokąt, ustawia współrzędne kratki na (0, 0) oraz nadaje
kratce domyślny czarny kolor. Drugi robi to samo ale zmienia współrzędne zgodnie z naszym
życzeniem, trzeci dodatkowo nadaje żądany kolor. Wyposażamy klasę również w funkcje do
sprawdzenia stanu kratki (wolna/zajęta), do ustawienia jej koloru oraz do odczytania go. Oprócz
tego kratka musi posiadać funkcje pozwalające na wyświetlenie elementu oraz ukrycie (czyli
wypełnienie określonym kolorem, takim jak tło), więc tworzymy funkcje rysuj i kasuj. Możemy już
zamknąć plik Kratka.cs, nie będziemy go więcej modyfikować.using System;

*/

namespace tet
{
    class Kartka
    {
        private Rectangle kwadrat;
        private Color kolor;
        private int x, y;
        private bool zajeta;
        public const int wymiar = 15;
    }
}
