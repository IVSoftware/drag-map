using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drag_map
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            countryMapImage.MouseMove += onMapMouseMove;
            countryMapImage.MouseDown += onMapMouseDown;
        }

        Point
            // Where's the cursor in relation to screen when mouse button is pressed?
            _mouseDownScreen = new Point(),
            // Where's the 'map' control when mouse button is pressed?
            _controlDownPoint = new Point(),
            // How much has the mouse moved from it's original mouse-down location?
            _mouseDelta = new Point();

        private void onMapMouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Control control)
            {                
                _mouseDownScreen = control.PointToScreen(e.Location);
                Text = $"{_mouseDownScreen}";
                _controlDownPoint = countryMapImage.Location;
            }
        }

        private void onMapMouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Equals(MouseButtons.Left))
            {
                if (sender is Control control)
                {
                    var screen = control.PointToScreen(e.Location);
                    _mouseDelta = new Point(screen.X - _mouseDownScreen.X, screen.Y - _mouseDownScreen.Y);
                    Text = $"{_mouseDownScreen} {screen} {_mouseDelta}";
                    var newControlLocation = new Point(_controlDownPoint.X + _mouseDelta.X, _controlDownPoint.Y + _mouseDelta.Y);
                    if(!countryMapImage.Location.Equals(newControlLocation))
                    {
                        countryMapImage.Location = newControlLocation;
                    }
                }
            }
        }
    }
}
