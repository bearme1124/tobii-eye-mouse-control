using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tobii.Interaction;
using WindowsInput;

namespace TobiiFormApp
{
    static class Program
    {
        private static Point prevPos;
        private static bool hasPrevPos;
        private static float alpha_smooth = 0.3f;

        private enum filters {Smooth, Averaged, Euro, Unfiltered};

        private static bool enableGazeMouseControl = false;
        private static int currentFilter;

        private static Form1 form;
        private static IKeyboardMouseEvents m_GlobalHook;

        #region EUROFilter
        public static long GetTimestamp() // 이 값에 1000을 나눠야 second 단위임.
        {
            return DateTimeOffset.Now.ToUnixTimeMilliseconds();
        }

        public class OneEuroFilter
        {
            public OneEuroFilter(double minCutoff, double beta) 
            {
                firstTime = true;
                this.minCutoff = minCutoff;
                this.beta = beta;

                xFlit = new LowpassFilter();
                dxFlit = new LowpassFilter();
                dcutoff = 1.0; // 여기 value 값이 초기 설정해야 하는 cutoff for derivative;
            }
            protected bool firstTime;
            protected double minCutoff;
            protected double beta;
            protected LowpassFilter xFlit;
            protected LowpassFilter dxFlit;
            protected double dcutoff;

            public double MinCutoff
            {
                get { return minCutoff; }
                set { minCutoff = value; } //여기 value 값이 초기 설정해야 하는 cutoff minimum;
            }
            public double Beta
            {
                get { return beta; }
                set { beta = value; } //여기 value 값이 초기 설정해야 하는 beta;
            }
            public double Filter(double x, double rate)
            {
                double dx = firstTime ? 0 : (x - xFlit.Last()) * rate;
                if (firstTime)
                {
                    firstTime = false;
                }
                var edx = dxFlit.Filter(dx, Alpha(rate, dcutoff));
                var cutoff = minCutoff + beta * Math.Abs(edx);

                return xFlit.Filter(x, Alpha(rate, cutoff));
            }
            protected double Alpha(double rate, double cutoff)
            {
                var tau = 1.0 / (2 * Math.PI * cutoff);
                var te = 1.0 / rate;
                return 1.0 / (1.0 + tau / te);
            }
        }
        public class LowpassFilter
        {
            public LowpassFilter()
            {
                firstTime = true;
            }
            protected bool firstTime;
            protected double hatXPrev;

            public double Last()
            {
                return hatXPrev;
            }
            public double Filter(double x, double alpha)
            {
                double hatX = 0;
                if(firstTime)
                {
                    firstTime = false;
                    hatX = x;
                }
                else
                {
                    hatX = alpha * x + (1 - alpha) * hatXPrev;
                }
                hatXPrev = hatX;
                return hatX;
            }
        }
        #endregion

        private static void GlobalHookKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                InputSimulator inputSimulator = new InputSimulator(); //!!!!!
                inputSimulator.Mouse.LeftButtonDown();
            }
        }

        private static void GlobalHookKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                InputSimulator inputSimulator = new InputSimulator(); //!!!!!
                inputSimulator.Mouse.LeftButtonUp();
            }
        }

        //Moves the mouse cursor and applies filter based on the currently selected setting
        private static void moveCursor(int x, int y)
        {
            Cursor.Position = SmoothFilter(new Point(x,y));
        }

        private static void subscribeGlobalKeyHook()
        {
            m_GlobalHook = Hook.GlobalEvents();
            m_GlobalHook.KeyDown += GlobalHookKeyDown;
            m_GlobalHook.KeyUp += GlobalHookKeyUp;
        }

        private static void unsubscribeGlobalKeyHook()
        {
            m_GlobalHook.KeyDown -= GlobalHookKeyDown;
            m_GlobalHook.KeyUp -= GlobalHookKeyUp;
            m_GlobalHook.Dispose();
        }

        //Applies a filter to the point based on currently selected setting
        private static Point SmoothFilter(Point point)
        {
            //checks which filter is selected
            checkFilterSettings();

            Point filteredPoint = point;

            if (!hasPrevPos)
            {
                prevPos = point;
                hasPrevPos = true;
            }

            if(currentFilter == (int)filters.Smooth)
            {
                filteredPoint = new Point((int)((point.X * alpha_smooth) + (prevPos.X * (1.0f - alpha_smooth))),
                                                (int)((point.Y * alpha_smooth) + (prevPos.Y * (1.0f - alpha_smooth))));
            }
            else if(currentFilter == (int)filters.Averaged)  //takes the average of the current point and the previous point
            {
                filteredPoint = new Point((point.X + prevPos.X) / 2, (point.Y + prevPos.Y) / 2);
            }
            else if(currentFilter == (int)filters.Euro)
            {
                OneEuroFilter oneEuroFilter
                filteredPoint = new Point(point.X, point.Y);
            }
            prevPos = filteredPoint; //set the previous point to current point

            return filteredPoint;
        }

        private static void toggleGazeMouse(object sender, EventArgs e)
        {
            enableGazeMouseControl = !enableGazeMouseControl;
        }

        private static void checkFilterSettings()
        {
            if (form.radioButton1.Checked) //Smooth alpha filter
            {
                currentFilter = (int)filters.Smooth;
            }
            else if (form.radioButton2.Checked) //Averaged filter
            {
                currentFilter = (int)filters.Averaged;
            }
            else if (form.radioButton4.Checked) // 1EURO filter
            {
                currentFilter = (int)filters.Euro;
            }
            else //unfiltered
            {
                currentFilter = (int)filters.Unfiltered;
            }
        }

        [STAThread]
        static void Main()
        {
            var host = new Host();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            form = new Form1();

            subscribeGlobalKeyHook();

            //handle the 'toggle gaze control' button event
            form.button1.Click += new System.EventHandler(toggleGazeMouse);

            //create the data stream
            var gazePointDataStream = host.Streams.CreateGazePointDataStream(Tobii.Interaction.Framework.GazePointDataMode.LightlyFiltered);
            gazePointDataStream.GazePoint((x, y, _) =>
            {
                if (enableGazeMouseControl)
                {
                    moveCursor((int)x, (int)y);
                    //update the form labels with gaze coordinate
                    form.label3.Invoke((MethodInvoker)(() => form.label3.Text = x.ToString()));
                    form.label4.Invoke((MethodInvoker)(() => form.label4.Text = y.ToString()));
                    form.label6.Invoke((MethodInvoker)(() => form.label6.Text = GetTimestamp().ToString())); 
                }
                
            });

            Application.Run(form);
        }
    }
}
