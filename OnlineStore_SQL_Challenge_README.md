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
