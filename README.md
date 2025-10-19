# Bank Application Client DB Module

## Introduction

You must complete the implementation of one of the banking system modules used to persist and take clients and accounts data from DB.

The module uses **SQLite** database to store data.

## Problem Statement

To complete this task you must implement the following requirements:

-   The `GetAllClientsThatHaveAtLeastOneAccountDetached` method in `ClientModuleDataAccess` currently returns all clients data that are tracked by Entity Framework. After your changes the method should:

-   Returns clients with their accounts, but only clients which have at least one account. The accounts should be stored in the `BankClient` -> `ClientAccounts` property.

-   Returns data without tracking changes in the objects.

-   Implement `SaveNewClient` method in `ClientModuleDataAccess`.

-   This function should persist data of new clients passed as a parameter together with its accounts (stored in `ClientAccounts` property).

-   Before saving, it should check if the client is new (Id property less or equal 0). If not, the function should throw a `DataExistsException` exception.

-   Function should return true id operation completed with success or throw `WritingToDBException` exception if not.

-   Implement `StartTracking` method in `ClientModuleDataAccess`.

-   This function should start tracking `BankClient` passed as parameter if it is not tracked by Entity Framework yet.

-   If another instance of `BankClient` with the same Id is already tracked by EF context the function should "Detached" it.

-   If the `BankClient` passed as parameter is not tracked by EF context the function should start tracking it and mark it as "Modified" if Id greater than 0 or as "Added" if Id is less or equal 0 (so after saving changes in context, the passed Bank Client would overwrite data in DB).

-   The function should always return a tracked `BankClient`.

-   Implement the `IsClientTrackedByEF` method in `ClientModuleDataAccess`.
    Function should return true, if the client object passed as function parameter is tracked by Entity Framework or false if not.

## Hints

-   The `BankClient` contains client data.

-   The `BankAccount` contains account data and contains a foreign key to client data.

-   Follow the TODO comments.

-   Your solution should pass all tests.