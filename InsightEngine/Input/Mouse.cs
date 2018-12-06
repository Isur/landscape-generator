namespace InsightEngine.Input
{
    public static class Mouse
    {
        static int x;
        static int y;

        public static bool Click { get; set; }
        public static int X
        {
            get { return x; }
            set
            {
                DeltaX = value - x;
                x = value;
            }
        }
        public static int Y
        {
            get { return y; }
            set
            {
                DeltaY = value - y;
                y = value;
            }
        }

        public static int DeltaX { get; private set; }
        public static int DeltaY { get; private set; }

        public static void Reset()
        {
            X = X;
            Y = Y;
        }
    }
}
