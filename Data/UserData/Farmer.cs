﻿using System.Diagnostics;
using CS4125.Data.AnimalData;
using CS4125.Data.Finance;
using CS4125.Data.Finance.State;
using Microsoft.VisualStudio.Web.CodeGeneration.Utils;
using static System.Diagnostics.Contracts.Contract;

namespace CS4125.Data.UserData;

// Concrete Observer
public class Farmer : User, IObserver
{
    private readonly HashSet<Invoice> _invoices;
    private static int MAX_SITES = 10;

    public State State;
    private System.System _subject;
    public Tier Tier;

    public Farmer(System.System subject, string email, string firstName, string lastName) : base(email,
        firstName, lastName)

    {
        _invoices = new HashSet<Invoice>();
        Sites = new List<Site>();
        Tier = Tier.Bronze;
        this._subject = subject;
    }

    public List<Site> Sites { get; }

    public void Update(ISubject subject)
    {
        var system = subject as System.System;
        _invoices.Add(new Invoice(this, 25, system.GetCompanyData().getName(), system.GetCompanyData().getAddress()));
    }

    public void PayInvoice(Invoice invoice)
    {
        invoice.Pay();
    }

    public HashSet<Invoice> GetInvoices()
    {
        return _invoices;
    }

    public void AddInvoice(Invoice invoice)
    {
        _invoices.Add(invoice);
    }

    public List<Animal> Animals()
    {
        var animals = new List<Animal>();
        foreach (var site in Sites) animals.AddRange(site.GetAnimals());

        return animals;
    }

    public Invoice GetInvoiceToPay()
    {
        foreach (var invoice in _invoices)
            if (!invoice.IsPaid())
                return invoice;

        return null;
    }

    public int GetSiteCount()
    {
        return Sites.Count;
    }

    public int GetAnimalCount()
    {
        var count = 0;
        foreach (var site in Sites) count += site.GetAnimalCount();

        return count;
    }
    
    public int GetRemainingCapacity(){
        var capacity = 0;
        foreach (var site in Sites) capacity += site.GetRemainingCapacity();

        return capacity;
    }

    public void  AddSite()
    {
        Requires(Sites.Count < MAX_SITES);
     
        var countBefore = Sites.Count;
        Sites.Add(new Site("site 1", new Address()));
        Ensures(Sites.Count == countBefore + 1);
    }

    public List<Animal> GetAnimals()
    {
        //get animals from all sites in a list
        var animals = new List<Animal>();
        foreach (var site in Sites) animals.AddRange(site.GetAnimals());
        
        return animals;
        
    }
}

public enum Tier
{
    Bronze,
    Silver,
    Gold
}