using System;
using System.Linq;

namespace Names
{
    internal static class HistogramTask
    {
        public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
        {
            names = names.Where(n => n.Name == name).ToArray();
            var xLabels = new string[31];
            var ages = new double[31];

            for (int i = 0; i < xLabels.Length; i++)
            {
                xLabels[i] = (i + 1).ToString();
                ages[i] = i !=0 ? names.Count(n => n.BirthDate.Day == i + 1) : 0;
            }

            return new HistogramData(
                string.Format("Рождаемость людей с именем '{0}'", name), 
                xLabels, 
                ages);
        }
    }
}