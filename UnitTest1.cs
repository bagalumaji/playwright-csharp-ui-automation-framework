using Microsoft.Playwright;

namespace playwright_csharp_ui_automation_framework
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task Test1()
        {
            IPlaywright playwright = await Playwright.CreateAsync();
            IBrowser browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
               // Channel = "chrome" 
            });
            IBrowserContext browserContext = await browser.NewContextAsync();
            IPage page = await browserContext.NewPageAsync();
            await page.GotoAsync("https://google.com");
            await browser.CloseAsync();
        }
    }
}