using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VIN_LIB;
using REG_MARK_LIB;

namespace LibTest
{
    [TestClass]
    public class UnitTests
    {
        private VIN vin = new VIN();
        private RegMark reg = new RegMark();

        [TestMethod]
        public void CheckVINTest()
        {
            Assert.IsTrue(vin.CheckVIN("1HGCG2254WA015540"));
            Assert.IsTrue(vin.CheckVIN("1G4GD5EDXBF330171"));
            Assert.IsFalse(vin.CheckVIN("WD2YD2418253568"));
            Assert.IsFalse(vin.CheckVIN("JH4KA2532HC022031123"));
            Assert.IsFalse(vin.CheckVIN("2I8GP44LX5R216765"));
        }

        [TestMethod]
        public void GetTransportYearTest()
        {
            Console.WriteLine("1HGCG2254WA015540 -> " + vin.GetTransportYear("1HGCG2254WA015540"));
            Console.WriteLine("1G4GD5EDXBF330171 -> " + vin.GetTransportYear("1G4GD5EDXBF330171"));
            Console.WriteLine("WD2YD241825356884 -> " + vin.GetTransportYear("WD2YD241825356884"));
            Console.WriteLine("JH4KA2532HC022031 -> " + vin.GetTransportYear("JH4KA2532HC022031"));
            Console.WriteLine("2D8GP44LX5R216765 -> " + vin.GetTransportYear("2D8GP44LX5R216765"));
        }

        [TestMethod]
        public void GetVINCountryTest()
        {
            Console.WriteLine("1HGCG2254WA015540 -> " + vin.GetVINCountry("1HGCG2254WA015540"));
            Console.WriteLine("1G4GD5EDXBF330171 -> " + vin.GetVINCountry("1G4GD5EDXBF330171"));
            Console.WriteLine("WD2YD241825356884 -> " + vin.GetVINCountry("WD2YD241825356884"));
            Console.WriteLine("JH4KA2532HC022031 -> " + vin.GetVINCountry("JH4KA2532HC022031"));
            Console.WriteLine("2D8GP44LX5R216765 -> " + vin.GetVINCountry("2D8GP44LX5R216765"));
        }

        [TestMethod]
        public void CheckMarkTest()
        {
            Assert.IsTrue(reg.CheckMark("A999AA999"));
            Assert.IsTrue(reg.CheckMark("X123YO124"));
            Assert.IsFalse(reg.CheckMark("AAA999999"));
            Assert.IsFalse(reg.CheckMark("999AAA999"));
            Assert.IsFalse(reg.CheckMark("I999QU999"));
        }
    }
}
