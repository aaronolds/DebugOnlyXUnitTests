using System.Diagnostics;
using Xunit;

namespace Xunit.Helper
{
  /// <inheritdoc />
    /// <summary>
    /// This attribute will ensure that a unit test is only run in interactive mode.
    /// Specifically the Build Test Seed DAta doesn't need to run as automatic unit test.
    /// </summary>
    /// <seealso cref="T:Xunit.TheoryAttribute" />
    public sealed class TheoryRunnableInDebugOnlyAttribute : TheoryAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TheoryRunnableInDebugOnlyAttribute"/> class.
        /// </summary>
        public TheoryRunnableInDebugOnlyAttribute()
        {
            if (!Debugger.IsAttached) Skip = "Only running in interactive mode.";
        }
    }
}
