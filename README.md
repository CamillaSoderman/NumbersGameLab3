# NumbersGameLab3
# Om uppgiften

Nu är det dags att bygga ditt första riktiga program som faktiskt kan vara kul att använda - ett enklare spel!

Det du ska skapa är ett rätt enkelt spel där användaren får gissa ett nummer. Användaren kommer få lite ledtrådar och den har ett begränsat antal försök på sig att gissa.

# Vad du ska göra

- [ ]  Skapa ett nytt projekt i Visual Studio (Console Application → C# → .Net Core)
- [ ]  Döp projektet till "NumbersGame".
- [ ]  När programmet startar ska följande skrivas ut i konsollen: "Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök."
- [ ]  Programmet ska slumpa fram ett tal som användaren ska gissa på men såklart inte skriva ut vilket tal det är. Förslagsvis genererar programmet ett tal mellan 1 och 20 men du får välja.
- [ ]  Användaren ska sedan mata in ett tal som den vill gissa på.
- [ ]  Om talet är fel ska programmet svara med antingen "Tyvärr, du gissade för lågt!" eller "Tyvärr, du gissade för högt!" beroende på om talet som användaren gissade på var just högre eller lägre än det rätta.
- [ ]  Om användaren gissar rätt ska programmet skriva ut "Wohoo! Du klarade det!"
- [ ]  Om användaren har gissat fem (5) gånger och inte fått till rätt tal ska programmet skriva ut “Tyvärr, du lyckades inte gissa talet på fem försök!" och användaren får inte gissa mer.
- [ ]  Någon del av din kod ska vara i en egen funktion/metod. Exempelvis kan du ha en funktion för att kolla om gissningen är rätt eller fel som heter `CheckGuess()`

