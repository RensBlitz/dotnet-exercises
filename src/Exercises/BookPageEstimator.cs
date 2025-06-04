namespace Exercises;

public static class BookPageEstimator
{
    /// <summary>pagesPerHour × minutes / 60.</summary>
    public static double EstimatePages(int pagesPerHour, int minutes)
        => pagesPerHour * (double)minutes / 60;
} 