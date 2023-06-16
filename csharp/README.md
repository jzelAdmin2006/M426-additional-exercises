# Aufgabe 1: Lotto (Test-Driven Development)

Bei einer Lotterie werden mehrere Zahlen aus einem bestimmten Wertebereich
zufällig gezogen. Der Spieler kann für einen zuvor festgelegten Geldbetrag einen
Tipp abgeben, welche Zahlen gezogen werden. Je mehr Zahlen von diesem Tipp mit
den tatsächlich gezogenen Zahlen übereinstimmen, desto höher ist der Gewinn des
Spielers.

Beispiel: Bei einer Lotterie werden sechs Zahlen von 1 bis 45 gezogen. Für einen
Geldbetrag von CHF 2.- kann man einen Tipp abgeben. Der Spieler tippt auf die
Zahlen 1, 13, 25, 37, 41 und 45. Die Ziehung ergibt die Zahlen 5, 13, 24, 37, 44
und 45. Der Spieler hat drei richtige Zahlen getippt (13, 37 und 45). Er gewinnt
einen Betrag von CHF 5.- und hat abzüglich der investierten CHF 2.- nun einen
Nettogewinn von CHF 3.-.

Im Projekt `Lottery` ist eine solche Lottosimulation als ausführbares Programm
(`Program.cs`) vorbereitet.  Die Simulation funktioniert jedoch noch nicht, da
die Programmlogik noch fehlt.  Diese solle Sie mithilfe von _Test-Driven
Development_ umsetzen!

Genauer haben Sie folgende Methoden zu implementieren:

- Die Klasse `Lottery` (Lotterie, `Lottery.cs`) enthält die Regeln für die
Lottoziehung, d.h.  Anzahl gezogene Zahlen und den Wertebereich (immer bei 1
beginnend).
    - Die Methode `Draw()` soll auf Grundlage dieser Regel die Ziehung der
    Gewinnzahlen durchführen. Hierzu wird ein neues `LotteryDraw`-Objekt
    (`LotteryDraw.cs`) erstellt. (Tipp: Verwenden Sie die `Random`-Klasse zur
    Generierung von Zufallszahlen.)
    - Die Methode `CreateRandomBet()` soll für die Simulation des Spielers einen
    Tipp generieren. Das Ergebnis ist eine Liste von Ganzzahlen, welche die
    gleiche Bedingungen wie die Gewinnzahlen erfüllen muss (Wertebereich, nur
    eindeutige Zahlen.)
- Die Klasse `LotteryDraw` (`LotteryDraw.cs`, Lottoziehung) repräsentiert eine
konkrete Lottoziehung und dient zur Auswertung von Gewinnen.
    - Die Methode `CountCorrectNumbers()` vergleicht den gegebenen Tipp (`bet`)
    mit den Gewinnzahlen (`winningNumbers`) und gibt die Anzahl der
    übereinstimmenden Zahlen zurück.
    - Die Methode `getReward()` berechnet den Gewinn (bzw. Verlust) des Spielers
    anhand des gegebenen `rewards`-Dictionaries und der Kosten für einen Tipp
    (`betCost`).
    
Die `TODO`-Kommentare enthalten weitere Hinweise für die Implementierung. In
`Program.cs` befindet sich die `Main()`-Methode, welche mehrere Lottoziehungen
simuliert. Ein Spieler gibt solange Tipps ab, bis er kein Geld mehr hat.

In `Lottery.Tests/LotteryTest.cs` finden Sie eine grobe Struktur für mögliche
Testfälle. Sie können weitere Testmethoden schreiben.

Folgen Sie den Regeln von TDD beim Umsetzen der oben beschriebenen Methoden:

1. Schreiben Sie keinen Produktivcode, solange Sie keinen scheiternden Test haben.
2. Schreiben Sie nur so viel Testcode, um den Test zum Scheitern zu bringen.
3. Schreiben Sie nur so viel Produktivcode, um den Test zum Durchlaufen zu bringen.

Die Tests lassen sich folgendermassen ausführen:

    $ dotnet test Lottery.Tests

Wenn Sie alle Methoden (korrekt) umgesetzt haben, können Sie die Simulation starten:

    $ dotnet run --project Lottery

# Aufgabe 2: ISBN-13 (Clean Code)

Bücher werden anhand einer
[ISBN](https://de.wikipedia.org/wiki/Internationale_Standardbuchnummer)
(internationale Standardbuchnummer) identifiziert. Früher war dies eine
zehnstellige Zahl (ISBN-10). Heutzutage verwendet man die dreizehnstellige
ISBN-13, um mit [EAN](https://de.wikipedia.org/wiki/European_Article_Number)
(European Article Number) kompatibel zu sein. (Als Landespräfix wird die Zahl
978 oder 979 verwendet, welche für das fiktive Land _Buchland_ steht.)

Die letzte Stelle einer ISBN-13 ist eine sogenannte Prüfsumme, mithilfe welcher
man mögliche Fehler beim Übermitteln einer ISBN-13 bzw. Fehler beim Scanvorgang
des Barcodes erkennen kann. Der Algorithmus zur [Berechnung der
ISBN-13-Prüfsumme](https://de.wikipedia.org/wiki/Internationale_Standardbuchnummer#ISBN-13)
ist in der Klasse `ISBN13` (`ISBN13/ISBN13.cs`) implementiert. Hierzu gibt es
zahlreiche (positive und negative) Testfälle in `ISBN13.Tests/ISBN13Tests.cs`,
die Sie folgendermassen ausführen können:

    $ dotnet test ISBN13.Tests

Der Produktivcode (`ISBN13.IsValid()`) weist einige stilistische Mängel auf und
könnte wesentlich eleganter und besser lesbar formuliert werden.

Verbessern Sie den Code und stelle Sie nach jeder Änderung sicher, dass die
Testfälle noch durchlaufen!

# Aufgabe 3: Schere, Stein, Papier (Refactoring)

Beim Spiel [_Schere, Stein,
Papier_](https://de.wikipedia.org/wiki/Schere,_Stein,_Papier) (engl. _Rock,
Paper, Scissors_) treten zwei Spieler gegeneinander an, wobei Sie durch
gleichzeitiges Vorzeigen eines Handzeichens ihren Spielzug formulieren:

- _Schere_: Zeigefinger und Mittelfinger gespreizt
- _Stein_: Hand zu einer Faust geballt
- _Papier_: Flache Hand

Machen beide Spieler den gleichen Spielzug, ist das Ergebnis des Spiels
unentschieden. Ansonsten gelten folgende Regeln:

- _Schere_ schlägt _Papier_ (zerschneiden)
- _Papier_ schlägt _Stein_ (umwickeln)
- _Stein_ schlägt _Schere_ (zertrümmern)

Die Spiellogik ist in `RockPaperScissors/RockPaperScissors.cs` in der Klasse `RockPaperScossors` implementiert. Testfälle finden Sie in `RockPaperScissors.Tests/RockPaperScissors.cs`; diese lassen sich folgendermassen ausführen:

    $ dotnet test RockPapersScissors.Tests

Der Code von `RockPaperScissors` weist verschiedene Mängel auf:

1. Die Spiellogik (`Winner()`-Methode) ist etwas umständlich implementiert.
2. Die Spiellogik verwendet Zeichenketten und Ganzzahlen um Spielzüge und
Ergebnisse zu codieren.

Führen Sie die folgenden Refactorings aus, um diese Probleme zu lösen:

1. Definieren Sie die Zusammenhänge zwischen den Spielzügen und den Ergebnissen
_statisch_, d.h. in einer entsprechenden Datenstruktur. (Anhand der beiden
Spielzüge kann das Spielergebnis nachgeschlagen werden.)
2. Definieren Sie die Spielzüge und -ergebnisse els
[_Enumeration_](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum)
(Aufzählung):
    - Für den Spielzug: Enum `Move` mit Varianten `Rock`, `Paper`, `Scissors`
    - Für das Spielergebnis: Enum `Result` mit Varianten `PlayerOneWins`,
    `PlayerTwoWins`, `Draw`
    
Für das erste Refactoring brauchen Sie nichts an den Tests anzupassen. Für das
zweite Refactoring müssen Sie die Schnittstelle verändern, da Sie neu Enums und
nicht mehr Zeichenketten bzw. Ganzzahlen erwarten bzw. zurückgeben.

Wird der Code durch die Verwendung von Enums "besser"? Inwiefern?

# Aufgabe 4: Liste flach machen (Design Patterns)

Mit dem
[Composite](https://refactoring.guru/design-patterns/composite)-Entwurfsmuster
können hierarchische Beziehungen als baumartige Strukturen modelliert werden,
wie zum Beispiel in einem Dateisystem, wo es Ordner und Dateien gibt. Ordner
können Dateien und andere Ordner enthalten. Dateien hingegen stehen ganz am Ende
der Hierarchie.

Im Projekt `Flatten` ist ein Composite implementiert (`Composite.cs`). Einem
`Composite` können mithilfe der `Add()`-Methode Elemente vom Typ `Node`
(`Node.cs`) hinzugefügt werden. Ein `Node` ist ein Interface, das von den beiden
Klassen `Value` (`Value.cs`) und `List` (`List.cs`) implementiert wird. Ein
`Value` besteht aus einem ganzzahligen Wert. Eine `List` besteht aus einer Reihe
von `Node`-Objekten, die entweder ein einfacher `Value` oder wieder eine `List`
sein können. Dadurch lassen sich beliebig tief verschachtelte Strukturen
aufbauen. Das Beispielprogramm in `Flatten/Program.cs` baut folgende  Struktur
auf:

    0, [1, 2, 3], 4, [5, [6, [7]]], 8, [9]

Die Methode `Composite.Flatten()` soll aus dieser Struktur eine Flache Liste
erzeugen, die in diesem Fall folgendermassen aussehen sollte:

    [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]

Implementieren Sie  die Methode `Composite.Flatten()`!

Testfälle sind in `Flatten.Tests/CompositeTest.cs` vorhanden:

    $ dotnet test Flatten.Tests

Sie können die Beispielanwendung folgendermassen ausführen:

    $ dotnet run --project Flatten

Tipp: Sie können das `Node`-Interface um eine Methode erweitern, die dann von
`Value` und `List` implementiert werden muss. Diese Methode könnte eine Flache
Liste für das jeweilige Element zurückgeben.
