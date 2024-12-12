namespace AdventOfCode.Y24.D1
{
    class Input
    {
        public List<int> Left { get; set; } = [];
        public List<int> Right { get; set; } = [];

        public override string ToString()
        {
            return $"{{\n Left: [\n{string.Join(",", Left)}\n],\n Right: [\n{string.Join(",", Right)}\n]\n }}";
        }
    }
}