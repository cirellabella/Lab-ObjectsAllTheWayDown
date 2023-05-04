using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_ObjectsAllTheWayDown
{
    internal class Sunglasses
    {
        private string lensShape;
        private int templeLength;
        private int bridgeWidth;
        private int lensWidth;
        private string color;
        private string pattern;
        private float lensDarkness;
        private int uvProtectionFactor;
        private string frameMaterial;
        private string frameStyle;
        private string lensColor;
        private string logo;
        private string name;

        public string LensShape { get => lensShape; set => lensShape = value; }
        public int TempleLength { get => templeLength; set => templeLength = value; }
        public int BridgeWidth { get => bridgeWidth; set => bridgeWidth = value; }
        public int LensWidth { get => lensWidth; set => lensWidth = value; }
        public string Color { get => color; set => color = value; }
        public string Pattern { get => pattern; set => pattern = value; }
        public float LensDarkness { get => lensDarkness; set => lensDarkness = value; }
        public int UvProtectionFactor { get => uvProtectionFactor; set => uvProtectionFactor = value; }
        public string FrameMaterial { get => frameMaterial; set => frameMaterial = value; }
        public string FrameStyle { get => frameStyle; set => frameStyle = value; }
        public string LensColor { get => lensColor; set => lensColor = value; }
        public string Logo { get => logo; set => logo = value; }
        public string Name { get => name; set => name = value; }

        public Sunglasses(string lensShape, int templeLength, int bridgeWidth, int lensWidth, string color, string pattern, float lensDarkness, int uvProtectionFactor, string frameMaterial, string frameStyle, string lensColor, string logo, string name)
        {
            this.LensShape = lensShape;
            this.TempleLength = templeLength;
            this.BridgeWidth = bridgeWidth;
            this.LensWidth = lensWidth;
            this.Color = color;
            this.Pattern = pattern;
            this.LensDarkness = lensDarkness;
            this.UvProtectionFactor = uvProtectionFactor;
            this.FrameMaterial = frameMaterial;
            this.FrameStyle = frameStyle;
            this.LensColor = lensColor;
            this.Logo = logo;
            this.Name = name;
        }
    }
}
