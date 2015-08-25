using System;
using lemon_bt_CShape;
class testNode1 : Bt_Action
{
    public override Bt_Result doAction()
    {
        Bt_Result _result = Bt_Result.FAIL;
        string msg = "test node 1";
        Bt_Debug.Debug(_result, msg);
        return _result;
    }

}

