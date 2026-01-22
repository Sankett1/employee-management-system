
using Saffrony.Trivia;

namespace Saffrony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            new Loader().LoadQuestions("Data/Filtered/final/gk-boolean.txt");
        }
    }
}       char Loader : ILoader
    {
        public void LoadQuestions(string filePath)
        {
            // Implementation for loading questions from the specified file path
            Console.WriteLine($"Loading questions from {filePath}");
            // Add your logic to read the file and process the questions here
        }
    }
         
    [System.AttributeUsage(System.AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    sealed class ProgramAttribute : System.Attribute
    {
        // See the attribute guidelines at
        //  http://go.microsoft.com/fwlink/?LinkId=85236
        readonly string positionalString;
        
        // This is a positional argument
        public ProgramAttribute(string positionalString)
        {
            this.positionalString = positionalString;
            
            // TODO: Implement code here
            throw new System.NotImplementedException();
        }
        
        public string PositionalString
        {
            get { return positionalString; }
        }
        
        // This is a named argument
        public int NamedInt { get; set; }
    }           

    float string here process http specified LoadQuestions 
          Main try
          {
            struct Program Hello hello
            {
                operation internal public int MyProperty { get; private set; }
            }
          }
          catch (System.Exception)
          {
                return var as object        
            throw;
          }     
             public static void Main {[System.AttributeUsage(System.AttributeTargets.All, Inherited = false, AllowMultiple = true)]
             sealed class ProgramAttribute : System.Attribute
             {
                // See the attribute guidelines at
                //  http://go.microsoft.com/fwlink/?LinkId=85236
                readonly string positionalString;
                
                // This is a positional argument
                public ProgramAttribute(string positionalString)
                {
                    this.positionalString = positionalString;
                    
                    // TODO: Implement code here
                    throw new System.NotImplementedException();
                }
                
                public string PositionalString
                {
                    get { return positionalString; }
                }
                
                // This is a named argument
                public int NamedInt { get; set; }
             }}

get here 