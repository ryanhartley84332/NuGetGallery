using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAutomation;
using Xunit;

namespace NuGetGallery.FunctionalTests
{
    public class Sample : FluentTest
    {
        public Sample()
        {
            FluentAutomation.SeleniumWebDriver.Bootstrap(SeleniumWebDriver.Browser.Chrome);
        }

        [Fact]
        public void Test()
        {
            I.Open("http://nuget.org");
            I.WaitUntil(() => I.Expect.Exists("p#releaseTag"));
            I.Expect.Text(str => str.Trim().StartsWith("This is the NuGet Gallery.")).In("p#releaseTag");
        }
    }
}
