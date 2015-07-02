# braces-kata
Description:

Write a function called validBraces that takes a string of braces, and determines if the order of the braces is valid. validBraces should return true if the string is valid, and false if it's invalid.<br/>
<br/>
This Kata is similar to the Valid Parentheses Kata, but introduces four new characters. Open and closed brackets, and open and closed curly braces. Thanks to @arnedag for the idea!<br/>
<br/>
All input strings will be nonempty, and will only consist of open parentheses '(' , closed parentheses ')', open brackets '[', closed brackets ']', open curly braces '{' and closed curly braces '}'.<br/>
<br/>
What is considered Valid? A string of braces is considered valid if all braces are matched with the correct brace.<br/>
For example:<br/>
'(){}[]' and '([{}])' would be considered valid, while '(}', '[(])' would be considered invalid.
<br/>
Examples:<br/>
validBraces( "(){}[]" ) => returns true<br/>
validBraces( "(}" ) => returns false<br/>
validBraces( "[(])" ) => returns false<br/>
validBraces( "([{}])" ) => returns true
