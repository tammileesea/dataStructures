using System;
namespace data_structures_2.src.DataStructures
{
    public class BstNode
    {
        public BstNode Left { get; set; }
        public BstNode Right { get; set; }
        public int Data { get; set; }

        public BstNode(int data)
        {
            Data = data;
        }
    }
}

