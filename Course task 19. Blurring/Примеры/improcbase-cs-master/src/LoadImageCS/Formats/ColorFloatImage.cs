using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace ImageReadCS
{
    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct ColorFloatPixel
    {
        public float b, g, r, a;
    }

    public class ColorFloatImage
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public readonly ColorFloatPixel[] rawdata;

        public ColorFloatImage(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
            rawdata = new ColorFloatPixel[Width * Height];
        }

        public ColorFloatPixel this[int x, int y]
        {
            get
            {
#if DEBUG
                if (x < 0 || x >= Width || y < 0 || y >= Height)
                    throw new IndexOutOfRangeException(string.Format("Trying to access pixel ({0}, {1}) in {2}x{3} image", x, y, Width, Height));
#endif
                return rawdata[y * Width + x];
            }
            set
            {
#if DEBUG
                if (x < 0 || x >= Width || y < 0 || y >= Height)
                    throw new IndexOutOfRangeException(string.Format("Trying to access pixel ({0}, {1}) in {2}x{3} image", x, y, Width, Height));
#endif
                rawdata[y * Width + x] = value;
            }
        }
    }
}
