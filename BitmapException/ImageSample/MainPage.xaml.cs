using Android.Graphics.Drawables;

namespace ImageSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button_Clicked(object sender, EventArgs e)
        {
#if ANDROID
            if (this.image != null && this.image.Handler != null && this.image.Handler.PlatformView is Android.Views.View nativeView)
            {
                if (nativeView is Android.Widget.ImageView imageView && imageView.Drawable is BitmapDrawable drawable)
                {
                    var bitmap = drawable.Bitmap?.Copy(drawable.Bitmap.GetConfig(), true);
                    if (bitmap == null)
                    {
                        return;
                    }

                    Android.Graphics.Bitmap? newBitmap = Android.Graphics.Bitmap.CreateBitmap(bitmap.Width, bitmap.Height, drawable.Bitmap!.GetConfig());
                    Android.Graphics.Canvas canvas = new Android.Graphics.Canvas(bitmap);
                    nativeView.Draw(canvas);

                    //// This will scale the bitmap to the specified width and height of image dimensions.
                    bitmap = Android.Graphics.Bitmap.CreateScaledBitmap(bitmap, (int)this.image.Width, (int)this.image.Height, true);

                }
            }
#endif
        }
    }
}
