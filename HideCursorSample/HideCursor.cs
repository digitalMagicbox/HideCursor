using System;
using System.Windows.Input;
using System.Windows.Threading;

namespace HideCursorSample
{
    public class HideCursor : IDisposable
    {
        private readonly DispatcherTimer cursorTimer;
        public HideCursor(int interval = 5)
        {
            cursorTimer = new DispatcherTimer();
            cursorTimer.Tick += new EventHandler(CursorTimer_Tick);
            cursorTimer.Interval = new TimeSpan(0, 0, interval);
            cursorTimer.Start();
            Mouse.OverrideCursor = Cursors.None;
        }

        public void Dispose()
        {
            cursorTimer.Stop();
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        public void MouseMove(object sender, MouseEventArgs e)
        {
            if (Mouse.OverrideCursor == Cursors.None)
            {
                Mouse.OverrideCursor = Cursors.Arrow;
            }
            cursorTimer.Stop();
            cursorTimer.Start();
        }
        private void CursorTimer_Tick(object sender, EventArgs e)
        {
            Mouse.OverrideCursor = Cursors.None;
        }
    }
}