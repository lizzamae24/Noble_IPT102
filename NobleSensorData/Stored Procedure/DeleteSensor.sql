CREATE PROCEDURE [dbo].[DeleteSensor]
    @SensorId INT
AS
BEGIN

    DELETE FROM [dbo].[Sensor]
    WHERE SensorId = @SensorId;

END
