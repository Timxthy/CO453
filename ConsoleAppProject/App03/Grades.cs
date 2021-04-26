using System.ComponentModel;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// Grade A is First Class   : 70 - 100
    /// Grade B is Upper Second  : 60 - 69
    /// Grade C is Lower Second  : 50 - 59
    /// Grade D is Third Class   : 40 - 49
    /// Grade F is Fail          :  0 - 39
    /// </summary>
    public enum GradesEnum
    {
        
        [Description("Fail")]
        F,
        
        [Description("Pass")]
        D,
        
        [Description("Merit")]
        C,
      
        [Description("Higher Merit")]
        B,
        
        [Description("Distinction")]
        A
    }
}
