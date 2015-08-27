# Lemon-BT-CShape  
A behavior tree framework, using the C# language.  

# Node  
* Composite Node  
  * Selector Node:one true then true, all false then false;   
  * Sequence Node:one false then false, all true then true;   
  * Parallel Node:parallel execute;   
     * Parallel Selector Node: one false return false, all true return true.   
     * Parallel Sequence Node: one true return true, all false return false.   
* Decorator Node  
* Condition Node  
* Action Node  

# Run test        
![](https://github.com/onelei/Lemon-BT-CShape/blob/master/ImgCache/test.png) 
