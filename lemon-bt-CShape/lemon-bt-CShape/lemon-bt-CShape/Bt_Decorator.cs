/**
 * Decorator node.
 */


using System.Collections.Generic;
public class Bt_Decorator : Bt_Node
{
    Bt_Node child;
    protected void setChild(Bt_Node node)
    {
        this.child = node;
    }
}

