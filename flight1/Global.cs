using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace flight1
{
    public class Global
    {
        // strings store flight info, cabinupgrade stores seat avail after paying extra fee
        public static string flightfrom, flightto, cabin,cabinupgrade;

        // coreticket: ticket picked from DB-do not use. duration: flight duration, fnumber: flight number, e1-f1-b1: price variable depending on class selection-display only.
        public static int coreticket, guest = 1, duration,fnumber, fjet,e1,e2,e3,e4,e5,b1,b2,b3,b4,b5,f1,f2,f3,f4,f5;
        
        // upseat: seat selection after upgrade, outticket/returnticket: price of ticket after selection, servicefee=meal+bag+seat+insu, totaltick: all fee / 1 pax, finaltick: all fee / all pax
        public static decimal upseat, outticket, returnticket,outandreturnticket,tax,airportfee,meal,bag,insurance,servicefee,totaltick,finaltick;
        
        public static DateTime fromdate, todate;
        
        // define 1 way / return
        public static Boolean returnflight;

        // customer info: pp: passport
        public static string phone,p1name, p1pp, p1email,   expmonth, expyear, cardname, p2name, p2pp, p3name, p3pp, p4name, p4pp, p5name, p5pp;
        public static DateTime p1dob, p2dob, p3dob, p4dob, p5dob;

        //card1: first 4 digit, booknum: booking number gen randomly 
        public static double card1,card2,card3,card4,cvv, booknum;
    }
}
