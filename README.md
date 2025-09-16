Správa zaměstnanců

Vytvořte Windows Forms aplikaci pro správu zaměstnanců ve společnosti. Aplikace by měla umožňovat správu zaměstnanců pomocí databáze, ukládání dat do textového souboru a zobrazování dat v komponentě DataGridView.
Obecné požadavky:
Napojení na MySQL databázi:

    Vytvořte spojení s MySQL databází obsahující 4 tabulky: Zaměstnanci, Oddělení, Pozice a Projekt.

    Připojte se k databázi a načtěte data z tabulek do aplikace.

    Zobrazte data v komponentě DataGridView.

Správa zaměstnanců:

    Vytvořte formulář pro přidání nového zaměstnance do databáze.

    Přidejte validační pravidla pro kontrolu vyplnění všech potřebných informací (např. jméno, příjmení, pozice).

    Umožněte editaci a odstranění existujících zaměstnanců.

Práce s textovým souborem:

    Přidejte možnost uložit seznam zaměstnanců do textového souboru.

    Implementujte načítání seznamu zaměstnanců ze souboru do aplikace.

Zobrazení dat v DataGridView:

    Zobrazte seznam zaměstnanců ve formě DataGridView v hlavním okně aplikace.

    Přidejte možnost třídění a filtrování dat ve DataGridView.

Další funkce:

    Implementujte vyhledávání zaměstnanců podle různých kritérií (např. jméno, příjmení, oddělení).

    Přidejte možnost zobrazit statistiky zaměstnanců, například počet zaměstnanců v jednotlivých odděleních.

Funkční požadavky:
Přihlášení:

    Vytvořte formulář pro přihlášení do aplikace s uživatelským jménem a heslem.

    Zkontrolujte, zda jsou zadané přihlašovací údaje správné.

    Omezte přístup k funkcím aplikace pouze pro přihlášené uživatele.

Správa zaměstnanců:

    Zobrazte seznam zaměstnanců ve formě DataGridView v hlavním okně aplikace.

    Umožněte přidání nového zaměstnance do databáze.

    Při přidávání zaměstnance zkontrolujte, zda jsou všechna pole správně vyplněna.

    Umožněte editaci existujících zaměstnanců v databázi.

    Umožněte odstranění zaměstnance z databáze.

Správa oddělení:

    Umožněte přidání nového oddělení do databáze.

    Při přidávání oddělení zkontrolujte, zda je název vyplněn.

    Umožněte editaci a odstranění existujících oddělení v databázi.

Správa pozic:

    Umožněte přidání nové pozice do databáze.

    Při přidávání pozice zkontrolujte, zda je název vyplněn.

    Umožněte editaci a odstranění existujících pozic v databázi.

Správa projektů:

    Umožněte přidání nového projektu do databáze.

    Při přidávání projektu zkontrolujte, zda jsou vyplněny název a popis.

    Umožněte editaci a odstranění existujících projektů v databázi.

Ukládání a načítání dat:

    Umožněte ukládání seznamu zaměstnanců do textového souboru.

    Implementujte načítání seznamu zaměstnanců ze souboru do aplikace.

    Zabezpečte, aby se při načítání a ukládání dat do textového souboru zachovala integrita dat.

Zobrazení dat v DataGridView:

    Zobrazte seznam zaměstnanců ve formě DataGridView v hlavním okně aplikace.

    Přidejte možnost třídění a filtrování dat ve DataGridView.

    Umožněte výběr zaměstnance z DataGridView pro další úpravy nebo zobrazení detailů.

Statistiky zaměstnanců:

    Implementujte možnost zobrazit statistiky zaměstnanců, například počet zaměstnanců v jednotlivých odděleních.

    Zobrazte statistiky ve vhodné formě, například graficky nebo v tabulkové formě.

Datový model:
Tabulka "Zaměstnanci":

    ID: unikátní identifikátor zaměstnance (integer)

    Jméno: jméno zaměstnance (text)

    Příjmení: příjmení zaměstnance (text)

    OdděleníID: identifikátor oddělení, ke kterému zaměstnanec patří (integer, cizí klíč na tabulku "Oddělení")

    PoziceID: identifikátor pozice zaměstnance (integer, cizí klíč na tabulku "Pozice")

Tabulka "Oddělení":

    ID: unikátní identifikátor oddělení (integer)

    Název: název oddělení (text)

Tabulka "Pozice":

    ID: unikátní identifikátor pozice (integer)

    Název: název pozice (text)

Tabulka "Projekt":

    ID: unikátní identifikátor projektu (integer)

    Název: název projektu (text)

    Popis: popis projektu (text)

Doporučení:

    Pro přístup k MySQL databázi využijte Entity Framework.

    Pro uložení dat do textového souboru použijte třídu StreamWriter a pro načítání třídu StreamReader.

    Pro práci s DataGridView můžete využít události pro editaci buněk, řádků nebo vybraných položek.
