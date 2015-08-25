# Lemon-BT-CShape
A behavior tree framework, using the C# language.

# Node
-Composite Node
-Decorator Node
-Condition Node
-Action Node

# Composite Node
-Selector Node:一真则真,全假则假;
-Sequence Node:一假则假,全真则真;
-Parallel Node:并发执行;

 # Parallel Node
 -Parallel Selector Node:一False则返回False,全True才返回True.
 -Parallel Sequence Node:一True则返回True,全False才返回False.

# Run test        
![](https://github.com/onelei/Lemon-BT-CShape/blob/master/ImgCache/test.png) 