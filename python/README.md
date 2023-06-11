Richten Sie zunächst eine virtuelle Umgebung ein und aktivieren Sie sie:

    $ cd python
    $ python -m venv env

    $ . env/bin/activate       # Linux/Bash
    $ env/Scripts/activate     # Windows/Bash
    > env/Scripts/Activate.ps1 # Windows/PowerShell

Installieren Sie `pytest` und (optional) `mypy`:

    $ pip install pytest mypy

Mit `mypy` (und den im Code vorhandenen Typ-Annotationen) können Sie prüfen, ob
im Code die richtigen Datentypen verwendet werden und so mögliche Fehler schon
vor der Ausführung finden (hier: für alle Aufgaben):

    $ mypy .
    Success: no issues found in 2 source files

Oder für eine einzelne Aufgabe:

    $ pytest flatten

Mit `pytest` können Sie die Testfälle ausführen (hier: alle Tests in allen
Unterordnern):

    $ pytest .

Oder für eine einzelne Aufgabe:

    $ pytest flatten

# Aufgabe 1: Lotto (Test-Driven Development)

- komplett implementieren
- grundlegende Klassen geben
- Simulation schreiben (Verwendung dokumentieren)

# Aufgabe 2: ISBN-13 (Clean Code)

- korrekte Implementierung
- Tests gegeben
- schlechter Code

# Aufgabe 3: Schere, Stein, Papier (Refactoring)

mit Enum arbeiten:

- Move(Rock, Paper, Scissor)
- Result(LeftWins, RightWins, Draw)

# Aufgabe 4: Liste flach machen (Design Patterns)

Mit dem
[Composite](https://refactoring.guru/design-patterns/composite)-Entwurfsmuster
können hierarchische Beziehungen als baumartige Strukturen modelliert werden,
wie zum Beispiel in einem Dateisystem, wo es Ordner und Dateien gibt. Ordner
können Dateien und andere Ordner enthalten. Dateien hingegen stehen ganz am Ende
der Hierarchie.

Im Ordner `flatten/` ist ein Composite implementiert (`composite.py`). Einem
`Composite` können mithilfe der `add()`-Methode Elemente vom Typ `Node`
hinzugefügt werden. Ein `Node` ist ein Protokoll, das von den beiden Klassen
`Value` und `List` implementiert wird. Ein `Value` besteht aus einem
ganzzahligen Wert. Eine `List` besteht aus einer Reihe von `Node`-Objekten, die
entweder ein einfacher `Value` oder wieder eine `List` sein können. Dadurch
lassen sich beliebig tief verschachtelte Strukturen aufbauen. Das Beispielskript
in `flatten/composite.py` baut folgende  Struktur auf:

    0, [1, 2, 3], 4, [5, [6, [7]]], 8, [9]

Die Methode `Composite.flatten()` soll aus dieser Struktur eine Flache Liste erzeugen, die in diesem Fall folgendermassen aussehen sollte:

    [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]

Implementieren Sie  die Methode `Composite.flatten()`!

Testfälle sind in `flatten/composite_test.py` vorhanden:

    $ pytest flatten/composite_test.py

Sie können das Beispielskript folgendermassen ausführen:

    $ pytest flatten/composite.py
