namespace TestSample
{
    internal class SlotsView : IDrawable
    {
        private float xPos = 50, width = 60;

        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            canvas.StrokeColor = Colors.LightGray;
            canvas.DrawLine(0, 0, dirtyRect.Width, 1);
            for (int i = 0; i < 60; i++)
            {
                canvas.DrawString(i.ToString(), new Rect(xPos, 0, 60, 100), HorizontalAlignment.Center, VerticalAlignment.Center);
                canvas.DrawLine(xPos, 0, xPos, dirtyRect.Height);
                xPos += width;
            }

            canvas.DrawLine(0, dirtyRect.Height, dirtyRect.Width, dirtyRect.Height);
            xPos = 50;
        }
    }
}
