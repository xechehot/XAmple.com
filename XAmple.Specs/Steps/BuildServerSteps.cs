﻿using TechTalk.SpecFlow;
using XAmple.Specs.Support.Drivers;

namespace XAmple.Specs.Steps
{

    [Binding]
    public class BuildServerSteps
    {
        private readonly BuildServerDriver m_Driver;

        public BuildServerSteps(BuildServerDriver driver)
        {
            m_Driver = driver;
        }

        [When(@"I retrieve the build version")]
        public void RetrieveBuildVersion_Step()
        {
            m_Driver
                .RetrieveBuildVersion();
        }


    }
}