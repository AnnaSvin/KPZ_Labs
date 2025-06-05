public static class MemoryUtil
{
    public static long GetMemorySizeInBytes(object obj)
    {
        using (var process = System.Diagnostics.Process.GetCurrentProcess())
        {
            long before = process.PrivateMemorySize64;

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            object copy = obj;
            long after = process.PrivateMemorySize64;

            return after - before;
        }
    }
}
