using System;
using System.Windows.Forms;
using Tekla.Structures.Model;

namespace Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MyModel = new Model();
        }

        private readonly Model MyModel;

        /// <summary>
        /// Callback function to create objects on corrent places.
        /// Two loops are used to go through all positions.
        /// </summary>
        private void CreatePadFootings(object sender, EventArgs e)
        {
            // Always remember to check that you really have working connection
            if (MyModel.GetConnectionStatus())
            {
                // Loop through X-axis  (these loops should be changed to match current grid)
                 for (double PositionX = 0.0; PositionX <= 12000.0; PositionX += 3000.0)
                {
                    // In first and in last line
                    if (PositionX.Equals(0.0) || PositionX.Equals(12000.0))
                    {
                        // Loop through Y-axis to get pad footings on the longer sides of the grid
                         for (double PositionY = 0.0; PositionY <= 30000.0; PositionY += 6000.0)
                        {
                            CreatePadFooting(PositionX, PositionY);
                        }
                    }
                    else
                    {   // Create pad footings on the shorter sides of the grid
                        CreatePadFooting(PositionX, 0.0);
                        CreatePadFooting(PositionX, 30000.0);
                    }
                }
                // Always remember to commit changes to Tekla Structures, otherwise some things might be left in uncertain state
                MyModel.CommitChanges();
            }
        }

        /// <summary>
        /// Method that creates a pad footing on given position and returns the created pad footing.
        /// The created pad footing is recognized as beam in Tekla Structures.
        /// </summary>
        /// <param name="PositionX">X-coordination of the position</param>
        /// <param name="PositionY">Y-coordination of the position</param>
        /// <returns></returns>
        private static void CreatePadFooting(double PositionX, double PositionY)
        {
            Beam PadFooting1 = new Beam();

            PadFooting1.Name = "FOOTING";
            PadFooting1.Profile.ProfileString = "1500*1500";
            PadFooting1.Material.MaterialString = "C50/60";
            PadFooting1.Class = "8";
            PadFooting1.StartPoint.X = PositionX;
            PadFooting1.StartPoint.Y = PositionY;
            PadFooting1.StartPoint.Z = 0.0;
            PadFooting1.EndPoint.X = PositionX;
            PadFooting1.EndPoint.Y = PositionY;
            PadFooting1.EndPoint.Z = -500.0;
            PadFooting1.Position.Rotation = Position.RotationEnum.FRONT;
            PadFooting1.Position.Plane = Position.PlaneEnum.MIDDLE;
            PadFooting1.Position.Depth = Position.DepthEnum.MIDDLE;

            PadFooting1.Insert();
        }
    }
}