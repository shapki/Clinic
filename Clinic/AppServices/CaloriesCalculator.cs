using System;
using System.Data.Entity;
using System.Linq;

namespace Clinic.AppServices
{
    public static class CalorieCalculator
    {
        public static double CalculateDailyCalories(int patientId, double activityCoefficient)
        {
            try
            {
                var patient = Program.context.Patients
                    .Include(p => p.Genders)
                    .FirstOrDefault(p => p.IdPatient == patientId);

                if (patient == null)
                {
                    throw new Exception($"Пациент с ID {patientId} не найден");
                }

                int age = CalculateAge(patient.BirthDate);

                double bmr = CalculateBMR(
                    patient.Genders.GenderName,
                    (double)patient.Weight,
                    (double)patient.Height,
                    age
                );

                double dailyCalories = bmr * activityCoefficient;

                return Math.Round(dailyCalories, 0);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при расчете калорий: {ex.Message}", ex);
            }
        }

        private static int CalculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;

            if (birthDate.Date > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }

        private static double CalculateBMR(string gender, double weight, double height, int age)
        {
            string normalizedGender = gender?.Trim().ToLower() ?? "";

            if (normalizedGender == "муж" || normalizedGender == "мужской" || normalizedGender == "м")
            {
                return (9.99 * weight) + (6.25 * height) - (4.92 * age) + 5;
            }
            else if (normalizedGender == "жен" || normalizedGender == "женский" || normalizedGender == "ж")
            {
                return (9.99 * weight) + (6.25 * height) - (4.92 * age) - 161;
            }
            else
            {
                throw new Exception($"Неизвестный пол: {gender}");
            }
        }

        public static double CalculateDailyCalories(int patientId, ActivityLevel activityLevel)
        {
            double coefficient = GetActivityCoefficient(activityLevel);
            return CalculateDailyCalories(patientId, coefficient);
        }

        private static double GetActivityCoefficient(ActivityLevel level)
        {
            switch (level)
            {
                case ActivityLevel.Minimal:
                    return 1.2;
                case ActivityLevel.Low:
                    return 1.375;
                case ActivityLevel.Moderate:
                    return 1.55;
                case ActivityLevel.High:
                    return 1.725;
                case ActivityLevel.Extreme:
                    return 1.9;
                default:
                    return 1.2;
            }
        }
    }

    public enum ActivityLevel
    {
        Minimal,
        Low,
        Moderate,
        High,
        Extreme
    }
}