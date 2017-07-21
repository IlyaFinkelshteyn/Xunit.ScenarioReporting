﻿using System.Collections.Generic;
using System.Reflection;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Xunit.ScenarioReporting
{
    public class ScenarioReportingXunitTestFrameworkExecutor : XunitTestFrameworkExecutor
    {
        public ScenarioReportingXunitTestFrameworkExecutor(AssemblyName assemblyName, ISourceInformationProvider sourceInformationProvider, IMessageSink diagnosticMessageSink)
            : base(assemblyName, sourceInformationProvider, diagnosticMessageSink)
        { }

        protected override ITestFrameworkDiscoverer CreateDiscoverer()
        {
            return new ScenarioReportingXunitTestFrameworkDiscoverer(AssemblyInfo, SourceInformationProvider, DiagnosticMessageSink);
        }

        protected override async void RunTestCases(IEnumerable<IXunitTestCase> testCases, IMessageSink executionMessageSink, ITestFrameworkExecutionOptions executionOptions)
        {
            using (var assemblyRunner = new ScenarioReportingXunitTestAssemblyRunner(TestAssembly, testCases, DiagnosticMessageSink, executionMessageSink, executionOptions))
                await assemblyRunner.RunAsync();
        }
    }
    //Xunit framework has changed and this class is copied from the pre release versions. when it is released, most of the implementation can be removed and just have the 
    //DiscoverTypeCache primed with overridden types for scenarios
}