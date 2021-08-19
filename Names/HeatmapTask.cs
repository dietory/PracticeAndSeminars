using System.Linq;

namespace Names
{
    internal static class HeatmapTask
    {
        public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
        {
            var xLabels = new string[30];
            var yLabels = new string[12];
            var heatValues = new double[30, 12];
            for (int y = 0; y < yLabels.Length; y++)
            {
                yLabels[y] = (y + 1).ToString();

                for (int x = 0; x < xLabels.Length; x++)
                {
                    xLabels[x] = (x + 2).ToString();
                    heatValues[x, y] = names.Count(n => n.BirthDate.Day == x + 2 && n.BirthDate.Month == y + 1);
                }
            }
            return new HeatmapData(
                "Пример карты интенсивностей",
                heatValues, 
                xLabels, 
                yLabels);
        }
    }
}