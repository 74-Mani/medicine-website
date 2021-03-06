﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Medical.Synchronization;

public class SearchExpander
{
    /// <summary>
    /// Constructor 1 - default
    /// </summary>
    /// <param name="columnname"></param>
    /// <param name="display"></param>
    /// <param name="pktype"></param>
    public SearchExpander(string columnname, string display, Type pktype)
    {
        this.Type = null;
        this.HasLinkRef = false;
        this.DisplayFormat = null;
        this.BeenSearch = true;
        this.ColumnName = columnname;
        this.Display = display;
        this.PKType = pktype;
        this.Refference = null;
        this.HasDetail = false;
        this.DisplayRefferenceColumn = "Name";
    }

    public SearchExpander(bool beensearch, string columnname, string display, string displayformat, Type pktype)
    {
        this.Type = null;
        this.HasLinkRef = false;
        this.DisplayFormat = displayformat;
        this.BeenSearch = beensearch;
        this.ColumnName = columnname;
        this.Display = display;
        this.PKType = pktype;
        this.Refference = null;
        this.HasDetail = false;
        this.DisplayRefferenceColumn = "Name";
    }

    /// <summary>
    /// Constructor 1 - has detail items
    /// </summary>
    /// <param name="columnname"></param>
    /// <param name="display"></param>
    /// <param name="pktype"></param>
    public SearchExpander(string columnname, string display, Type pktype, bool hasdetail)
    {
        this.Type = null;
        this.HasLinkRef = false;
        this.DisplayFormat = null;
        this.BeenSearch = true;
        this.ColumnName = columnname;
        this.Display = display;
        this.PKType = pktype;
        this.Refference = null;
        this.HasDetail = hasdetail;
        this.DisplayRefferenceColumn = "Name";
    }

    /// <summary>
    /// Constructor 1 - has refference column
    /// </summary>
    /// <param name="columnname"></param>
    /// <param name="display"></param>
    /// <param name="pktype"></param>
    public SearchExpander(string columnname, string display, Type pktype, string refferencecolumn, Type refference)
    {
        this.Type = null;
        this.HasLinkRef = false;
        this.DisplayFormat = null;
        this.BeenSearch = true;
        this.ColumnName = columnname;
        this.Display = display;
        this.PKType = pktype;
        this.RefferenceColumn = refferencecolumn;
        this.Refference = refference;
        this.HasDetail = false;
        this.DisplayRefferenceColumn = "Name";
    }

    /// <summary>
    /// Constructor 1 - has refference column
    /// </summary>
    /// <param name="columnname"></param>
    /// <param name="display"></param>
    /// <param name="pktype"></param>
    public SearchExpander(string columnname, string display, Type pktype, string refferencecolumn, string displayrefferencecolumn, Type refference)
    {
        this.Type = null;
        this.HasLinkRef = false;
        this.DisplayFormat = null;
        this.BeenSearch = true;
        this.ColumnName = columnname;
        this.Display = display;
        this.PKType = pktype;
        this.RefferenceColumn = refferencecolumn;
        this.Refference = refference;
        this.HasDetail = false;
        this.DisplayRefferenceColumn = displayrefferencecolumn;
    }

    public SearchExpander(string columnname, string display, Type pktype, Type type, string refferencecolumn, string displayrefferencecolumn, Type refference)
    {
        this.Type = type;
        this.HasLinkRef = false;
        this.DisplayFormat = null;
        this.BeenSearch = true;
        this.ColumnName = columnname;
        this.Display = display;
        this.PKType = pktype;
        this.RefferenceColumn = refferencecolumn;
        this.Refference = refference;
        this.HasDetail = false;
        this.DisplayRefferenceColumn = displayrefferencecolumn;
    }

    /// <summary>
    /// Constructor 1 - has refference column
    /// </summary>
    /// <param name="columnname"></param>
    /// <param name="display"></param>
    /// <param name="pktype"></param>
    public SearchExpander(string columnname, string display, Type pktype, string refferencecolumn, string displayrefferencecolumn, Type refference, bool haslinkref)
    {
        this.Type = null;
        this.HasLinkRef = haslinkref;
        this.DisplayFormat = null;
        this.BeenSearch = true;
        this.ColumnName = columnname;
        this.Display = display;
        this.PKType = pktype;
        this.RefferenceColumn = refferencecolumn;
        this.Refference = refference;
        this.HasDetail = false;
        this.DisplayRefferenceColumn = displayrefferencecolumn;
    }

    public SearchExpander(string columnname, string display, Type pktype, Type type, string refferencecolumn, string displayrefferencecolumn, Type refference, bool haslinkref)
    {
        this.Type = type;
        this.HasLinkRef = haslinkref;
        this.DisplayFormat = null;
        this.BeenSearch = true;
        this.ColumnName = columnname;
        this.Display = display;
        this.PKType = pktype;
        this.RefferenceColumn = refferencecolumn;
        this.Refference = refference;
        this.HasDetail = false;
        this.DisplayRefferenceColumn = displayrefferencecolumn;
    }

    public bool HasLinkRef { get; set; }

    public string DisplayFormat { get; set; }

    public bool BeenSearch { get; set; }

    public string ColumnName { get; set; }

    public string Display { get; set; }

    public Type Refference { get; set; }

    public string RefferenceColumn { get; set; }

    public string DisplayRefferenceColumn { get; set; }

    public Type PKType { get; set; }

    public Type Type { get; set; }

    public bool HasDetail { get; set; }

    public object Value { get; set; }
}