// QHtmlDecode v1.0 (c) 2022 Sensei (aka 'Q')
// Reads stdin and decodes HTML entities.
//
// Usage:
// QHtmlDecode
//
// Compilation:
// %SYSTEMROOT%\Microsoft.NET\Framework\v3.5\csc QHtmlDecode.cs

using System;
using System.Web;

public static class QHtmlDecode {
   public static void Main( string [] args ) {
      string row;
      while( ( row = Console.ReadLine() ) != null ) {
         Console.WriteLine( HttpUtility.HtmlDecode( row ) );
      }
   }
}
