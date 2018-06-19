using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Console;

namespace PleaseNoError
{
    public partial class PleaseWork : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Main();


        }
        /* 
 January - 31 days
 February - 28 days in a common year and 29 days in leap years
 March - 31 days
 April - 30 days
 May - 31 days
 June - 30 days
 July - 31 days
 August - 31 days
 September - 30 days
 October - 31 days
 November - 30 days
 December - 31 days
*/
        int sidsteJanMarMayJulAugOctDec = 31;
        int sidsteAprJunSepNov = 30;
        int sidsteFebNoLeap = 28;
        int sidsteFebLeap = 29;
       

        DateTime date = DateTime.Now;
        //DAGE//
        int Dag;
        int dagMandag = 1;
        int dagTirsdag = 2;
        int dagOnsdag = 3;
        int dagTorsdag = 4;
        int dagFredag = 5;
        int dagLordag = 6;
        int sondag = 0;

        //MÅNEDER
        int[] JanMarMayJulAugOctDec =  {1, 3, 5, 7, 8, 10, 12 };
        int[] AprJunSepNov = { 4, 6, 9, 11 };
        int Måned;
        int månedJanuary = 1;
        int månedFebruary = 2;
        int månedMarch = 3;
        int månedApril = 4;
        int månedMay = 5;
        int månedJune = 6;
        int månedJuly = 7;
        int månedAugust = 8;
        int månedSeptember = 9;
        int månedOctober = 10;
        int månedNovember = 11;
        int månedDecember = 12;

        int year;
        int DagIMoned;
        string HvilkenDagIdag;



        public void Main()
        {
            Label3.Visible = false;
                    Dag = (int)date.DayOfWeek; // tells days from mon-sun => range from Monday is 1 and Sunday is 0.
            Måned = date.Month; // tells month from Jan-Dec => 1-12.
            DagIMoned = date.Day; // tells the day of the month Example 25th. feb => 25.
            year = date.Year;

            Label1.Text = "Is It Wednesday Today?";
            foreach (char s in Dag.ToString()) //Calculating which day in words it is
            {

                if (s == '1' )
                {
                    HvilkenDagIdag = "Monday";
                }
                else if (s == '2')
                {
                    
                    HvilkenDagIdag = "Tuesday";
                }

                else if (s == '0')
                {
                    HvilkenDagIdag = "Sunday";
                }

                else if (s == '4')
                {
                    HvilkenDagIdag = "Thursday";
                }

                else if (s == '5')
                {
                    HvilkenDagIdag = "Friday";
                }

                else if (s == '6')
                {
                    HvilkenDagIdag = "Saturday";
                }
            }

            /*Last day of month */


            // Fortæller om det er skudår eller ej => 365 or 366 days <=
                    if (year % 4 == 0)
                    {
                            /*Skudår*/
                       if (Array.Exists(JanMarMayJulAugOctDec, x => x == Måned) && DagIMoned == sidsteJanMarMayJulAugOctDec || Array.Exists(AprJunSepNov, x => x == Måned) && DagIMoned == sidsteAprJunSepNov || Måned == månedFebruary && DagIMoned == sidsteFebLeap)
                       {
                            
                              Label3.Text = "It is the Last day of the month. Which also Mean PAYDAY!!!";
                              Label3.Text += " it is also LEAP year with 366 days.";
                              Label3.Visible = true;
                          if (Dag == dagOnsdag)
                          {

                                Label3.Text += "It is also the last day of the month Ma Dude! PayDay Come Faster!";
                                Label3.Visible = true;


                          }
                       }
                /*Test*/    // else { Label1.Text = "Virker ikke 1"; }
            }
            else   /*Ikke skudår*/
                    {
                        if (Array.Exists(JanMarMayJulAugOctDec, x => x == Måned) && DagIMoned == sidsteJanMarMayJulAugOctDec || Array.Exists(AprJunSepNov, x => x == Måned) && DagIMoned == sidsteAprJunSepNov || Måned == månedFebruary && DagIMoned == sidsteFebNoLeap)
                        {
                            
                    Label3.Text = "It is the Last day of the month. Which also Mean PAYDAY!!!";
                    Label3.Visible = true;
                    if (Dag == dagOnsdag)
                    {

                        Label3.Text += "It is also the last day of the month Ma Dude! PayDay Come Faster!";
                        Label3.Visible = true;


                    }
                }
                    /*Test*/      //else { Label1.Text = "Virker ikke 2"; }
                    }
                
                    // Den længere kode af den ovenfor.
            /*  if (Måned == månedJanuary && DagIMoned == sidsteJanMarMayJulAugOctDec || Måned == månedFebruary && DagIMoned == sidsteFebNoLeap || Måned == månedMarch && DagIMoned == sidsteJanMarMayJulAugOctDec
                 || Måned == månedApril && DagIMoned == sidsteAprJunSepNov || Måned == månedMay && DagIMoned == sidsteJanMarMayJulAugOctDec
                 || Måned == månedJune && DagIMoned == sidsteAprJunSepNov || Måned == månedJuly && DagIMoned == sidsteJanMarMayJulAugOctDec
                 || Måned == månedAugust && DagIMoned == sidsteJanMarMayJulAugOctDec || Måned == månedSeptember && DagIMoned == sidsteAprJunSepNov
                 || Måned == månedOctober && DagIMoned == sidsteJanMarMayJulAugOctDec || Måned == månedNovember && DagIMoned == sidsteAprJunSepNov
                 || Måned == månedDecember && DagIMoned == sidsteJanMarMayJulAugOctDec)

              { 
                  Label3.Text = "It is the Last day of the month. Which also Mean PAYDAY!!!";
                  Label3.Visible = true;
                  if(Dag == dagOnsdag)
                  {

                      Label3.Text = "It is also the last day of the month Ma Dude! PayDay Come Faster!";
                      Label3.Visible = true;


                  }

              }*/


            if (Dag == dagOnsdag) // day of week
            {
                Label2.Text = "Yes, It IS Wednesday Ma Dudes!  :)";
                Image1.Visible = true;

            }
            else
            {
                
                Label2.Text = "No, It Is "+ HvilkenDagIdag +" Today :(";
            }

            if(Måned == månedMarch && DagIMoned == 25) //birthday
            {
                Label2.Text = "  No, but It is John's Birthday";
                Image2.Visible = true;
                if (Dag == dagOnsdag)
                {
                    Label2.Text = "Yes, It is also Jonh's Birthday";
                    
                }
            }

           

        }
        public void IDAG()
        {
          string HvilkenDag = "";
          string HvilkenMoned = "";
            foreach(char s in Dag.ToString())
            {
                if(s == '1')
                {
                    HvilkenDag = "Monday";
                }
                else if (s == '2')
                {
                    HvilkenDag = "Tuesday";
                }
                else if (s == '3')
                {
                    HvilkenDag = "wednesday";
                }
                else if (s == '4')
                {
                    HvilkenDag = "Thursday";
                }
                else if (s == '5')
                {
                    HvilkenDag = "Friday";
                }
                else if (s == '6')
                {
                    HvilkenDag = "Saturday";
                }
                else if (s == '0')
                {
                    HvilkenDag = "Sunday";
                }
            }
            foreach(char s in date.Month.ToString())
            {
               
                if(s.ToString() == "1")
                {
                    HvilkenMoned = "January";
                }
               else if (s.ToString() == "2")
                {
                    HvilkenMoned = "February";
                }
                else if (s.ToString() == "3")
                {
                    HvilkenMoned = "March";
                }
                else if (s.ToString() == "4")
                {
                    HvilkenMoned = "April";
                }
                else if (s.ToString() == "5")
                {
                    HvilkenMoned = "May";
                }
                else if (s.ToString() == "6")
                {
                    HvilkenMoned = "June";
                }
                else if (s.ToString() == "7")
                {
                    HvilkenMoned = "July";
                }
                else if (s.ToString() == "8")
                {
                    HvilkenMoned = "August";
                }
                else if (s.ToString() == "9")
                {
                    HvilkenMoned = "September";
                }
                 if (s.ToString() == "10")
                {
                    HvilkenMoned = "October";
                }
                 if (s.ToString() == "11")
                {
                    HvilkenMoned = "November";
                }
                 if (s.ToString() == "12")
                {
                    HvilkenMoned = "December";
                }
            }
            
            

            Label1.Text = "The current date is";
            Label2.Text = HvilkenDag + ", "+ date.Day+ " " + HvilkenMoned+ " " + date.Year;
            Label3.Visible = true;
            int skudår = date.Year % 4;
            if(skudår == 3)
            {
                Label3.Text = "1 years before Leap year";
            }
            else if(skudår == 2)
            {
                Label3.Text = "2 years before leap year";
            }
            else if(skudår == 1)
            {
                Label3.Text = "3 years before leap year";
            }
            else
            {
                Label3.Text = "It is Leap year (ø_ø)//";
            }
         
        }



        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(int.Parse(DropDownList1.SelectedItem.Value) == 0)
            {
                Main();
            }
            else if(int.Parse(DropDownList1.SelectedItem.Value) == 1)
            {
                IDAG();
            }
            else if(int.Parse(DropDownList1.SelectedItem.Value) == 2)
            {
                Response.Redirect("Ze Tian Ji.aspx");
            }

        }
    }
}