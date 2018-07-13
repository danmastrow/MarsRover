using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarsRover
{
    public partial class Form1 : Form
    {
        private IList<IRover> rovers;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. Read and seperate File
            Console.WriteLine("Parsing file");

            // 2. Parse size of the plateu.
            var testPlateuSize = 5;
            IPlateu plateu = new Plateu(testPlateuSize);

            // 3. Parse Rovers
            string[] testRoverInput = { "1 2 N", "3 E" };

            // 4. Parse each Rovers Path
            string[] paths = { "LMLMLMLMM 3", "MMRMMRMRRM" };

            // 5. Start animation timer.
            // Ever x Seconds call MoveRover
            rovers = new List<Rover>()
            {
                new Rover(50,50,5,Color.Red)
            };
        }

        private void DrawRovers()
        {
            Graphics formGraphics = this.CreateGraphics();

            foreach (var rover in rovers)
            {
                var rectBrush = new SolidBrush(rover.Color);
                var stringBrush = new SolidBrush(rover.DirectionColor);
                var rect = new Rectangle(rover.X, rover.Y, rover.Size, rover.Size);

                formGraphics.FillRectangle(rectBrush, rect);
                formGraphics.DrawString(rover.Direction.ToString(), rover.DirectionFont, stringBrush, rover.X, rover.Y);

                rectBrush.Dispose();
                stringBrush.Dispose();
            }
            formGraphics.Dispose();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            DrawRovers();
            //var x = 200;
            //var y = 200;
            //var size = 50;
            //var direction = "N";
            //Font drawFont = new Font("Arial", 16);
            //Graphics formGraphics;
            //SolidBrush myBrush = new SolidBrush(Color.OrangeRed);
            //

            //formGraphics.FillRectangle(myBrush, new Rectangle(x, y, size, size));
            //myBrush.Color = Color.Black;
            //formGraphics.DrawString(direction, drawFont, myBrush, x, y);

            //myBrush.Dispose();
            //formGraphics.Dispose();
        }
    }
}
