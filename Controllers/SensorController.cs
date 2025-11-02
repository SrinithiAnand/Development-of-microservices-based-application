using Microsoft.AspNetCore.Mvc;
using Sensors.Models;
using System;
using System.Collections.Generic;

namespace Sensors.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SensorController : ControllerBase
    {
        private readonly Random random = new Random();

        // Sample data collection interval constants
        private readonly TimeSpan temperatureInterval = TimeSpan.FromMinutes(30);
        private readonly TimeSpan rainfallInterval = TimeSpan.FromMinutes(30);
        private readonly TimeSpan humidityInterval = TimeSpan.FromHours(1);
        private readonly TimeSpan airPollutionInterval = TimeSpan.FromHours(1);
        private readonly TimeSpan co2EmissionsInterval = TimeSpan.FromHours(2);

        // GET api/sensor
        [HttpGet]
        public ActionResult<IEnumerable<object>> Get()
        {
            List<object> sensorReadings = GenerateSensorReadings();
            return Ok(sensorReadings);
        }

        // POST api/sensor/temperature
        [HttpPost("temperature")]
        public ActionResult<TemperatureSensor> PostTemperature()
        {
            TemperatureSensor reading = GenerateTemperatureReading();
            // Save the reading to the database or perform other necessary operations
            return Ok(reading);
        }

        // PUT api/sensor/temperature/{id}
        [HttpPut("temperature/{id}")]
        public ActionResult<TemperatureSensor> PutTemperature(int id)
        {
            // Update the temperature reading with the specified id
            TemperatureSensor updatedReading = GenerateTemperatureReading();
            // Perform the update operation and return the updated reading
            return Ok(updatedReading);
        }

        // DELETE api/sensor/temperature/{id}
        [HttpDelete("temperature/{id}")]
        public ActionResult DeleteTemperature(int id)
        {
            // Delete the temperature reading with the specified id
            // Perform the delete operation
            return NoContent();
        }

        // Similar POST, PUT, DELETE methods for other sensor types...

        private List<object> GenerateSensorReadings()
        {
            List<object> sensorReadings = new List<object>();

            // Generate Temperature sensor readings
            for (int i = 0; i < 3; i++)
            {
                sensorReadings.Add(GenerateTemperatureReading());
            }

            // Generate Rainfall sensor readings
            for (int i = 0; i < 2; i++)
            {
                sensorReadings.Add(GenerateRainfallReading());
            }

            // Generate Humidity sensor reading
            sensorReadings.Add(GenerateHumidityReading());

            // Generate Air Pollution sensor reading
            sensorReadings.Add(GenerateAirPollutionReading());

            // Generate CO2 Emissions sensor readings
            for (int i = 0; i < 5; i++)
            {
                sensorReadings.Add(GenerateCO2EmissionsReading());
            }

            return sensorReadings;
        }

        private TemperatureSensor GenerateTemperatureReading()
        {
            return new TemperatureSensor
            {
                Id = random.Next(),
                SensorNumber = random.Next(),
                Timestamp = DateTime.UtcNow,
                Temperature = random.NextDouble() * (39 - (-20)) + (-20)
            };
        }

        private RainfallSensor GenerateRainfallReading()
        {
            return new RainfallSensor
            {
                Id = random.Next(),
                SensorNumber = random.Next(),
                Timestamp = DateTime.UtcNow,
                Rainfall = random.NextDouble() * (40 - 0)
            };
        }

        private HumiditySensor GenerateHumidityReading()
        {
            return new HumiditySensor
            {
                Id = random.Next(),
                SensorNumber = random.Next(),
                Timestamp = DateTime.UtcNow,
                Humidity = random.NextDouble() * 100
            };
        }

        private AirPollutionSensor GenerateAirPollutionReading()
        {
            return new AirPollutionSensor
            {
                Id = random.Next(),
                SensorNumber = random.Next(),
                Timestamp = DateTime.UtcNow,
                AirQualityIndex = random.Next(1, 11)
            };
        }

        private CO2EmissionsSensor GenerateCO2EmissionsReading()
        {
            return new CO2EmissionsSensor
            {
                Id = random.Next(),
                SensorNumber = random.Next(),
                Timestamp = DateTime.UtcNow,
                CO2Emissions = random.NextDouble() * 100
            };
        }
    }
}
