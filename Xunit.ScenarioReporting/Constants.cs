namespace Xunit.ScenarioReporting
{
    /// <summary>
    /// Defines constants used in the assembly
    /// </summary>
    public static class Constants
    {
        internal const string XmlTagAssembly = "Assembly";
        internal const string XmlTagName = "Name";
        internal const string XmlTagTime = "Time";
        internal const string XmlTagScenario = "Definition";
        internal const string XmlTagGiven = "Given";
        internal const string XmlTagThen = "Then";
        internal const string XmlTagWhen = "When";
        internal const string XmlTagDetails = "Details";
        internal const string XmlTagTitle = "Title";
        internal const string XmlTagDetail = "Detail";
        internal const string XmlTagMessage = "Message";
        internal const string XmlTagFailure = "Failure";
        internal const string ReportAssemblyOverviewHtmlHeader = "ReportAssemblyOverviewHTMLHeader.html";
        internal const string ReportAssemblyOverviewHtmlContent = "ReportAssemblyOverviewHTMLContent.xslt";
        internal const string ReportAssemblyOverviewHtmlFooter = "ReportAssemblyOverviewHTMLFooter.html";
        internal const string ReportAssemblyOverviewHtml = "ReportAssemblyOverview.html";
        internal const string ReportAssemblyOverviewMarkdownContent = "ReportAssemblyOverviewMarkdownContent.xslt";
        internal const string ReportAssemblyOverviewMarkdown = "ReportAssemblyOverview.md";
        internal const string ReportPath = "Reports";

        /// <summary>
        /// The name of the assembly to use in the <see cref="TestFrameworkAttribute"/>
        /// </summary>
        public const string AssemblyName = "Xunit.ScenarioReporting";
        /// <summary>
        /// The name of the framework to use in the <see cref="TestFrameworkAttribute"/>
        /// </summary>
        public const string Framework = AssemblyName + "." + nameof(ScenarioReportingXunitTestFramework);
    }
}