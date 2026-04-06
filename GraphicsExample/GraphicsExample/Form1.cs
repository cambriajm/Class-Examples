namespace GraphicsExample
{
    public partial class GraphicsForm : Form
    {
        public GraphicsForm()
        {
            InitializeComponent();
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            DrawLine();
            DrawEllipse();
            drawRectangle();
            drawPie();
            drawText();

        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        void DrawLine()
        {
            //create a Graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(Color.Black);
            thePen.Width = 10;
            //draw the line here
            g.DrawLine(thePen, 0, 0, DisplayPictureBox.Width, DisplayPictureBox.Height);

            //free up resources
            g.Dispose();
            thePen.Dispose();

        }

        void DrawEllipse()
        {
            //create a Graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(Color.Lime);
            thePen.Width = 5;

            g.DrawEllipse(thePen, 0, 0, 100, 100);

            //free up resources
            g.Dispose();
            thePen.Dispose();
        }


        //rectangle
        private void drawRectangle()
        {
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(Color.Lime);
            thePen.Width = 5;

            g.DrawRectangle(thePen, 100, 100, 200, 200);

            //free up resources
            g.Dispose();
            thePen.Dispose();
        }

        //drawPi
        private void drawPie()
        {
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(Color.Beige);
            SolidBrush theBrush = new SolidBrush(Color.Lavender);
            thePen.Width = 5;
            Rectangle bounds = new Rectangle(100, 100, 200, 200);

            g.DrawPie(thePen, bounds, 0, 6);
            g.FillPie(theBrush, bounds, 45, 130); 
            g.FillPie(theBrush, bounds, 70, 20); 
            g.FillPie(theBrush, bounds, 45, 210);

            //free up resources
            g.Dispose();
            thePen.Dispose();
        }


        //text
        private void drawText()
        {
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(Color.DarkOliveGreen);
            Font theFont = new Font("Arial",24);
            SolidBrush theBrush = new SolidBrush(Color.DarkOliveGreen);
            g.DrawString("WAAAAAA", theFont, theBrush, 0, DisplayPictureBox.Height / 5);
            
            //free up resources
            g.Dispose();
            thePen.Dispose();
        }

        //image


    }
}
