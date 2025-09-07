using System.ComponentModel.DataAnnotations;

namespace MetricSystem.Models
{
    public class MetricSystemModel
    {
        [Required(ErrorMessage = "Fahrenheit Value is required.")]
        
        [Range(typeof(decimal), "-459.67", "10000",
            ErrorMessage = "Fahrenheit must be ≥ -459.67.")]
        public decimal? FahrenheitValue { get; set; }

        
        public decimal? CelsiusValue { get; set; }


        public decimal? CalculateMetricSystem()
        {
            if (!FahrenheitValue.HasValue) return null;

            decimal celsius = (FahrenheitValue.Value - 32m) * 5m / 9m;
            CelsiusValue = celsius;
            return celsius;
        }
    }
}