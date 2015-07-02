/*
Having never used C# before, I decided I would try out a kata similar to one
I've made a pass at previously in Java. Currently the algorithm seems tight,
although rudimentary in structure due to this being my first run with C#. Ever.
Pretty simple bracket validation, although funnily enough the Tests were 
broken on Codewars.. Hopefully they fix the issue so I can reap my reward.
*/

using System;
using System.Linq;
using System.Collections.Generic;

public class Brace {

    private static Stack<char> stack = new Stack<char>();
    private static Dictionary<char,char> brDict = new Dictionary<char,char>();    
    
    public static bool validBraces(String braces) {
      //Console.Write("\n"+braces+" for ");
      brDict.Clear();
      brDict.Add('(',')');
      brDict.Add('[',']');
      brDict.Add('{','}');
      
      stack.Clear(); 
      stack.Push('f');
      stack.Push(braces[0]);
      
      for(int i = 1; i< braces.Length; i++) {
        char last = stack.Peek();
        if(brDict.ContainsKey(last)){
          if(brDict[last] == braces[i]){ 
            stack.Pop();
          } else {
            stack.Push(braces[i]);
          } 
        } else {
          return false;
        }
      }
      
      if(stack.Pop()=='f'){
        return true;
      }
      // else
      return false;
    }
}
