# My DSL( Domain Specific Language)

### 1. Introduction

#### Using Antlr I created a DSL that converts a sentence into  C# POCO classes that we can serialize  and save into database.

#### Example sentence: 

```book a hotel room for Santosh Singh and 3 guests on 23-SEP-2013 00:12 ```

#### Output:

```{"Time":"2013-06-28T00:12:00","Person":{"FirstName":"Mussa","LastName":"Abdarazak","NumberOfGuests":1}}```

### 2. How to run the project: cd in Antrl folder and run the following command

```dotnet run```