CREATE TRIGGER tr_calcAgeAndRetirement
ON dbo.Mitarbeiter
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE m
    SET
        [Alter] = DATEDIFF(YEAR, i.Geburtsdatum, GETDATE()) - 
                   CASE WHEN MONTH(i.Geburtsdatum) > MONTH(GETDATE()) OR 
                             (MONTH(i.Geburtsdatum) = MONTH(GETDATE()) AND DAY(i.Geburtsdatum) > DAY(GETDATE()))
                        THEN 1 
                        ELSE 0 
                   END,
        Rentenbeginn = DATEADD(DAY, 22, DATEADD(YEAR, 67, i.Geburtsdatum))
    FROM dbo.Mitarbeiter m
    INNER JOIN inserted i ON m.ID = i.ID;
END;
