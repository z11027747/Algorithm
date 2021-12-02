namespace Algorithm._2QuadTree
{
    public struct AABB
    {
        public float left;
        public float right;
        public float top;
        public float bottom;

        public float MiddleWidth => (left + right) / 2;
        public float MiddleHeight => (top + bottom) / 2;

        public bool IsIn(AABB other) =>
            left >= other.left && right <= other.right && top <= other.top && bottom >= other.bottom;

        public bool IsHit(AABB other) =>
            right <= other.left && left <= other.right && top >= other.bottom && bottom <= other.top;
    }
}