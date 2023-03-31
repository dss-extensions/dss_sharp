using dss_sharp;
using ScottPlot;
using System.Windows.Forms;

namespace WinFormsAppSample
{
    public partial class Form1 : Form
    {
        DSS engine;

        public Form1()
        {
            InitializeComponent();
            engine = new DSS();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(engine.Version);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var lines = textBox1.Lines;
            foreach (var line in lines)
            {
                try
                {
                    engine.Text.Command = line;
                }
                catch (DSSException ex)
                {
                    MessageBox.Show(ex.Message);
                    break;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Try running the test circuit
            try
            {
                engine.Text.Command = @"compile 'C:\Program Files\OpenDSS\IEEETestCases\13Bus\IEEE13Nodeckt.dss'";
            }
            catch (DSSException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            var circ = engine.ActiveCircuit;

            // Create an array for the x-axis and clear any previous plot
            var x = new double[circ.NumNodes];
            for (int i = 0; i < x.Length; ++i)
            {
                x[i] = i + 1;
            }
            var plot = formsPlot1.Plot;
            plot.Clear();

            // Ensure the solution mode is snapshot, and solve the base case
            circ.Solution.Mode = (int)SolveModes.dssSnapShot;
            circ.Solution.LoadMult = 1.0;
            circ.Solution.Solve();

            // Be sure to check the convergency since it doesn't necessarily becomes
            // an error/exception if the system fails to converge.
            if (!circ.Solution.Converged)
            {
                MessageBox.Show("Failed to converge.");
                return;
            }

            // Add the base plot
            plot.AddScatter(x, circ.AllBusVmagPu, label: "Base case");

            // Solve the 1.5x load case, add it to the plot
            circ.Solution.LoadMult = 1.5;
            circ.Solution.Solve();
            if (!circ.Solution.Converged)
            {
                MessageBox.Show("Failed to converge.");
                return;
            }

            plot.AddScatter(x, circ.AllBusVmagPu, label: "1.5x load");

            // Finishing touches to the chart
            plot.Legend();
            plot.XLabel("Bus index");
            plot.YLabel("Voltage (pu)");
            plot.Title($"Circuit: {circ.Name}, NumNodes: {circ.NumNodes}");

            formsPlot1.Refresh();
        }
    }
}
