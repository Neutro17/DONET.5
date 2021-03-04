namespace Manager.Domain.Entities{
  
    public abstract class Base{ 
             public Long Id { get; set; }

             internal List<string> _errors;

             public abstract bool Validate();  
    }
}


