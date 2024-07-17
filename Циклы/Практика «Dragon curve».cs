using Avalonia.Media;
using System;

namespace Fractals;

internal static class DragonFractalTask
{
    public static void DrawDragonFractal(Pixels pixels, int iterationsCount, int seed)
    {
        Random random = new Random(seed);
        double x = 1;
        double y = 0;
        double newX;
        double newY;
        for (int i = 0; i < iterationsCount; i++)
        {
            var randomNumber = random.Next(2);
            if (randomNumber == 0)
                RotatePoint((45 * Math.PI) / 180, 0);
            else
                RotatePoint((135 * Math.PI) / 180, 1);
            pixels.SetPixel(x, y);
        }
        
        void RotatePoint(double angleRadian, int i)
        {
            newX = (x * Math.Cos(angleRadian) - y * Math.Sin(angleRadian)) / Math.Sqrt(2) + i;
            newY = (x * Math.Sin(angleRadian) + y * Math.Cos(angleRadian)) / Math.Sqrt(2);
            x = newX;
            y = newY;
        }
    } 
}
