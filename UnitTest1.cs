using Microsoft.Playwright;

namespace playwright_csharp_ui_automation_framework
{
    public class Tests
    {
        private IBrowserContext _browserContext;
        private IBrowser _browser;
        private IPlaywright _playwright;
        private IPage _page;

        [SetUp]
        public async Task Setup()
        {
            _playwright = await Playwright.CreateAsync();
            _browser = await _playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
                // Channel = "chrome" 
            });
            _browserContext = await _browser.NewContextAsync();
        }

        [Test]
        public async Task Test1()
        {
            _page = await _browserContext.NewPageAsync();
            await _page.GotoAsync("https://google.com");

        }
        [TearDown]
        public async Task TearDown()
        {
            await _page.CloseAsync();
            await _browserContext.CloseAsync();
            await _browser.CloseAsync();
        }
    }
}