using System.Globalization;
using ScottPlot;
using ScottPlot.AutoScalers;
using ScottPlot.AxisPanels;
using ScottPlot.AxisPanels.Experimental;
using ScottPlot.DataGenerators;
using ScottPlot.DataSources;
using ScottPlot.Plottables;
using ScottPlot.TickGenerators;
using Color = ScottPlot.Color;
using Timer = System.Threading.Timer;

namespace PID
{
    public partial class Form1 : Form
    {
        private PIDController _pidContrller;

        private int index = 0;
        private List<double> _dataPV = new List<double>() { 0, 0 };//过程值
        private List<double> _dataSP = new List<double>() { 0, 0 };//设定值
        private List<double> _dataOP = new List<double>() { 0, 0 };//输出值

        private RandomWalker _walkerPV = new RandomWalker(5, 0);
        private RandomWalker _walkerSP = new RandomWalker(1, 0);
        private RandomWalker _walkerOP = new RandomWalker(3, 0);

        private Scatter myScatterPV = null;
        private Scatter myScatterSP = null;
        private Scatter myScatterOP = null;

        private List<DateTime> _dataTime = new List<DateTime>() { DateTime.Now, DateTime.Now.AddSeconds(1) };//当前时间记录
        private System.Windows.Forms.Timer timer;
        private bool isRecording;

        public Form1()
        {
            InitializeComponent();
            InitPlot();
        }

        public void InitPlot()
        {
            isRecording = false;
            // 初始化定时器
            timer = new() { Interval = 10, Enabled = true };
            timer.Tick += Timer_Tick;
            /*配置 ScottPlot*/
            DateTimeXAxis? bottomAxes = formsPlot1.Plot.Axes.DateTimeTicksBottom();
            bottomAxes.LabelText = "Time";
            //配置时间轴的格式
            DateTimeAutomatic? tickGen = (ScottPlot.TickGenerators.DateTimeAutomatic)bottomAxes.TickGenerator;
            tickGen.LabelFormatter = CustomFormatter;
            tickGen.MaxTickCount = 1000;

            myScatterPV = formsPlot1.Plot.Add.ScatterLine(_dataTime, _dataPV);
            myScatterSP = formsPlot1.Plot.Add.ScatterLine(_dataTime, _dataSP);
            myScatterOP = formsPlot1.Plot.Add.ScatterLine(_dataTime, _dataOP);

            //Scatter? myScatterPV = formsPlot1.Plot.Add.ScatterLine(_dataTime, _dataPV);
            myScatterPV.Smooth = true;//将线圆润化
            myScatterPV.LegendText = "PV";
            myScatterPV.Color = Color.FromColor(System.Drawing.Color.Black);

            //Scatter? myScatterSP = formsPlot1.Plot.Add.ScatterLine(_dataTime, _dataSP);
            myScatterSP.Smooth = true;//将线圆润化
            myScatterSP.LegendText = "SP";
            myScatterSP.Color = Color.FromColor(System.Drawing.Color.Red);

            //Scatter? myScatterOP = formsPlot1.Plot.Add.ScatterLine(_dataTime, _dataOP);
            myScatterOP.Smooth = true;//将线圆润化
            myScatterOP.LegendText = "OP";
            myScatterOP.Color = Color.FromColor(System.Drawing.Color.DarkCyan);
            formsPlot1.Plot.ShowLegend();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (isRecording)
            {
                //横坐标自动滚动
                formsPlot1.Plot.Axes.Pan(new PixelOffset(1, 0));
                #region Scatter
                formsPlot1.Plot.Remove(myScatterPV);
                formsPlot1.Plot.Remove(myScatterSP);
                formsPlot1.Plot.Remove(myScatterOP);
                _dataPV.Add(_walkerPV.Next());
                _dataSP.Add(_walkerSP.Next());
                _dataOP.Add(_walkerOP.Next());
                _dataTime.Add(DateTime.Now);
                myScatterPV = formsPlot1.Plot.Add.ScatterLine(_dataTime, _dataPV);
                myScatterPV.Smooth = true;//将线圆润化
                myScatterPV.LegendText = "PV";
                myScatterPV.Color = Color.FromColor(System.Drawing.Color.Black);
                myScatterSP = formsPlot1.Plot.Add.ScatterLine(_dataTime, _dataSP);
                myScatterSP.Smooth = true;//将线圆润化
                myScatterSP.LegendText = "SP";
                myScatterSP.Color = Color.FromColor(System.Drawing.Color.Red);
                myScatterOP = formsPlot1.Plot.Add.ScatterLine(_dataTime, _dataOP);
                myScatterOP.Smooth = true;//将线圆润化
                myScatterOP.LegendText = "OP";
                myScatterOP.Color = Color.FromColor(System.Drawing.Color.DarkCyan);
                formsPlot1.Refresh();
                #endregion
            }
        }

        static string CustomFormatter(DateTime dt)
        {
            return dt.ToString("mm:ss");
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            isRecording = true;
            timer.Start();
            int count = 0;//设定计数器
            Task.Run(() =>
            {
                //仿真参数
                double simTime = 100;//仿真总时间(秒)
                double dt = 0.1;//仿真步长(秒)
                int steps = (int)(simTime / dt);

                //被控对象参数(管线压力传递函数)
                double K_process = 1.0;//被控对象增益
                double T_process = 5.0;//被控对象时间常数

                //初始化过程值、设定值、控制输出
                double pv = 0;
                double controlOutput = 0;
                while (count<steps)
                {
                    _dataOP.Add(_pidContrller.Compute(Convert.ToDouble(textBox_value_set.Text),pv,dt));
                }
            });
        }

        private void button_suspend_Click(object sender, EventArgs e)
        {
            isRecording = false;
            timer.Stop();
        }

        public void UpdateRealValue(double pv, double sp, double op)
        {
            _dataPV.Add(pv);
            _dataSP.Add(sp);
            _dataOP.Add(op);
        }

        private void button_create_Click(object sender, EventArgs e)
        {

            _pidContrller = new PIDController(Convert.ToDouble(textBox_value_p.Text),
                Convert.ToDouble(textBox_value_i.Text),
                Convert.ToDouble(textBox_value_d.Text),double.MaxValue,double.MinValue);
        }
    }
}
