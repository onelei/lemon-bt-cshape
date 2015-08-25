using System;
using lemon_bt_CShape;
class testNode2 : Bt_Action
{
    public override Bt_Result doAction()
    {
        Bt_Result _result = Bt_Result.SUCCESSFUL;
        string msg = "test node 2";
        Bt_Debug.Debug(_result, msg);
        return _result;
    }

}

