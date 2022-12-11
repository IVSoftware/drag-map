Your [post]() states that your "draggable map resets to default after releasing and moving mouse".

Sometimes it's tricky to get the _relative_ coordinates right. Is the point relative to the control? To the main form? To the screen? 

Here's one approach that I just tested out that should help. The strategy for the `MouseDown` and `MouseMove` events is to convert the `e.Location` to _screen_ coordinates relative to `control` in order to calculate the dX and dY apples-to-apples. Then it's a simple matter of summing the delta to where the control was located on `MouseDown`.

    public MainForm()
    {
        InitializeComponent();
        countryMapImage.MouseMove += onMapMouseMove;
        countryMapImage.MouseDown += onMapMouseDown;
    }

    Point
        _mouseDownScreen = new Point(),
        _mouseDelta = new Point(),
        _controlDownPoint = new Point();

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

![screenshot](https://github.com/IVSoftware/drag-map/blob/master/drag-map/Screenshots/screenshot.png)

The `MouseUp` event shouldn't need to be handled in this simple scenario.
