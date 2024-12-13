namespace Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Yo, let's grab those scores from the file.
            string[] lines = File.ReadAllLines("scores.txt");
            List<int> scores = new List<int>();
            foreach (var line in lines)
            {
                if (int.TryParse(line, out int score))
                {
                    scores.Add(score); // Add each legit number to the list.
                }
            }

            // Alright, time to sort these bad boys.
            List<int> sortedScores = QuickSort(scores);

            // Now, let's build a tree because why not?
            TreeNode root = null;
            foreach (var score in sortedScores)
            {
                root = InsertToTree(root, score); // Pop those scores into the tree.
            }

            // Let's show off that tree.
            Console.WriteLine("In-Order Traversal of the Tree:");
            InOrderTraversal(root);
        }

        // QuickSort because we like things fast and fancy.
        static List<int> QuickSort(List<int> list)
        {
            if (list.Count <= 1) return list; // Already sorted or empty? We're done here.

            int pivot = list[list.Count / 2]; // Grab the middle for pivot vibes.
            list.RemoveAt(list.Count / 2);

            List<int> less = new List<int>();
            List<int> greater = new List<int>();

            foreach (var num in list)
            {
                if (num <= pivot)
                    less.Add(num); // Smaller? Go left.
                else
                    greater.Add(num); // Bigger? Go right.
            }

            // Recursively sort and put it all together.
            var sorted = QuickSort(less);
            sorted.Add(pivot);
            sorted.AddRange(QuickSort(greater));
            return sorted;
        }

        // TreeNode is like our building block for the tree.
        class TreeNode
        {
            public int Value;
            public TreeNode Left, Right;
            public TreeNode(int value) => Value = value;
        }

        // Insert scores into the tree, one by one.
        static TreeNode InsertToTree(TreeNode node, int value)
        {
            if (node == null)
            {
                return new TreeNode(value); // New node gets made here.
            }

            if (value < node.Value)
            {
                node.Left = InsertToTree(node.Left, value); // Smaller goes left.
            }
            else
            {
                node.Right = InsertToTree(node.Right, value); // Bigger goes right.
            }
            return node; // Return the updated tree.
        }

        // In-Order Traversal: Left -> Node -> Right. Shows values in order.
        static void InOrderTraversal(TreeNode node)
        {
            if (node == null) return;

            InOrderTraversal(node.Left); // Check the left side first.
            Console.WriteLine(node.Value); // Then the node itself.
            InOrderTraversal(node.Right); // Now the right side.
        }
    }
}
