using System;

namespace Algorithm._2QuadTree
{
    public class QuadTree
    {
        private QuadTreeNode[] _quadTreeNodes;

        private int depth = 3;

        private float backgroundLength = 100f;
        private float looseSpacing = 5f;

        public void Init()
        {
            int nodeSum = 0;
            for (int i = 0; i < depth; i++)
            {
                //四个代表一个区域，每层个数按指数增长
                nodeSum += (int) Math.Pow(4, i);
            }

            _quadTreeNodes = new QuadTreeNode[nodeSum];

            AABB rootAABB = default;
            rootAABB.left = -backgroundLength / 2 - looseSpacing;
            rootAABB.right = backgroundLength / 2 + looseSpacing;
            rootAABB.top = backgroundLength / 2 + looseSpacing;
            rootAABB.bottom = -backgroundLength / 2 - looseSpacing;

            for (int i = 1; i < nodeSum; i++)
            {
                AABB aabb = default;
                AABB parentAABB = _quadTreeNodes[(i - 1) / 4].aabb;

                int currNodeIdx = i % 4;
                if (currNodeIdx == 1) //左上
                {
                    aabb.left = Math.Max(parentAABB.left - looseSpacing, rootAABB.left);
                    aabb.right = parentAABB.MiddleWidth + looseSpacing;
                    aabb.top = Math.Max(parentAABB.top + looseSpacing, rootAABB.top);
                    aabb.bottom = parentAABB.MiddleHeight - looseSpacing;
                }
                else if (currNodeIdx == 2) //右上
                {
                    aabb.left = parentAABB.MiddleWidth - looseSpacing;
                    aabb.right = Math.Min(parentAABB.right + looseSpacing, rootAABB.right);
                    aabb.top = Math.Min(parentAABB.top + looseSpacing, rootAABB.top);
                    aabb.bottom = parentAABB.MiddleHeight - looseSpacing;
                }
                else if (currNodeIdx == 3) //左下
                {
                    aabb.left = Math.Max(parentAABB.left - looseSpacing, rootAABB.left);
                    aabb.right = parentAABB.MiddleWidth + looseSpacing;
                    aabb.top = parentAABB.MiddleHeight + looseSpacing;
                    aabb.bottom = Math.Max(aabb.bottom - looseSpacing, rootAABB.bottom);
                }
                else if (currNodeIdx == 4) //右下
                {
                    aabb.left = parentAABB.MiddleWidth - looseSpacing;
                    aabb.right = Math.Min(parentAABB.right + looseSpacing, rootAABB.right);
                    aabb.top = parentAABB.MiddleHeight + looseSpacing;
                    aabb.bottom = Math.Max(aabb.bottom - looseSpacing, rootAABB.bottom);
                }

                QuadTreeNode quadTreeNode = new QuadTreeNode()
                    {index = i, aabb = aabb,};
                _quadTreeNodes[i] = quadTreeNode;
            }
        }

        public void Update()
        {
        }
    }
}