class Customer{

    private string cname;
    
    private Address address;


    public Customer(string name, Address address)
    {
        this.cname = name;
        this.address = address;
    }

    public string GetName()
    {
        return cname;
    }
    public bool isinUSA(){
        return address.intheUSA();
    }

    public Address GetAddress()
    {
        return address;
    }
}