using Microsoft.VisualStudio.TestTools.UnitTesting;
using Basics.Poly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Poly.Tests
{
    [TestClass()]
    public class SiteOwnerTests : Contact
    {
        string siteName = "Test";

        [TestMethod()]
        public void UpdateNotifyTest()
        {
            
            Contact[] Contacts = new Contact[1];
            Contacts[0] = new SiteOwner(siteName);

            foreach (Contact poc in Contacts)
            {
                try
                {
                    if (!poc.Equals(Contacts[0]))
                    {
                        Assert.Fail();
                    }
                }
                catch
                {
                    Exception SO = new Exception("Failure in SiteOwner");
                }
            }
            
        }
    }
}