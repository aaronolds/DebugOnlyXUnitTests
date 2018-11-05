using System.Diagnostics;
using Xunit;

namespace Xunit.Helper
{
    /// <inheritdoc />
    /// <summary>
    /// This attribute will ensure that a unit test is only run in interactive mode.
    /// Specifically the Build Test Seed DAta doesn't need to run as automatic unit test.
    /// </summary>
    /// <seealso cref="T:Xunit.FactAttribute" />
    public sealed class FactRunnableInDebugOnlyAttribute : FactAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TheoryRunnableInDebugOnlyAttribute"/> class.
        /// </summary>
        public FactRunnableInDebugOnlyAttribute()
        {
            if (!Debugger.IsAttached) Skip = "Only running in interactive mode.";
        }
    }
}
