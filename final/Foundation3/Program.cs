// Name: Kyle Guo Date: Apirl 3 2023
using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures lectures = new Lectures("China history","how to build the great wall",DateTime.Now,TimeSpan.FromDays(2), new Address("200 W 100 E","Rexurg","Idaho",83440),"Kyle",20,"public speaking");
        lectures.Details();

        Receptions receptions = new Receptions("Food","green",DateTime.Now,TimeSpan.FromDays(4), new Address("500 N 300 E","San Jose","CA",35774),"zoe2234@gmail.com");
        lectures.Details();

        Outdoor outdoor = new Outdoor("Church","sacrement meeting",DateTime.Now,TimeSpan.FromDays(6), new Address("450 N 100 E","LA","CA",35774),"Sunny");
        lectures.Details();
    }
}