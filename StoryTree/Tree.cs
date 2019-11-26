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
            TreeNode r1n1 = root.left = new TreeNode("A large city", "You enter the the city, seeing a sprawling market, a busy riverwalk, and a transit center. Do you go to: ");
            TreeNode r1n2 = root.right = new TreeNode("An open field", "You walk to the open field, seeing a farmhouse off in the distance, as well as a shed with a car in it. Do you go to: ");
            TreeNode r2n1 = r1n1.left = new TreeNode("The market", "You enter the market, seeing a wide variety of stands selling many items, such as fish, clothes, and tools. Do you go to: ");
            TreeNode r2n2 = r1n1.right = new TreeNode("The transit center", "You walk into the transit center, and see a board of arrivals and departures for trains, heading to many cities across the country. Do you go to: ");
            TreeNode r2n3 = r1n2.left = new TreeNode("The farmhouse", "You walk towards the farmhouse, past severl pastures of cows and goats. You see an older couple sitting on the front porch. Do you: ");
            TreeNode r2n4 = r1n2.right = new TreeNode("The shed", "You enter the shed. It smells old and dusty. You look around and see several tools hung up on the wall, as well as the keys to the car. Do you: ");
            TreeNode r3n1 = r2n1.left = new TreeNode("The clothing stand", "You walk over to the clothing stand. You see several items for sale, including a robe, a hat, and boots. Do you: ");
            TreeNode r3n2 = r2n1.right = new TreeNode("The tool stand", "You walk over to the tool stand. You see several tools for sale, including a saw, a drill, and pliers. Do you: ");
            TreeNode r3n3 = r2n2.left = new TreeNode("The ticket office", "You approach the ticket office, and see the list of ticket prices for various cities, including Chicago, Milwaukee, and Minneapolis. Do you buy: ");
            TreeNode r3n4e = r2n2.right = new TreeNode("The train leaving for Chicago", "You run trough the gate to the train leaving for Chicago, but get arrested because you didn't pay to ride it. Tickets are useful things.");
            TreeNode r3n5 = r2n3.left = new TreeNode("Approach the couple", "You walk over to the couple and greet them. They respond kindly, and ask you what brings you to their farm. Do you say: ");
            TreeNode r3n6 = r2n3.right = new TreeNode("Turn back to the road", "You turn around and walk a ways down a dirt road. Eventually, the road leads to a stream. Do you: ");
            TreeNode r3n7 = r2n4.left = new TreeNode("Take the car keys", "You take the car keys, start up the car, and floor it out of the shed and onto the road. Do you drive: ");
            TreeNode r3n8 = r2n4.right = new TreeNode("Take the sickle", "You take the sickle and exit the shed. You are back in the field, near the farmhouse. Do you: ");
        }
    }
}