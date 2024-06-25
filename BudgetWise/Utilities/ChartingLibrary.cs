using BudgetWise.Interfaces;
using BudgetWise.Repositories;
using ScottPlot;
using ScottPlot.WinForms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetWise.Utilities
{
    public class ChartingLibrary
    {
        public void SpendingByCategoryBar(FormsPlot plot, IPersonalUserRepository userRepository, int id)
        {
            Dictionary<string, decimal> spending = userRepository.GetSpendingByCategory(id);
            List<double> positions = new List<double>();
            List<string> labels = new List<string>();
            var tickindex = 0;
            plot.Plot.Clear();
            plot.Plot.Grid.IsVisible = false;
            plot.Plot.Title("Amount Spent By Category");
            plot.Plot.XLabel("Category");
            plot.Plot.YLabel("Amount Spent");

            foreach(var item in spending)
            {
                positions.Add(tickindex);
                labels.Add(item.Key);
                tickindex++;
            }

            double[] arrPos = positions.ToArray();
            string[] arrLabels = labels.ToArray();

            plot.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(arrPos, arrLabels);
            plot.Plot.Axes.Bottom.MajorTickStyle.Length = 0;
            plot.Plot.Axes.Margins(bottom: 0);

            var index = 0;
            double[] values = new double[spending.Count];
            foreach (var amount in spending)
            {
                values[index] = (Convert.ToDouble(amount.Value));
                index++;
            }

            plot.Plot.Add.Bars(values);
        }
        public void SpendingByMonthBar(FormsPlot plot, IPersonalUserRepository userRepository, int id)
        {

            Dictionary<int, decimal> monthlySpend = userRepository.GetSpendingByMonth(id);
            Dictionary<string, decimal> monthSpendStrings = new Dictionary<string, decimal>();
            List<string> months = new List<string>();
            List<double> amount = new List<double>();
            List<double> positions = new List<double>();

            plot.Plot.Clear();
            plot.Plot.Grid.IsVisible = false;
            plot.Plot.Title("Amount Spent By Month");
            plot.Plot.XLabel("Month");
            plot.Plot.YLabel("Amount Spent");

            foreach (var item in monthlySpend)
            {
                string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(item.Key);
                monthSpendStrings.Add(monthName, item.Value);
            }

            var tickIndex = 0;
            foreach(var item in monthSpendStrings)
            {
                months.Add(item.Key);
                amount.Add(Convert.ToDouble(item.Value));
                positions.Add(tickIndex);
                tickIndex++;
            }
            double[] arrPos = positions.ToArray();
            string[] arrLabels = months.ToArray();

            plot.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(arrPos, arrLabels);
            plot.Plot.Axes.Bottom.MajorTickStyle.Length = 0;
            plot.Plot.Axes.Margins(bottom: 0);

            var index = 0;
            double[] values = new double[monthSpendStrings.Count];
            foreach (var amountSpent in monthSpendStrings)
            {
                values[index] = (Convert.ToDouble(amountSpent.Value));
                index++;
            }

            plot.Plot.Add.Bars(values);
        }
    }
}
