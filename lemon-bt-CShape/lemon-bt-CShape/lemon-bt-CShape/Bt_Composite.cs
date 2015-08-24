/*
 * Composite node: parent of nodes that have multi-children. 
 */


using System.Collections.Generic;

public class Bt_Composite : Bt_Node
{
    protected List<Bt_Node> children;
    protected void addChild(Bt_Node node)
    {
        this.children.Add(node);
    }
}

