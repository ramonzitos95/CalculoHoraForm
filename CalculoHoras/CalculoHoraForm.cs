using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoHoras
{
    public partial class CalculoHoraForm : Form
    {
        public CalculoHoraForm()
        {
            InitializeComponent();
            AlterFormatFromDateTimePicker();
            textTotal.Text = string.Empty;
        }

        public void CalculaHorasTrabalhadas()
        {
            var horaEntrada1 = dateTimePickerEntrada1.Value;
            var horaEntrada2 = dateTimePickerEntrada2.Value;
            var horaSaida1 = dateTimePickerSaida1.Value;
            var horaSaida2 = dateTimePickerSaida2.Value;

            var somaTotal = ((horaEntrada1 - horaSaida1) + (horaEntrada2 - horaSaida2)) *-1;
            textTotal.Text = $"{somaTotal.Hours.ToString()}:{somaTotal.Minutes.ToString()}:{somaTotal.Seconds.ToString()}";
        }

        private void AlterFormatFromDateTimePicker()
        {
            dateTimePickerEntrada1.Format = DateTimePickerFormat.Time;
            dateTimePickerEntrada2.Format = DateTimePickerFormat.Time;
            dateTimePickerSaida1.Format = DateTimePickerFormat.Time;
            dateTimePickerSaida2.Format = DateTimePickerFormat.Time;
        }

        private void dateTimePickerSaida2_Leave(object sender, EventArgs e)
        {
            CalculaHorasTrabalhadas();
        }
    }
}
