namespace InsightEngine.Input
{
    public static class Keyboard
    {
        public static bool W { get; set; }
        public static bool S { get; set; }

        public static void Reset()
        {
            Keyboard.W = false;
            Keyboard.S = false;
        }
    }
}
