# Netflix Assignment - No Database

## Projectbeschrijving
Je bouwt een eenvoudige in-memory CRUD-backend voor een Netflix-achtige applicatie in C# met ASP .NET Core. Alle data is "hard coded" tijdens runtime, wegschrijven gebeurt niet—bij POST-verzoeken log je alleen met Console.WriteLine. De service biedt endpoints om films te beheren en gebruikersratings toe te voegen.

## 1. API-specificatie

| Endpoint | Doel |
|----------|------|
| GET /films | Haalt alle films op. |
| GET /films/{id} | Levert de details van één film. |
| POST /films | 'Voegt toe' door te loggen; retourneert de nieuwe film. |
| GET /films/populair?limit=&datum= | Toont populairste films op een bepaalde dag. |
| POST /films/{id}/rating | 'Voegt rating toe' door te loggen; retourneert de rating. |

## 2. Hoe te starten met Rider

1. **Open JetBrains Rider**
2. **Maak een nieuw project aan:**
   - Klik op "New Solution" of "File" → "New" → "Solution"
3. **Selecteer project type:**
   - Kies "ASP.NET Core Web Application" of "ASP.NET Core Web API"
4. **Configureer het project:**
   - **Solution name:** NetflixApp (of een andere naam naar keuze)
   - **Project name:** NetflixApp
   - **Framework:** .NET 8.0 of .NET 7.0 (nieuwste beschikbare versie)
   - **Authentication:** No Authentication
   - **Configure for HTTPS:** Aangevinkt (aanbevolen)
   - **Enable OpenAPI support:** Aangevinkt (voor Swagger documentatie)
5. **Klik "Create"**
6. **Project structuur aanpassen:**
   - Maak de mappen aan: `Controllers/`, `Dtos/`, `Services/`
   - Verwijder eventuele standaard controller files die je niet nodig hebt

## 3. Over ASP .NET Core

- Cross-platform met Kestrel-server.
- Built-in DI-container: services registreer je in Program.cs.
- Attribute routing: [HttpGet], [HttpPost] op controller-methodes.
- Minimal APIs of MVC-controllers: hier gebruiken we controllers.

## 4. Architectuur: Controller–Service–Repository

### Controller
Definieert routes met attributen en roept de service aan.

### Service
Bevat de business-/CRUD-logica en hard-coded in-memory DTO's.

### Repository (optioneel)
Voor echte databases; hier geïntegreerd in de service.

## 5. Projectstructuur

```
YourApp/
│
├─ Controllers/        FilmsController.cs
├─ Dtos/               FilmDto.cs         (en RatingDto.cs)
├─ Services/           IFilmService.cs  
│                      FilmService.cs
└─ Program.cs
```

Elke map is automatisch een namespace; verder geen __init__.py-gedoe zoals in Python.

## 6. DTO-voorbeeld

Definieer je Data Transfer Object met een constructor:

```csharp
public class FilmDto
{
    public string Id { get; set; }
    public string Titel { get; set; }
    // … overige properties …

    public FilmDto(string id, string titel /*, … */)
    {
        Id    = id;
        Titel = titel;
        // … initialisatie …
    }
}
```

## 7. Service-voorbeeld

Met hard-coded data en logging in plaats van opslaan:

```csharp
public class FilmService : IFilmService
{
    private readonly List<FilmDto> _films = new() {
        new FilmDto("123", "Inception" /*, …*/)
    };

    public IEnumerable<FilmDto> GetAllFilms() => _films;

    public FilmDto AddFilm(FilmDto film)
    {
        Console.WriteLine($"New film: {JsonSerializer.Serialize(film)}");
        return film;
    }

    // … overige methodes …
}
```

## 8. Controller-voorbeeld

Injectie van de service en één route:

```csharp
[ApiController]
[Route("films")]
public class FilmsController : ControllerBase
{
    private readonly IFilmService _svc;
    public FilmsController(IFilmService svc) => _svc = svc;

    [HttpGet]
    public ActionResult<IEnumerable<FilmDto>> GetAll()
        => Ok(new { films = _svc.GetAllFilms() });
}
```

## 9. Program.cs-configuratie

Registratie DI en routes:

```csharp
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IFilmService, FilmService>();
builder.Services.AddControllers();

var app = builder.Build();
app.MapControllers();
app.Run();
```

## 10. Testen via Postman

Basis-URL: http://localhost:5000/films

- GET / → /films
- GET /{id} → /films/123
- POST / → /films (JSON body; logging)
- GET /populair → /films/populair?limit=5&datum=2025-06-10
- POST /{id}/rating → /films/123/rating (JSON body; logging) 