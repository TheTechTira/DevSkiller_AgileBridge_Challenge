# Code Challenge 1:
---

## Bank Application Client DB Module

### Introduction

You must complete the implementation of one of the banking system modules used to persist and take clients and accounts data from DB.

The module uses **SQLite** database to store data.

### Problem Statement

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

### Hints

-   The `BankClient` contains client data.

-   The `BankAccount` contains account data and contains a foreign key to client data.

-   Follow the TODO comments.

-   Your solution should pass all tests.

---

### 🎯 Task + Solution
Implement the methods described in the Problem Statement section inside the `ClientModuleDataAccess` class. 
- Commented sections marked with `TODO` need to be completed.
    - Left comments to understand what has been done on each method according to requirements.

---

# Code Challenge 2:
---

# 🛒 Online Store SQL Challenge

## 📋 Problem Statement
You are provided with a single database table named **`orders`** containing the following columns:

```sql
CREATE TABLE orders
(
    order_number INT PRIMARY KEY,
    client VARCHAR(20),
    revenue INT,
    fixed_transport_cost INT,
    income INT,
    order_date DATE
);
```

### 🎯 Task
Select **clients whose first order was placed in 2017**, and calculate how much **income was generated in 2018** (total) per each of them.

### 🧩 Desired Output Example
| Clients whose first order placed in 2017 | Sum of income in 2018 |
|------------------------------------------|------------------------|
| McDuck                                   | 5000                   |
| Pocahontas & co.                         | 3500                   |

---

## 🧠 Solution Explanation

To solve this, we must:
1. Identify clients whose **first order** (`MIN(order_date)`) occurred in **2017**.  
2. Filter orders for those clients that were placed in **2018**.  
3. Sum their **income** values.

---

## ✅ Final SQL Query

```sql
SELECT
    o.client AS "Clients whose first order placed in 2017",
    SUM(o.income) AS "Sum of income in 2018"
FROM orders o
WHERE 
    EXTRACT(YEAR FROM o.order_date) = 2018
    AND o.client IN (
        SELECT client
        FROM orders
        GROUP BY client
        HAVING EXTRACT(YEAR FROM MIN(order_date)) = 2017
    )
GROUP BY o.client
ORDER BY o.client;
```

---

## 🧾 How It Works

### Step 1 — Find first orders in 2017
```sql
SELECT client
FROM orders
GROUP BY client
HAVING EXTRACT(YEAR FROM MIN(order_date)) = 2017;
```
This subquery finds clients whose earliest order date was in **2017**.

### Step 2 — Calculate total 2018 income
The outer query filters the **2018** records and sums **income** only for clients found in Step 1.

---

## 💡 Notes
- `EXTRACT(YEAR FROM order_date)` isolates the year from the `DATE` field.  
- `HAVING` is used instead of `WHERE` because it filters aggregated results.  
- Works across multiple datasets — do **not** hardcode years or names.

---

## 🧰 Example Output
| Clients whose first order placed in 2017 | Sum of income in 2018 |
|------------------------------------------|------------------------|
| McDuck                                   | 5000                   |
| Pocahontas & co.                         | 3500                   |
