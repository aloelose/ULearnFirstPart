using System;

namespace Mazes;

public static class DiagonalMazeTask
{
    public static void MoveOut(Robot robot, int width, int height)
    {
        var verticalSteps =  (int)Math.Round((double)height / width + 0.4);
        var horizontalSteps = (int)Math.Round((double)width / height + 0.4);
        if (verticalSteps >= horizontalSteps)
            MoveDownFirst(robot, horizontalSteps, verticalSteps);
        else
            MoveRightFirst(robot, horizontalSteps, verticalSteps);
    }

    public static void MoveRightFirst(Robot robot, int horizontalSteps, int verticalSteps)
    {
        MoveRight(robot, horizontalSteps);
        while (!robot.Finished)
        {
            MoveDown(robot, verticalSteps);
            MoveRight(robot, horizontalSteps);
        }
    }

    public static void MoveDownFirst(Robot robot, int horizontalSteps, int verticalSteps)
    {
        MoveDown(robot, verticalSteps);
        while (!robot.Finished)
        {
            MoveRight(robot, horizontalSteps);
            MoveDown(robot, verticalSteps);
        }
    }

    public static void MoveRight(Robot robot, int horizontalSteps)
    {
        if (!robot.Finished)
            for (int i = 0; i < horizontalSteps; i++)
            {
                robot.MoveTo(Direction.Right);
            }   
    }

    public static void MoveDown(Robot robot, int verticalSteps)
    {
        if (!robot.Finished)
            for (int i = 0; i < verticalSteps; i++)
            {
                robot.MoveTo(Direction.Down);
            }
    }
}
