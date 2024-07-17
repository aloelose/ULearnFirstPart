using System;

namespace Rectangles;

public static class RectanglesTask
{
    // Пересекаются ли два прямоугольника (пересечение только по границе также считается пересечением)
    public static bool AreIntersected(Rectangle r1, Rectangle r2)
    {
        bool horizontalOverlap = r1.Left <= r2.Right && r1.Right >= r2.Left;
        bool verticalOverlap = r1.Top <= r2.Bottom && r1.Bottom >= r2.Top;

        return horizontalOverlap && verticalOverlap;
    }
    // Площадь пересечения прямоугольников
    public static int IntersectionSquare(Rectangle r1, Rectangle r2)
    {
        if (AreIntersected(r1, r2))
        {
            int left = Math.Max(r1.Left, r2.Left);
            int right = Math.Min(r1.Right, r2.Right);
            int width = Math.Max(right - left, 0);

            int top = Math.Max(r1.Top, r2.Top);
            int bottom = Math.Min(r1.Bottom, r2.Bottom);
            int height = Math.Max(bottom - top, 0);

            return width * height;
        }
        else
        {
            return 0;
        }
    }
    // Если один из прямоугольников целиком находится внутри другого — вернуть номер (с нуля) внутреннего.
    // Иначе вернуть -1
    // Если прямоугольники совпадают, можно вернуть номер любого из них.
    public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
    {
        if (r1.Left <= r2.Left && r1.Right >= r2.Right && r1.Top <= r2.Top && r1.Bottom >= r2.Bottom)
            return 1;
        else if (r2.Left <= r1.Left && r2.Right >= r1.Right && r2.Top <= r1.Top && r2.Bottom >= r1.Bottom)
            return 0;
        return -1;
    }
}
