CREATE PROCEDURE [dbo].[UpdateSensor]
    @SensorId INT,
    @SensorName NVARCHAR(100),
    @SensorType NVARCHAR(50) = NULL,
    @Location NVARCHAR(100) = NULL,
    @LastReading FLOAT = NULL
AS
BEGIN

    UPDATE [dbo].[Sensor]
    SET SensorName = @SensorName,
        SensorType = @SensorType,
        Location = @Location,
        LastReading = @LastReading
    WHERE SensorId = @SensorId;

END
