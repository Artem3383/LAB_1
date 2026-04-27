# Homework Manager

## Spis treści
1. Opis projektu  
2. Funkcjonalności  
3. Instrukcja uruchomienia  
4. Wymagania    
5. Przykładowe dane  

---

## 1. Opis projektu

Homework Manager to aplikacja webowa stworzona w technologii ASP.NET Core MVC.  
Aplikacja umożliwia zarządzanie zadaniami domowymi (Homework), takimi jak dodawanie, edycja, usuwanie oraz przeglądanie listy zadań.

Projekt wykorzystuje wzorzec MVC (Model-View-Controller) oraz bazę danych SQLite.

---

## 2. Funkcjonalności

Zaimplementowane funkcjonalności:

- Dodawanie nowego zadania
- Edycja istniejącego zadania
- Usuwanie zadania
- Wyświetlanie listy zadań
- Wyświetlanie szczegółów zadania
- Walidacja danych (wymagane pola, długość tekstu, format daty)
- Status zadania (wykonane / niewykonane)
- Dodanie funkcji wyszukiwania

---

## 3. Instrukcja uruchomienia

### Wymagania:
- .NET SDK 9.0
- Visual Studio Code

### Kroki uruchomienia:
1. Sklonuj repozytorium:
   git clone https://github.com/Artem3383/LAB_1.git

2. Przejdź do folderu projektu:
   cd LAB_1/Projekt/HomeworkManager

3. Zainstaluj zależności:
   dotnet restore

4. Utwórz bazę danych:
   dotnet ef database update

5. Uruchom aplikację:
   dotnet run

6. Otwórz przeglądarkę i przejdź do:
   https://localhost:5272/Homeworks


## 4. Wymagania

Projekt wymaga zainstalowania następujących pakietów:


dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.Design

## 5. Przykładowe dane
Przykładowe zadanie:
- Description: Matematyka - zadanie domowe
- DueDate: 2026-04-30
- Status: New



## Kod źródłowy

Kod źródłowy znajduje się w repozytorium projektu.
https://github.com/Artem3383/LAB_1/tree/main/Projekt