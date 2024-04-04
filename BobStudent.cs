using System;


public class studentBob
{

   public string odatacontext { get; set; }
   public int odatacount { get; set; }
   public Value[] value { get; set; }
}

public class Value
{
   public int Id { get; set; }
   public string EmailAddress { get; set; }
   public string StudentNumber { get; set; }
   public string FirstName { get; set; }
   public string LastName { get; set; }
   public string Disabled { get; set; }
   public string MobilePhoneNumber { get; set; }
   public string Veteran { get; set; }
   public string City { get; set; }
   public string State { get; set; }
}

