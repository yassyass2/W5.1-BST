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
            Insert(value, Root.Right);
        }
        else
        {
            Insert(value, Root.Left);
        }
    }
    public void InsertIterative(T value)
    {
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
        if (Root == null){
            Root = new TreeNode<T>(value);
            return;
        }
        if (value.CompareTo(Root.Value) == 0) return;

        if (value.CompareTo(Root.Value) > 0)
        {
            if (Root.Right == null)
                Root.Right = new TreeNode<T>(value);
                return;
            else
                Insert(value, Root.Right);
        }
        else
        {
            if (Root.Left == null)
                Root.Left = new TreeNode<T>(value);
                return;
            else
                Insert(value, Root.Left);
        }
    }

    #region Traversal

    public string PreOrderTraversal() => PreOrderTraversal(Root);
    private string PreOrderTraversal(TreeNode<T>? currNode)
    {
        throw new NotImplementedException();
    }

    public string InOrderTraversal() => InOrderTraversal(Root);
    private string InOrderTraversal(TreeNode<T>? currNode)
    {
        throw new NotImplementedException();        
    }

    public string PostOrderTraversal() => PostOrderTraversal(Root);
    private string PostOrderTraversal(TreeNode<T>? currNode)
    {
        throw new NotImplementedException();

    }
    #endregion

    public bool Contains(T value) => throw new NotImplementedException(); 

    private TreeNode<T> Search(TreeNode<T>? node, T value)
    {
        throw new NotImplementedException();
        // node does not exist
        
        // value in the node is the same we are looking for

        // value in the node is smaller than the one we are looking for
 
        // value in the node is bigger than the one we are looking for

    }

    #region  Remove Delete

    public bool Remove(T value) => throw new NotImplementedException();

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