using Microsoft.Extensions.Logging;
using Microsoft.Playwright;

namespace OverwatchArcade.Twitter.Services.ScreenshotService;

public class ScreenshotService : IScreenshotService
{
    private readonly ILogger<ScreenshotService> _logger;

    public ScreenshotService(ILogger<ScreenshotService> logger)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async Task<byte[]> CreateScreenshot(string screenshotUrl)
    {
        //ревью -- нельзя использовать var
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync();
        //ревью -- нельзя использовать var
        var page = await browser.NewPageAsync();

        try
        {
            await page.GotoAsync(screenshotUrl, new PageGotoOptions()
            {
                WaitUntil = WaitUntilState.NetworkIdle,
            });
            var screenshot = await page.ScreenshotAsync(new PageScreenshotOptions { FullPage = true, Type = ScreenshotType.Jpeg });
            await browser.CloseAsync();

            return screenshot;
        }
        catch (Exception e)
        {
            //ревью -- неправильное логгирование
            _logger.LogError(e.Message);
            throw;
        }
    }
}