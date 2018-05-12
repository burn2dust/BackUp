using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Poly
{
    abstract public class Contact
    {
        public virtual string UpdateNotify()
        {
            return "Web Site Change Notification";
        }
    }

    public class Customer : Contact
    {
        public override string UpdateNotify()
        {
            return @"
This is to let you know your
favorite site, Financial Times,
has been updated with new links";
        }
    }

    public class SiteOwner : Contact
    {
        string siteName;
        public SiteOwner(string sName)
        {
            siteName = sName;
        }

        public override string UpdateNotify()
        {
            return @"
This is to let you know your site, " + "\n" +
siteName + @", has been added as
a link to Financial Times.";
        }
    }

    //public class Test
    //{
    //    public static void Main()
    //    {
    //        Contact[] Contacts = new Contact[2];

    //        Contacts[0] = new SiteOwner("Pierre Doe");
    //        Contacts[1] = new Customer();

    //        foreach (Contact poc in Contacts)
    //        {
    //            Console.WriteLine("Message: {0}\n", poc.UpdateNotify());
    //        }
    //    }
    //}
}
