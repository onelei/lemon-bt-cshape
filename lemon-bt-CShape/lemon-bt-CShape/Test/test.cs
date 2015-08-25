/*
 * test the lemon-bt-CShape;
 * 
 */

using System;
using lemon_bt_CShape;

class test
{
    static void Main(string[] args)
    {

        // test Bt_Sequence;
        testBt_Sequence();

        // test Bt_Select;
        testBt_Select();

        // test Bt_ParallelSelector;
        testBt_ParallelSelector();

        // test Bt_ParallelSequence;
        testBt_ParallelSequence();

        //test Bt_Decorator;
        testBt_Decorator();

        Console.ReadLine();
    }

    #region test Bt_Sequence
    static void testBt_Sequence()
    {
        Console.WriteLine("test Bt_Sequence=>");
        Bt_Sequence seq = new Bt_Sequence();
        testNode1 _test1 = new testNode1();
        testNode2 _test2 = new testNode2();
        seq.addChild(_test1);
        seq.addChild(_test2);
        seq.doAction();
    }
    #endregion;

    #region test Bt_Select
    static void testBt_Select()
    {
        Console.WriteLine("test Bt_Select=>");
        Bt_Select sel = new Bt_Select();
        testNode1 _test1 = new testNode1();
        testNode2 _test2 = new testNode2();
        sel.addChild(_test1);
        sel.addChild(_test2);
        sel.doAction();
    }
    #endregion;

    #region test Bt_ParallelSelector
    static void testBt_ParallelSelector()
    {
        Console.WriteLine("test Bt_ParallelSelector=>");
        Bt_ParallelSelector pasel = new Bt_ParallelSelector();
        testNode1 _test1 = new testNode1();
        testNode2 _test2 = new testNode2();
        pasel.addChild(_test1);
        pasel.addChild(_test2);
        pasel.doAction();
    }
    #endregion;

    #region test Bt_ParallelSequence
    static void testBt_ParallelSequence()
    {
        Console.WriteLine("test Bt_ParallelSequence=>");
        Bt_ParallelSequence paseq = new Bt_ParallelSequence();
        testNode1 _test1 = new testNode1();
        testNode2 _test2 = new testNode2();
        paseq.addChild(_test1);
        paseq.addChild(_test2);
        paseq.doAction();
    }
    #endregion;

    #region test Bt_Decorator
    static void testBt_Decorator()
    {
        Console.WriteLine("test Bt_Decorator=>");
        Bt_Decorator pasel = new Bt_Decorator();
        testNode1 _test1 = new testNode1();
        testNode2 _test2 = new testNode2();
        // pasel.addChild(_test1);
        //pasel.addChild(_test2);
        pasel.doAction();
    }
    #endregion;
}

