CREATE TABLE [dbo].[Sensor]
(
    [SensorId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [SensorName] NVARCHAR(100) NOT NULL,             
    [SensorType] NVARCHAR(50) NULL,                 
    [Location] NVARCHAR(100) NULL,                
    [LastReading] FLOAT NULL                         
);
