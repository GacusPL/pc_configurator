# 🖥️ Konfigurator PC (PC Configurator)

> **Projekt zaliczeniowy z przedmiotu:** Budowa aplikacji na platformie .NET 

**Autor:** Kacper Szponar  
**Nr indeksu:** 21306

Aplikacja wielookienkowa stworzona w środowisku **.NET (WinForms)** z wykorzystaniem języka **C#**. Projekt opiera się na architekturze **MVC (Model-View-Controller)** i służy do intuicyjnego składania, walidacji oraz zapisywania zestawów komputerowych.

## ✨ Główne funkcjonalności

* **Pełna obsługa CRUD:** Możliwość tworzenia nowych zestawów komputerowych, przeglądania zapisanych konfiguracji oraz ich edycji i usuwania z poziomu interfejsu graficznego.
* **Walidacja kompatybilności sprzętowej:** Aplikacja w czasie rzeczywistym weryfikuje dobierane podzespoły, upewniając się, że tworzony zestaw jest w 100% ze sobą zgodny.
* **Integracja z relacyjną bazą danych:** Wykorzystanie **MSSQL** do przechowywania informacji o dostępnych częściach oraz zapisanych konfiguracjach użytkownika.
* **Dynamiczna prezentacja danych:** Szerokie wykorzystanie kontrolek `DataGridView` do wygodnego filtrowania, sortowania i wyboru podzespołów.
* **Wielookienkowy interfejs (Multi-form):** Rozbudowana nawigacja pomiędzy menu głównym, kreatorem zestawu i menedżerem zapisanych konfiguracji.

## 🛠️ Zastosowane technologie

* **Język:** C#
* **Platforma:** .NET Framework (Windows Forms)
* **Baza danych:** Microsoft SQL Server (MSSQL)
* **Architektura:** MVC (Model-View-Controller)
* **Narzędzia:** Visual Studio, Data Source Wizard

## 📐 Architektura MVC w projekcie

Projekt został podzielony zgodnie ze wzorcem MVC, aby oddzielić logikę biznesową od interfejsu użytkownika:
* **Model:** Odpowiada za strukturę danych oraz komunikację z bazą MSSQL (zapytania, aktualizacje).
* **View:** Formularze WinForms prezentujące dane (m.in. przez `DataGridView`) i odbierające interakcje od użytkownika.
* **Controller:** Logika pośrednicząca – obsługuje walidację podzespołów, przetwarza dane z bazy i decyduje, co ma zostać wyświetlone w widoku.

## 📸 Zrzuty ekranu

## 🚀 Jak uruchomić projekt lokalnie?

1. Sklonuj to repozytorium na swój komputer:
   ```bash
   git clone [https://github.com/GacusPL/pc_configurator.git](https://github.com/GacusPL/pc_configurator.git)