namespace TreeSort
{
    public class TreeSort
    {
        private int[] array;
        public TreeSort(int[] array) 
        {
            this.array = array;
            Sort(this.array);

            foreach (int num in this.array) Console.Write(num + " ");
        }

        private void Sort(int[] array)
        {
            if (array == null || array.Length <= 1) return;

            TreeNode root = null;
            foreach (int value in array) root = Insert(root, value);

            List<int> sortedList = new List<int>();
            InOrderTraversal(root, sortedList);

            for (int i = 0; i < sortedList.Count; i++) this.array[i] = sortedList[i];
        }

        private TreeNode Insert(TreeNode root, int value)
        {
            if (root == null) return new TreeNode(value);

            if (value < root.value) root.left = Insert(root.left, value);
            else if (value > root.value) root.right = Insert(root.right, value);

            return root;
        }

        private void InOrderTraversal(TreeNode root, List<int> result)
        {
            if (root != null)
            {
                InOrderTraversal(root.left, result);
                result.Add(root.value);
                InOrderTraversal(root.right, result);
            }
        }
    }
}
