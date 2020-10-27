

public class Order
    {
       public string Id {get; set;}
       public decimal Amount {get; set;}
       public string Name {get; set;}

       public Order(string id,decimal amount, string name)
       {
           this.Id=id;
           this.Amount=amount;
           this.Name = name;
       }
    }