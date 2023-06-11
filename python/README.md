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

TODO: Tests vorgeben