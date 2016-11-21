using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print
{
 public class Mystery
{ 
   public static void Main(string[] args)
        { 
     int count = 1; 
     while ( count <= 10 ) 
     { 
       Console.WriteLine( count % 2 == 1 ? "****" : "++++++++" ); 
        count++; 
      } 
  } 
 } 

}
