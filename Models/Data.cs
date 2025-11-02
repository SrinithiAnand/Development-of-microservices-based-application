namespace Sensors.Models

{
public class TemperatureSensor
{
    public int Id { get; set; }             // Unique identifier for the sensor
    public int SensorNumber { get; set; }    // Unique identifier for each sensor reading
    public DateTime Timestamp { get; set; }  // Timestamp indicating when the reading was taken
    public double Temperature { get; set; }  // Temperature measured by the sensor in Celsius
}

public class RainfallSensor
{
    public int Id { get; set; }             // Unique identifier for the sensor
    public int SensorNumber { get; set; }    // Unique identifier for each sensor reading
    public DateTime Timestamp { get; set; }  // Timestamp indicating when the reading was taken
    public double Rainfall { get; set; }     // Rainfall measured by the sensor in millimeters
}

public class HumiditySensor
{
    public int Id { get; set; }             // Unique identifier for the sensor
    public int SensorNumber { get; set; }    // Unique identifier for each sensor reading
    public DateTime Timestamp { get; set; }  // Timestamp indicating when the reading was taken
    public double Humidity { get; set; }     // Humidity measured by the sensor in percentage
}

public class AirPollutionSensor
{
    public int Id { get; set; }             // Unique identifier for the sensor
    public int SensorNumber { get; set; }    // Unique identifier for each sensor reading
    public DateTime Timestamp { get; set; }  // Timestamp indicating when the reading was taken
    public int AirQualityIndex { get; set; } // Air Quality Index (AQI) measured by the sensor
}

public class CO2EmissionsSensor
{
    public int Id { get; set; }             // Unique identifier for the sensor
    public int SensorNumber { get; set; }    // Unique identifier for each sensor reading
    public DateTime Timestamp { get; set; }  // Timestamp indicating when the reading was taken
    public double CO2Emissions { get; set; } // CO2 emissions measured by the sensor in tonnes of CO2e
}
public class Data
    {
        public int Id { get; set; }
        public int No { get; set; }
        public string? Name { get; set; }
    }

}
