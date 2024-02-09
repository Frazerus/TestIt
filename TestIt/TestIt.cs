using OpenQA.Selenium.Edge;

class TestIt
{
  public static void Main ()
  {
    var shouldUseLocalEdge = false;

    var solutionDir = Directory.GetParent(Environment.CurrentDirectory)!.Parent!.Parent!.Parent!.FullName;

    var options = new EdgeOptions
      {
        BinaryLocation = $"{solutionDir}/edge_v121/msedge.exe"
      };

    var driver = shouldUseLocalEdge
        ? new EdgeDriver()
        : new EdgeDriver(options);

    driver.Url = "https://bing.com";

    Thread.Sleep(5000);

    driver.Close();
  }
}
