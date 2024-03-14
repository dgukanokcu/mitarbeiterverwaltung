CREATE TABLE Mitarbeiter
(
    ID INT PRIMARY KEY IDENTITY(100,2),
    Vorname NVARCHAR(50),
    Nachname NVARCHAR(50),
    Strasse NVARCHAR(50),
    Nr NVARCHAR(5),
    PLZ NVARCHAR(10),
    Ort NVARCHAR(20),
    Telefon NVARCHAR(10),
    [E-Mail] NVARCHAR(50),
    Position NVARCHAR(50),
    EintrittDatum DATE,
    Gehalt INT,
    Rentenbeginn DATE,
    Geburtsdatum DATE,
    [Alter] INT,
    Geschlecht NVARCHAR(15)
);
