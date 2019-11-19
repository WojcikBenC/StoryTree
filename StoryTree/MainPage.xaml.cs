using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StoryTree
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            current.Text = StoryTree.Tree.cursor.current;
            left.Text = StoryTree.Tree.cursor.left.choice;
            right.Text = StoryTree.Tree.cursor.right.choice;
        }

        void LeftClicked(object sender, EventArgs e)
        {
            if(StoryTree.Tree.cursor.left != null) StoryTree.Tree.cursor = StoryTree.Tree.cursor.left;
            current.Text = StoryTree.Tree.cursor.current;
            if(StoryTree.Tree.cursor.left != null) left.Text = StoryTree.Tree.cursor.left.choice;
            if(StoryTree.Tree.cursor.right != null) right.Text = StoryTree.Tree.cursor.right.choice;
        }

        void RightClicked(object sender, EventArgs e)
        {
            if (StoryTree.Tree.cursor.right != null) StoryTree.Tree.cursor = StoryTree.Tree.cursor.right;
            current.Text = StoryTree.Tree.cursor.current;
            if (StoryTree.Tree.cursor.left != null) left.Text = StoryTree.Tree.cursor.left.choice;
            if (StoryTree.Tree.cursor.right != null) right.Text = StoryTree.Tree.cursor.right.choice;
        }
    }
}
