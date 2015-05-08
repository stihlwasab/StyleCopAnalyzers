﻿namespace StyleCop.Analyzers
{
    using System.Threading.Tasks;
    using Microsoft.CodeAnalysis;

    internal static class AnalyzerConstants
    {
        static AnalyzerConstants()
        {
#if DEBUG
            // In DEBUG builds, the tests are enabled to simplify development and testing.
            DisabledNoTests = true;
#else
            DisabledNoTests = false;
#endif
        }

        /// <summary>
        /// Gets a reference value which can be passed to
        /// <see cref="DiagnosticDescriptor(string, string, string, string, DiagnosticSeverity, bool, string, string, string[])"/>
        /// to disable a diagnostic which is currently untested.
        /// </summary>
        /// <value>
        /// A reference value which can be passed to
        /// <see cref="DiagnosticDescriptor(string, string, string, string, DiagnosticSeverity, bool, string, string, string[])"/>
        /// to disable a diagnostic which is currently untested.
        /// </value>
        internal static bool DisabledNoTests { get; }

        /// <summary>
        /// Gets a reference value which can be passed to
        /// <see cref="DiagnosticDescriptor(string, string, string, string, DiagnosticSeverity, bool, string, string, string[])"/>
        /// to indicate that the diagnostic should be enabled by default.
        /// </summary>
        /// <value>
        /// A reference value which can be passed to
        /// <see cref="DiagnosticDescriptor(string, string, string, string, DiagnosticSeverity, bool, string, string, string[])"/>
        /// to indicate that the diagnostic should be enabled by default.
        /// </value>
        internal static bool EnabledByDefault => true;

        internal static Task CompletedTask { get; } = Task.FromResult(false);
    }
}
