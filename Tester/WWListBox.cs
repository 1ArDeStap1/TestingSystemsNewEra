
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

public class WWListBox : ListBox
{
    private void WWListBox_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
    {
        if (Items.Count > 0)
        {

        }
    }
    public WWListBox()
    {
        MeasureItem += WWListBox_MeasureItem;
        DrawItem += WWListBox_DrawItem;
        //This is super important. If you miss it… you won’t be able to Draw the item. 
        //If you make it OwnerDrawFixed you won’t be able to measure the item. 
    }
    private void WWListBox_MeasureItem(object sender, System.Windows.Forms.MeasureItemEventArgs e)
    {
    }
}

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
