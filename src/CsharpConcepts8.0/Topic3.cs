using System;

namespace CsharpConcepts8._0
{
    class Topic3
    {
        public void Entry()
        {
            var color = FromRainbow(Topic3Rainbow.Blue);
            Console.WriteLine(FromRGB(color));
            Console.WriteLine(FromTuples(0x4B, 0x00, 0x82));

            var orange = FromRainbow(Topic3Rainbow.Orange);
            Console.WriteLine(GetColor(orange));
        }

        //switch expressions
        Topic3RgbColor FromRainbow(Topic3Rainbow colorBand) =>
                colorBand switch
                {
                    Topic3Rainbow.Red => new Topic3RgbColor(0xFF, 0x00, 0x00),
                    Topic3Rainbow.Orange => new Topic3RgbColor(0xFF, 0x7F, 0x00),
                    Topic3Rainbow.Yellow => new Topic3RgbColor(0xFF, 0xFF, 0x00),
                    Topic3Rainbow.Green => new Topic3RgbColor(0x00, 0xFF, 0x00),
                    Topic3Rainbow.Blue => new Topic3RgbColor(0x00, 0x00, 0xFF),
                    Topic3Rainbow.Indigo => new Topic3RgbColor(0x4B, 0x00, 0x82),
                    Topic3Rainbow.Violet => new Topic3RgbColor(0x94, 0x00, 0xD3),
                    _ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(colorBand)),
                };

        //Property patterns
        string FromRGB(Topic3RgbColor rgbColor) =>
                rgbColor switch
                {
                    { R: 0xFF } => Topic3Rainbow.Red.ToString(),
                    { G: 0xFF } => Topic3Rainbow.Green.ToString(),
                    { B: 0xFF } => Topic3Rainbow.Blue.ToString(),
                    _ => throw new ArgumentException(message: "invalid value"),
                };

        //Tuple patterns
        string FromTuples(int r, int g, int b) =>
                (r, g, b) switch
                {
                    (0x4B, 0x00, 0x82) => Topic3Rainbow.Indigo.ToString(),
                    (0x94, 0x00, 0xD3) => Topic3Rainbow.Violet.ToString(),
                    _ => throw new ArgumentException(message: "invalid value"),
                };

        //Positional patterns
        string GetColor(Topic3RgbColor color) =>
                color switch
                {
                    var (r, g, b) when r == 0xFF && g == 0x7F && b == 0x00 => Topic3Rainbow.Orange.ToString(),
                    _ => throw new ArgumentException(message: "invalid value"),
                };
    }

    internal enum Topic3Rainbow
    {
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Indigo,
        Violet
    }

    public class Topic3RgbColor
    {
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
        public Topic3RgbColor(int r, int g, int b)
        {
            R = r;
            G = g;
            B = b;
        }
        public void Deconstruct(out int r, out int g, out int b) => (r, g, b) = (R, G, B);
    }
}
