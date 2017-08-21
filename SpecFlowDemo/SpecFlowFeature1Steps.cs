using System;
using TechTalk.SpecFlow;

namespace SpecFlowDemo
{
    [Binding]
    public class SpecFlowFeature1Steps
    {

        GoogleTest g = new GoogleTest();


        [Given(@"user launches the app")]
        public void GivenUserLaunchesTheApp()
        {
            Console.WriteLine("Openning app");
            g.openApp();

            
        }
        
        [Given(@"searches for ""(.*)""")]
        public void GivenSearechesFor(string p0)
        {
            Console.WriteLine("Searching for "+ p0);
            g.search(p0);
        }
        
        [Then(@"verifies the infostretch link in search results")]
        public void ThenVerifiesTheInfostretchLinkInSearchResults()
        {
            Console.WriteLine("Done");
            g.verifyLinkPresent();
        }
    }
}
