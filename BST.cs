namespace Solution;

public class BST<T> : IBST<T> where T : IComparable<T>
{
    public TreeNode<T>? Root { get; set; }

    public void Insert(T value){
        if (Root == null){
            Root = new TreeNode<T>(value);
            return;
        }
        if (value.CompareTo(Root.Value) == 0) return;

        if (value.CompareTo(Root.Value) > 0)
        {
            if (Root.Right != null) Insert(value, Root.Right);
            else Root.Right = new TreeNode<T>(value);
        }
        else
        {
            if (Root.Left != null) Insert(value, Root.Left);
            else Root.Left = new TreeNode<T>(value);
        }
    }
    public void InsertIterative(T value)
    {
        if (Root == null){
            Root = new TreeNode<T>(value);
            return;
        }
        TreeNode<T> TempRoot = Root;
        TreeNode<T> parent = null;

        while(TempRoot != null){
            parent = TempRoot;
            if (value.CompareTo(TempRoot.Value) == 0) return;
            else if (value.CompareTo(TempRoot.Value) > 0){
                TempRoot = TempRoot.Right;
            }
            else if (value.CompareTo(TempRoot.Value) < 0){
                TempRoot = TempRoot.Left;
            }
        }
        if (value.CompareTo(parent.Value) > 0) parent.Right = new TreeNode<T>(value);
        else parent.Left = new TreeNode<T>(value);
    }

    private void Insert(T value, TreeNode<T>? node)
    {
        if (node == null){
            return;
        }
        if (value.CompareTo(node.Value) == 0) return;

        if (value.CompareTo(node.Value) > 0)
        {
            if (node.Right == null){
                node.Right = new TreeNode<T>(value);
                return;
            }
            else {
                Insert(value, node.Right);
            }
        }
        else
        {
            if (node.Left == null){
                node.Left = new TreeNode<T>(value);
                return;
            }
            else{
                Insert(value, node.Left);
            }
        }
    }

    #region Traversal

    public string PreOrderTraversal() => PreOrderTraversal(Root);
    private string PreOrderTraversal(TreeNode<T>? currNode)
    {
        if (currNode == null) return "";
        
        return currNode.Value.ToString() + " " + 
           PreOrderTraversal(currNode.Left) + 
           PreOrderTraversal(currNode.Right);
    }

    public string InOrderTraversal() => InOrderTraversal(Root);
    private string InOrderTraversal(TreeNode<T>? currNode)
    {
        if (currNode == null) return "";

        return InOrderTraversal(currNode.Left) + 
           currNode.Value.ToString() + " " + 
           InOrderTraversal(currNode.Right);
    }

    public string PostOrderTraversal() => PostOrderTraversal(Root);
    private string PostOrderTraversal(TreeNode<T>? currNode)
    {
        if (currNode == null) return "";

        return PostOrderTraversal(currNode.Left) + 
           PostOrderTraversal(currNode.Right) + 
           currNode.Value.ToString() + " ";
    }
    #endregion

    public bool Contains(T value) => Search(Root, value) != null;

    private TreeNode<T> Search(TreeNode<T>? node, T value)
    {
        // node does not exist
        if (node == null) return default;
        
        // value in the node is the same we are looking for
        if (node.Value.CompareTo(value) == 0) return node;

        // value in the node is smaller than the one we are looking for
        if (node.Value.CompareTo(value) > 0) return Search(node.Right, value);
 
        // value in the node is bigger than the one we are looking for
        return Search(node.Left, value);
    }

    #region  Remove Delete

    public bool Remove(T value) => DeleteValue(this, value);

    private bool DeleteValue(BST<T>? tree, T value)
    { 
        throw new NotImplementedException();
        // special case if the value to delete is in the root (and the root has 0 children or 1 child)
        
            // there are no children:

            // there is only left child, the right does not exist
            
            // there is only right child, the left does not exist


        // all other cases. Find first the node corresponding to the value we want to delete

        // actually perform the deletion

    }

    private bool delete(TreeNode<T> nodeToDelete)
    {
        throw new NotImplementedException();
        // CASE 1 : LEAF

        // CASE 2 : ONE CHILD

        // CASE 3 : TWO CHILDREN

        // find inordersucc == smallest element of right subtree

        // copy value to nodeToDelete

        // call recursively delete on inordersucc 

    }

    // This methods finds the in order successor of the node given as parameter
    private TreeNode<T>? findInOrderSucc(TreeNode<T> node)
    {
        var currNode = node.Right;
        while (currNode != null && currNode.Left != null)
            currNode = currNode.Left;

        return currNode;
    }
 
    // This methods checks if the node given as first parameter is the left child of the node given as second parameter ("parent"). 
    // The comparison is based on the values of the nodes.
    private bool isLeft(TreeNode<T> node, TreeNode<T> parent)
    {
        return parent.Left != null && parent.Left.Value.CompareTo(node.Value) == 0;
    }

    public List<T> Traversal(TraversalOrder traversalOrder) //Optional
    {
        throw new NotImplementedException();
    }
    #endregion
}