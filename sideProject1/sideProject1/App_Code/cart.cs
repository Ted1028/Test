﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for cart
/// </summary>
public class cart
{

    public int Id { get; set; }
    public string ProductName { get; set; }
    public string Property { get; set; }
    public int Price { get; set; }
    public string Description { get; set; }
    public string ImageFileName { get; set; }
    public int Quantity { get; set; }
    public int Total
    {
        get 
        {
            return Price * Quantity;
        } 
    }
    

}