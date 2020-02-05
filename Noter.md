# Noter
#### Undervisning 05-02-2020
First App - inspect 1.

What platforms do I want to support and what platforms can my OS support?

Windows supporterer out of the box Android og UWP. For at supportere iOS skal man have et Apple device med Xcode installeret. Her kan man lave remote. OSX supporterer alt out of the box.

What template do i want for my project?

Blank forms app: Ingen sample data og ingen pages.

Shell: Bruger et [Shell](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/shell/introduction) til at holde på Child pages. Kommer med sample pages og sample data.

Tabbed: Laver en tab menu til at navigere rundt i child pages. Kommer med sample data og sample pages.

Master detail: Kommer med en sidemenu til at navigere rundt i childpages. Kommer med sample data og pages. 

What should my app name be?

Det bestemmer man selv - oftest er det bedst at navngive generisk og ikke specifikt for en platform når man udvikler en forms app.

What is organizer identifier?

Det er noget unikt der kan identificere hvilken virksomhed har udviklet. Skrevet i reverse DNS format, f.eks. com.xamarin. Det er også en del af dit bundle ID.

What type of shared code should i use?

.NET Standard er crossplatform og kan tilgå flere forskellige API'er i .NET.

Shared Projects 
Kan gøre brug af #if i compileren og lave specifikt business logik til hver platform. 

Umiddelbart vil jeg altid foretrække .NET Standard. Færre filer at vedligeholde osv. 