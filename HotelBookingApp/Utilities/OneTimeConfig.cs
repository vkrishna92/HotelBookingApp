using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApp.Utilities
{
    [TestClass]
    class OneTimeConfig
    {
        [AssemblyInitialize]
        public static void OneTimeSetup(TestContext testContext)
        {
            //Add Extent report Config
        }
        [AssemblyCleanup]
        public static void OneTimeTearDown()
        {
            //Flush Extent report
        }
    }
}
