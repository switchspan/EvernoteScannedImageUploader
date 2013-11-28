using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace EvernoteScannedImageUploader.Core.Tests
{
    public class EnscriptExecutorTest
    {
        const string EnscriptPath = @"C:\Program Files (x86)\Evernote\Evernote\ENScript.exe";
        const string BadEnscriptPath = @"C:\Program Files\Evernote\Evernote\ENScript.exe";

        [Fact]
        public void IsValid_WithGoodPath_ReturnsTrue()
        {
            // When creating an executor object, the actual file should be found.
            var executor = new EnscriptExecutor(EnscriptPath);

            Assert.True(executor.IsValid());
        }

        [Fact]
        public void IsValid_WithBadPath_ReturnsFalse()
        {
           
            var executor = new EnscriptExecutor(BadEnscriptPath);

            Assert.False(executor.IsValid());
        }

    }
}
