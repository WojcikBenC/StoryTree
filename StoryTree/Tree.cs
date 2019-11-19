using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoryTree
{
    public static class Tree
    {
        public class TreeNode
        {
            public String choice;
            public String current;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(String choice, String current)
            {
                this.choice = choice;
                this.current = current;
            }
        }

        private static TreeNode root = new TreeNode(null, "You are an adventurer, seeking to find the lost guitar of the temples. Select where to travel to first on your quest: ");
        public static TreeNode cursor = root;

        public static TreeNode getRoot()
        {
            return root;
        }

        public static void setupTree()
        {
            root.left = new TreeNode("A large city.", "You enter the the city, seeing a sprawling market, a busy riverwalk, and a transit center. Do you go to: ");
            root.right = new TreeNode("An open field.", "You walk to the open field, seeing a farmhouse off in the distance, as well as a shed with a car in it. Do you go to: ");
        }
    }
}