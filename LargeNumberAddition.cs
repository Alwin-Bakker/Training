using System;
using System.Collections.Generic;

public class Kata
{
  public static string Reverse(string s){
    char[] charArray = s.ToCharArray();
    Array.Reverse( charArray );
    return new string(charArray);
  }
  
  public static int ReverseInt(int num){
    int result=0;
    while (num>0) 
    {
       result = result*10 + num%10;
       num /= 10;
    }
    return result;
  }
  
  public static Boolean LeftLonger(int a, int b){
    if (a > b){
      return true;
    }
    return false;
  }
  
  public static string FillString(string a, int length){
    while (a.Length < length){
      a = a + "0";
    }
    return a;
  }
  
  public static int SumOfChars(char a, char b){
    int Inta = (int)Char.GetNumericValue(a);
    int Intb = (int)Char.GetNumericValue(b);
    return Inta + Intb;
  }
    
  public static string Add(string a, string b){
    if (a == "" || b == ""){
      return "";
    }
    if (a == "0"){
      return b;
    }
    if (b == "0"){
      return a;
    }
    String aReverse = Reverse(a);
    String bReverse = Reverse(b);
    String result = "";
       
    
    if (LeftLonger(aReverse.Length, bReverse.Length)){
        bReverse = FillString(bReverse, aReverse.Length);
    }
    if (LeftLonger(bReverse.Length, aReverse.Length)){
        aReverse = FillString(aReverse, bReverse.Length);
    }
    if (bReverse.Length != aReverse.Length){
        return "Error, Stings not equalized";
    }
    
    
    Boolean flag = false;
    for (int i = 0; i < aReverse.Length; i++){
        int sum = SumOfChars(aReverse[i], bReverse[i]);
        if (flag == true){
          flag = false;
          sum += 1;
        }
        if (sum >= 10){
          sum = sum % 10;
          flag = true;
        }
        result += "" + sum;
        if (flag == true && (i + 1) == aReverse.Length){
          result += "1";
        }
        Console.WriteLine("Running Sum:" + result);
    }
    Console.WriteLine("Final Result:" + Reverse(result));
    return Reverse(result);
    }
}
