using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MoqDemoTests.Logic
{
  public class PersonProcessorTests
  {
    [Theory]
    [InlineData("6'8\"", true, 80)]
    [InlineData("6\"8'", false, 0)]
    [InlineData("six'eight\"", false, 0)]
    public void ConvertHeightTextToInches_VariousOptions(string heightText, bool expectedIsValid, double expectedHeightInches)
    {

    }

  }
}
