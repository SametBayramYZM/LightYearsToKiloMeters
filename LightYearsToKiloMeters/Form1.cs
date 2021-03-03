using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightYearsToKiloMeters
{
    public partial class LightYearsToKiloMeters : Form
    {
        public LightYearsToKiloMeters()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double LightYear = Convert.ToDouble(tbLightYear.Text);
            double KiloMeter = LightYear * (Math.Pow(60, 2) * 24 * 365 * 299792.458) + (Math.Pow(60, 2) * 6 * 299792.458);
            lbKiloMeter.Text = Convert.ToString(KiloMeter);
            lbAU.Text = Convert.ToString(KiloMeter / 149597870.700) + " AU";
        }
    }
}
