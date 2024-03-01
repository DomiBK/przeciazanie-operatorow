Przeciążanie operatorów to ważny mechanizm w języku programowania C#, który umożliwia definiowanie niestandardowych zachowań dla operatorów wbudowanych. Oto kilka możliwości, jakie daje przeciążanie operatorów:

Dostosowanie zachowania operatorów do niestandardowych typów danych: Pozwala na zdefiniowanie, jak operatory działają na niestandardowych typach danych. Na przykład, gdy tworzysz klasę, która reprezentuje wektor, możesz przeciążyć operatory matematyczne, takie jak +, -, *, aby działały zgodnie z regułami matematycznymi na wektorach.



Umożliwienie wygodnego używania operatorów dla własnych klas: Dzięki przeciążaniu operatorów, kod może być bardziej zwięzły i czytelny. Na przykład, zamiast wywoływać metodę Dodaj() możesz przeciążyć operator + dla swojej klasy, aby dodać dwa obiekty tej klasy.



Ułatwienie porównywania obiektów: Operatorów porównania, takich jak ==, !=, <, >, można przeciążać, aby określić niestandardowe reguły porównywania dla twoich klas.



Dostosowanie zachowania do semantyki i intuicji użytkownika: Przeciążanie operatorów może pomóc w dopasowaniu zachowania operacji do intuicyjnych oczekiwań użytkownika. Na przykład, przeciążenie operatora + dla klas może oznaczać konkatenację (łączenie) lub dodawanie, w zależności od kontekstu.



Umożliwienie operacji bitowych na niestandardowych typach: Dzięki przeciążaniu operatorów, możesz tworzyć niestandardowe typy danych, które obsługują operacje bitowe, takie jak |, &, ^, <<, >>.



Dostosowanie do konwencji języka: W niektórych przypadkach przeciążanie operatorów może być przydatne do utrzymania konwencji języka lub interfejsu użytkownika. Na przykład, przeciążanie operatorów dla klas reprezentujących liczby zespolone może umożliwić naturalne użycie operatorów matematycznych.

Przeciążanie operatorów może znacznie zwiększyć elastyczność i czytelność kodu, ale należy go używać ostrożnie, aby uniknąć wprowadzania niejasności lub nadmiernego skomplikowania.

W załączniku do zadania jest przykład działania przeciążeń

Zadanie

Utwórz klasę Produkt która zawiera pola takie jak Nazwa, Cena, Ilość. Metody do wyświetlania informacji o produkcie oraz przeciążenia operatorów takich jak ==, !=, <, >, do porównywania cen produktów, operatory inkrementacji i dekrementacji (++,--) które operują na ilości produktów

Utwórz klasę Magazyn która zawierać będzie pole Nazwa , Listę produktów, metody do wyświetlania produktów oraz sortowania wykorzystującą przeciążone operatory klasy Produkt

Na cel
Utwórz klasę Macierz, która reprezentuje macierz liczb rzeczywistych. Przeciąż operatory dodawania +, odejmowania - i mnożenia * dla macierzy, aby umożliwić wygodne wykonywanie operacji, dodatkowo ++ oraz -- które inkrementują, dekrementują macierz o 2

