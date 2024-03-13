CREATE TABLE Mitarbeiter
(
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Vorname NVARCHAR(50),
    Nachname NVARCHAR(50),
    Adresse NVARCHAR(MAX),
    Strasse NVARCHAR(50),
    Hausnummer NVARCHAR(10),
    PLZ NVARCHAR(10),
    Ort NVARCHAR(20),
    Telefon NCHAR(20),
    [E-Mail] NVARCHAR(50),
    Position NVARCHAR(50),
    EintrittDatum DATE,
    Gehalt INT,
    Rentenbeginn DATE,
    Geburtsdatum DATE,
    [Alter] INT,
    Geschlecht NCHAR(15)
);
