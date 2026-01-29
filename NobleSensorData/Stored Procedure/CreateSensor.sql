CREATE PROCEDURE [dbo].[CreateSensor]
    @SensorName NVARCHAR(100),
    @SensorType NVARCHAR(50) = NULL,
    @Location NVARCHAR(100) = NULL,
    @LastReading FLOAT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO [dbo].[Sensor] (SensorName, SensorType, Location, LastReading)
    VALUES (@SensorName, @SensorType, @Location, @LastReading);

END
