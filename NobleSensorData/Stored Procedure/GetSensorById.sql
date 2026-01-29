CREATE PROCEDURE [dbo].[GetSensorById]
    @SensorId INT
AS
BEGIN

    SELECT SensorId,
           SensorName,
           SensorType,
           Location,
           LastReading
    FROM [dbo].[Sensor]
    WHERE SensorId = @SensorId;
END
