using System;

namespace Exercises;

public static class BookPageEstimator
{
    /// <summary>
    /// pagesPerHour × minutes / 60
    /// </summary>
    public static double EstimatePages(int pagesPerHour, int minutes)
    {
        if (pagesPerHour < 0 || minutes < 0)
            throw new ArgumentOutOfRangeException("Inputs must be non-negative.");

        return pagesPerHour * minutes / 60.0;
    }
} 