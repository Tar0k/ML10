using Microsoft.AspNetCore.Mvc;

namespace ML10.Controllers;

public class PrefaceController : Controller
{
    // GET
    public IActionResult Index()
    {
        var components = new List<Component>
        {
            new()
            {
                ImgDevice = "images/Preface/ML10LEFT.jpg",
                Description = "Лазер ML10",
                Link = "ml10 laser.htm"
            },
            new()
            {
                ImgDevice = "images/Preface/Ec10.jpg",
                Description = "Блок компенсации окружающей среды EC10",
                Link = "EC10.htm"
            }
        };
        ViewBag.Components = components;

        var options = new List<Option>
        {
            new()
            {
                ImgDevice = "images/Preface/linear.gif",
                Description = "Линейная точность позиционирования и повторяемость одной оси",
                Link = "lin-frontpg.htm",
                ImgDefinition = "images/Preface/linear2.gif"
            },
            new()
            {
                ImgDevice = "images/Preface/angular2.gif",
                Description = "Измерение углового отклонения и крена оси",
                Link = "ang-frontpg.htm",
                ImgDefinition = "images/Preface/angular.gif"
            },
            new()
            {
                ImgDevice = "images/Preface/straight2.gif",
                Description = "Прямолинейность оси",
                Link = "str-frontpg.htm",
                ImgDefinition = "images/Preface/straightness.gif"
            },
            new()
            {
                ImgDevice = "images/Preface/square2.gif",
                Description = "Перпендикулярность между осями",
                Link = "sq-frontpg.htm",
                ImgDefinition = "images/Preface/squareness.gif"
            },
            new()
            {
                ImgDevice = "images/Preface/Flat2.gif",
                Description = "Измерение неровности поверхности",
                Link = "flat-frontpg.htm",
                ImgDefinition = "images/Preface/flatness.gif"
            },
            new()
            {
                ImgDevice = "images/Preface/rot2.gif",
                Description = "Точность углового позиционирования",
                Link = "rx10-frontpg.htm",
                ImgDefinition = "images/Preface/rotary.gif"
            },
            new()
            {
                ImgDevice = "images/Preface/Dynamic2.gif",
                Description = "Измерение динамических характеристик",
                Link = "dynam-frontpg.htm",
                ImgDefinition = "images/Preface/dynamic.gif"
            }
        };
        ViewBag.Options = options;
        return View();
    }
}

public record Component
{
    public required string ImgDevice { get; init; }
    public required string Description { get; init; }
    public required string Link { get; init; }
}

public record Option : Component
{
    public string? ImgDefinition { get; init; }
}