CREATE TABLE Mitarbeiter
(
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Vorname NVARCHAR(50),
    Nachname NVARCHAR(50),
    Adresse NVARCHAR(MAX),
    Telefon NCHAR(20),
    [E-Mail] NVARCHAR(50),
    Position NVARCHAR(50),
    EintrittDatum DATE,
    Gehalt INT,
    Rentenbeginn DATE,
    Geburtsdatum DATE,
    Geschlecht NCHAR(15)
);
