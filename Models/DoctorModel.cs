using Microsoft.AspNetCore.Mvc;

namespace WebDemo.Models
{
    public class FeverCheckFormData
    {
        public float TemperaturData { get; set; }
        public string FeberInteFeber { get; set; }

        public static string checkTemp(float temperatur) {
            if (temperatur < 35.0)
            {
                return "För låg kroppstemperatur";
            }
            else if (temperatur > 38.0)
            {
                return "Du har feber";
            }
            else
            {
                return "Du har normal kroppstemperatur";
            }
        }
    }
}