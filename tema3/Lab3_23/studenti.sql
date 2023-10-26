INSERT INTO [students] (Id, DateTime, LastModified, Name, Age)
VALUES (NEWID(), GETDATE(), GETDATE(), 'Test2', 23);

Select * from Students ;
