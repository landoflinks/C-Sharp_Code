﻿using System;

public class Customer
{
    public string first;
    public string last;
    public string state;
    public string bookGenre;

    public Customer()
	{
        first = "none";
        last = "none";
        state = "XX";
        bookGenre = "nope";
	}

    public Customer(string firstName, string lastName)
    {
        first = firstName;
        last = lastName;
    }

    public Customer(string firstName, string lastName, string myState, string genre)
    {
        first = firstName;
        last = lastName;
        state = myState;
        bookGenre = genre;
    }

    public void SetDefaults(string firstName, string lastName)
    {
        first = firstName;
        last = lastName;
        state = "IL";
        bookGenre = "Comedy";
    }
}
